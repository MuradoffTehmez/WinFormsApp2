using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private bool _showPassword = false;
        private int _failCount = 0;
        private const int MAX_FAIL = 5;
        private const string REG_KEY = @"SOFTWARE\SecureLoginApp";
        private bool _isDragging = false;
        private Point _dragStartPoint = Point.Empty;
        private System.Windows.Forms.Timer _timer;
        private int _cooldownSeconds = 0;

        public Form1()
        {
            InitializeComponent();
            ApplyRoundedCard();
            LoadRememberedUser();
            SetupFormDrag();
            SetupAutoLogoutTimer();

            this.txtUsername.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) txtPassword.Focus();
            };
            this.txtPassword.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) btnLogin_Click(s, e);
            };
        }

        // ── Formu sürüşdürmə ─────────────────────────────────────────
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

        // ── Avtomatik çıxış timer ─────────────────────────────────────
        private void SetupAutoLogoutTimer()
        {
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            _timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_cooldownSeconds > 0)
            {
                _cooldownSeconds--;
                lblCooldown.Text = $"⏳ {_cooldownSeconds}s";
                lblCooldown.Visible = true;
                btnLogin.Enabled = false;
            }
            else
            {
                _timer.Stop();
                lblCooldown.Visible = false;
                btnLogin.Enabled = true;
            }
        }

        // ── Gradient arxa fon ─────────────────────────────────────────
        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            using var brush = new LinearGradientBrush(
                pnlMain.ClientRectangle,
                Color.FromArgb(16, 60, 30),
                Color.FromArgb(30, 100, 60),
                LinearGradientMode.ForwardDiagonal);
            e.Graphics.FillRectangle(brush, pnlMain.ClientRectangle);

            // Dekorativ dairələr
            using var pen = new Pen(Color.FromArgb(60, 180, 120), 2);
            e.Graphics.DrawEllipse(pen, -80, -80, 250, 250);
            using var pen2 = new Pen(Color.FromArgb(40, 160, 100), 2);
            e.Graphics.DrawEllipse(pen2, pnlMain.Width - 180, pnlMain.Height - 180, 250, 250);
            using var pen3 = new Pen(Color.FromArgb(30, 140, 80), 1);
            e.Graphics.DrawEllipse(pen3, pnlMain.Width / 2 - 100, -50, 200, 200);
        }

        // ── Karta yuvarlaq künc ─────────────────────────────────────
        private void ApplyRoundedCard()
        {
            int radius = 20;
            var path = new GraphicsPath();
            var rect = new Rectangle(0, 0, pnlCard.Width, pnlCard.Height);
            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
            path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
            path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            pnlCard.Region = new Region(path);
        }

        // ── Göz düyməsi ──────────────────────────────────────────────
        private void btnEye_Click(object sender, EventArgs e)
        {
            _showPassword = !_showPassword;
            txtPassword.PasswordChar = _showPassword ? '\0' : '●';
            btnEye.Text = _showPassword ? "🙈" : "👁";
            btnEye.BackColor = _showPassword ? Color.FromArgb(220, 255, 220) : Color.White;
        }

        // ── Login ─────────────────────────────────────────────────────
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            HideError();

            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                ShowError("Zəhmət olmasa bütün sahələri doldurun.");
                AnimateShake(pnlCard);
                return;
            }

            if (_failCount >= MAX_FAIL)
            {
                _cooldownSeconds = MAX_FAIL * 60;
                _timer.Start();
                ShowError($"Çoxlu uğursuz cəhd. {MAX_FAIL} dəqiqə gözləyin.");
                return;
            }

            SetLoading(true);
            await Task.Delay(700);

            bool ok = user.Equals("admin", StringComparison.OrdinalIgnoreCase)
                   && HashSha256(pass) == HashSha256("Admin@123");

            SetLoading(false);

            if (ok)
            {
                _failCount = 0;
                if (chkRemember.Checked) SaveUserToRegistry(user);
                else ClearRegistry();

                AnimateSuccess();
                MessageBox.Show($"Xoş gəldiniz, {user}!",
                    "Uğurlu giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OpenDashboard(user);
            }
            else
            {
                _failCount++;
                ShowError($"İstifadəçi adı və ya şifrə yanlışdır. ({_failCount}/{MAX_FAIL})");
                txtPassword.Clear();
                txtPassword.Focus();
                AnimateShake(pnlCard);
            }
        }

        // ── Animasiyalar ──────────────────────────────────────────────
        private async void AnimateShake(Panel panel)
        {
            var original = panel.Location;
            for (int i = 0; i < 3; i++)
            {
                panel.Left += 10;
                await Task.Delay(50);
                panel.Left -= 20;
                await Task.Delay(50);
                panel.Left += 10;
                await Task.Delay(50);
            }
        }

        private async void AnimateSuccess()
        {
            for (int i = 0; i < 5; i++)
            {
                pnlCard.BackColor = i % 2 == 0 ? Color.FromArgb(220, 255, 220) : Color.White;
                await Task.Delay(100);
            }
            pnlCard.BackColor = Color.White;
        }

        // ── Qonaq rejimi ─────────────────────────────────────────────
        private void btnGuest_Click(object sender, EventArgs e)
        {
            using var guestForm = new GuestForm();
            var result = guestForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                OpenDashboard("Qonaq");
            }
        }

        // ── Şifrəni unutdum ───────────────────────────────────────────
        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using var forgotForm = new ForgotPasswordForm();
            forgotForm.ShowDialog();
        }

        // ── Hover effektləri ──────────────────────────────────────────
        private void btnLogin_MouseEnter(object sender, EventArgs e) =>
            btnLogin.BackColor = Color.FromArgb(20, 150, 80);

        private void btnLogin_MouseLeave(object sender, EventArgs e) =>
            btnLogin.BackColor = Color.FromArgb(16, 130, 70);

        private void btnGuest_MouseEnter(object sender, EventArgs e)
        {
            btnGuest.BackColor = Color.FromArgb(230, 255, 240);
            btnGuest.FlatAppearance.BorderColor = Color.FromArgb(16, 130, 70);
        }

        private void btnGuest_MouseLeave(object sender, EventArgs e)
        {
            btnGuest.BackColor = Color.White;
            btnGuest.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.FromArgb(240, 255, 245);
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.FromArgb(240, 255, 245);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
        }

        // ── Köməkçi metodlar ──────────────────────────────────────────
        private void ShowError(string msg)
        {
            lblError.Text = "  " + msg;
            pnlError.Visible = true;
            pnlError.BackColor = Color.FromArgb(255, 235, 235);
        }

        private void HideError() => pnlError.Visible = false;

        private void SetLoading(bool on)
        {
            progressBar.Visible = on;
            btnLogin.Enabled = !on;
            btnLogin.Text = on ? "Yoxlanılır..." : "Daxil ol";
        }

        private void OpenDashboard(string username)
        {
            using var dashboard = new DashboardForm(username);
            this.Hide();
            dashboard.ShowDialog();
            this.Show();
        }

        // ── SHA-256 ───────────────────────────────────────────────────
        private static string HashSha256(string input)
        {
            using var sha = SHA256.Create();
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sb = new StringBuilder();
            foreach (var b in bytes) sb.Append(b.ToString("X2"));
            return sb.ToString();
        }

        // ── Registry ──────────────────────────────────────────────────
        private void SaveUserToRegistry(string user)
        {
            using var key = Registry.CurrentUser.CreateSubKey(REG_KEY);
            key?.SetValue("RememberedUser", user);
        }

        private void LoadRememberedUser()
        {
            using var key = Registry.CurrentUser.OpenSubKey(REG_KEY);
            if (key?.GetValue("RememberedUser") is string saved && !string.IsNullOrEmpty(saved))
            {
                txtUsername.Text = saved;
                chkRemember.Checked = true;
                txtPassword.Focus();
            }
        }

        private static void ClearRegistry()
        {
            using var key = Registry.CurrentUser.OpenSubKey(REG_KEY, true);
            key?.DeleteValue("RememberedUser", false);
        }

        // ── Bağlama düyməsi ──────────────────────────────────────────
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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