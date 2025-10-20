namespace AkilliRandevuYonetimiS
{
    partial class frmPersonel
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
            dgvPersonel = new System.Windows.Forms.DataGridView();
            leftPanel = new System.Windows.Forms.Panel();
            pictureBoxProfil = new System.Windows.Forms.PictureBox();
            rightLayout = new System.Windows.Forms.TableLayoutPanel();
            lblAdSoyad = new System.Windows.Forms.Label();
            txtAdSoyad = new System.Windows.Forms.TextBox();
            lblUnvan = new System.Windows.Forms.Label();
            txtUnvan = new System.Windows.Forms.TextBox();
            lblTelefon = new System.Windows.Forms.Label();
            txtTelefon = new System.Windows.Forms.TextBox();
            buttonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            btnEkle = new System.Windows.Forms.Button();
            btnGuncelle = new System.Windows.Forms.Button();
            btnSil = new System.Windows.Forms.Button();
            btnTemizle = new System.Windows.Forms.Button();
            mainPanel.SuspendLayout();
            tableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).BeginInit();
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
            mainPanel.Font = new System.Drawing.Font("Segoe UI", 10F);
            mainPanel.Location = new System.Drawing.Point(0, 0);
            mainPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new System.Windows.Forms.Padding(12);
            mainPanel.Size = new System.Drawing.Size(1176, 835);
            mainPanel.TabIndex = 0;
            // 
            // tableLayout
            // 
            tableLayout.ColumnCount = 2;
            tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tableLayout.Controls.Add(dgvPersonel, 0, 0);
            tableLayout.Controls.Add(leftPanel, 0, 1);
            tableLayout.Controls.Add(rightLayout, 1, 1);
            tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayout.Location = new System.Drawing.Point(12, 12);
            tableLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 2;
            tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayout.Size = new System.Drawing.Size(1152, 811);
            tableLayout.TabIndex = 0;
            // 
            // dgvPersonel
            // 
            dgvPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersonel.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dgvPersonel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tableLayout.SetColumnSpan(dgvPersonel, 2);
            dgvPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvPersonel.Location = new System.Drawing.Point(3, 4);
            dgvPersonel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvPersonel.Name = "dgvPersonel";
            dgvPersonel.RowHeadersVisible = false;
            dgvPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvPersonel.Size = new System.Drawing.Size(1146, 478);
            dgvPersonel.TabIndex = 0;
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(pictureBoxProfil);
            leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            leftPanel.Location = new System.Drawing.Point(3, 490);
            leftPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            leftPanel.Name = "leftPanel";
            leftPanel.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            leftPanel.Size = new System.Drawing.Size(454, 317);
            leftPanel.TabIndex = 1;
            // 
            // pictureBoxProfil
            // 
            pictureBoxProfil.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBoxProfil.Location = new System.Drawing.Point(9, 10);
            pictureBoxProfil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBoxProfil.Name = "pictureBoxProfil";
            pictureBoxProfil.Size = new System.Drawing.Size(436, 297);
            pictureBoxProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxProfil.TabIndex = 0;
            pictureBoxProfil.TabStop = false;
            // 
            // rightLayout
            // 
            rightLayout.ColumnCount = 2;
            rightLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            rightLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            rightLayout.Controls.Add(lblAdSoyad, 0, 0);
            rightLayout.Controls.Add(txtAdSoyad, 1, 0);
            rightLayout.Controls.Add(lblUnvan, 0, 1);
            rightLayout.Controls.Add(txtUnvan, 1, 1);
            rightLayout.Controls.Add(lblTelefon, 0, 2);
            rightLayout.Controls.Add(txtTelefon, 1, 2);
            rightLayout.Controls.Add(buttonsPanel, 1, 3);
            rightLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            rightLayout.Location = new System.Drawing.Point(463, 490);
            rightLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            rightLayout.Name = "rightLayout";
            rightLayout.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            rightLayout.RowCount = 5;
            rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            rightLayout.Size = new System.Drawing.Size(686, 317);
            rightLayout.TabIndex = 2;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.Dock = System.Windows.Forms.DockStyle.Fill;
            lblAdSoyad.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblAdSoyad.Location = new System.Drawing.Point(12, 10);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new System.Drawing.Size(108, 56);
            lblAdSoyad.TabIndex = 0;
            lblAdSoyad.Text = "Ad Soyad:";
            lblAdSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Dock = System.Windows.Forms.DockStyle.Fill;
            txtAdSoyad.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtAdSoyad.Location = new System.Drawing.Point(126, 14);
            txtAdSoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new System.Drawing.Size(548, 25);
            txtAdSoyad.TabIndex = 1;
            // 
            // lblUnvan
            // 
            lblUnvan.Dock = System.Windows.Forms.DockStyle.Fill;
            lblUnvan.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblUnvan.Location = new System.Drawing.Point(12, 66);
            lblUnvan.Name = "lblUnvan";
            lblUnvan.Size = new System.Drawing.Size(108, 56);
            lblUnvan.TabIndex = 2;
            lblUnvan.Text = "Unvan:";
            lblUnvan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUnvan
            // 
            txtUnvan.Dock = System.Windows.Forms.DockStyle.Fill;
            txtUnvan.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtUnvan.Location = new System.Drawing.Point(126, 70);
            txtUnvan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtUnvan.Name = "txtUnvan";
            txtUnvan.Size = new System.Drawing.Size(548, 25);
            txtUnvan.TabIndex = 3;
            // 
            // lblTelefon
            // 
            lblTelefon.Dock = System.Windows.Forms.DockStyle.Fill;
            lblTelefon.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblTelefon.Location = new System.Drawing.Point(12, 122);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new System.Drawing.Size(108, 56);
            lblTelefon.TabIndex = 4;
            lblTelefon.Text = "Telefon:";
            lblTelefon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTelefon
            // 
            txtTelefon.Dock = System.Windows.Forms.DockStyle.Fill;
            txtTelefon.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtTelefon.Location = new System.Drawing.Point(126, 126);
            txtTelefon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new System.Drawing.Size(548, 25);
            txtTelefon.TabIndex = 5;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Controls.Add(btnEkle);
            buttonsPanel.Controls.Add(btnGuncelle);
            buttonsPanel.Controls.Add(btnSil);
            buttonsPanel.Controls.Add(btnTemizle);
            buttonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonsPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            buttonsPanel.Location = new System.Drawing.Point(126, 182);
            buttonsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Padding = new System.Windows.Forms.Padding(6);
            buttonsPanel.Size = new System.Drawing.Size(548, 56);
            buttonsPanel.TabIndex = 6;
            buttonsPanel.WrapContents = false;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEkle.ForeColor = System.Drawing.Color.White;
            btnEkle.Location = new System.Drawing.Point(410, 12);
            btnEkle.Margin = new System.Windows.Forms.Padding(6);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new System.Drawing.Size(120, 42);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = System.Drawing.Color.LightGray;
            btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuncelle.ForeColor = System.Drawing.Color.Black;
            btnGuncelle.Location = new System.Drawing.Point(278, 12);
            btnGuncelle.Margin = new System.Windows.Forms.Padding(6);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new System.Drawing.Size(120, 42);
            btnGuncelle.TabIndex = 1;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            btnSil.BackColor = System.Drawing.Color.FromArgb(244, 67, 54);
            btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSil.ForeColor = System.Drawing.Color.White;
            btnSil.Location = new System.Drawing.Point(146, 12);
            btnSil.Margin = new System.Windows.Forms.Padding(6);
            btnSil.Name = "btnSil";
            btnSil.Size = new System.Drawing.Size(120, 42);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = System.Drawing.Color.LightGray;
            btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTemizle.ForeColor = System.Drawing.Color.Black;
            btnTemizle.Location = new System.Drawing.Point(14, 12);
            btnTemizle.Margin = new System.Windows.Forms.Padding(6);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new System.Drawing.Size(120, 42);
            btnTemizle.TabIndex = 3;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            // 
            // frmPersonel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1176, 835);
            Controls.Add(mainPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmPersonel";
            Text = "Personel Yönetimi";
            mainPanel.ResumeLayout(false);
            tableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel rightLayout;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblUnvan;
        private System.Windows.Forms.TextBox txtUnvan;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.FlowLayoutPanel buttonsPanel;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView dgvPersonel;
    }
}
