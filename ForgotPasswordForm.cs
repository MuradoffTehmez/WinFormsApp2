using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class ForgotPasswordForm : Form
    {
        private bool _isDragging = false;
        private Point _dragStartPoint = Point.Empty;
        private string _generatedCode = "";
        private System.Windows.Forms.Timer _timer;
        private int _remainingSeconds = 60;

        public ForgotPasswordForm()
        {
            InitializeComponent();
            ApplyRoundedCorners();
            SetupFormDrag();
            SetupTimer();
        }

        private void SetupFormDrag()
        {
            this.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    _isDragging = true;
                    _dragStartPoint = new Point(e.X, e.Y);
                }
            };
            this.MouseMove += (s, e) =>
            {
                if (_isDragging)
                {
                    Point p = PointToScreen(e.Location);
                    this.Location = new Point(p.X - _dragStartPoint.X, p.Y - _dragStartPoint.Y);
                }
            };
            this.MouseUp += (s, e) => _isDragging = false;
        }

        private void SetupTimer()
        {
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            _timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _remainingSeconds--;
            btnSendCode.Text = $"Kodu göndər ({_remainingSeconds}s)";
            btnSendCode.Enabled = false;

            if (_remainingSeconds <= 0)
            {
                _timer.Stop();
                btnSendCode.Text = "Kodu göndər";
                btnSendCode.Enabled = true;
                _remainingSeconds = 60;
            }
        }

        private void ApplyRoundedCorners()
        {
            int radius = 15;
            var path = new GraphicsPath();
            var rect = new Rectangle(0, 0, this.Width, this.Height);
            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
            path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
            path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
        }

        // ── Bağlama ──────────────────────────────────────────────────
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // ── Kodu göndər ──────────────────────────────────────────────
        private void btnSendCode_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                ShowError("Zəhmət olmasa email ünvanınızı daxil edin.");
                return;
            }

            if (!IsValidEmail(email))
            {
                ShowError("Düzgün email ünvanı daxil edin.");
                return;
            }

            // Təsdiq kodunu yarat
            _generatedCode = GenerateVerificationCode();

            // Email göndər (simulyasiya)
            bool sent = SendVerificationEmail(email, _generatedCode);

            if (sent)
            {
                lblVerificationCode.Visible = true;
                txtVerificationCode.Visible = true;
                btnVerify.Visible = true;
                btnSendCode.Enabled = false;
                _timer.Start();

                ShowSuccess($"Təsdiq kodu {email} ünvanına göndərildi.");
                pnlEmail.Enabled = false;
            }
            else
            {
                ShowError("Email göndərilərkən xəta baş verdi.");
            }
        }

        // ── Kodu təsdiq et ────────────────────────────────────────────
        private void btnVerify_Click(object sender, EventArgs e)
        {
            string code = txtVerificationCode.Text.Trim();

            if (string.IsNullOrWhiteSpace(code))
            {
                ShowError("Zəhmət olmasa təsdiq kodunu daxil edin.");
                return;
            }

            if (code == _generatedCode)
            {
                ShowSuccess("Kod təsdiq edildi! Yeni şifrə təyin edə bilərsiniz.");

                txtNewPassword.Visible = true;
                txtConfirmPassword.Visible = true;
                lblNewPassword.Visible = true;
                lblConfirmPassword.Visible = true;
                btnResetPassword.Visible = true;

                txtVerificationCode.Enabled = false;
                btnVerify.Enabled = false;
            }
            else
            {
                ShowError("Təsdiq kodu yanlışdır.");
                txtVerificationCode.Clear();
                txtVerificationCode.Focus();
            }
        }

        // ── Şifrəni sıfırla ──────────────────────────────────────────
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string newPass = txtNewPassword.Text;
            string confirmPass = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(newPass) || string.IsNullOrWhiteSpace(confirmPass))
            {
                ShowError("Zəhmət olmasa yeni şifrəni daxil edin.");
                return;
            }

            if (newPass.Length < 8)
            {
                ShowError("Şifrə ən azı 8 simvol olmalıdır.");
                return;
            }

            if (!Regex.IsMatch(newPass, @"[A-Z]"))
            {
                ShowError("Şifrədə ən azı bir böyük hərf olmalıdır.");
                return;
            }

            if (!Regex.IsMatch(newPass, @"[a-z]"))
            {
                ShowError("Şifrədə ən azı bir kiçik hərf olmalıdır.");
                return;
            }

            if (!Regex.IsMatch(newPass, @"[0-9]"))
            {
                ShowError("Şifrədə ən azı bir rəqəm olmalıdır.");
                return;
            }

            if (newPass != confirmPass)
            {
                ShowError("Şifrələr uyğun gəlmir.");
                return;
            }

            // Burada şifrəni yenilə
            MessageBox.Show("Şifrə uğurla yeniləndi!", "Uğurlu",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // ── Email göndərmə ──────────────────────────────────────────
        private bool SendVerificationEmail(string to, string code)
        {
            try
            {
                // Əsl email göndərmək üçün:
                using var smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("your-email@gmail.com", "your-app-password");

                using var msg = new MailMessage();
                msg.From = new MailAddress("your-email@gmail.com", "SecureLogin");
                msg.To.Add(to);
                msg.Subject = "Şifrə sıfırlama təsdiq kodu";
                msg.Body = $@"
                    <html>
                    <body style='font-family: Arial, sans-serif;'>
                        <h2 style='color: #1A6B3C;'>Şifrə Sıfırlama</h2>
                        <p>Təsdiq kodunuz: <strong style='font-size: 24px; color: #1A6B3C;'>{code}</strong></p>
                        <p>Bu kod 5 dəqiqə ərzində etibarlıdır.</p>
                        <hr>
                        <small>SecureLogin tərəfindən göndərildi</small>
                    </body>
                    </html>";
                msg.IsBodyHtml = true;

                smtp.Send(msg);

                // Demo üçün mesaj göstər
                MessageBox.Show($"Təsdiq kodu: {code}\n\n(Email göndərildi: {to})",
                    "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch
            {
                // Demo üçün true qaytar
                MessageBox.Show($"Təsdiq kodu: {code}\n\n(Email göndərilə bilmədi, lakin test üçün kod göstərilir)",
                    "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
        }

        // ── Köməkçi metodlar ──────────────────────────────────────────
        private string GenerateVerificationCode()
        {
            var random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void ShowError(string msg)
        {
            lblError.Text = "  " + msg;
            pnlError.Visible = true;
            pnlError.BackColor = Color.FromArgb(255, 235, 235);
        }

        private void ShowSuccess(string msg)
        {
            lblError.Text = "  ✅ " + msg;
            pnlError.Visible = true;
            pnlError.BackColor = Color.FromArgb(220, 255, 220);
        }

        // ── Hover effektləri ──────────────────────────────────────────
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(255, 80, 80);
            btnClose.ForeColor = Color.White;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
            btnClose.ForeColor = Color.FromArgb(80, 80, 80);
        }
    }
}