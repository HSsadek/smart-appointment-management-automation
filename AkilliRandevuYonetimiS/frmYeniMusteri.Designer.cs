namespace AkilliRandevuYonetimiS
{
    partial class frmYeniMusteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYeniMusteri));
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            txtAd = new DevExpress.XtraEditors.TextEdit();
            txtTelefon = new DevExpress.XtraEditors.TextEdit();
            txtSoyad = new DevExpress.XtraEditors.TextEdit();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)txtAd.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTelefon.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSoyad.Properties).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new System.Drawing.Point(266, 92);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(37, 26);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Adı";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new System.Drawing.Point(266, 143);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(69, 26);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "Soyadı";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new System.Drawing.Point(266, 197);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(76, 26);
            labelControl3.TabIndex = 2;
            labelControl3.Text = "Telefon";
            // 
            // txtAd
            // 
            txtAd.Location = new System.Drawing.Point(361, 94);
            txtAd.Name = "txtAd";
            txtAd.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            txtAd.Properties.Appearance.Options.UseFont = true;
            txtAd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            txtAd.Size = new System.Drawing.Size(221, 28);
            txtAd.TabIndex = 3;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new System.Drawing.Point(361, 190);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            txtTelefon.Properties.Appearance.Options.UseFont = true;
            txtTelefon.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            txtTelefon.Size = new System.Drawing.Size(221, 28);
            txtTelefon.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new System.Drawing.Point(361, 140);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            txtSoyad.Properties.Appearance.Options.UseFont = true;
            txtSoyad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            txtSoyad.Size = new System.Drawing.Size(221, 28);
            txtSoyad.TabIndex = 5;
            // 
            // btnKaydet
            // 
            btnKaydet.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            btnKaydet.Appearance.Options.UseFont = true;
            btnKaydet.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            btnKaydet.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnKaydet.ImageOptions.SvgImage");
            btnKaydet.ImageOptions.SvgImageSize = new System.Drawing.Size(50, 50);
            btnKaydet.Location = new System.Drawing.Point(325, 278);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new System.Drawing.Size(165, 51);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click_1;
            // 
            // frmYeniMusteri
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnKaydet);
            Controls.Add(txtSoyad);
            Controls.Add(txtTelefon);
            Controls.Add(txtAd);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Name = "frmYeniMusteri";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)txtAd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTelefon.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSoyad.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.TextEdit txtTelefon;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
    }
}