using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AkilliRandevuYonetimiS
{
    public partial class frmPersonel : Form
    {
        private DataTable dtPersonel;
        private int? selectedPersonelId = null;

        public frmPersonel()
        {
            InitializeComponent();
            SetupControls();
            LoadPersonelList();
        }

        private void SetupControls()
        {
            // Styling
            this.FormBorderStyle = FormBorderStyle.None;

            txtAdSoyad.Font = new Font("Segoe UI", 9F);
            txtUnvan.Font = new Font("Segoe UI", 9F);
            txtTelefon.Font = new Font("Segoe UI", 9F);

            btnEkle.Click += BtnEkle_Click;
            btnGuncelle.Click += BtnGuncelle_Click;
            btnSil.Click += BtnSil_Click;
            btnTemizle.Click += BtnTemizle_Click;

            dgvPersonel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersonel.MultiSelect = false;
            dgvPersonel.ReadOnly = true;
            dgvPersonel.AllowUserToAddRows = false;
            dgvPersonel.AllowUserToDeleteRows = false;
            dgvPersonel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersonel.CellClick += DgvPersonel_CellClick;
        }

        private void LoadPersonelList()
        {
            try
            {
                dtPersonel = new DataTable();
                using var conn = VeritabaniBaglantisi.Baglan();
                conn.Open();
                // Try to select common columns; if Unvan/Telefon don't exist, query will fail
                string sorgu = "SELECT PersonelID, AdSoyad, COALESCE(Unvan, '') AS Unvan, COALESCE(Telefon, '') AS Telefon FROM Personel ORDER BY AdSoyad";
                using var da = new MySqlDataAdapter(sorgu, conn);
                da.Fill(dtPersonel);

                dgvPersonel.DataSource = dtPersonel;
                dgvPersonel.Columns["PersonelID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel listesi yüklenirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvPersonel.Rows.Count)
            {
                var row = dgvPersonel.Rows[e.RowIndex];
                if (row != null)
                {
                    selectedPersonelId = row.Cells["PersonelID"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["PersonelID"].Value) : (int?)null;
                    txtAdSoyad.Text = row.Cells["AdSoyad"].Value?.ToString() ?? string.Empty;
                    txtUnvan.Text = row.Cells["Unvan"].Value?.ToString() ?? string.Empty;
                    txtTelefon.Text = row.Cells["Telefon"].Value?.ToString() ?? string.Empty;
                }
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            selectedPersonelId = null;
            txtAdSoyad.Text = string.Empty;
            txtUnvan.Text = string.Empty;
            txtTelefon.Text = string.Empty;
            dgvPersonel.ClearSelection();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var adSoyad = txtAdSoyad.Text.Trim();
                var unvan = txtUnvan.Text.Trim();
                var telefon = txtTelefon.Text.Trim();

                if (string.IsNullOrWhiteSpace(adSoyad))
                {
                    MessageBox.Show("Ad Soyad boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var conn = VeritabaniBaglantisi.Baglan();
                conn.Open();
                string sorgu = "INSERT INTO Personel (AdSoyad, Unvan, Telefon) VALUES (@adSoyad, @unvan, @telefon)";
                using var cmd = new MySqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@adSoyad", adSoyad);
                cmd.Parameters.AddWithValue("@unvan", unvan);
                cmd.Parameters.AddWithValue("@telefon", telefon);
                cmd.ExecuteNonQuery();

                LoadPersonelList();
                ClearForm();
                MessageBox.Show("Personel eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel eklenirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedPersonelId == null)
                {
                    MessageBox.Show("Lütfen listeden bir personel seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var adSoyad = txtAdSoyad.Text.Trim();
                var unvan = txtUnvan.Text.Trim();
                var telefon = txtTelefon.Text.Trim();

                if (string.IsNullOrWhiteSpace(adSoyad))
                {
                    MessageBox.Show("Ad Soyad boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var conn = VeritabaniBaglantisi.Baglan();
                conn.Open();
                string sorgu = "UPDATE Personel SET AdSoyad=@adSoyad, Unvan=@unvan, Telefon=@telefon WHERE PersonelID=@id";
                using var cmd = new MySqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@adSoyad", adSoyad);
                cmd.Parameters.AddWithValue("@unvan", unvan);
                cmd.Parameters.AddWithValue("@telefon", telefon);
                cmd.Parameters.AddWithValue("@id", selectedPersonelId.Value);
                cmd.ExecuteNonQuery();

                LoadPersonelList();
                ClearForm();
                MessageBox.Show("Personel güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel güncellenirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedPersonelId == null)
                {
                    MessageBox.Show("Lütfen listeden bir personel seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var dr = MessageBox.Show("Seçili personeli silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr != DialogResult.Yes) return;

                using var conn = VeritabaniBaglantisi.Baglan();
                conn.Open();
                string sorgu = "DELETE FROM Personel WHERE PersonelID=@id";
                using var cmd = new MySqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@id", selectedPersonelId.Value);
                cmd.ExecuteNonQuery();

                LoadPersonelList();
                ClearForm();
                MessageBox.Show("Personel silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel silinirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
