namespace WinFormsApp2
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlError;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlMain = new Panel();
            pnlContent = new Panel();
            btnClose = new Button();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlError = new Panel();
            lblError = new Label();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnRegister = new Button();
            pnlMain.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlError.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(16, 60, 30);
            pnlMain.Controls.Add(pnlContent);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(450, 535);
            pnlMain.TabIndex = 0;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.Controls.Add(btnClose);
            pnlContent.Controls.Add(lblTitle);
            pnlContent.Controls.Add(lblSubtitle);
            pnlContent.Controls.Add(pnlError);
            pnlContent.Controls.Add(txtUsername);
            pnlContent.Controls.Add(txtEmail);
            pnlContent.Controls.Add(txtPassword);
            pnlContent.Controls.Add(txtConfirmPassword);
            pnlContent.Controls.Add(btnRegister);
            pnlContent.Location = new Point(25, 25);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(400, 478);
            pnlContent.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.ForeColor = Color.FromArgb(80, 80, 80);
            btnClose.Location = new Point(355, 5);
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
            lblTitle.Location = new Point(20, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(360, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "📝 Qeydiyyat";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(20, 75);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(360, 30);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Yeni hesab yaratmaq üçün məlumatları daxil edin";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlError
            // 
            pnlError.BackColor = Color.FromArgb(255, 235, 235);
            pnlError.Controls.Add(lblError);
            pnlError.Location = new Point(20, 115);
            pnlError.Name = "pnlError";
            pnlError.Size = new Size(360, 40);
            pnlError.TabIndex = 3;
            pnlError.Visible = false;
            // 
            // lblError
            // 
            lblError.Dock = DockStyle.Fill;
            lblError.ForeColor = Color.FromArgb(200, 50, 50);
            lblError.Location = new Point(0, 0);
            lblError.Name = "lblError";
            lblError.Padding = new Padding(10, 0, 0, 0);
            lblError.Size = new Size(360, 40);
            lblError.TabIndex = 0;
            lblError.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(20, 173);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "İstifadəçi adı";
            txtUsername.Size = new Size(360, 30);
            txtUsername.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(20, 217);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email ünvanı";
            txtEmail.Size = new Size(360, 30);
            txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(20, 261);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "Şifrə";
            txtPassword.Size = new Size(360, 30);
            txtPassword.TabIndex = 6;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 10F);
            txtConfirmPassword.Location = new Point(20, 305);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.PlaceholderText = "Şifrəni təsdiqlə";
            txtConfirmPassword.Size = new Size(360, 30);
            txtConfirmPassword.TabIndex = 7;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(16, 130, 70);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(20, 369);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(360, 45);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Qeydiyyatdan keç";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // RegisterForm
            // 
            ClientSize = new Size(450, 535);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterParent;
            pnlMain.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlError.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}