using System.Drawing.Drawing2D;

namespace WinFormsApp2
{
    public partial class RegisterForm : Form
    {
        private bool _isDragging = false;
        private Point _dragStartPoint = Point.Empty;

        public RegisterForm()
        {
            InitializeComponent();
            ApplyRoundedCorners();
            SetupFormDrag();
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Xətaların yoxlanılması
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                ShowError("Bütün sahələri doldurun.");
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                ShowError("Düzgün email daxil edin.");
                return;
            }

            if (password.Length < 8)
            {
                ShowError("Şifrə ən azı 8 simvol olmalıdır.");
                return;
            }

            if (password != confirmPassword)
            {
                ShowError("Şifrələr uyğun gəlmir.");
                return;
            }

            // Məntiq 1: Ad artıq mövcuddur?
            if (Form1.RegisteredUsers.ContainsKey(username))
            {
                ShowError("Bu istifadəçi adı artıq mövcuddur.");
                return;
            }

            // Məntiq 2: Email artıq mövcuddur?
            if (Form1.UserEmails.ContainsKey(email))
            {
                ShowError("Bu email artıq qeydiyyatdan keçib!");
                return;
            }

            // İstifadəçini və Emailini Sistemə qeyd edirik
            Form1.RegisteredUsers.Add(username, Form1.HashSha256(password));
            Form1.UserEmails.Add(email, username);

            MessageBox.Show("Qeydiyyat uğurla tamamlandı! İndi daxil ola bilərsiniz.",
                "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void ShowError(string msg)
        {
            lblError.Text = "  " + msg;
            pnlError.Visible = true;
            pnlError.BackColor = Color.FromArgb(255, 235, 235);
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