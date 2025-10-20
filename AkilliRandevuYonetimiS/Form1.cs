using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars; // ItemClickEventArgs için
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraScheduler;
using MySql.Data.MySqlClient;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors; // PanelControl için

namespace AkilliRandevuYonetimiS
{
    public partial class Form1 : RibbonForm
    {
        // Panel içinde hangi formun aktif olduğunu tutmak için (genel kullanım)
        // private Form activeInlineForm = null; // Bu özel mekanizmaya artık ihtiyacımız yok gibi

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            schedulerControl.Storage = new SchedulerStorage();
            this.schedulerControl.EditAppointmentFormShowing += schedulerControl_EditAppointmentFormShowing;
            this.schedulerControl.PopupMenuShowing += schedulerControl_PopupMenuShowing;

            // Wire personel button click (Dashboard -> Personel / barButtonItem7)
            try
            {
                this.barButtonItem7.ItemClick += barButtonItem7_ItemClick;
            }
            catch { /* ignore if designer name differs */ }

            // Wire hizmetler button click (Dashboard -> Hizmetler / barButtonItem8)
            try
            {
                this.barButtonItem8.ItemClick += barButtonItem8_ItemClick;
            }
            catch { /* ignore if designer name differs */ }

            // Profil butonunun olayını bağlıyoruz (Tasarımcıda çift tıkladıysanız bu satıra gerek yok)
            // Eğer tasarımcıda btnProfil_ItemClick metodu otomatik oluştuysa bu satırı silebilirsiniz.
            // Aksi takdirde bırakın veya tasarımcıdan bağlayın.
            // this.btnProfil.ItemClick += btnProfil_ItemClick; // İsmin btnProfil olduğundan emin olun

            schedulerControl.Start = System.DateTime.Now;
            RandevulariYukle();
        }

        // ===========================================================================
        //  VERİTABANINDAN RANDEVULARI YÜKLEME METODU (Değişiklik yok)
        // ===========================================================================
        void RandevulariYukle()
        {
            string sorgu = @"
                SELECT
                    R.*,
                    CONCAT(M.Ad, ' ', M.Soyad, ' - ', H.HizmetAdi) AS RandevuKonusu,
                    CASE R.Durum
                        WHEN 'Tamamlandı' THEN 3
                        WHEN 'İptal Edildi' THEN 5
                        ELSE 0
                    END AS RenkKodu
                FROM Randevular AS R
                JOIN Musteriler AS M ON R.MusteriID = M.MusteriID
                JOIN Hizmetler AS H ON R.HizmetID = H.HizmetID";

            DataTable dtRandevular = new DataTable();
            try
            {
                MySqlConnection baglanti = VeritabaniBaglantisi.Baglan();
                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglanti);
                da.Fill(dtRandevular);

                schedulerControl.Storage.Appointments.Mappings.Start = "BaslangicZamani";
                schedulerControl.Storage.Appointments.Mappings.End = "BitisZamani";
                schedulerControl.Storage.Appointments.Mappings.Subject = "RandevuKonusu";
                schedulerControl.Storage.Appointments.Mappings.Description = "Notlar";
                schedulerControl.Storage.Appointments.Mappings.Label = "RenkKodu";
                schedulerControl.Storage.Appointments.DataSource = dtRandevular;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevular yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        // ===========================================================================
        //  YENİ RANDEVU EKLEME / DÜZENLEME FORMU GÖSTERME OLAYI (Değişiklik yok)
        // ===========================================================================
        private void schedulerControl_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            e.Handled = true;
            this.BeginInvoke(new Action(() =>
            {
                frmYeniRandevu randevuFormu = new frmYeniRandevu(e.Appointment, schedulerControl);
                DialogResult sonuc = randevuFormu.ShowDialog();
                if (sonuc == DialogResult.OK)
                {
                    RandevulariYukle();
                }
            }));
        }

