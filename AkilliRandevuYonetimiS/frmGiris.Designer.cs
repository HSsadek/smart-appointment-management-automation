namespace AkilliRandevuYonetimiS
{
    partial class frmGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            txtSifre = new DevExpress.XtraEditors.TextEdit();
            btnGiris = new DevExpress.XtraEditors.SimpleButton();
            linkSifremiUnuttum = new DevExpress.XtraEditors.HyperlinkLabelControl();
            svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(components);
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            panelMain.SuspendLayout();
            panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtKullaniciAdi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSifre.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollection1).BeginInit();
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
            panelMain.Size = new System.Drawing.Size(800, 450);
            panelMain.TabIndex = 0;
            // 
            // panelCard
            // 
            panelCard.BackColor = System.Drawing.Color.White;
            panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelCard.Controls.Add(pictureBoxLogo);
            panelCard.Controls.Add(labelControl1);
            panelCard.Controls.Add(labelControl2);
            panelCard.Controls.Add(txtKullaniciAdi);
            panelCard.Controls.Add(txtSifre);
            panelCard.Controls.Add(btnGiris);
            panelCard.Controls.Add(linkSifremiUnuttum);
            panelCard.Location = new System.Drawing.Point(190, 65);
            panelCard.Name = "panelCard";
            panelCard.Size = new System.Drawing.Size(420, 320);
            panelCard.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new System.Drawing.Point(28, 18);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new System.Drawing.Size(60, 60);
            pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(34, 34, 34);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new System.Drawing.Point(100, 30);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(147, 32);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Sisteme Giriş";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(90, 90, 90);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new System.Drawing.Point(100, 66);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(171, 15);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "Lütfen kullanıcı bilgilerinizi girin.";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new System.Drawing.Point(28, 110);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            txtKullaniciAdi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            txtKullaniciAdi.Properties.NullValuePrompt = "Kullanıcı adı veya e-posta";
            txtKullaniciAdi.Properties.Padding = new System.Windows.Forms.Padding(8);
            txtKullaniciAdi.Size = new System.Drawing.Size(362, 42);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new System.Drawing.Point(28, 162);
            txtSifre.Name = "txtSifre";
            txtSifre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtSifre.Properties.Appearance.Options.UseFont = true;
            txtSifre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            txtSifre.Properties.NullValuePrompt = "Şifrenizi giriniz";
            txtSifre.Properties.Padding = new System.Windows.Forms.Padding(8);
            txtSifre.Properties.PasswordChar = '*';
            txtSifre.Size = new System.Drawing.Size(362, 42);
            txtSifre.TabIndex = 3;
            // 
            // btnGiris
            // 
            btnGiris.Appearance.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            btnGiris.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnGiris.Appearance.ForeColor = System.Drawing.Color.White;
            btnGiris.Appearance.Options.UseBackColor = true;
            btnGiris.Appearance.Options.UseFont = true;
            btnGiris.Appearance.Options.UseForeColor = true;
            btnGiris.Location = new System.Drawing.Point(28, 220);
            btnGiris.LookAndFeel.UseDefaultLookAndFeel = false;
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new System.Drawing.Size(362, 42);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş Yap";
            btnGiris.Click += btnGiris_Click;
            // 
            // linkSifremiUnuttum
            // 
            linkSifremiUnuttum.Location = new System.Drawing.Point(28, 274);
            linkSifremiUnuttum.Name = "linkSifremiUnuttum";
            linkSifremiUnuttum.Size = new System.Drawing.Size(81, 13);
            linkSifremiUnuttum.TabIndex = 5;
            linkSifremiUnuttum.Text = "Şifremi Unuttum?";
            // 
            // labelControl3
            // 
            labelControl3.Location = new System.Drawing.Point(0, 0);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(75, 14);
            labelControl3.TabIndex = 0;
            // 
            // labelControl4
            // 
            labelControl4.Location = new System.Drawing.Point(0, 0);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(75, 14);
            labelControl4.TabIndex = 0;
            // 
            // labelControl5
            // 
            labelControl5.Location = new System.Drawing.Point(0, 0);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(75, 14);
            labelControl5.TabIndex = 0;
            // 
            // frmGiris
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(panelMain);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmGiris";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Sisteme Giriş";
            panelMain.ResumeLayout(false);
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtKullaniciAdi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSifre.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollection1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.SimpleButton btnGiris;
        private DevExpress.XtraEditors.HyperlinkLabelControl linkSifremiUnuttum;
    }
}