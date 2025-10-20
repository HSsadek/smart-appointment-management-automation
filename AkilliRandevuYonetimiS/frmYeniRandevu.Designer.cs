namespace AkilliRandevuYonetimiS
{
    partial class frmYeniRandevu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYeniRandevu));
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            lookUpMusteri = new DevExpress.XtraEditors.LookUpEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            lookUpHizmet = new DevExpress.XtraEditors.LookUpEdit();
            lookUpPersonel = new DevExpress.XtraEditors.LookUpEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            dateBaslangic = new DevExpress.XtraEditors.DateEdit();
            timeBaslangic = new DevExpress.XtraEditors.TimeEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            memoNot = new DevExpress.XtraEditors.MemoEdit();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            btnIptal = new DevExpress.XtraEditors.SimpleButton();
            btnYeniMusteriEkle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)lookUpMusteri.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpHizmet.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpPersonel.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateBaslangic.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateBaslangic.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeBaslangic.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memoNot.Properties).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new System.Drawing.Point(133, 161);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(75, 24);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Müşteri:";
            // 
            // lookUpMusteri
            // 
            lookUpMusteri.Location = new System.Drawing.Point(251, 158);
            lookUpMusteri.Name = "lookUpMusteri";
            lookUpMusteri.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            lookUpMusteri.Properties.Appearance.Options.UseFont = true;
            lookUpMusteri.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            lookUpMusteri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpMusteri.Size = new System.Drawing.Size(414, 24);
            lookUpMusteri.TabIndex = 1;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new System.Drawing.Point(133, 239);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(84, 24);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "Personel:";
            // 
            // lookUpHizmet
            // 
            lookUpHizmet.Location = new System.Drawing.Point(251, 308);
            lookUpHizmet.Name = "lookUpHizmet";
            lookUpHizmet.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            lookUpHizmet.Properties.Appearance.Options.UseFont = true;
            lookUpHizmet.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            lookUpHizmet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpHizmet.Size = new System.Drawing.Size(414, 24);
            lookUpHizmet.TabIndex = 5;
            // 
            // lookUpPersonel
            // 
            lookUpPersonel.Location = new System.Drawing.Point(251, 236);
            lookUpPersonel.Name = "lookUpPersonel";
            lookUpPersonel.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            lookUpPersonel.Properties.Appearance.Options.UseFont = true;
            lookUpPersonel.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            lookUpPersonel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpPersonel.Size = new System.Drawing.Size(414, 24);
            lookUpPersonel.TabIndex = 6;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new System.Drawing.Point(133, 311);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(71, 24);
            labelControl3.TabIndex = 7;
            labelControl3.Text = "Hizmet:";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new System.Drawing.Point(133, 380);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(94, 24);
            labelControl4.TabIndex = 8;
            labelControl4.Text = "Başlangıç:";
            // 
            // dateBaslangic
            // 
            dateBaslangic.EditValue = null;
            dateBaslangic.Location = new System.Drawing.Point(251, 373);
            dateBaslangic.Name = "dateBaslangic";
            dateBaslangic.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            dateBaslangic.Properties.Appearance.Options.UseFont = true;
            dateBaslangic.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            dateBaslangic.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateBaslangic.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateBaslangic.Size = new System.Drawing.Size(190, 24);
            dateBaslangic.TabIndex = 9;
            // 
            // timeBaslangic
            // 
            timeBaslangic.EditValue = new System.DateTime(2025, 10, 14, 0, 0, 0, 0);
            timeBaslangic.Location = new System.Drawing.Point(470, 377);
            timeBaslangic.Name = "timeBaslangic";
            timeBaslangic.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            timeBaslangic.Properties.Appearance.Options.UseFont = true;
            timeBaslangic.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            timeBaslangic.Size = new System.Drawing.Size(195, 26);
            timeBaslangic.TabIndex = 10;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new System.Drawing.Point(133, 449);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(64, 24);
            labelControl5.TabIndex = 11;
            labelControl5.Text = "Notlar:";
            // 
            // memoNot
            // 
            memoNot.Location = new System.Drawing.Point(251, 448);
            memoNot.Name = "memoNot";
            memoNot.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            memoNot.Properties.Appearance.Options.UseFont = true;
            memoNot.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            memoNot.Size = new System.Drawing.Size(429, 96);
            memoNot.TabIndex = 12;
            // 
            // btnKaydet
            // 
            btnKaydet.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            btnKaydet.Appearance.ForeColor = System.Drawing.Color.FromArgb(0, 192, 0);
            btnKaydet.Appearance.Options.UseFont = true;
            btnKaydet.Appearance.Options.UseForeColor = true;
            btnKaydet.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnKaydet.AppearanceHovered.Options.UseBackColor = true;
            btnKaydet.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnKaydet.ImageOptions.SvgImage");
            btnKaydet.Location = new System.Drawing.Point(431, 604);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnKaydet.Size = new System.Drawing.Size(150, 49);
            btnKaydet.TabIndex = 13;
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            btnIptal.Appearance.ForeColor = System.Drawing.Color.Red;
            btnIptal.Appearance.Options.UseFont = true;
            btnIptal.Appearance.Options.UseForeColor = true;
            btnIptal.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            btnIptal.AppearanceHovered.BorderColor = System.Drawing.Color.Gray;
            btnIptal.AppearanceHovered.Options.UseBackColor = true;
            btnIptal.AppearanceHovered.Options.UseBorderColor = true;
            btnIptal.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnIptal.ImageOptions.SvgImage");
            btnIptal.Location = new System.Drawing.Point(167, 604);
            btnIptal.Name = "btnIptal";
            btnIptal.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnIptal.Size = new System.Drawing.Size(128, 49);
            btnIptal.TabIndex = 14;
            btnIptal.Text = "İptal";
            btnIptal.Click += btnIptal_Click;
            // 
            // btnYeniMusteriEkle
            // 
            btnYeniMusteriEkle.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            btnYeniMusteriEkle.Appearance.ForeColor = System.Drawing.Color.Black;
            btnYeniMusteriEkle.Appearance.Options.UseFont = true;
            btnYeniMusteriEkle.Appearance.Options.UseForeColor = true;
            btnYeniMusteriEkle.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnYeniMusteriEkle.ImageOptions.SvgImage");
            btnYeniMusteriEkle.Location = new System.Drawing.Point(671, 152);
            btnYeniMusteriEkle.Name = "btnYeniMusteriEkle";
            btnYeniMusteriEkle.Size = new System.Drawing.Size(117, 37);
            btnYeniMusteriEkle.TabIndex = 15;
            btnYeniMusteriEkle.Text = "Yeni Müşteri";
            btnYeniMusteriEkle.Click += btnYeniMusteriEkle_Click;
            // 
            // frmYeniRandevu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 811);
            Controls.Add(btnYeniMusteriEkle);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(memoNot);
            Controls.Add(labelControl5);
            Controls.Add(timeBaslangic);
            Controls.Add(dateBaslangic);
            Controls.Add(labelControl4);
            Controls.Add(labelControl3);
            Controls.Add(lookUpPersonel);
            Controls.Add(lookUpHizmet);
            Controls.Add(labelControl2);
            Controls.Add(lookUpMusteri);
            Controls.Add(labelControl1);
            Name = "frmYeniRandevu";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmYeniRandevu";
            Load += frmYeniRandevu_Load;
            ((System.ComponentModel.ISupportInitialize)lookUpMusteri.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpHizmet.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpPersonel.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateBaslangic.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateBaslangic.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeBaslangic.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)memoNot.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpMusteri;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lookUpHizmet;
        private DevExpress.XtraEditors.LookUpEdit lookUpPersonel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dateBaslangic;
        private DevExpress.XtraEditors.TimeEdit timeBaslangic;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.MemoEdit memoNot;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnIptal;
        private DevExpress.XtraEditors.SimpleButton btnYeniMusteriEkle;
    }
}