        // ===========================================================================
        //  SAĞ TIK MENÜSÜ OLAYI (Değişiklik yok)
        // ===========================================================================
        private void schedulerControl_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.Menu.Id == SchedulerMenuItemId.AppointmentMenu)
            {
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.DeleteAppointment);

                DXSubMenuItem statusMenuItem = new DXSubMenuItem("Durumu Değiştir");
                DXMenuItem completedItem = new DXMenuItem("Tamamlandı", (o, args) =>
                {
                    if (schedulerControl.SelectedAppointments.Count > 0)
                    {
                        DataRowView row = schedulerControl.SelectedAppointments[0].GetRow(schedulerControl.Storage) as DataRowView;
                        if (row != null)
                        {
                            int randevuID = Convert.ToInt32(row["RandevuID"]);
                            RandevuDurumunuGuncelle(randevuID, "Tamamlandı");
                        }
                    }
                });
                statusMenuItem.Items.Add(completedItem);

                DXMenuItem canceledItem = new DXMenuItem("İptal Edildi", (o, args) =>
                {
                    if (schedulerControl.SelectedAppointments.Count > 0)
                    {
                        DataRowView row = schedulerControl.SelectedAppointments[0].GetRow(schedulerControl.Storage) as DataRowView;
                        if (row != null)
                        {
                            int randevuID = Convert.ToInt32(row["RandevuID"]);
                            RandevuDurumunuGuncelle(randevuID, "İptal Edildi");
                        }
                    }
                });
                statusMenuItem.Items.Add(canceledItem);

                e.Menu.Items.Insert(0, statusMenuItem);
                e.Menu.Items.Insert(1, new DXMenuHeaderItem());

                DXMenuItem customDeleteItem = new DXMenuItem("Randevuyu Veritabanından Sil");
                customDeleteItem.Click += (o, args) =>
                {
                    DialogResult sonuc = MessageBox.Show("Bu randevuyu kalıcı olarak silmek istediğinizden emin misiniz?", "Randevu Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sonuc == DialogResult.Yes)
                    {
                        if (schedulerControl.SelectedAppointments.Count > 0)
                        {
                            Appointment apt = schedulerControl.SelectedAppointments[0];
                            DataRowView row = apt.GetRow(schedulerControl.Storage) as DataRowView;
                            if (row != null)
                            {
                                int randevuID = Convert.ToInt32(row["RandevuID"]);
                                MySqlConnection baglanti = VeritabaniBaglantisi.Baglan();
                                try
                                {
                                    baglanti.Open();
                                    string sorgu = "DELETE FROM Randevular WHERE RandevuID = @id";
                                    MySqlCommand cmd = new MySqlCommand(sorgu, baglanti);
                                    cmd.Parameters.AddWithValue("@id", randevuID);
                                    cmd.ExecuteNonQuery();
                                    RandevulariYukle();
                                }
                                catch (Exception ex) { MessageBox.Show("Randevu silinirken bir hata oluştu: " + ex.Message, "Hata"); }
                                finally { baglanti.Close(); }
                            }
                        }
                    }
                };
                e.Menu.Items.Add(customDeleteItem);
            }
        }

        // ===========================================================================
        //  RANDEVU DURUMUNU GÜNCELLEME METODU (Değişiklik yok)
        // ===========================================================================
        void RandevuDurumunuGuncelle(int randevuID, string yeniDurum)
        {
            MySqlConnection baglanti = VeritabaniBaglantisi.Baglan();
            try
            {
                baglanti.Open();
                string sorgu = "UPDATE Randevular SET Durum = @yeniDurum WHERE RandevuID = @id";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@yeniDurum", yeniDurum);
                cmd.Parameters.AddWithValue("@id", randevuID);
                cmd.ExecuteNonQuery();
                RandevulariYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu durumu güncellenirken bir hata oluştu: " + ex.Message, "Hata");
            }
            finally
            {
                baglanti.Close();
            }
        }

        // ===========================================================================
        //  PROFİL BUTONUNA TIKLANDIĞINDA ÇALIŞACAK YENİ KOD
        // ===========================================================================

        private void btnProfil_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            // 1. Hedef Konteyner: SplitContainer'ın takvimi içeren paneli (Genellikle Panel1)
            var targetPanel = schedulerSplitContainerControl.Panel1;

            // 2. Panelin içini temizle (varsa eski formu kaldırır)
            targetPanel.Controls.Clear();

            // 3. Profil formunu oluştur ve ayarla
            frmProfilDuzenle profilForm = new frmProfilDuzenle();
            profilForm.TopLevel = false;
            profilForm.FormBorderStyle = FormBorderStyle.None;
            profilForm.Dock = DockStyle.Fill; // Panelin içini tamamen dolduracak

            // 4. Formu doğru panele ekle
            targetPanel.Controls.Add(profilForm);

            // 5. Formu göster
            profilForm.Visible = true; // VEYA profilForm.Show();

            // 6. Takvimi gizle (Panel zaten görünür)
            schedulerControl.Visible = false;

            // panelContent'e artık ihtiyacımız yok, bu yüzden onunla ilgili kodları sildik.

        }

        // New handler: show personnel management form
        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            var targetPanel = schedulerSplitContainerControl.Panel1;
            targetPanel.Controls.Clear();

            var personelForm = new frmPersonel();
            personelForm.TopLevel = false;
            personelForm.FormBorderStyle = FormBorderStyle.None;
            personelForm.Dock = DockStyle.Fill;

            targetPanel.Controls.Add(personelForm);
            personelForm.Show();

            // Hide scheduler
            schedulerControl.Visible = false;
        }

        // New handler: show services management form
        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            var targetPanel = schedulerSplitContainerControl.Panel1;
            targetPanel.Controls.Clear();

            var hizmetForm = new frmHizmet();
            hizmetForm.TopLevel = false;
            hizmetForm.FormBorderStyle = FormBorderStyle.None;
            hizmetForm.Dock = DockStyle.Fill;

            targetPanel.Controls.Add(hizmetForm);
            hizmetForm.Show();

            // Hide scheduler
            schedulerControl.Visible = false;
        }

        // ===========================================================================
        //  TAKVMİ GÖSTERMEK İÇİN GENEL (PUBLIC) METOD
        // ===========================================================================
        public void TakvimiGoster()
            {
            // Profil panelini gizle
            panelContent.Visible = false; // panelContent adının doğru olduğundan emin olun
            panelContent.Controls.Clear(); // İçini temizlemek iyi bir pratik

            // Takvimi göster
            schedulerControl.Visible = true;
            schedulerControl.BringToFront(); // Her ihtimale karşı öne getir
        } 
    } 
}