namespace WinFormsApp2
{
    partial class ForgotPasswordForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlError;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.Label lblVerificationCode;
        private System.Windows.Forms.TextBox txtVerificationCode;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnResetPassword;

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
            pnlEmail = new Panel();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnSendCode = new Button();
            lblVerificationCode = new Label();
            txtVerificationCode = new TextBox();
            btnVerify = new Button();
            lblNewPassword = new Label();
            txtNewPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            btnResetPassword = new Button();

            pnlMain.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlError.SuspendLayout();
            pnlEmail.SuspendLayout();
            SuspendLayout();

            // pnlMain
            pnlMain.BackColor = Color.FromArgb(16, 60, 30);
            pnlMain.Controls.Add(pnlContent);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(500, 650);

            // pnlContent
            pnlContent.BackColor = Color.White;
            pnlContent.Controls.Add(btnClose);
            pnlContent.Controls.Add(lblTitle);
            pnlContent.Controls.Add(lblSubtitle);
            pnlContent.Controls.Add(pnlError);
            pnlContent.Controls.Add(pnlEmail);
            pnlContent.Controls.Add(lblVerificationCode);
            pnlContent.Controls.Add(txtVerificationCode);
            pnlContent.Controls.Add(btnVerify);
            pnlContent.Controls.Add(lblNewPassword);
            pnlContent.Controls.Add(txtNewPassword);
            pnlContent.Controls.Add(lblConfirmPassword);
            pnlContent.Controls.Add(txtConfirmPassword);
            pnlContent.Controls.Add(btnResetPassword);
            pnlContent.Location = new Point(30, 30);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(440, 590);
            pnlContent.TabIndex = 0;

            // btnClose
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.ForeColor = Color.FromArgb(80, 80, 80);
            btnClose.Location = new Point(395, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 30);
            btnClose.TabIndex = 0;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;

