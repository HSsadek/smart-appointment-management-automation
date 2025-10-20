using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace AkilliRandevuYonetimiS
{
    public partial class frmSifremiUnuttum : Form
    {
        private string currentCode;
        private DateTime codeExpiry;
        private string sentEmail;

        public string VerifiedCode { get; private set; }
        public string VerifiedEmail { get; private set; }

        public frmSifremiUnuttum()
        {
            InitializeComponent();

            // simple runtime visuals
            try
            {
                pictureBoxLogo.Image = CreateLogoBitmap(56, 56);
            }
            catch { }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text?.Trim();
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Lütfen e-posta adresinizi girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Generate 6-digit random code
            var rng = new Random();
            currentCode = rng.Next(0, 1000000).ToString("D6");
            codeExpiry = DateTime.UtcNow.AddMinutes(15);
            sentEmail = email;

            // Send email
            try
            {
                SendCodeByEmail(email, currentCode);
                MessageBox.Show("Kod gönderildi. Lütfen e-postanızı kontrol edin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("E-posta gönderilemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            var entered = txtCode.Text?.Trim();
            if (string.IsNullOrWhiteSpace(entered))
            {
                MessageBox.Show("Lütfen kodu girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentCode == null)
            {
                MessageBox.Show("Önce kod gönderin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DateTime.UtcNow > codeExpiry)
            {
                MessageBox.Show("Kodun süresi dolmuş. Lütfen yeni bir kod isteyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (entered == currentCode)
            {
                // Kod doğru - set verified properties so caller can use them
                VerifiedCode = currentCode;
                VerifiedEmail = sentEmail;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Kod hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendCodeByEmail(string toEmail, string code)
        {
            // Read SMTP settings from App.config if present (simple fallbacks)
            var smtpHost = System.Configuration.ConfigurationManager.AppSettings["SmtpHost"] ?? "smtp.example.com";
            var smtpPortStr = System.Configuration.ConfigurationManager.AppSettings["SmtpPort"] ?? "587";
            var smtpUser = System.Configuration.ConfigurationManager.AppSettings["SmtpUser"] ?? "user@example.com";
            var smtpPass = System.Configuration.ConfigurationManager.AppSettings["SmtpPass"] ?? "password";
            int smtpPort = 587;
            int.TryParse(smtpPortStr, out smtpPort);

            var from = new MailAddress(smtpUser, "Akıllı Randevu Sistemi");
            var to = new MailAddress(toEmail);

            using (var client = new SmtpClient(smtpHost, smtpPort))
            {
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(smtpUser, smtpPass);

                var msg = new MailMessage(from, to)
                {
                    Subject = "Şifre Sıfırlama Kodu",
                    Body = $"Merhaba,\n\nŞifre sıfırlama kodunuz: {code}\nBu kod 15 dakika geçerlidir.\n\nEğer bu talebi siz yapmadıysanız lütfen hesabınızı kontrol edin.",
                    IsBodyHtml = false
                };

                client.Send(msg);
            }
        }

        // simple logo generator to match frmGiris style
        private System.Drawing.Bitmap CreateLogoBitmap(int w, int h)
        {
            var accentColor = System.Drawing.Color.FromArgb(37, 99, 235);
            var bmp = new System.Drawing.Bitmap(w, h);
            using (var g = System.Drawing.Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(System.Drawing.Color.Transparent);
                using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(new System.Drawing.Rectangle(0, 0, w, h), accentColor, System.Drawing.Color.FromArgb(0, 180, 255), 45F))
                {
                    g.FillEllipse(brush, 0, 0, w, h);
                }
                using (var font = new System.Drawing.Font("Segoe UI", w / 4f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel))
                using (var sf = new System.Drawing.StringFormat() { Alignment = System.Drawing.StringAlignment.Center, LineAlignment = System.Drawing.StringAlignment.Center })
                using (var brush = new System.Drawing.SolidBrush(System.Drawing.Color.White))
                {
                    g.DrawString("R", font, brush, new System.Drawing.RectangleF(0, 0, w, h), sf);
                }
            }
            return bmp;
        }
    }
}
