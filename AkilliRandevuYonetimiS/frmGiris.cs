using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkilliRandevuYonetimiS
{
    public partial class frmGiris : Form
    {
        // Modern palette
        private readonly Color accentColor = Color.FromArgb(37, 99, 235); // modern blue
        private readonly Color accentColorDark = Color.FromArgb(24, 75, 200);
        private readonly Color textPrimary = Color.FromArgb(17, 24, 39);
        private readonly Color textSecondary = Color.FromArgb(107, 114, 128);
        private readonly Color iconMuted = Color.FromArgb(120, 120, 130);

        public frmGiris()
        {
            InitializeComponent();

            // Prevent designer from executing runtime-only initialization which can crash the designer host
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                // Load pictureBoxLogo image at runtime to avoid designer TypeConverter issues
                try
                {
                    var rm = new System.Resources.ResourceManager(typeof(frmGiris));
                    var stream = rm.GetStream("pictureBoxLogo.Image");
                    if (stream != null)
                    {
                        using (var s = stream)
                        {
                            this.pictureBoxLogo.Image = System.Drawing.Image.FromStream(s);
                        }
                    }
                    else
                    {
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
                        object res = null;
                        try { res = resources.GetObject("pictureBoxLogo.Image"); } catch { res = null; }
                        if (res is System.Drawing.Image img) this.pictureBoxLogo.Image = img;
                        else if (res is byte[] bytes) { using var ms = new System.IO.MemoryStream(bytes); this.pictureBoxLogo.Image = System.Drawing.Image.FromStream(ms); }
                        else if (res is System.IO.Stream st) { this.pictureBoxLogo.Image = System.Drawing.Image.FromStream(st); }
                        else { try { this.pictureBoxLogo.Image = CreateLogoBitmap(60, 60); } catch { } }
                    }
                }
                catch
                {
                    try { this.pictureBoxLogo.Image = CreateLogoBitmap(60, 60); } catch { }
                }

                ApplyModernDesign();
            }
            else
            {
                // Designer: set a simple fallback so designer shows something without executing runtime logic
                try { this.pictureBoxLogo.Image = CreateLogoBitmap(60, 60); } catch { }
            }

            // Ensure there is a single click handler wired (in case designer wired another earlier)
            try
            {
                btnGiris.Click -= btnGiris_Click;
            }
            catch { }
            btnGiris.Click += btnGiris_Click;

            // Ensure 'Şifremi Unuttum' link opens the forgot form
            try { linkSifremiUnuttum.Click -= LinkSifremiUnuttum_Click; } catch { }
            linkSifremiUnuttum.Click += LinkSifremiUnuttum_Click;
        }

        private void ApplyModernDesign()
        {
            // Performance
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            // Form visuals
            this.BackColor = Color.White;
            this.Padding = new Padding(12);

            // Handle painting and resizing
            this.Paint += FrmGiris_Paint;
            this.Resize += FrmGiris_Resize;

            // Keyboard
            this.KeyPreview = true;
            this.KeyDown += FrmGiris_KeyDown;

            // Fonts and colors
            try
            {
                var titleFont = new Font(new FontFamily("Segoe UI"), 18F, FontStyle.Bold, GraphicsUnit.Point);
                var regularFont = new Font(new FontFamily("Segoe UI"), 9F, FontStyle.Regular, GraphicsUnit.Point);

                labelControl1.Appearance.Font = titleFont;
                labelControl1.Appearance.ForeColor = textPrimary;

                labelControl2.Appearance.Font = regularFont;
                labelControl2.Appearance.ForeColor = textSecondary;

                txtKullaniciAdi.Properties.Appearance.Font = new Font(new FontFamily("Segoe UI"), 11F, FontStyle.Regular, GraphicsUnit.Point);
                txtKullaniciAdi.Properties.Appearance.ForeColor = textPrimary;
                txtSifre.Properties.Appearance.Font = new Font(new FontFamily("Segoe UI"), 11F, FontStyle.Regular, GraphicsUnit.Point);
                txtSifre.Properties.Appearance.ForeColor = textPrimary;

                btnGiris.Appearance.Font = new Font(new FontFamily("Segoe UI"), 12F, FontStyle.Bold, GraphicsUnit.Point);
            }
            catch { }

            // Button visuals using accent
            btnGiris.Appearance.Options.UseBackColor = true;
            btnGiris.Appearance.BackColor = accentColor;
            btnGiris.Appearance.Options.UseForeColor = true;
            btnGiris.Appearance.ForeColor = Color.White;
            btnGiris.LookAndFeel.UseDefaultLookAndFeel = false;

            // Hover
            btnGiris.MouseEnter += (s, e) => { try { btnGiris.Appearance.BackColor = accentColorDark; } catch { } };
            btnGiris.MouseLeave += (s, e) => { try { btnGiris.Appearance.BackColor = accentColor; } catch { } };

            // Ensure button visible
            btnGiris.Visible = true;
            btnGiris.BringToFront();

            // Shift textboxes to make room for icons and add icons
            try
            {
                if (this.panelCard != null)
                {
                    txtKullaniciAdi.Location = new Point(68, txtKullaniciAdi.Location.Y);
                    txtKullaniciAdi.Width = 320;

                    txtSifre.Location = new Point(68, txtSifre.Location.Y);
                    txtSifre.Width = 320;

                    int iconSize = 28;

                    var picUser = new PictureBox()
                    {
                        Size = new Size(iconSize, iconSize),
                        Location = new Point(28, txtKullaniciAdi.Location.Y + (txtKullaniciAdi.Height - iconSize) / 2),
                        SizeMode = PictureBoxSizeMode.CenterImage,
                        BackColor = Color.Transparent,
                        Cursor = Cursors.Default,
                    };
                    picUser.Image = CreateUserIcon(iconSize, iconMuted);

                    var picLock = new PictureBox()
                    {
                        Size = new Size(iconSize, iconSize),
                        Location = new Point(28, txtSifre.Location.Y + (txtSifre.Height - iconSize) / 2),
                        SizeMode = PictureBoxSizeMode.CenterImage,
                        BackColor = Color.Transparent,
                        Cursor = Cursors.Default,
                    };
                    picLock.Image = CreateLockIcon(iconSize, iconMuted);

                    var picEye = new PictureBox()
                    {
                        Size = new Size(iconSize, iconSize),
                        Location = new Point(txtSifre.Location.X + txtSifre.Width - iconSize - 6, txtSifre.Location.Y + (txtSifre.Height - iconSize) / 2),
                        SizeMode = PictureBoxSizeMode.CenterImage,
                        BackColor = Color.Transparent,
                        Cursor = Cursors.Hand,
                    };
                    picEye.Image = CreateEyeIcon(iconSize, iconMuted, isOpen: false);

                    picEye.Click += (s, e) =>
                    {
                        // DevExpress TextEdit PasswordChar can be '\0' or '*'
                        var current = txtSifre.Properties.PasswordChar;
                        if (current == '*' || current == '\0' && txtSifre.Text.Length > 0 && txtSifre.Properties.PasswordChar == '\0')
                        {
                            // toggle using a simple check
                        }

                        if (txtSifre.Properties.PasswordChar == '*')
                        {
                            txtSifre.Properties.PasswordChar = '\0';
                            picEye.Image = CreateEyeIcon(iconSize, accentColor, isOpen: true);
                        }
                        else
                        {
                            txtSifre.Properties.PasswordChar = '*';
                            picEye.Image = CreateEyeIcon(iconSize, iconMuted, isOpen: false);
                        }
                    };

                    if (this.pictureBoxLogo != null)
                    {
                        try
                        {
                            if (this.pictureBoxLogo.Image == null)
                                this.pictureBoxLogo.Image = CreateLogoBitmap(60, 60);
                        }
                        catch { }
                    }

                    // Link color
                    try { linkSifremiUnuttum.Appearance.ForeColor = accentColor; linkSifremiUnuttum.Appearance.Options.UseForeColor = true; } catch { }

                    this.panelCard.Controls.Add(picUser);
                    this.panelCard.Controls.Add(picLock);
                    this.panelCard.Controls.Add(picEye);

                    picUser.BringToFront();
                    picLock.BringToFront();
                    picEye.BringToFront();
                }
            }
            catch { }

            // Textbox focus visuals
            txtKullaniciAdi.Enter += (s, e) => txtKullaniciAdi.Properties.Appearance.BackColor = Color.FromArgb(250, 250, 255);
            txtKullaniciAdi.Leave += (s, e) => txtKullaniciAdi.Properties.Appearance.BackColor = Color.White;

            txtSifre.Enter += (s, e) => txtSifre.Properties.Appearance.BackColor = Color.FromArgb(250, 250, 255);
            txtSifre.Leave += (s, e) => txtSifre.Properties.Appearance.BackColor = Color.White;

            // Accept button
            this.AcceptButton = btnGiris;
        }

        private Bitmap CreateUserIcon(int size, Color color)
        {
            var bmp = new Bitmap(size, size);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);
                using (var p = new Pen(color, 2))
                {
                    var headRect = new Rectangle((int)(size * 0.25), (int)(size * 0.12), (int)(size * 0.5), (int)(size * 0.5));
                    g.DrawEllipse(p, headRect);
                    var bodyRect = new Rectangle((int)(size * 0.12), (int)(size * 0.55), (int)(size * 0.76), (int)(size * 0.34));
                    g.DrawArc(p, bodyRect, 20, 140);
                }
            }
            return bmp;
        }

        private Bitmap CreateLockIcon(int size, Color color)
        {
            var bmp = new Bitmap(size, size);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);
                using (var pen = new Pen(color, 2))
                {
                    int w = size;
                    int h = size;
                    var body = new Rectangle((int)(w * 0.18), (int)(h * 0.38), (int)(w * 0.64), (int)(h * 0.44));
                    g.DrawRectangle(pen, body);
                    var shackleRect = new Rectangle((int)(w * 0.30), (int)(h * 0.10), (int)(w * 0.40), (int)(h * 0.56));
                    g.DrawArc(pen, shackleRect, 200, 140);
                    g.FillEllipse(Brushes.White, new Rectangle((int)(w * 0.46), (int)(h * 0.52), (int)(w * 0.08), (int)(h * 0.12)));
                }
            }
            return bmp;
        }

        private Bitmap CreateEyeIcon(int size, Color color, bool isOpen)
        {
            var bmp = new Bitmap(size, size);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);
                using (var pen = new Pen(color, 2))
                using (var brush = new SolidBrush(color))
                {
                    int w = size;
                    int h = size;
                    var eyeRect = new Rectangle((int)(w * 0.08), (int)(h * 0.30), (int)(w * 0.84), (int)(h * 0.40));
                    g.DrawArc(pen, eyeRect, 20, 140);
                    g.DrawArc(pen, eyeRect, 200, 140);
                    if (isOpen)
                    {
                        g.FillEllipse(brush, new Rectangle((int)(w * 0.42), (int)(h * 0.38), (int)(w * 0.16), (int)(h * 0.24)));
                    }
                    else
                    {
                        g.DrawLine(pen, (int)(w * 0.12), (int)(h * 0.18), (int)(w * 0.88), (int)(h * 0.82));
                    }
                }
            }
            return bmp;
        }

        private Bitmap CreateLogoBitmap(int w, int h)
        {
            var bmp = new Bitmap(w, h);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);
                using (var brush = new LinearGradientBrush(new Rectangle(0, 0, w, h), accentColor, Color.FromArgb(0, 180, 255), 45F))
                {
                    g.FillEllipse(brush, 0, 0, w, h);
                }
                using (var font = new Font("Segoe UI", w / 4f, FontStyle.Bold, GraphicsUnit.Pixel))
                using (var sf = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                using (var brush = new SolidBrush(Color.White))
                {
                    g.DrawString("R", font, brush, new RectangleF(0, 0, w, h), sf);
                }
            }
            return bmp;
        }

        private void FrmGiris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                btnGiris.PerformClick();
            }
        }

        private void FrmGiris_Resize(object sender, EventArgs e)
        {
            SetRoundedRegion(14);
            Invalidate();
        }

        private void FrmGiris_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(250, 252, 255), Color.FromArgb(245, 248, 255), 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            using (var pen = new Pen(Color.FromArgb(230, 230, 230), 1))
            {
                e.Graphics.DrawLine(pen, 0, 0, this.ClientSize.Width, 0);
            }
        }

        private void SetRoundedRegion(int radius)
        {
            var bounds = new Rectangle(0, 0, this.Width, this.Height);
            using (var gp = GetRoundedRectPath(bounds, radius))
            {
                this.Region?.Dispose();
                this.Region = new Region(gp);
            }
        }

        private GraphicsPath GetRoundedRectPath(Rectangle bounds, int radius)
        {
            var diameter = radius * 2;
            var gp = new GraphicsPath();

            if (diameter > bounds.Width) diameter = bounds.Width;
            if (diameter > bounds.Height) diameter = bounds.Height;

            gp.AddArc(bounds.Left, bounds.Top, diameter, diameter, 180, 90);
            gp.AddArc(bounds.Right - diameter, bounds.Top, diameter, diameter, 270, 90);
            gp.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            gp.AddArc(bounds.Left, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            gp.CloseFigure();

            return gp;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var baglanti = VeritabaniBaglantisi.Baglan())
                {
                    baglanti.Open();
                    // Query the full user row directly using the real column names
                    string sorgu = "SELECT KullaniciID, KullaniciAdi, Sifre, `AdSoyad`, Rol, Email, fotograf FROM Kullanicilar WHERE KullaniciAdi=@kullaniciAdi AND Sifre=@sifre LIMIT 1";
                    using (var cmd = new MySqlCommand(sorgu, baglanti))
                    {
                        cmd.Parameters.AddWithValue("@kullaniciAdi", txtKullaniciAdi.Text.Trim());
                        cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Authentication successful, load session
                                try
                                {
                                    var idObj = reader["KullaniciID"];
                                    SessionManager.UserId = idObj != DBNull.Value ? Convert.ToInt32(idObj) : 0;

                                    SessionManager.Username = reader["KullaniciAdi"]?.ToString();

                                    // 'Ad Soyad' column has a space in name
                                    string adSoyad = reader["Ad Soyad"] != DBNull.Value ? reader["Ad Soyad"].ToString() : string.Empty;
                                    if (!string.IsNullOrWhiteSpace(adSoyad))
                                    {
                                        var parts = adSoyad.Split(new[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
                                        SessionManager.FirstName = parts.Length > 0 ? parts[0] : string.Empty;
                                        SessionManager.LastName = parts.Length > 1 ? parts[1] : string.Empty;
                                    }
                                    else
                                    {
                                        SessionManager.FirstName = string.Empty;
                                        SessionManager.LastName = string.Empty;
                                    }

                                    SessionManager.DisplayName = (SessionManager.FirstName + " " + SessionManager.LastName).Trim();
                                    SessionManager.Role = reader["Rol"] != DBNull.Value ? reader["Rol"].ToString() : string.Empty;
                                    SessionManager.Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : string.Empty;

                                    if (reader["fotograf"] != DBNull.Value)
                                    {
                                        try
                                        {
                                            SessionManager.AvatarBytes = (byte[])reader["fotograf"];
                                        }
                                        catch { SessionManager.AvatarBytes = null; }
                                    }
                                    else
                                    {
                                        SessionManager.AvatarBytes = null;
                                    }
                                }
                                catch { }

                                this.DialogResult = DialogResult.OK;
                                this.Close();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {
            // Toggle password visibility
            if (txtSifre.Properties.PasswordChar == '*')
            {
                txtSifre.Properties.PasswordChar = '\0';
            }
            else
            {
                txtSifre.Properties.PasswordChar = '*';
            }
        }

        private void LinkSifremiUnuttum_Click(object sender, EventArgs e)
        {
            try
            {
                using (var f = new frmSifremiUnuttum())
                {
                    var result = f.ShowDialog(this);
                    if (result == DialogResult.OK)
                    {
                        // Prefill username and password with verified values from the forgot form
                        if (!string.IsNullOrWhiteSpace(f.VerifiedEmail))
                        {
                            txtKullaniciAdi.Text = f.VerifiedEmail;
                        }
                        if (!string.IsNullOrWhiteSpace(f.VerifiedCode))
                        {
                            txtSifre.Text = f.VerifiedCode;
                            // make sure password is masked by default
                            try { txtSifre.Properties.PasswordChar = '*'; } catch { }
                        }

                        // Check DB for a user with Email = verified email (not KullaniciAdi)
                        try
                        {
                            using (var baglanti = VeritabaniBaglantisi.Baglan())
                            {
                                baglanti.Open();
                                string sorgu = "SELECT COUNT(1) FROM Kullanicilar WHERE Email = @email";
                                using (var cmd = new MySqlCommand(sorgu, baglanti))
                                {
                                    cmd.Parameters.AddWithValue("@email", f.VerifiedEmail?.Trim());
                                    var dbResult = cmd.ExecuteScalar();
                                    if (dbResult != null && Convert.ToInt32(dbResult) > 0)
                                    {
                                        // User exists — consider them authenticated because they verified email via code
                                        this.DialogResult = DialogResult.OK;
                                        this.Close();
                                        return;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Doğrulanan e-posta ile eşleşen kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Veritabanı sorgu hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        // Optionally attempt login automatically
                        // btnGiris.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Şifremi unuttum penceresi açılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
