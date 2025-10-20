using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace AkilliRandevuYonetimiS
{
    public partial class frmYeniMusteri : Form
    {
        // Bu property, form kapandıktan sonra frmYeniRandevu'nun yeni ID'yi almasını sağlar.
        public int? YeniMusteriID { get; private set; } = null;

        public frmYeniMusteri()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
           
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) || string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection baglanti = VeritabaniBaglantisi.Baglan();
            try
            {
                baglanti.Open();
                // Önce INSERT yapıyoruz, sonra o kaydın ID'sini alıyoruz.
                string sorgu = "INSERT INTO Musteriler (Ad, Soyad, Telefon) VALUES (@ad, @soyad, @telefon); SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);

                // ExecuteScalar, sorgudan dönen ilk satırın ilk sütununu alır. Bizim durumumuzda bu, yeni ID'dir.
                object sonuc = cmd.ExecuteScalar();
                if (sonuc != null)
                {
                    this.YeniMusteriID = Convert.ToInt32(sonuc);
                    MessageBox.Show("Müşteri başarıyla eklendi.", "Bilgi");
                    this.DialogResult = DialogResult.OK; // Formun başarıyla kapandığını belirtir.
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri eklenirken hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

        }
    }
}