using System.Drawing.Drawing2D;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace WinFormsApp2
{
    public partial class ForgotPasswordForm : Form
    {
        private bool _isDragging = false;
        private Point _dragStartPoint = Point.Empty;
        private string _generatedCode = "";
        private System.Windows.Forms.Timer _timer;
        private int _remainingSeconds = 60;
        private string _targetUsername = ""; // Şifrəsi dəyişdiriləcək istifadəçini yadda saxlamaq üçün

        public ForgotPasswordForm()
        {
            InitializeComponent();
            ApplyRoundedCorners();
            SetupFormDrag();
            SetupTimer();
        }

        private void SetupFormDrag()
        {
            pnlMain.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    _isDragging = true;
                    _dragStartPoint = new Point(e.X, e.Y);
                }
            };
            pnlMain.MouseMove += (s, e) =>
            {
                if (_isDragging)
                {
                    Point p = PointToScreen(e.Location);
                    this.Location = new Point(p.X - _dragStartPoint.X, p.Y - _dragStartPoint.Y);
                }
            };
            pnlMain.MouseUp += (s, e) => _isDragging = false;
        }

        private void SetupTimer()
        {
            _timer = new System.Windows.Forms.Timer { Interval = 1000 };
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

            // SİSTEMDƏ EMAİL VARMI DEYƏ YOXLANILMASI
            if (!Form1.UserEmails.ContainsKey(email))
            {
                ShowError("Bu email sistemdə tapılmadı!");
                return;
            }

            // Varsa, sahibini yadda saxlayaq
            _targetUsername = Form1.UserEmails[email];

            _generatedCode = GenerateVerificationCode();
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

            if (newPass != confirmPass)
            {
                ShowError("Şifrələr uyğun gəlmir.");
                return;
            }

            // ŞİFRƏNİN SİSTEMDƏ (LÜĞƏTDƏ) HƏQİQƏTƏN YENİLƏNMƏSİ
            Form1.RegisteredUsers[_targetUsername] = Form1.HashSha256(newPass);

            MessageBox.Show("Şifrə uğurla yeniləndi! Yeni şifrənizlə daxil ola bilərsiniz.", "Uğurlu",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Köməkçi Metodlar
        private bool SendVerificationEmail(string to, string code)
        {
            try
            {
                // Demo simulyasiyası
                MessageBox.Show($"Təsdiq kodu: {code}\n\n(Email göndərildi: {to})",
                    "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private string GenerateVerificationCode() => new Random().Next(100000, 999999).ToString();

        private bool IsValidEmail(string email)
        {
            try { return new MailAddress(email).Address == email; }
            catch { return false; }
        }

        private void ShowError(string msg) { lblError.Text = "  " + msg; pnlError.Visible = true; pnlError.BackColor = Color.FromArgb(255, 235, 235); }
        private void ShowSuccess(string msg) { lblError.Text = "  ✅ " + msg; pnlError.Visible = true; pnlError.BackColor = Color.FromArgb(220, 255, 220); }
        private void btnClose_MouseEnter(object sender, EventArgs e) { btnClose.BackColor = Color.FromArgb(255, 80, 80); btnClose.ForeColor = Color.White; }
        private void btnClose_MouseLeave(object sender, EventArgs e) { btnClose.BackColor = Color.Transparent; btnClose.ForeColor = Color.FromArgb(80, 80, 80); }
    }
}