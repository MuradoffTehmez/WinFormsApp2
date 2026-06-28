namespace WinFormsApp2
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Label lblStatsTitle;
        private System.Windows.Forms.Label lblTotalUsers;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.Label lblRevenue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlMain = new Panel();
            pnlHeader = new Panel();
            btnClose = new Button();
            btnMinimize = new Button();
            lblTitle = new Label();
            pnlContent = new Panel();
            lblWelcome = new Label();
            lblUserType = new Label();
            lblClock = new Label();
            lblDate = new Label();
            btnProfile = new Button();
            btnSettings = new Button();
            btnProducts = new Button();
            btnLogout = new Button();
            pnlStats = new Panel();
            lblStatsTitle = new Label();
            lblTotalUsers = new Label();
            lblTotalOrders = new Label();
            lblRevenue = new Label();

            pnlMain.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlStats.SuspendLayout();
            SuspendLayout();

            // pnlMain
            pnlMain.BackColor = Color.FromArgb(16, 60, 30);
            pnlMain.Controls.Add(pnlHeader);
            pnlMain.Controls.Add(pnlContent);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(800, 600);

            // pnlHeader
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Controls.Add(btnMinimize);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(20, 20);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(760, 50);
            pnlHeader.TabIndex = 0;

            // btnClose
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.ForeColor = Color.FromArgb(80, 80, 80);
            btnClose.Location = new Point(720, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 40);
            btnClose.TabIndex = 0;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;

            // btnMinimize
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 12F);
            btnMinimize.ForeColor = Color.FromArgb(80, 80, 80);
            btnMinimize.Location = new Point(685, 5);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(35, 40);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "─";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            btnMinimize.MouseEnter += btnMinimize_MouseEnter;
            btnMinimize.MouseLeave += btnMinimize_MouseLeave;

            // lblTitle
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(16, 130, 70);
            lblTitle.Location = new Point(20, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 40);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "🌿 Dashboard";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;

            // pnlContent
            pnlContent.BackColor = Color.White;
            pnlContent.Controls.Add(lblWelcome);
            pnlContent.Controls.Add(lblUserType);
            pnlContent.Controls.Add(lblClock);
            pnlContent.Controls.Add(lblDate);
            pnlContent.Controls.Add(btnProfile);
            pnlContent.Controls.Add(btnSettings);
            pnlContent.Controls.Add(btnProducts);
            pnlContent.Controls.Add(btnLogout);
            pnlContent.Controls.Add(pnlStats);
            pnlContent.Location = new Point(20, 80);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(760, 490);
            pnlContent.TabIndex = 1;

            // lblWelcome
            lblWelcome.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(40, 60, 50);
            lblWelcome.Location = new Point(20, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(500, 35);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Xoş gəldiniz!";

            // lblUserType
            lblUserType.Font = new Font("Segoe UI", 10F);
            lblUserType.Location = new Point(20, 55);
            lblUserType.Name = "lblUserType";
            lblUserType.Size = new Size(200, 25);
            lblUserType.TabIndex = 1;
            lblUserType.Text = "🔐 Admin";

            // lblClock
            lblClock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblClock.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblClock.ForeColor = Color.FromArgb(16, 130, 70);
            lblClock.Location = new Point(550, 20);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(190, 35);
            lblClock.TabIndex = 2;
            lblClock.Text = "00:00:00";
            lblClock.TextAlign = ContentAlignment.MiddleRight;

            // lblDate
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDate.Font = new Font("Segoe UI", 10F);
            lblDate.ForeColor = Color.Gray;
            lblDate.Location = new Point(550, 55);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(190, 25);
            lblDate.TabIndex = 3;
            lblDate.Text = "01 January 2024";
            lblDate.TextAlign = ContentAlignment.MiddleRight;

            // pnlStats
            pnlStats.BackColor = Color.FromArgb(245, 250, 247);
            pnlStats.Controls.Add(lblStatsTitle);
            pnlStats.Controls.Add(lblTotalUsers);
            pnlStats.Controls.Add(lblTotalOrders);
            pnlStats.Controls.Add(lblRevenue);
            pnlStats.Location = new Point(20, 95);
            pnlStats.Name = "pnlStats";
            pnlStats.Size = new Size(720, 120);
            pnlStats.TabIndex = 4;

            // lblStatsTitle
            lblStatsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatsTitle.ForeColor = Color.FromArgb(40, 60, 50);
            lblStatsTitle.Location = new Point(15, 10);
            lblStatsTitle.Name = "lblStatsTitle";
            lblStatsTitle.Size = new Size(690, 25);
            lblStatsTitle.TabIndex = 0;
            lblStatsTitle.Text = "📊 Statistikalar";

            // lblTotalUsers
            lblTotalUsers.Font = new Font("Segoe UI", 10F);
            lblTotalUsers.ForeColor = Color.FromArgb(60, 60, 60);
            lblTotalUsers.Location = new Point(15, 45);
            lblTotalUsers.Name = "lblTotalUsers";
            lblTotalUsers.Size = new Size(200, 25);
            lblTotalUsers.TabIndex = 1;
            lblTotalUsers.Text = "👥 Ümumi istifadəçi: 1,248";

            // lblTotalOrders
            lblTotalOrders.Font = new Font("Segoe UI", 10F);
            lblTotalOrders.ForeColor = Color.FromArgb(60, 60, 60);
            lblTotalOrders.Location = new Point(260, 45);
            lblTotalOrders.Name = "lblTotalOrders";
            lblTotalOrders.Size = new Size(200, 25);
            lblTotalOrders.TabIndex = 2;
            lblTotalOrders.Text = "📦 Sifarişlər: 542";

            // lblRevenue
            lblRevenue.Font = new Font("Segoe UI", 10F);
            lblRevenue.ForeColor = Color.FromArgb(60, 60, 60);
            lblRevenue.Location = new Point(505, 45);
            lblRevenue.Name = "lblRevenue";
            lblRevenue.Size = new Size(200, 25);
            lblRevenue.TabIndex = 3;
            lblRevenue.Text = "💰 Gəlir: $12,450";

            // btnProducts
            btnProducts.BackColor = Color.White;
            btnProducts.Cursor = Cursors.Hand;
            btnProducts.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 10F);
            btnProducts.ForeColor = Color.FromArgb(40, 60, 50);
            btnProducts.Location = new Point(20, 240);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(170, 45);
            btnProducts.TabIndex = 5;
            btnProducts.Text = "📦 Məhsullar";
            btnProducts.UseVisualStyleBackColor = false;

            // btnProfile
            btnProfile.BackColor = Color.White;
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 10F);
            btnProfile.ForeColor = Color.FromArgb(40, 60, 50);
            btnProfile.Location = new Point(210, 240);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(170, 45);
            btnProfile.TabIndex = 6;
            btnProfile.Text = "👤 Profil";
            btnProfile.UseVisualStyleBackColor = false;

            // btnSettings
            btnSettings.BackColor = Color.White;
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 10F);
            btnSettings.ForeColor = Color.FromArgb(40, 60, 50);
            btnSettings.Location = new Point(400, 240);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(170, 45);
            btnSettings.TabIndex = 7;
            btnSettings.Text = "⚙️ Ayarlar";
            btnSettings.UseVisualStyleBackColor = false;

            // btnLogout
            btnLogout.BackColor = Color.FromArgb(16, 130, 70);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(20, 310);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(720, 45);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "🚪 Çıxış et";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;

            // DashboardForm
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 620);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            pnlMain.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlStats.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}