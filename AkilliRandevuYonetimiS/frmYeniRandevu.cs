using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AkilliRandevuYonetimiS
{
    public partial class frmYeniRandevu : Form
    {
        private Appointment appointmentToEdit;
        private SchedulerControl schedulerControl;
        private int? editingRandevuID = null;

        public frmYeniRandevu()
        {
            InitializeComponent();
        }

        public frmYeniRandevu(Appointment apt, SchedulerControl control)
        {
            InitializeComponent();
            this.appointmentToEdit = apt;
            this.schedulerControl = control;
        }

        void VeriYukle(LookUpEdit lookUp, string sorgu, string displayMember, string valueMember)
        {
            try
            {
                MySqlConnection baglanti = VeritabaniBaglantisi.Baglan();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglanti);
                da.Fill(dt);
                lookUp.Properties.DataSource = dt;
                lookUp.Properties.DisplayMember = displayMember;
                lookUp.Properties.ValueMember = valueMember;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"'{lookUp.Name}' verileri yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void frmYeniRandevu_Load(object sender, EventArgs e)
        {
            btnKaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            btnIptal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            // + butonunu da Flat yapalım
            btnYeniMusteriEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;

            VeriYukle(lookUpMusteri, "SELECT MusteriID, CONCAT(Ad, ' ', Soyad) AS AdSoyad FROM Musteriler ORDER BY Ad, Soyad", "AdSoyad", "MusteriID");
            VeriYukle(lookUpPersonel, "SELECT PersonelID, AdSoyad FROM Personel ORDER BY AdSoyad", "AdSoyad", "PersonelID");
            VeriYukle(lookUpHizmet, "SELECT HizmetID, HizmetAdi FROM Hizmetler ORDER BY HizmetAdi", "HizmetAdi", "HizmetID");

            if (appointmentToEdit != null)
            {
                this.Text = "Randevu Detayları";
                DataRowView row = appointmentToEdit.GetRow(schedulerControl.Storage) as DataRowView;
                if (row != null)
                {
                    editingRandevuID = Convert.ToInt32(row["RandevuID"]);
                    lookUpMusteri.EditValue = row["MusteriID"];
                    lookUpPersonel.EditValue = row["PersonelID"];
                    lookUpHizmet.EditValue = row["HizmetID"];
                    dateBaslangic.EditValue = row["BaslangicZamani"];
                    timeBaslangic.EditValue = row["BaslangicZamani"];
                    memoNot.Text = row["Notlar"].ToString();
                }
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lookUpMusteri.EditValue == null || lookUpPersonel.EditValue == null || lookUpHizmet.EditValue == null || dateBaslangic.EditValue == null || timeBaslangic.EditValue == null)
            {
                MessageBox.Show("Lütfen tüm zorunlu alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int musteriID = Convert.ToInt32(lookUpMusteri.EditValue);
            int personelID = Convert.ToInt32(lookUpPersonel.EditValue);
            int hizmetID = Convert.ToInt32(lookUpHizmet.EditValue);
            DateTime baslangicZamani = dateBaslangic.DateTime.Date.Add(timeBaslangic.Time.TimeOfDay);
            string notlar = memoNot.Text;

            int hizmetSuresi = 0;
            MySqlConnection baglanti = VeritabaniBaglantisi.Baglan();
            try
            {
                baglanti.Open();
                MySqlCommand sureCmd = new MySqlCommand("SELECT Sure FROM Hizmetler WHERE HizmetID = @hizmetID", baglanti);
                sureCmd.Parameters.AddWithValue("@hizmetID", hizmetID);
                object sonuc = sureCmd.ExecuteScalar();
                if (sonuc != null) hizmetSuresi = Convert.ToInt32(sonuc);
            }
            catch (Exception ex) { MessageBox.Show("Hizmet süresi alınırken hata: " + ex.Message); return; }
            finally { if (baglanti.State == ConnectionState.Open) baglanti.Close(); }
            DateTime bitisZamani = baslangicZamani.AddMinutes(hizmetSuresi);

            if (editingRandevuID == null)
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "INSERT INTO Randevular (MusteriID, PersonelID, HizmetID, BaslangicZamani, BitisZamani, Notlar, Durum) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, 'Planlandı')";
                    MySqlCommand cmd = new MySqlCommand(sorgu, baglanti);
                    cmd.Parameters.AddWithValue("@p1", musteriID);
                    cmd.Parameters.AddWithValue("@p2", personelID);
                    cmd.Parameters.AddWithValue("@p3", hizmetID);
                    cmd.Parameters.AddWithValue("@p4", baslangicZamani);
                    cmd.Parameters.AddWithValue("@p5", bitisZamani);
                    cmd.Parameters.AddWithValue("@p6", notlar);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Randevu başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex) { MessageBox.Show("Kayıt sırasında hata: " + ex.Message); }
                finally { baglanti.Close(); }
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "UPDATE Randevular SET MusteriID=@p1, PersonelID=@p2, HizmetID=@p3, BaslangicZamani=@p4, BitisZamani=@p5, Notlar=@p6 WHERE RandevuID=@randevuID";
                    MySqlCommand cmd = new MySqlCommand(sorgu, baglanti);
                    cmd.Parameters.AddWithValue("@p1", musteriID);
                    cmd.Parameters.AddWithValue("@p2", personelID);
                    cmd.Parameters.AddWithValue("@p3", hizmetID);
                    cmd.Parameters.AddWithValue("@p4", baslangicZamani);
                    cmd.Parameters.AddWithValue("@p5", bitisZamani);
                    cmd.Parameters.AddWithValue("@p6", notlar);
                    cmd.Parameters.AddWithValue("@randevuID", editingRandevuID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Randevu başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex) { MessageBox.Show("Güncelleme sırasında hata: " + ex.Message); }
                finally { baglanti.Close(); }
            }
        }

        // '+' BUTONUNA TIKLANDIĞINDA ÇALIŞACAK KOD
        private void btnYeniMusteriEkle_Click(object sender, EventArgs e)
        {
            frmYeniMusteri musteriEkleFormu = new frmYeniMusteri();
            DialogResult sonuc = musteriEkleFormu.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                VeriYukle(lookUpMusteri, "SELECT MusteriID, CONCAT(Ad, ' ', Soyad) AS AdSoyad FROM Musteriler ORDER BY Ad, Soyad", "AdSoyad", "MusteriID");
                int? yeniID = musteriEkleFormu.YeniMusteriID;
                if (yeniID != null)
                {
                    lookUpMusteri.EditValue = yeniID;
                }
            }
        }
    }
}