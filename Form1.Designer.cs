namespace WinFormsApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlError;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.LinkLabel lnkForgot;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnEye;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblCooldown;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlMain = new Panel();
            pnlCard = new Panel();
            pnlHeader = new Panel();
            btnClose = new Button();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlError = new Panel();
            lblError = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnEye = new Button();
            chkRemember = new CheckBox();
            lnkForgot = new LinkLabel();
            progressBar = new ProgressBar();
            btnLogin = new Button();
            btnGuest = new Button();
            pnlMain.SuspendLayout();
            pnlCard.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlError.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlCard);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(580, 750);
            pnlMain.TabIndex = 0;
            pnlMain.Paint += pnlMain_Paint;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(pnlHeader);
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Controls.Add(lblSubtitle);
            pnlCard.Controls.Add(pnlError);
            pnlCard.Controls.Add(lblUsername);
            pnlCard.Controls.Add(txtUsername);
            pnlCard.Controls.Add(lblPassword);
            pnlCard.Controls.Add(txtPassword);
            pnlCard.Controls.Add(btnEye);
            pnlCard.Controls.Add(chkRemember);
            pnlCard.Controls.Add(lnkForgot);
            pnlCard.Controls.Add(progressBar);
            pnlCard.Controls.Add(btnLogin);
            pnlCard.Controls.Add(btnGuest);
            pnlCard.Location = new Point(90, 60);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(400, 640);
            pnlCard.TabIndex = 1;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(400, 30);
            pnlHeader.TabIndex = 12;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.ForeColor = Color.FromArgb(80, 80, 80);
            btnClose.Location = new Point(366, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 30);
            btnClose.TabIndex = 0;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(16, 130, 70);
            lblTitle.Location = new Point(20, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(360, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🌿 SecureLogin";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(100, 120, 110);
            lblSubtitle.Location = new Point(20, 90);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(360, 30);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Hesabınıza daxil olun";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlError
            // 
            pnlError.BackColor = Color.FromArgb(255, 235, 235);
            pnlError.Controls.Add(lblError);
            pnlError.Location = new Point(20, 135);
            pnlError.Name = "pnlError";
            pnlError.Size = new Size(360, 40);
            pnlError.TabIndex = 2;
            pnlError.Visible = false;
            // 
            // lblError
            // 
            lblError.Dock = DockStyle.Fill;
            lblError.Font = new Font("Segoe UI", 9F);
            lblError.ForeColor = Color.FromArgb(200, 50, 50);
            lblError.Location = new Point(0, 0);
            lblError.Name = "lblError";
            lblError.Padding = new Padding(10, 0, 0, 0);
            lblError.Size = new Size(360, 40);
            lblError.TabIndex = 0;
            lblError.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(40, 60, 50);
            lblUsername.Location = new Point(20, 195);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(360, 25);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "İstifadəçi adı";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(20, 222);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "admin";
            txtUsername.Size = new Size(360, 30);
            txtUsername.TabIndex = 0;
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(40, 60, 50);
            lblPassword.Location = new Point(20, 275);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(360, 25);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Şifrə";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(20, 302);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "••••••••";
            txtPassword.Size = new Size(326, 30);
            txtPassword.TabIndex = 1;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // btnEye
            // 
            btnEye.BackColor = Color.White;
            btnEye.Cursor = Cursors.Hand;
            btnEye.FlatAppearance.BorderSize = 0;
            btnEye.FlatStyle = FlatStyle.Flat;
            btnEye.Font = new Font("Segoe UI", 12F);
            btnEye.Location = new Point(346, 296);
            btnEye.Name = "btnEye";
            btnEye.Size = new Size(34, 40);
            btnEye.TabIndex = 5;
            btnEye.TabStop = false;
            btnEye.Text = "👁";
            btnEye.UseVisualStyleBackColor = false;
            btnEye.Click += btnEye_Click;
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.Font = new Font("Segoe UI", 9F);
            chkRemember.ForeColor = Color.FromArgb(60, 80, 70);
            chkRemember.Location = new Point(20, 365);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(109, 24);
            chkRemember.TabIndex = 2;
            chkRemember.Text = "Məni xatırla";
            // 
            // lnkForgot
            // 
            lnkForgot.AutoSize = true;
            lnkForgot.Font = new Font("Segoe UI", 9F);
            lnkForgot.LinkColor = Color.FromArgb(16, 130, 70);
            lnkForgot.Location = new Point(270, 368);
            lnkForgot.Name = "lnkForgot";
            lnkForgot.Size = new Size(121, 20);
            lnkForgot.TabIndex = 3;
            lnkForgot.TabStop = true;
            lnkForgot.Text = "Şifrəni unutdum?";
            lnkForgot.LinkClicked += lnkForgot_LinkClicked;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(20, 409);
            progressBar.MarqueeAnimationSpeed = 30;
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(360, 10);
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.TabIndex = 6;
            progressBar.Visible = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(16, 130, 70);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(20, 430);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(360, 50);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Daxil ol";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseEnter += btnLogin_MouseEnter;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            // 
            // btnGuest
            // 
            btnGuest.BackColor = Color.White;
            btnGuest.Cursor = Cursors.Hand;
            btnGuest.FlatAppearance.BorderColor = Color.FromArgb(16, 130, 70);
            btnGuest.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 255, 240);
            btnGuest.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 255, 240);
            btnGuest.FlatStyle = FlatStyle.Flat;
            btnGuest.Font = new Font("Segoe UI", 10F);
            btnGuest.ForeColor = Color.FromArgb(16, 130, 70);
            btnGuest.Location = new Point(20, 500);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(360, 45);
            btnGuest.TabIndex = 5;
            btnGuest.Text = "Qonaq olaraq davam et";
            btnGuest.UseVisualStyleBackColor = false;
            btnGuest.Click += btnGuest_Click;
            btnGuest.MouseEnter += btnGuest_MouseEnter;
            btnGuest.MouseLeave += btnGuest_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 750);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SecureLogin";
            pnlMain.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlError.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}