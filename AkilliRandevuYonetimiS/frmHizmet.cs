using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AkilliRandevuYonetimiS
{
    public partial class frmHizmet : Form
    {
        private DataTable dtHizmet;
        private int? selectedHizmetId = null;

        public frmHizmet()
        {
            InitializeComponent();
            SetupControls();
            LoadHizmetList();
        }

        private void SetupControls()
        {
            this.FormBorderStyle = FormBorderStyle.None;

            txtHizmetAdi.Font = new Font("Segoe UI", 9F);
            txtAciklama.Font = new Font("Segoe UI", 9F);
            txtSure.Font = new Font("Segoe UI", 9F);
            txtUcret.Font = new Font("Segoe UI", 9F);

            btnEkle.Click += BtnEkle_Click;
            btnGuncelle.Click += BtnGuncelle_Click;
            btnSil.Click += BtnSil_Click;
            btnTemizle.Click += BtnTemizle_Click;

            dgvHizmet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHizmet.MultiSelect = false;
            dgvHizmet.ReadOnly = true;
            dgvHizmet.AllowUserToAddRows = false;
            dgvHizmet.AllowUserToDeleteRows = false;
            dgvHizmet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHizmet.CellClick += DgvHizmet_CellClick;
        }

        private void LoadHizmetList()
        {
            try
            {
                dtHizmet = new DataTable();
                using var conn = VeritabaniBaglantisi.Baglan();
                conn.Open();
                string sorgu = "SELECT HizmetID, HizmetAdi, COALESCE(Aciklama, '') AS Aciklama, COALESCE(Sure, 0) AS Sure, COALESCE(Ucret, 0) AS Ucret FROM Hizmetler ORDER BY HizmetAdi";
                using var da = new MySqlDataAdapter(sorgu, conn);
                da.Fill(dtHizmet);

                dgvHizmet.DataSource = dtHizmet;
                if (dgvHizmet.Columns.Contains("HizmetID")) dgvHizmet.Columns["HizmetID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hizmet listesi yüklenirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvHizmet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvHizmet.Rows.Count)
            {
                var row = dgvHizmet.Rows[e.RowIndex];
                if (row != null)
                {
                    selectedHizmetId = row.Cells["HizmetID"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["HizmetID"].Value) : (int?)null;
                    txtHizmetAdi.Text = row.Cells["HizmetAdi"].Value?.ToString() ?? string.Empty;
                    txtAciklama.Text = row.Cells["Aciklama"].Value?.ToString() ?? string.Empty;
                    txtSure.Text = row.Cells["Sure"].Value?.ToString() ?? "0";
                    txtUcret.Text = row.Cells["Ucret"].Value?.ToString() ?? "0";
                }
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            selectedHizmetId = null;
            txtHizmetAdi.Text = string.Empty;
            txtAciklama.Text = string.Empty;
            txtSure.Text = string.Empty;
            txtUcret.Text = string.Empty;
            dgvHizmet.ClearSelection();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var hizmetAdi = txtHizmetAdi.Text.Trim();
                var aciklama = txtAciklama.Text.Trim();
                if (!int.TryParse(txtSure.Text.Trim(), out int sure)) sure = 0;
                if (!decimal.TryParse(txtUcret.Text.Trim(), out decimal ucret)) ucret = 0;

                if (string.IsNullOrWhiteSpace(hizmetAdi))
                {
                    MessageBox.Show("Hizmet adı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var conn = VeritabaniBaglantisi.Baglan();
                conn.Open();
                string sorgu = "INSERT INTO Hizmetler (HizmetAdi, Aciklama, Sure, Ucret) VALUES (@adi, @aciklama, @sure, @ucret)";
                using var cmd = new MySqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@adi", hizmetAdi);
                cmd.Parameters.AddWithValue("@aciklama", aciklama);
                cmd.Parameters.AddWithValue("@sure", sure);
                cmd.Parameters.AddWithValue("@ucret", ucret);
                cmd.ExecuteNonQuery();

                LoadHizmetList();
                ClearForm();
                MessageBox.Show("Hizmet eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hizmet eklenirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedHizmetId == null)
                {
                    MessageBox.Show("Lütfen listeden bir hizmet seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var hizmetAdi = txtHizmetAdi.Text.Trim();
                var aciklama = txtAciklama.Text.Trim();
                if (!int.TryParse(txtSure.Text.Trim(), out int sure)) sure = 0;
                if (!decimal.TryParse(txtUcret.Text.Trim(), out decimal ucret)) ucret = 0;

                if (string.IsNullOrWhiteSpace(hizmetAdi))
                {
                    MessageBox.Show("Hizmet adı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var conn = VeritabaniBaglantisi.Baglan();
                conn.Open();
                string sorgu = "UPDATE Hizmetler SET HizmetAdi=@adi, Aciklama=@aciklama, Sure=@sure, Ucret=@ucret WHERE HizmetID=@id";
                using var cmd = new MySqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@adi", hizmetAdi);
                cmd.Parameters.AddWithValue("@aciklama", aciklama);
                cmd.Parameters.AddWithValue("@sure", sure);
                cmd.Parameters.AddWithValue("@ucret", ucret);
                cmd.Parameters.AddWithValue("@id", selectedHizmetId.Value);
                cmd.ExecuteNonQuery();

                LoadHizmetList();
                ClearForm();
                MessageBox.Show("Hizmet güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hizmet güncellenirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedHizmetId == null)
                {
                    MessageBox.Show("Lütfen listeden bir hizmet seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var dr = MessageBox.Show("Seçili hizmeti silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr != DialogResult.Yes) return;

                using var conn = VeritabaniBaglantisi.Baglan();
                conn.Open();
                string sorgu = "DELETE FROM Hizmetler WHERE HizmetID=@id";
                using var cmd = new MySqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@id", selectedHizmetId.Value);
                cmd.ExecuteNonQuery();

                LoadHizmetList();
                ClearForm();
                MessageBox.Show("Hizmet silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hizmet silinirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
