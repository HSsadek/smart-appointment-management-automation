using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using AkilliRandevuYonetimiS.Services;
using MySql.Data.MySqlClient;
using System.Data; // DataTable ve CommandBehavior için
using System.Configuration; // Gerekirse (ProfileService'de yoksa)
using System.Drawing.Imaging;
using System.Linq;

namespace AkilliRandevuYonetimiS
{
    public partial class frmProfilDuzenle : Form
    {
        private readonly ProfileService _service = new ProfileService();
        private int currentUserId = SessionManager.UserId ?? 0;

        public frmProfilDuzenle()
        {
            InitializeComponent();
        }

        private void frmProfilDuzenle_Load(object sender, EventArgs e)
        {
            // If SessionManager has user, prefer it
            if (SessionManager.UserId.HasValue && SessionManager.UserId.Value > 0)
            {
                currentUserId = SessionManager.UserId.Value;
            }

            // If we don't have an ID but SessionManager contains user info, populate from session as fallback
            if (currentUserId == 0 && !string.IsNullOrWhiteSpace(SessionManager.Username))
            {
                txtUsername.Text = SessionManager.Username ?? string.Empty;
                txtEmail.Text = SessionManager.Email ?? string.Empty;
                txtRole.Text = SessionManager.Role ?? string.Empty;
                txtFirstName.Text = SessionManager.FirstName ?? string.Empty;
                txtLastName.Text = SessionManager.LastName ?? string.Empty;
                if (SessionManager.AvatarBytes != null)
                {
                    try
                    {
                        using var ms = new MemoryStream(SessionManager.AvatarBytes);
                        pictureBoxAvatar.Image = Image.FromStream(ms);
                        MakeAvatarCircular();
                    }
                    catch { }
                }

                txtUsername.ReadOnly = true;
                txtRole.ReadOnly = true;
                return;
            }

            MySqlConnection baglanti = VeritabaniBaglantisi.Baglan(); // Veritabanı bağlantı metodunuzu kullanın
            try
            {
                baglanti.Open();
                // Use the actual columns. The table contains KullaniciID, KullaniciAdi, Sifre, AdSoyad, Rol, Email, fotograf
                string sorgu = "SELECT KullaniciID, KullaniciAdi, AdSoyad, Rol, Email, fotograf FROM Kullanicilar WHERE KullaniciID = @id LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@id", currentUserId);

                using (MySqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow)) // Sadece tek satır bekliyoruz
                {
                    if (reader.Read()) // Kullanıcı bulunduysa
                    {
                        txtUsername.Text = reader["KullaniciAdi"]?.ToString();
                        txtEmail.Text = reader["Email"]?.ToString();
                        txtRole.Text = reader["Rol"]?.ToString();

                        // AdSoyad sütununu ayırma
                        string adSoyad = reader["AdSoyad"] != DBNull.Value ? reader["AdSoyad"].ToString() : string.Empty;
                        if (!string.IsNullOrWhiteSpace(adSoyad))
                        {
                            int ilkBosluk = adSoyad.IndexOf(' ');
                            if (ilkBosluk > 0)
                            {
                                txtFirstName.Text = adSoyad.Substring(0, ilkBosluk);
                                txtLastName.Text = adSoyad.Substring(ilkBosluk + 1);
                            }
                            else
                            {
                                txtFirstName.Text = adSoyad;
                                txtLastName.Text = "";
                            }
                        }

                        // Avatar
                        if (reader["fotograf"] != DBNull.Value)
                        {
                            try
                            {
                                byte[] avatarBytes = (byte[])reader["fotograf"];
                                using (var ms = new MemoryStream(avatarBytes))
                                {
                                    pictureBoxAvatar.Image = Image.FromStream(ms);
                                    MakeAvatarCircular();
                                }
                            }
                            catch { }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bilgileri yüklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Profil bilgileri yüklenirken hata: " + ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            finally
            {
                baglanti.Close();
            }

            txtUsername.ReadOnly = true;
            txtRole.ReadOnly = true;
        }

        private void panelCard_Paint(object sender, PaintEventArgs e)
        {
            using var p = new Pen(Color.FromArgb(235, 235, 240));
            e.Graphics.DrawRectangle(p, 0, 0, panelCard.Width - 1, panelCard.Height - 1);
        }

        private void panelAvatarBorder_Paint(object sender, PaintEventArgs e)
        {
            // draw a subtle shadow and circular border
            var rect = panelAvatarBorder.ClientRectangle;
            using var shadowBrush = new SolidBrush(Color.FromArgb(30, 0, 0, 0));
            var shadowRect = new Rectangle(rect.Left + 2, rect.Top + 2, rect.Width, rect.Height);
            e.Graphics.FillEllipse(shadowBrush, shadowRect);
            using var pen = new Pen(Color.FromArgb(220, 220, 230), 1.5f);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawEllipse(pen, rect.Left + 1, rect.Top + 1, rect.Width - 3, rect.Height - 3);
        }

        private void MakeAvatarCircular()
        {
            try
            {
                var w = pictureBoxAvatar.Width;
                var h = pictureBoxAvatar.Height;
                var gp = new GraphicsPath();
                gp.AddEllipse(0, 0, w, h);
                pictureBoxAvatar.Region?.Dispose();
                pictureBoxAvatar.Region = new Region(gp);
            }
            catch { }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // If hosted inline, close and restore scheduler (Form1 handles visibility)
            this.Parent?.Controls.Remove(this);
            this.Dispose();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            // simple inline validation
            var email = txtEmail.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(email))
            {
                lblStatus.Text = "E-posta boş olamaz.";
                lblStatus.Appearance.ForeColor = Color.FromArgb(200, 40, 40);
            }
            else if (!email.Contains("@") || email.Length < 5)
            {
                lblStatus.Text = "Geçersiz e-posta formatı.";
                lblStatus.Appearance.ForeColor = Color.FromArgb(200, 100, 40);
            }
            else
            {
                lblStatus.Text = "";
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // validation: email must be valid
            var email = txtEmail.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                lblStatus.Text = "Geçerli bir e-posta girin.";
                lblStatus.Appearance.ForeColor = Color.FromArgb(200, 40, 40);
                return;
            }

            try
            {
                byte[] avatar = null;
                if (pictureBoxAvatar.Image != null)
                {
                    // Resize and compress to avoid large packets
                    const int maxWidth = 1024;
                    const int maxHeight = 1024;
                    const int targetMaxBytes = 4 * 1024 * 1024; // 4 MB

                    using var src = new Bitmap(pictureBoxAvatar.Image);

                    int newW = src.Width;
                    int newH = src.Height;
                    if (newW > maxWidth || newH > maxHeight)
                    {
                        var ratio = Math.Min((double)maxWidth / newW, (double)maxHeight / newH);
                        newW = (int)(newW * ratio);
                        newH = (int)(newH * ratio);
                    }

                    using var resized = new Bitmap(newW, newH);
                    using (var g = Graphics.FromImage(resized))
                    {
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                        g.DrawImage(src, 0, 0, newW, newH);
                    }

                    // Try different JPEG quality levels until under target size
                    var jpgEncoder = ImageCodecInfo.GetImageEncoders().FirstOrDefault(c => c.FormatID == ImageFormat.Jpeg.Guid);
                    if (jpgEncoder != null)
                    {
                        long quality = 90;
                        for (; quality >= 30; quality -= 10)
                        {
                            using var ms = new MemoryStream();
                            var encoderParams = new EncoderParameters(1);
                            encoderParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
                            resized.Save(ms, jpgEncoder, encoderParams);
                            if (ms.Length <= targetMaxBytes)
                            {
                                avatar = ms.ToArray();
                                break;
                            }
                        }

                        // if still null, save with lowest quality tried
                        if (avatar == null)
                        {
                            using var ms = new MemoryStream();
                            var encoderParams = new EncoderParameters(1);
                            encoderParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 30L);
                            resized.Save(ms, jpgEncoder, encoderParams);
                            avatar = ms.ToArray();
                        }
                    }
                    else
                    {
                        // Fallback: PNG
                        using var ms = new MemoryStream();
                        resized.Save(ms, ImageFormat.Png);
                        avatar = ms.ToArray();
                    }

                    // If still too large, inform user and abort
                    if (avatar != null && avatar.Length > targetMaxBytes)
                    {
                        lblStatus.Text = $"Resim çok büyük ({avatar.Length / 1024} KB).";
                        lblStatus.Appearance.ForeColor = Color.FromArgb(200, 40, 40);
                        return;
                    }
                }

                var success = await _service.UpdateProfileAsync(currentUserId, txtFirstName.Text.Trim(), txtLastName.Text.Trim(), txtEmail.Text.Trim(), avatar);
                if (success)
                {
                    SessionManager.FirstName = txtFirstName.Text.Trim();
                    SessionManager.LastName = txtLastName.Text.Trim();
                    SessionManager.DisplayName = (SessionManager.FirstName + " " + SessionManager.LastName).Trim();
                    SessionManager.Email = txtEmail.Text.Trim();
                    SessionManager.AvatarBytes = avatar;

                    lblStatus.Text = "Profil başarıyla kaydedildi.";
                    lblStatus.Appearance.ForeColor = Color.FromArgb(16, 185, 129); // green

                    // small fade-out after 2 seconds
                    var t = new Timer();
                    t.Interval = 2000;
                    t.Tick += (s, ea) =>
                    {
                        lblStatus.Text = "";
                        t.Stop();
                        t.Dispose();
                    };
                    t.Start();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lblStatus.Text = "Profil kaydedilemedi.";
                    lblStatus.Appearance.ForeColor = Color.FromArgb(200, 40, 40);
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Profil güncellenirken hata: " + ex.Message;
                lblStatus.Appearance.ForeColor = Color.FromArgb(200, 40, 40);
            }
        }

        private void btnUploadAvatar_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog();
            ofd.Filter = "Image files|*.png;*.jpg;*.jpeg;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var img = Image.FromFile(ofd.FileName);
                    pictureBoxAvatar.Image = img;
                    MakeAvatarCircular();
                }
                catch (Exception ex)
                {
                    lblStatus.Text = "Resim yüklenemedi: " + ex.Message;
                    lblStatus.Appearance.ForeColor = Color.FromArgb(200, 40, 40);
                }
            }
        }

        private void pictureBoxAvatar_Click(object sender, EventArgs e)
        {

        }
    }
}
