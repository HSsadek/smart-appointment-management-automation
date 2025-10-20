namespace AkilliRandevuYonetimiS
{
    partial class frmProfilDuzenle
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
            mainPanel = new System.Windows.Forms.Panel();
            tableLayout = new System.Windows.Forms.TableLayoutPanel();
            leftPanel = new System.Windows.Forms.Panel();
            pictureBoxProfil = new System.Windows.Forms.PictureBox();
            btnResimSec = new System.Windows.Forms.Button();
            rightLayout = new System.Windows.Forms.TableLayoutPanel();
            lblKullaniciAdi = new System.Windows.Forms.Label();
            txtKullaniciAdi = new System.Windows.Forms.TextBox();
            lblSifre = new System.Windows.Forms.Label();
            txtSifre = new System.Windows.Forms.TextBox();
            lblAdSoyad = new System.Windows.Forms.Label();
            txtAdSoyad = new System.Windows.Forms.TextBox();
            lblRol = new System.Windows.Forms.Label();
            cmbRol = new System.Windows.Forms.ComboBox();
            lblEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            buttonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            btnKaydet = new System.Windows.Forms.Button();
            btnIptal = new System.Windows.Forms.Button();
            mainPanel.SuspendLayout();
            tableLayout.SuspendLayout();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfil).BeginInit();
            rightLayout.SuspendLayout();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = System.Drawing.Color.White;
            mainPanel.Controls.Add(tableLayout);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 0);
            mainPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new System.Windows.Forms.Padding(18, 20, 18, 20);
            mainPanel.Size = new System.Drawing.Size(1029, 659);
            mainPanel.TabIndex = 0;
            // 
            // tableLayout
            // 
            tableLayout.ColumnCount = 2;
            tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66F));
            tableLayout.Controls.Add(leftPanel, 0, 0);
            tableLayout.Controls.Add(rightLayout, 1, 0);
            tableLayout.Controls.Add(buttonsPanel, 1, 1);
            tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayout.Location = new System.Drawing.Point(18, 20);
            tableLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 2;
            tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayout.Size = new System.Drawing.Size(993, 619);
            tableLayout.TabIndex = 0;
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(pictureBoxProfil);
            leftPanel.Controls.Add(btnResimSec);
            leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            leftPanel.Location = new System.Drawing.Point(3, 4);
            leftPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            leftPanel.Name = "leftPanel";
            leftPanel.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            tableLayout.SetRowSpan(leftPanel, 2);
            leftPanel.Size = new System.Drawing.Size(331, 611);
            leftPanel.TabIndex = 0;
            // 
            // pictureBoxProfil
            // 
            pictureBoxProfil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            pictureBoxProfil.Location = new System.Drawing.Point(60, 10);
            pictureBoxProfil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBoxProfil.Name = "pictureBoxProfil";
            pictureBoxProfil.Size = new System.Drawing.Size(251, 279);
            pictureBoxProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxProfil.TabIndex = 0;
            pictureBoxProfil.TabStop = false;
            // 
            // btnResimSec
            // 
            btnResimSec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnResimSec.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            btnResimSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnResimSec.ForeColor = System.Drawing.Color.White;
            btnResimSec.Location = new System.Drawing.Point(60, 304);
            btnResimSec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnResimSec.Name = "btnResimSec";
            btnResimSec.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            btnResimSec.Size = new System.Drawing.Size(251, 43);
            btnResimSec.TabIndex = 1;
            btnResimSec.Text = "Fotoğraf Seç";
            btnResimSec.UseVisualStyleBackColor = false;
            // 
            // rightLayout
            // 
            rightLayout.ColumnCount = 2;
            rightLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            rightLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            rightLayout.Controls.Add(lblKullaniciAdi, 0, 0);
            rightLayout.Controls.Add(txtKullaniciAdi, 1, 0);
            rightLayout.Controls.Add(lblSifre, 0, 1);
            rightLayout.Controls.Add(txtSifre, 1, 1);
            rightLayout.Controls.Add(lblAdSoyad, 0, 2);
            rightLayout.Controls.Add(txtAdSoyad, 1, 2);
            rightLayout.Controls.Add(lblRol, 0, 3);
            rightLayout.Controls.Add(cmbRol, 1, 3);
            rightLayout.Controls.Add(lblEmail, 0, 4);
            rightLayout.Controls.Add(txtEmail, 1, 4);
            rightLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            rightLayout.Location = new System.Drawing.Point(340, 4);
            rightLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            rightLayout.Name = "rightLayout";
            rightLayout.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            rightLayout.RowCount = 6;
            rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            rightLayout.Size = new System.Drawing.Size(650, 518);
            rightLayout.TabIndex = 1;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblKullaniciAdi.Location = new System.Drawing.Point(12, 10);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new System.Drawing.Size(120, 53);
            lblKullaniciAdi.TabIndex = 0;
            lblKullaniciAdi.Text = "Kullanıcı Adı:";
            lblKullaniciAdi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtKullaniciAdi.Location = new System.Drawing.Point(138, 14);
            txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new System.Drawing.Size(500, 23);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // lblSifre
            // 
            lblSifre.Dock = System.Windows.Forms.DockStyle.Fill;
            lblSifre.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblSifre.Location = new System.Drawing.Point(12, 63);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new System.Drawing.Size(120, 53);
            lblSifre.TabIndex = 2;
            lblSifre.Text = "Şifre:";
            lblSifre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSifre
            // 
            txtSifre.Dock = System.Windows.Forms.DockStyle.Fill;
            txtSifre.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtSifre.Location = new System.Drawing.Point(138, 67);
            txtSifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new System.Drawing.Size(500, 23);
            txtSifre.TabIndex = 3;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.Dock = System.Windows.Forms.DockStyle.Fill;
            lblAdSoyad.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblAdSoyad.Location = new System.Drawing.Point(12, 116);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new System.Drawing.Size(120, 53);
            lblAdSoyad.TabIndex = 4;
            lblAdSoyad.Text = "Ad Soyad:";
            lblAdSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Dock = System.Windows.Forms.DockStyle.Fill;
            txtAdSoyad.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtAdSoyad.Location = new System.Drawing.Point(138, 120);
            txtAdSoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new System.Drawing.Size(500, 23);
            txtAdSoyad.TabIndex = 5;
            // 
            // lblRol
            // 
            lblRol.Dock = System.Windows.Forms.DockStyle.Fill;
            lblRol.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblRol.Location = new System.Drawing.Point(12, 169);
            lblRol.Name = "lblRol";
            lblRol.Size = new System.Drawing.Size(120, 53);
            lblRol.TabIndex = 6;
            lblRol.Text = "Rol:";
            lblRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbRol
            // 
            cmbRol.Dock = System.Windows.Forms.DockStyle.Fill;
            cmbRol.Font = new System.Drawing.Font("Segoe UI", 9F);
            cmbRol.Location = new System.Drawing.Point(138, 173);
            cmbRol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new System.Drawing.Size(500, 23);
            cmbRol.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblEmail.Location = new System.Drawing.Point(12, 222);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(120, 53);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtEmail.Location = new System.Drawing.Point(138, 226);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(500, 23);
            txtEmail.TabIndex = 9;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Controls.Add(btnKaydet);
            buttonsPanel.Controls.Add(btnIptal);
            buttonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonsPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            buttonsPanel.Location = new System.Drawing.Point(340, 530);
            buttonsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            buttonsPanel.Size = new System.Drawing.Size(650, 85);
            buttonsPanel.TabIndex = 2;
            buttonsPanel.WrapContents = false;
            // 
            // btnKaydet
            // 
            btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnKaydet.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnKaydet.ForeColor = System.Drawing.Color.White;
            btnKaydet.Location = new System.Drawing.Point(499, 18);
            btnKaydet.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new System.Drawing.Size(126, 43);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            // 
            // btnIptal
            // 
            btnIptal.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnIptal.BackColor = System.Drawing.Color.LightGray;
            btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnIptal.ForeColor = System.Drawing.Color.Black;
            btnIptal.Location = new System.Drawing.Point(359, 18);
            btnIptal.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new System.Drawing.Size(126, 43);
            btnIptal.TabIndex = 1;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            // 
            // frmProfilDuzenle
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1029, 659);
            Controls.Add(mainPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmProfilDuzenle";
            Text = "Profil Düzenle";
            mainPanel.ResumeLayout(false);
            tableLayout.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfil).EndInit();
            rightLayout.ResumeLayout(false);
            rightLayout.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.PictureBox pictureBoxProfil;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.TableLayoutPanel rightLayout;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.FlowLayoutPanel buttonsPanel;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblEmail;
    }
}