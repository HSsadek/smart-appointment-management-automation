namespace AkilliRandevuYonetimiS
{
    partial class frmProfilDuzenle
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelMain = new System.Windows.Forms.Panel();
            panelCard = new System.Windows.Forms.Panel();
            panelAvatarBorder = new System.Windows.Forms.Panel();
            pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            btnUploadAvatar = new DevExpress.XtraEditors.SimpleButton();
            labelTitle = new DevExpress.XtraEditors.LabelControl();
            lblStatus = new DevExpress.XtraEditors.LabelControl();
            lblName = new DevExpress.XtraEditors.LabelControl();
            lblUsername = new DevExpress.XtraEditors.LabelControl();
            lblEmail = new DevExpress.XtraEditors.LabelControl();
            lblRole = new DevExpress.XtraEditors.LabelControl();
            txtFirstName = new DevExpress.XtraEditors.TextEdit();
            txtLastName = new DevExpress.XtraEditors.TextEdit();
            txtUsername = new DevExpress.XtraEditors.TextEdit();
            txtEmail = new DevExpress.XtraEditors.TextEdit();
            txtRole = new DevExpress.XtraEditors.TextEdit();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            panelMain.SuspendLayout();
            panelCard.SuspendLayout();
            panelAvatarBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFirstName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtLastName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtRole.Properties).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            panelMain.Controls.Add(panelCard);
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(520, 360);
            panelMain.TabIndex = 0;
            // 
            // panelCard
            // 
            panelCard.BackColor = System.Drawing.Color.White;
            panelCard.Controls.Add(panelAvatarBorder);
            panelCard.Controls.Add(btnUploadAvatar);
            panelCard.Controls.Add(labelTitle);
            panelCard.Controls.Add(lblStatus);
            panelCard.Controls.Add(lblName);
            panelCard.Controls.Add(lblUsername);
            panelCard.Controls.Add(lblEmail);
            panelCard.Controls.Add(lblRole);
            panelCard.Controls.Add(txtFirstName);
            panelCard.Controls.Add(txtLastName);
            panelCard.Controls.Add(txtUsername);
            panelCard.Controls.Add(txtEmail);
            panelCard.Controls.Add(txtRole);
            panelCard.Controls.Add(btnSave);
            panelCard.Location = new System.Drawing.Point(0, 2);
            panelCard.Name = "panelCard";
            panelCard.Padding = new System.Windows.Forms.Padding(20);
            panelCard.Size = new System.Drawing.Size(521, 360);
            panelCard.TabIndex = 1;
            panelCard.Paint += panelCard_Paint;
            // 
            // panelAvatarBorder
            // 
            panelAvatarBorder.Controls.Add(pictureBoxAvatar);
            panelAvatarBorder.Location = new System.Drawing.Point(24, 20);
            panelAvatarBorder.Name = "panelAvatarBorder";
            panelAvatarBorder.Size = new System.Drawing.Size(104, 104);
            panelAvatarBorder.TabIndex = 0;
            panelAvatarBorder.Paint += panelAvatarBorder_Paint;
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.Location = new System.Drawing.Point(4, 3);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new System.Drawing.Size(96, 96);
            pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxAvatar.TabIndex = 0;
            pictureBoxAvatar.TabStop = false;
            // 
            // btnUploadAvatar
            // 
            btnUploadAvatar.Appearance.BackColor = System.Drawing.Color.FromArgb(240, 240, 245);
            btnUploadAvatar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnUploadAvatar.Appearance.Options.UseBackColor = true;
            btnUploadAvatar.Appearance.Options.UseFont = true;
            btnUploadAvatar.Location = new System.Drawing.Point(28, 126);
            btnUploadAvatar.LookAndFeel.UseDefaultLookAndFeel = false;
            btnUploadAvatar.Name = "btnUploadAvatar";
            btnUploadAvatar.Size = new System.Drawing.Size(96, 28);
            btnUploadAvatar.TabIndex = 1;
            btnUploadAvatar.Text = "Avatar Yükle";
            btnUploadAvatar.Click += btnUploadAvatar_Click;
            // 
            // labelTitle
            // 
            labelTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            labelTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(34, 34, 34);
            labelTitle.Appearance.Options.UseFont = true;
            labelTitle.Appearance.Options.UseForeColor = true;
            labelTitle.Location = new System.Drawing.Point(144, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(79, 30);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Profilim";
            // 
            // lblStatus
            // 
            lblStatus.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblStatus.Appearance.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            lblStatus.Appearance.Options.UseFont = true;
            lblStatus.Appearance.Options.UseForeColor = true;
            lblStatus.Location = new System.Drawing.Point(144, 52);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(0, 15);
            lblStatus.TabIndex = 9;
            // 
            // lblName
            // 
            lblName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblName.Appearance.Options.UseFont = true;
            lblName.Location = new System.Drawing.Point(144, 76);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(74, 15);
            lblName.TabIndex = 10;
            lblName.Text = "İsim / Soyisim";
            // 
            // lblUsername
            // 
            lblUsername.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblUsername.Appearance.Options.UseFont = true;
            lblUsername.Location = new System.Drawing.Point(144, 136);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(66, 15);
            lblUsername.TabIndex = 11;
            lblUsername.Text = "Kullanıcı Adı";
            // 
            // lblEmail
            // 
            lblEmail.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblEmail.Appearance.Options.UseFont = true;
            lblEmail.Location = new System.Drawing.Point(144, 196);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(40, 15);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "E-posta";
            // 
            // lblRole
            // 
            lblRole.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblRole.Appearance.Options.UseFont = true;
            lblRole.Location = new System.Drawing.Point(144, 256);
            lblRole.Name = "lblRole";
            lblRole.Size = new System.Drawing.Size(17, 15);
            lblRole.TabIndex = 13;
            lblRole.Text = "Rol";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new System.Drawing.Point(144, 96);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Properties.NullValuePrompt = "Ad";
            txtFirstName.Size = new System.Drawing.Size(150, 20);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new System.Drawing.Point(306, 96);
            txtLastName.Name = "txtLastName";
            txtLastName.Properties.NullValuePrompt = "Soyad";
            txtLastName.Size = new System.Drawing.Size(120, 20);
            txtLastName.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(144, 156);
            txtUsername.Name = "txtUsername";
            txtUsername.Properties.NullValuePrompt = "Kullanıcı adı";
            txtUsername.Properties.ReadOnly = true;
            txtUsername.Size = new System.Drawing.Size(282, 20);
            txtUsername.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(144, 216);
            txtEmail.Name = "txtEmail";
            txtEmail.Properties.NullValuePrompt = "E-posta";
            txtEmail.Size = new System.Drawing.Size(282, 20);
            txtEmail.TabIndex = 6;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtRole
            // 
            txtRole.Location = new System.Drawing.Point(144, 276);
            txtRole.Name = "txtRole";
            txtRole.Properties.NullValuePrompt = "Rol";
            txtRole.Properties.ReadOnly = true;
            txtRole.Size = new System.Drawing.Size(282, 20);
            txtRole.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnSave.Appearance.ForeColor = System.Drawing.Color.White;
            btnSave.Appearance.Options.UseBackColor = true;
            btnSave.Appearance.Options.UseFont = true;
            btnSave.Appearance.Options.UseForeColor = true;
            btnSave.Location = new System.Drawing.Point(144, 316);
            btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(282, 34);
            btnSave.TabIndex = 8;
            btnSave.Text = "Kaydet";
            btnSave.Click += btnSave_Click;
            // 
            // frmProfilDuzenle
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(520, 360);
            Controls.Add(panelMain);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox = false;
            Name = "frmProfilDuzenle";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Profilimi Düzenle";
            Load += frmProfilDuzenle_Load;
            panelMain.ResumeLayout(false);
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            panelAvatarBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFirstName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtLastName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtRole.Properties).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Panel panelAvatarBorder;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private DevExpress.XtraEditors.SimpleButton btnUploadAvatar;
        private DevExpress.XtraEditors.LabelControl labelTitle;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.LabelControl lblUsername;
        private DevExpress.XtraEditors.LabelControl lblEmail;
        private DevExpress.XtraEditors.LabelControl lblRole;
        private DevExpress.XtraEditors.TextEdit txtFirstName;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtRole;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}