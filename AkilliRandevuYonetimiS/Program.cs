using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace AkilliRandevuYonetimiS {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("WXI");

            // Önce giriş formunu aç
            frmGiris girisFormu = new frmGiris();

            // Giriş formu kapanana kadar bekle ve sonucunu al
            DialogResult sonuc = girisFormu.ShowDialog();

            // EĞER giriş sonucu başarılı ise (yani DialogResult.OK ise)
            if (sonuc == DialogResult.OK)
            {
                // O zaman ana formu çalıştır
                Application.Run(new Form1());
            }
            // Eğer başarılı değilse (X ile kapatıldıysa vs.) uygulama hiçbir şey yapmadan biter.
        }
    }
}