namespace WinFormsApp2
{
    partial class GuestForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblFeatures;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnCancel;

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
            lblFeatures = new Label();
            btnContinue = new Button();
            btnCancel = new Button();

            pnlMain.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();

            // pnlMain
            pnlMain.BackColor = Color.FromArgb(16, 60, 30);
            pnlMain.Controls.Add(pnlContent);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(450, 400);

            // pnlContent
            pnlContent.BackColor = Color.White;
            pnlContent.Controls.Add(btnClose);
            pnlContent.Controls.Add(lblTitle);
            pnlContent.Controls.Add(lblSubtitle);
            pnlContent.Controls.Add(lblFeatures);
            pnlContent.Controls.Add(btnContinue);
            pnlContent.Controls.Add(btnCancel);
            pnlContent.Location = new Point(25, 25);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(400, 350);
            pnlContent.TabIndex = 0;

            // btnClose
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
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

            // lblTitle
            lblTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(16, 130, 70);
            lblTitle.Location = new Point(20, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(360, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "👤 Qonaq Rejimi";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // lblSubtitle
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(100, 120, 110);
            lblSubtitle.Location = new Point(20, 75);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(360, 30);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Qonaq olaraq aşağıdakı xüsusiyyətlərdən istifadə edə bilərsiniz:";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;

            // lblFeatures
            lblFeatures.Font = new Font("Segoe UI", 9F);
            lblFeatures.ForeColor = Color.FromArgb(60, 60, 60);
            lblFeatures.Location = new Point(20, 120);
            lblFeatures.Name = "lblFeatures";
            lblFeatures.Size = new Size(360, 120);
            lblFeatures.TabIndex = 3;
            lblFeatures.Text =
                "  ✅ Məhsulları baxış\n" +
                "  ✅ Kataloqda axtarış\n" +
                "  ✅ Məlumat səhifələri\n" +
                "  ✅ Əlaqə məlumatları\n\n" +
                "  ❌ Sifariş verə bilməzsiniz\n" +
                "  ❌ Profil məlumatlarını dəyişə bilməzsiniz";
            lblFeatures.TextAlign = ContentAlignment.MiddleLeft;

            // btnContinue
            btnContinue.BackColor = Color.FromArgb(16, 130, 70);
            btnContinue.Cursor = Cursors.Hand;
            btnContinue.FlatAppearance.BorderSize = 0;
            btnContinue.FlatStyle = FlatStyle.Flat;
            btnContinue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnContinue.ForeColor = Color.White;
            btnContinue.Location = new Point(20, 260);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(170, 45);
            btnContinue.TabIndex = 4;
            btnContinue.Text = "Davam et";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click;

            // btnCancel
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F);
            btnCancel.ForeColor = Color.FromArgb(80, 80, 80);
            btnCancel.Location = new Point(210, 260);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 45);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Ləğv et";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };

            // GuestForm
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 400);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GuestForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Qonaq Rejimi";
            pnlMain.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}