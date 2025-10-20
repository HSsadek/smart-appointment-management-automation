namespace AkilliRandevuYonetimiS
{
    partial class frmSifremiUnuttum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelMain = new System.Windows.Forms.Panel();
            panelCard = new System.Windows.Forms.Panel();
            pictureBoxLogo = new System.Windows.Forms.PictureBox();
            labelTitle = new DevExpress.XtraEditors.LabelControl();
            labelDesc = new DevExpress.XtraEditors.LabelControl();
            txtEmail = new DevExpress.XtraEditors.TextEdit();
            btnSend = new DevExpress.XtraEditors.SimpleButton();
            txtCode = new DevExpress.XtraEditors.TextEdit();
            btnVerify = new DevExpress.XtraEditors.SimpleButton();
            panelMain.SuspendLayout();
            panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCode.Properties).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            panelMain.Controls.Add(panelCard);
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new System.Windows.Forms.Padding(20);
            panelMain.Size = new System.Drawing.Size(600, 360);
            panelMain.TabIndex = 0;
            // 
            // panelCard
            // 
            panelCard.BackColor = System.Drawing.Color.White;
            panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelCard.Controls.Add(pictureBoxLogo);
            panelCard.Controls.Add(labelTitle);
            panelCard.Controls.Add(labelDesc);
            panelCard.Controls.Add(txtEmail);
            panelCard.Controls.Add(btnSend);
            panelCard.Controls.Add(txtCode);
            panelCard.Controls.Add(btnVerify);
            panelCard.Location = new System.Drawing.Point(90, 40);
            panelCard.Name = "panelCard";
            panelCard.Size = new System.Drawing.Size(420, 280);
            panelCard.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new System.Drawing.Point(28, 18);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new System.Drawing.Size(56, 56);
            pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            labelTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(34, 34, 34);
            labelTitle.Appearance.Options.UseFont = true;
            labelTitle.Appearance.Options.UseForeColor = true;
            labelTitle.Location = new System.Drawing.Point(100, 30);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(170, 28);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Şifremi Unuttum";
            // 
            // labelDesc
            // 
            labelDesc.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            labelDesc.Appearance.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            labelDesc.Appearance.Options.UseFont = true;
            labelDesc.Appearance.Options.UseForeColor = true;
            labelDesc.Location = new System.Drawing.Point(100, 62);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new System.Drawing.Size(220, 15);
            labelDesc.TabIndex = 2;
            labelDesc.Text = "E-posta adresinizi girin, size 6 haneli bir kod gönderelim.";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(28, 100);
            txtEmail.Name = "txtEmail";
            txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtEmail.Properties.Appearance.Options.UseFont = true;
            txtEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            txtEmail.Properties.NullValuePrompt = "E-posta adresi";
            txtEmail.Properties.Padding = new System.Windows.Forms.Padding(8);
            txtEmail.Size = new System.Drawing.Size(362, 42);
            txtEmail.TabIndex = 3;
            // 
            // btnSend
            // 
            btnSend.Appearance.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnSend.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnSend.Appearance.ForeColor = System.Drawing.Color.White;
            btnSend.Appearance.Options.UseBackColor = true;
            btnSend.Appearance.Options.UseFont = true;
            btnSend.Appearance.Options.UseForeColor = true;
            btnSend.Location = new System.Drawing.Point(28, 154);
            btnSend.LookAndFeel.UseDefaultLookAndFeel = false;
            btnSend.Name = "btnSend";
            btnSend.Size = new System.Drawing.Size(362, 40);
            btnSend.TabIndex = 4;
            btnSend.Text = "Kod Gönder";
            btnSend.Click += btnSend_Click;
            // 
            // txtCode
            // 
            txtCode.Location = new System.Drawing.Point(28, 204);
            txtCode.Name = "txtCode";
            txtCode.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtCode.Properties.Appearance.Options.UseFont = true;
            txtCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            txtCode.Properties.NullValuePrompt = "Gönderilen 6 haneli kod";
            txtCode.Properties.Padding = new System.Windows.Forms.Padding(8);
            txtCode.Size = new System.Drawing.Size(240, 42);
            txtCode.TabIndex = 5;
            // 
            // btnVerify
            // 
            btnVerify.Appearance.BackColor = System.Drawing.Color.FromArgb(24, 75, 200);
            btnVerify.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnVerify.Appearance.ForeColor = System.Drawing.Color.White;
            btnVerify.Appearance.Options.UseBackColor = true;
            btnVerify.Appearance.Options.UseFont = true;
            btnVerify.Appearance.Options.UseForeColor = true;
            btnVerify.Location = new System.Drawing.Point(280, 204);
            btnVerify.LookAndFeel.UseDefaultLookAndFeel = false;
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new System.Drawing.Size(110, 42);
            btnVerify.TabIndex = 6;
            btnVerify.Text = "Doğrula";
            btnVerify.Click += btnVerify_Click;
            // 
            // frmSifremiUnuttum
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            ClientSize = new System.Drawing.Size(600, 360);
            Controls.Add(panelMain);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmSifremiUnuttum";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Şifremi Unuttum";
            panelMain.ResumeLayout(false);
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCode.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private DevExpress.XtraEditors.LabelControl labelTitle;
        private DevExpress.XtraEditors.LabelControl labelDesc;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.SimpleButton btnSend;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.SimpleButton btnVerify;
    }
}