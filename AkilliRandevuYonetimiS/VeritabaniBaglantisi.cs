using MySql.Data.MySqlClient;
using System.Configuration;

namespace AkilliRandevuYonetimiS
{
    public class VeritabaniBaglantisi
    {
        // Bu fonksiyon, App.config dosyasından bağlantı bilgisini okur ve bize hazır bir bağlantı nesnesi verir.
        public static MySqlConnection Baglan()
        {
            // App.config dosyasındaki "MyConnectionString" isimli bağlantı bilgisini alıyoruz.
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            // Yeni bir MySQL bağlantısı oluşturup geri döndürüyoruz.
            MySqlConnection baglanti = new MySqlConnection(connectionString);
            return baglanti;
        }
    }
}