            // lblTitle
            lblTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(16, 130, 70);
            lblTitle.Location = new Point(20, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "🔐 Şifrəni Sıfırla";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // lblSubtitle
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(20, 75);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(400, 30);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Şifrənizi sıfırlamaq üçün email ünvanınızı daxil edin";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;

            // pnlError
            pnlError.BackColor = Color.FromArgb(255, 235, 235);
            pnlError.Controls.Add(lblError);
            pnlError.Location = new Point(20, 120);
            pnlError.Name = "pnlError";
            pnlError.Size = new Size(400, 40);
            pnlError.TabIndex = 3;
            pnlError.Visible = false;

            // lblError
            lblError.Dock = DockStyle.Fill;
            lblError.Font = new Font("Segoe UI", 9F);
            lblError.ForeColor = Color.FromArgb(200, 50, 50);
            lblError.Location = new Point(0, 0);
            lblError.Name = "lblError";
            lblError.Padding = new Padding(10, 0, 0, 0);
            lblError.Size = new Size(400, 40);
            lblError.TabIndex = 0;
            lblError.TextAlign = ContentAlignment.MiddleLeft;

            // pnlEmail
            pnlEmail.Controls.Add(lblEmail);
            pnlEmail.Controls.Add(txtEmail);
            pnlEmail.Controls.Add(btnSendCode);
            pnlEmail.Location = new Point(20, 180);
            pnlEmail.Name = "pnlEmail";
            pnlEmail.Size = new Size(400, 100);
            pnlEmail.TabIndex = 4;

            // lblEmail
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(40, 60, 50);
            lblEmail.Location = new Point(0, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(400, 25);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email ünvanı";

            // txtEmail
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(0, 25);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "example@email.com";
            txtEmail.Size = new Size(400, 30);
            txtEmail.TabIndex = 1;

            // btnSendCode
            btnSendCode.BackColor = Color.FromArgb(16, 130, 70);
            btnSendCode.Cursor = Cursors.Hand;
            btnSendCode.FlatAppearance.BorderSize = 0;
            btnSendCode.FlatStyle = FlatStyle.Flat;
            btnSendCode.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSendCode.ForeColor = Color.White;
            btnSendCode.Location = new Point(0, 60);
            btnSendCode.Name = "btnSendCode";
            btnSendCode.Size = new Size(400, 35);
            btnSendCode.TabIndex = 2;
            btnSendCode.Text = "Kodu göndər";
            btnSendCode.UseVisualStyleBackColor = false;
            btnSendCode.Click += btnSendCode_Click;

            // lblVerificationCode
            lblVerificationCode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVerificationCode.ForeColor = Color.FromArgb(40, 60, 50);
            lblVerificationCode.Location = new Point(20, 295);
            lblVerificationCode.Name = "lblVerificationCode";
            lblVerificationCode.Size = new Size(400, 25);
            lblVerificationCode.TabIndex = 5;
            lblVerificationCode.Text = "Təsdiq kodu";
            lblVerificationCode.Visible = false;

            // txtVerificationCode
            txtVerificationCode.BorderStyle = BorderStyle.FixedSingle;
            txtVerificationCode.Font = new Font("Segoe UI", 10F);
            txtVerificationCode.Location = new Point(20, 322);
            txtVerificationCode.Name = "txtVerificationCode";
            txtVerificationCode.PlaceholderText = "000000";
            txtVerificationCode.Size = new Size(270, 30);
            txtVerificationCode.TabIndex = 6;
            txtVerificationCode.Visible = false;

            // btnVerify
            btnVerify.BackColor = Color.FromArgb(16, 130, 70);
            btnVerify.Cursor = Cursors.Hand;
            btnVerify.FlatAppearance.BorderSize = 0;
            btnVerify.FlatStyle = FlatStyle.Flat;
            btnVerify.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVerify.ForeColor = Color.White;
            btnVerify.Location = new Point(295, 317);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(125, 38);
            btnVerify.TabIndex = 7;
            btnVerify.Text = "Təsdiq et";
            btnVerify.UseVisualStyleBackColor = false;
            btnVerify.Visible = false;
            btnVerify.Click += btnVerify_Click;

            // lblNewPassword
            lblNewPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNewPassword.ForeColor = Color.FromArgb(40, 60, 50);
            lblNewPassword.Location = new Point(20, 375);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(400, 25);
            lblNewPassword.TabIndex = 8;
            lblNewPassword.Text = "Yeni şifrə";
            lblNewPassword.Visible = false;

            // txtNewPassword
            txtNewPassword.BorderStyle = BorderStyle.FixedSingle;
            txtNewPassword.Font = new Font("Segoe UI", 10F);
            txtNewPassword.Location = new Point(20, 402);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '●';
            txtNewPassword.PlaceholderText = "••••••••";
            txtNewPassword.Size = new Size(400, 30);
            txtNewPassword.TabIndex = 9;
            txtNewPassword.Visible = false;

            // lblConfirmPassword
            lblConfirmPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConfirmPassword.ForeColor = Color.FromArgb(40, 60, 50);
            lblConfirmPassword.Location = new Point(20, 450);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(400, 25);
            lblConfirmPassword.TabIndex = 10;
            lblConfirmPassword.Text = "Şifrəni təsdiqlə";
            lblConfirmPassword.Visible = false;

            // txtConfirmPassword
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Segoe UI", 10F);
            txtConfirmPassword.Location = new Point(20, 477);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.PlaceholderText = "••••••••";
            txtConfirmPassword.Size = new Size(400, 30);
            txtConfirmPassword.TabIndex = 11;
            txtConfirmPassword.Visible = false;

            // btnResetPassword
            btnResetPassword.BackColor = Color.FromArgb(16, 130, 70);
            btnResetPassword.Cursor = Cursors.Hand;
            btnResetPassword.FlatAppearance.BorderSize = 0;
            btnResetPassword.FlatStyle = FlatStyle.Flat;
            btnResetPassword.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnResetPassword.ForeColor = Color.White;
            btnResetPassword.Location = new Point(20, 530);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(400, 40);
            btnResetPassword.TabIndex = 12;
            btnResetPassword.Text = "Şifrəni sıfırla";
            btnResetPassword.UseVisualStyleBackColor = false;
            btnResetPassword.Visible = false;
            btnResetPassword.Click += btnResetPassword_Click;

            // ForgotPasswordForm
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 650);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Şifrəni Sıfırla";
            pnlMain.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlError.ResumeLayout(false);
            pnlEmail.ResumeLayout(false);
            pnlEmail.PerformLayout();
            ResumeLayout(false);
        }
    }
}