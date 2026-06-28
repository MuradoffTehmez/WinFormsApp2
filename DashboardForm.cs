using System.Drawing.Drawing2D;

namespace WinFormsApp2
{
    public partial class DashboardForm : Form
    {
        private string _username;
        private bool _isDragging = false;
        private Point _dragStartPoint = Point.Empty;
        private System.Windows.Forms.Timer _clockTimer;

        public DashboardForm(string username)
        {
            InitializeComponent();
            _username = username;
            ApplyRoundedCorners();
            SetupFormDrag();
            SetupClock();
            lblWelcome.Text = $"Xoş gəldiniz, {username}!";

            if (username == "Qonaq")
            {
                btnSettings.Enabled = false;
                btnProfile.Enabled = false;
                lblUserType.Text = "🔓 Qonaq";
                lblUserType.ForeColor = Color.FromArgb(200, 150, 50);
            }
            else
            {
                lblUserType.Text = "🔐 Admin";
                lblUserType.ForeColor = Color.FromArgb(16, 130, 70);
            }
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

        private void SetupClock()
        {
            _clockTimer = new System.Windows.Forms.Timer();
            _clockTimer.Interval = 1000;
            _clockTimer.Tick += (s, e) =>
            {
                lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
                lblDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
            };
            _clockTimer.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Çıxış etmək istədiyinizə əminsiniz?",
                "Çıxış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
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

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.Transparent;
        }
    }
}