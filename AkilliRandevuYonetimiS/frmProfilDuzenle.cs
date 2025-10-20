using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AkilliRandevuYonetimiS
{
    public partial class frmProfilDuzenle : Form
    {
        private string currentImagePath;

        public frmProfilDuzenle()
        {
            InitializeComponent();
            SetupControls();
            LoadUserData();
        }

        private void SetupControls()
        {
            // Form ayarları
            this.Text = "Profil Düzenle";
            this.FormBorderStyle = FormBorderStyle.None;

            // Panel ayarları
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Padding = new Padding(20);

            // PictureBox ayarları
            pictureBoxProfil.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProfil.BorderStyle = BorderStyle.FixedSingle;

            // ComboBox ayarları
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Items.Clear();
            cmbRol.Items.AddRange(new object[] { "Admin", "Kullanıcı" });

            // Şifre alanı ayarları
            txtSifre.UseSystemPasswordChar = true;

            // Make controls responsive
            txtKullaniciAdi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSifre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAdSoyad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbRol.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            pictureBoxProfil.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnResimSec.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnKaydet.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnIptal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            // Event handlers
            btnResimSec.Click += BtnResimSec_Click;
            btnKaydet.Click += BtnKaydet_Click;
            btnIptal.Click += BtnIptal_Click;
        }

        private void LoadUserData()
        {
            try
            {
                int? userId = SessionManager.UserId;
                if (userId == null || userId == 0)
                {
                    // Try username fallback
                    if (!string.IsNullOrEmpty(SessionManager.Username))
                    {
                        using var conn = VeritabaniBaglantisi.Baglan();
                        conn.Open();
                        using var cmd1 = new MySqlCommand("SELECT KullaniciID FROM Kullanicilar WHERE KullaniciAdi=@u LIMIT 1", conn);
                        cmd1.Parameters.AddWithValue("@u", SessionManager.Username);
                        var idObj = cmd1.ExecuteScalar();
                        if (idObj != null && idObj != DBNull.Value) userId = Convert.ToInt32(idObj);
                    }
                }

                if (userId == null || userId == 0) return;

                using var baglanti = VeritabaniBaglantisi.Baglan();
                baglanti.Open();
                string sorgu = "SELECT KullaniciAdi, Sifre, AdSoyad, Rol, Email, fotograf FROM Kullanicilar WHERE KullaniciID=@id LIMIT 1";
                using var cmd = new MySqlCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@id", userId.Value);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtKullaniciAdi.Text = reader["KullaniciAdi"] != DBNull.Value ? reader["KullaniciAdi"].ToString() : string.Empty;
                    txtSifre.Text = reader["Sifre"] != DBNull.Value ? reader["Sifre"].ToString() : string.Empty;
                    txtAdSoyad.Text = reader["AdSoyad"] != DBNull.Value ? reader["AdSoyad"].ToString() : string.Empty;
                    txtEmail.Text = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : string.Empty;

                    var rolVal = reader["Rol"] != DBNull.Value ? reader["Rol"].ToString() : string.Empty;
                    if (!string.IsNullOrEmpty(rolVal) && cmbRol.Items.Contains(rolVal))
                        cmbRol.SelectedItem = rolVal;
                    else if (cmbRol.Items.Count > 0) cmbRol.SelectedIndex = 0;

                    if (reader["fotograf"] != DBNull.Value)
                    {
                        try
                        {
                            var bytes = (byte[])reader["fotograf"];
                            SessionManager.AvatarBytes = bytes;
                            using var ms = new MemoryStream(bytes);
                            pictureBoxProfil.Image = Image.FromStream(ms);
                        }
                        catch { SessionManager.AvatarBytes = null; }
                    }

                    // Update session values
                    SessionManager.UserId = userId;
                    SessionManager.Username = txtKullaniciAdi.Text;
                    SessionManager.Email = txtEmail.Text;
                    SessionManager.Role = rolVal;
                    SessionManager.DisplayName = txtAdSoyad.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Profil yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnResimSec_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    currentImagePath = ofd.FileName;
                    try
                    {
                        using (var fs = new FileStream(currentImagePath, FileMode.Open, FileAccess.Read))
                        {
                            pictureBoxProfil.Image = Image.FromStream(fs);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Resim yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                int? userId = SessionManager.UserId;
                if (userId == null || userId == 0)
                {
                    MessageBox.Show("Kullanıcı bilgisi bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var kullaniciAdi = txtKullaniciAdi.Text.Trim();
                var sifre = txtSifre.Text;
                var adSoyad = txtAdSoyad.Text.Trim();
                var rol = cmbRol.SelectedItem?.ToString() ?? string.Empty;
                var email = txtEmail.Text.Trim();

                using var baglanti = VeritabaniBaglantisi.Baglan();
                baglanti.Open();

                byte[] imageBytes = null;
                if (!string.IsNullOrEmpty(currentImagePath) && File.Exists(currentImagePath))
                {
                    imageBytes = File.ReadAllBytes(currentImagePath);
                }

                string sorgu;
                if (imageBytes != null)
                {
                    sorgu = "UPDATE Kullanicilar SET KullaniciAdi=@kullaniciAdi, Sifre=@sifre, AdSoyad=@adSoyad, Rol=@rol, Email=@email, fotograf=@fotograf WHERE KullaniciID=@id";
                }
                else
                {
                    sorgu = "UPDATE Kullanicilar SET KullaniciAdi=@kullaniciAdi, Sifre=@sifre, AdSoyad=@adSoyad, Rol=@rol, Email=@email WHERE KullaniciID=@id";
                }

                using var cmd = new MySqlCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                cmd.Parameters.AddWithValue("@adSoyad", adSoyad);
                cmd.Parameters.AddWithValue("@rol", rol);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@id", userId.Value);

                if (imageBytes != null)
                {
                    cmd.Parameters.AddWithValue("@fotograf", imageBytes);
                }

                cmd.ExecuteNonQuery();

                // Update session
                SessionManager.Username = kullaniciAdi;
                SessionManager.Email = email;
                SessionManager.DisplayName = adSoyad;
                SessionManager.Role = rol;
                if (imageBytes != null) SessionManager.AvatarBytes = imageBytes;

                MessageBox.Show("Profil bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                currentImagePath = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
            }
            catch
            {
                this.Close();
            }
        }
    }
}