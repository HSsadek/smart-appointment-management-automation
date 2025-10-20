namespace AkilliRandevuYonetimiS
{
    partial class frmHizmet
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

        private void InitializeComponent()
        {
            mainPanel = new System.Windows.Forms.Panel();
            tableLayout = new System.Windows.Forms.TableLayoutPanel();
            dgvHizmet = new System.Windows.Forms.DataGridView();
            leftPanel = new System.Windows.Forms.Panel();
            pictureBox = new System.Windows.Forms.PictureBox();
            rightLayout = new System.Windows.Forms.TableLayoutPanel();
            lblHizmetAdi = new System.Windows.Forms.Label();
            txtHizmetAdi = new System.Windows.Forms.TextBox();
            lblAciklama = new System.Windows.Forms.Label();
            txtAciklama = new System.Windows.Forms.TextBox();
            lblSure = new System.Windows.Forms.Label();
            txtSure = new System.Windows.Forms.TextBox();
            lblUcret = new System.Windows.Forms.Label();
            txtUcret = new System.Windows.Forms.TextBox();
            buttonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            btnEkle = new System.Windows.Forms.Button();
            btnGuncelle = new System.Windows.Forms.Button();
            btnSil = new System.Windows.Forms.Button();
            btnTemizle = new System.Windows.Forms.Button();
            mainPanel.SuspendLayout();
            tableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHizmet).BeginInit();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            rightLayout.SuspendLayout();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.BackColor = System.Drawing.Color.White;
            mainPanel.Controls.Add(tableLayout);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Font = new System.Drawing.Font("Segoe UI", 11F);
            mainPanel.Location = new System.Drawing.Point(0, 0);
            mainPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new System.Windows.Forms.Padding(18, 20, 18, 20);
            mainPanel.Size = new System.Drawing.Size(1143, 887);
            mainPanel.TabIndex = 0;
            // 
            // tableLayout
            // 
            tableLayout.ColumnCount = 2;
            tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66F));
            tableLayout.Controls.Add(dgvHizmet, 0, 0);
            tableLayout.Controls.Add(leftPanel, 0, 1);
            tableLayout.Controls.Add(rightLayout, 1, 1);
            tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayout.Location = new System.Drawing.Point(18, 20);
            tableLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 2;
            tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 456F));
            tableLayout.Size = new System.Drawing.Size(1107, 847);
            tableLayout.TabIndex = 0;
            // 
            // dgvHizmet
            // 
            dgvHizmet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvHizmet.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dgvHizmet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tableLayout.SetColumnSpan(dgvHizmet, 2);
            dgvHizmet.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvHizmet.Font = new System.Drawing.Font("Segoe UI", 10F);
            dgvHizmet.Location = new System.Drawing.Point(3, 4);
            dgvHizmet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvHizmet.Name = "dgvHizmet";
            dgvHizmet.RowHeadersVisible = false;
            dgvHizmet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvHizmet.Size = new System.Drawing.Size(1101, 383);
            dgvHizmet.TabIndex = 0;
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(pictureBox);
            leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            leftPanel.Location = new System.Drawing.Point(3, 395);
            leftPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            leftPanel.Name = "leftPanel";
            leftPanel.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            leftPanel.Size = new System.Drawing.Size(370, 448);
            leftPanel.TabIndex = 1;
            // 
            // pictureBox
            // 
            pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox.Location = new System.Drawing.Point(9, 10);
            pictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new System.Drawing.Size(352, 428);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // rightLayout
            // 
            rightLayout.ColumnCount = 2;
            rightLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            rightLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            rightLayout.Controls.Add(lblHizmetAdi, 0, 0);
            rightLayout.Controls.Add(txtHizmetAdi, 1, 0);
            rightLayout.Controls.Add(lblAciklama, 0, 1);
            rightLayout.Controls.Add(txtAciklama, 1, 1);
            rightLayout.Controls.Add(lblSure, 0, 2);
            rightLayout.Controls.Add(txtSure, 1, 2);
            rightLayout.Controls.Add(lblUcret, 0, 3);
            rightLayout.Controls.Add(txtUcret, 1, 3);
            rightLayout.Controls.Add(buttonsPanel, 1, 4);
            rightLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            rightLayout.Location = new System.Drawing.Point(379, 395);
            rightLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            rightLayout.Name = "rightLayout";
            rightLayout.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            rightLayout.RowCount = 5;
            rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            rightLayout.Size = new System.Drawing.Size(725, 448);
            rightLayout.TabIndex = 2;
            // 
            // lblHizmetAdi
            // 
            lblHizmetAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            lblHizmetAdi.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblHizmetAdi.Location = new System.Drawing.Point(12, 10);
            lblHizmetAdi.Name = "lblHizmetAdi";
            lblHizmetAdi.Size = new System.Drawing.Size(154, 45);
            lblHizmetAdi.TabIndex = 0;
            lblHizmetAdi.Text = "Hizmet Adı:";
            lblHizmetAdi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHizmetAdi
            // 
            txtHizmetAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            txtHizmetAdi.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtHizmetAdi.Location = new System.Drawing.Point(172, 14);
            txtHizmetAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtHizmetAdi.Name = "txtHizmetAdi";
            txtHizmetAdi.Size = new System.Drawing.Size(541, 27);
            txtHizmetAdi.TabIndex = 1;
            // 
            // lblAciklama
            // 
            lblAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            lblAciklama.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblAciklama.Location = new System.Drawing.Point(12, 55);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new System.Drawing.Size(154, 113);
            lblAciklama.TabIndex = 2;
            lblAciklama.Text = "Açıklama:";
            lblAciklama.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAciklama
            // 
            txtAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            txtAciklama.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtAciklama.Location = new System.Drawing.Point(172, 59);
            txtAciklama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new System.Drawing.Size(541, 105);
            txtAciklama.TabIndex = 3;
            // 
            // lblSure
            // 
            lblSure.Dock = System.Windows.Forms.DockStyle.Fill;
            lblSure.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblSure.Location = new System.Drawing.Point(12, 168);
            lblSure.Name = "lblSure";
            lblSure.Size = new System.Drawing.Size(154, 71);
            lblSure.TabIndex = 4;
            lblSure.Text = "Süre (dk):";
            lblSure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSure
            // 
            txtSure.Dock = System.Windows.Forms.DockStyle.Fill;
            txtSure.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtSure.Location = new System.Drawing.Point(172, 172);
            txtSure.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSure.Name = "txtSure";
            txtSure.Size = new System.Drawing.Size(541, 27);
            txtSure.TabIndex = 5;
            // 
            // lblUcret
            // 
            lblUcret.Dock = System.Windows.Forms.DockStyle.Fill;
            lblUcret.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblUcret.Location = new System.Drawing.Point(12, 239);
            lblUcret.Name = "lblUcret";
            lblUcret.Size = new System.Drawing.Size(154, 71);
            lblUcret.TabIndex = 6;
            lblUcret.Text = "Ücret:";
            lblUcret.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUcret
            // 
            txtUcret.Dock = System.Windows.Forms.DockStyle.Fill;
            txtUcret.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtUcret.Location = new System.Drawing.Point(172, 243);
            txtUcret.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtUcret.Name = "txtUcret";
            txtUcret.Size = new System.Drawing.Size(541, 27);
            txtUcret.TabIndex = 7;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Controls.Add(btnEkle);
            buttonsPanel.Controls.Add(btnGuncelle);
            buttonsPanel.Controls.Add(btnSil);
            buttonsPanel.Controls.Add(btnTemizle);
            buttonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            buttonsPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            buttonsPanel.Location = new System.Drawing.Point(172, 314);
            buttonsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonsPanel.MinimumSize = new System.Drawing.Size(0, 101);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            buttonsPanel.Size = new System.Drawing.Size(541, 119);
            buttonsPanel.TabIndex = 8;
            buttonsPanel.WrapContents = false;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEkle.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnEkle.ForeColor = System.Drawing.Color.White;
            btnEkle.Location = new System.Drawing.Point(354, 20);
            btnEkle.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new System.Drawing.Size(160, 56);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = System.Drawing.Color.LightGray;
            btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnGuncelle.ForeColor = System.Drawing.Color.Black;
            btnGuncelle.Location = new System.Drawing.Point(176, 20);
            btnGuncelle.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new System.Drawing.Size(160, 56);
            btnGuncelle.TabIndex = 1;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            btnSil.BackColor = System.Drawing.Color.FromArgb(244, 67, 54);
            btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSil.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnSil.ForeColor = System.Drawing.Color.White;
            btnSil.Location = new System.Drawing.Point(-2, 20);
            btnSil.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            btnSil.Name = "btnSil";
            btnSil.Size = new System.Drawing.Size(160, 56);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = System.Drawing.Color.LightGray;
            btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTemizle.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnTemizle.ForeColor = System.Drawing.Color.Black;
            btnTemizle.Location = new System.Drawing.Point(-180, 20);
            btnTemizle.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new System.Drawing.Size(160, 56);
            btnTemizle.TabIndex = 3;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            // 
            // frmHizmet
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1143, 887);
            Controls.Add(mainPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmHizmet";
            Text = "Hizmet Yönetimi";
            mainPanel.ResumeLayout(false);
            tableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHizmet).EndInit();
            leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            rightLayout.ResumeLayout(false);
            rightLayout.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.DataGridView dgvHizmet;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TableLayoutPanel rightLayout;
        private System.Windows.Forms.Label lblHizmetAdi;
        private System.Windows.Forms.TextBox txtHizmetAdi;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.FlowLayoutPanel buttonsPanel;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
    }
}
