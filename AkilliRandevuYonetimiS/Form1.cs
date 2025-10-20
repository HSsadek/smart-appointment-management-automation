using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraScheduler;
using MySql.Data.MySqlClient;
using DevExpress.Utils.Menu;
using AkilliRandevuYonetimiS.Services;

namespace AkilliRandevuYonetimiS
{
    public partial class Form1 : RibbonForm
    {
        private Form activeInlineForm = null;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            schedulerControl.Storage = new SchedulerStorage();
            this.schedulerControl.EditAppointmentFormShowing += schedulerControl_EditAppointmentFormShowing;
            this.schedulerControl.PopupMenuShowing += schedulerControl_PopupMenuShowing;
            schedulerControl.Start = System.DateTime.Now;
            RandevulariYukle();

            // wire the profile button (barButtonItem6)
            try { barButtonItem6.ItemClick -= BarButtonItem6_ItemClick; } catch { }
            barButtonItem6.ItemClick += BarButtonItem6_ItemClick;
        }

        private void BarButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Toggle inline profile view in place of schedulerControl
            if (activeInlineForm == null)
                ShowProfileInline();
            else
                CloseInlineForm();
        }

        private void ShowProfileInline()
        {
            try
            {
                // hide scheduler control (keep it in controls to restore later)
                schedulerControl.Visible = false;

                // create profile form and host it inside the panel
                var frm = new frmProfilDuzenle();
                activeInlineForm = frm;
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;

                // Add to the panel that currently hosts schedulerControl
                schedulerSplitContainerControl.Panel1.Controls.Add(frm);
                frm.Show();

                // Optionally refresh layout
                schedulerSplitContainerControl.Panel1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Profil görünümü açılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // restore schedulerControl visibility
                schedulerControl.Visible = true;
            }
        }

        private void CloseInlineForm()
        {
            try
            {
                if (activeInlineForm != null)
                {
                    schedulerSplitContainerControl.Panel1.Controls.Remove(activeInlineForm);
                    activeInlineForm.Dispose();
                    activeInlineForm = null;
                }
            }
            catch { }
            finally
            {
                schedulerControl.Visible = true;
            }
        }

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

        // === EN ÖNEMLİ DEĞİŞİKLİK BURADA: YANKI ETKİSİNİ ÖNLEME ===
        private void schedulerControl_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            // DevExpress'in kendi formunu açmasını hemen engelliyoruz.
            e.Handled = true;

            // Formu açma ve yenileme işlemini, mevcut olay döngüsü bittikten sonra yapması için zamanlıyoruz.
            // Bu, "yankı" etkisini ve formun iki kez açılmasını kesin olarak engeller.
            this.BeginInvoke(new Action(() =>
            {

                // Kendi özel formumuzu, tıklanan randevu bilgisiyle birlikte açıyoruz.
                frmYeniRandevu randevuFormu = new frmYeniRandevu(e.Appointment, schedulerControl);

                // Formu aç ve kapanırken gönderdiği sonucu yakala.
                DialogResult sonuc = randevuFormu.ShowDialog();

                // SADECE ve SADECE sonuç "OK" ise (yani Kaydet'e basıldıysa) takvimi yenile.
                if (sonuc == DialogResult.OK)
                {
                    RandevulariYukle();
                }
            }));
        }

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

        private void newAppointmentItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}