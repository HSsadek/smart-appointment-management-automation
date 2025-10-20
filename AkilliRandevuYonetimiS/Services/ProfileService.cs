using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace AkilliRandevuYonetimiS.Services
{
    public class ProfileService
    {
        private const int SaltSize = 16;
        private const int HashSize = 32;
        private const int Iterations = 100_000;

        private string GetConnectionString()
            => System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        public static string HashPassword(string password)
        {
            using var rng = RandomNumberGenerator.Create();
            var salt = new byte[SaltSize];
            rng.GetBytes(salt);

            using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256);
            var hash = pbkdf2.GetBytes(HashSize);

            var result = new byte[1 + SaltSize + HashSize];
            result[0] = 0; // version
            Buffer.BlockCopy(salt, 0, result, 1, SaltSize);
            Buffer.BlockCopy(hash, 0, result, 1 + SaltSize, HashSize);
            return Convert.ToBase64String(result);
        }

        public static bool VerifyPassword(string password, string stored)
        {
            var data = Convert.FromBase64String(stored);
            if (data.Length != 1 + SaltSize + HashSize) return false;
            var salt = new byte[SaltSize];
            Buffer.BlockCopy(data, 1, salt, 0, SaltSize);
            var storedHash = new byte[HashSize];
            Buffer.BlockCopy(data, 1 + SaltSize, storedHash, 0, HashSize);

            using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256);
            var hash = pbkdf2.GetBytes(HashSize);
            return CryptographicOperations.FixedTimeEquals(hash, storedHash);
        }

        // Update AdSoyad (single column) and Email, optionally fotograf blob. Use KullaniciID as identifier.
        public async Task<bool> UpdateProfileAsync(int userId, string firstName, string lastName, string email, byte[] avatarBytes = null)
        {
            var cs = GetConnectionString();
            await using var conn = new MySqlConnection(cs);
            await conn.OpenAsync();

            await using var tx = await conn.BeginTransactionAsync();
            try
            {
                string adSoyad = (firstName ?? string.Empty).Trim() + (string.IsNullOrEmpty(lastName) ? string.Empty : " " + lastName.Trim());

                string sql = avatarBytes == null
                    ? "UPDATE Kullanicilar SET AdSoyad = @adSoyad, Email = @email WHERE KullaniciID = @kullaniciId"
                    : "UPDATE Kullanicilar SET AdSoyad = @adSoyad, Email = @email, fotograf = @avatar WHERE KullaniciID = @kullaniciId";

                await using var cmd = new MySqlCommand(sql, conn, tx);
                cmd.Parameters.AddWithValue("@adSoyad", adSoyad);
                cmd.Parameters.AddWithValue("@email", email ?? string.Empty);
                cmd.Parameters.AddWithValue("@kullaniciId", userId);
                if (avatarBytes != null)
                {
                    var p = cmd.Parameters.Add("@avatar", MySqlDbType.Blob);
                    p.Value = avatarBytes;
                }

                var affected = await cmd.ExecuteNonQueryAsync();
                await tx.CommitAsync();
                return affected > 0;
            }
            catch
            {
                await tx.RollbackAsync();
                throw;
            }
        }

        public async Task<(int userId, string storedPasswordHash)?> FindUserByEmailAsync(string email)
        {
            var cs = GetConnectionString();
            await using var conn = new MySqlConnection(cs);
            await conn.OpenAsync();
            const string sql = "SELECT KullaniciID, Sifre FROM Kullanicilar WHERE Email = @email LIMIT 1";
            await using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@email", (email ?? string.Empty).Trim());
            await using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                var idObj = reader["KullaniciID"];
                var sifreObj = reader["Sifre"];
                int id = idObj != null && idObj != DBNull.Value ? Convert.ToInt32(idObj) : 0;
                string sifre = sifreObj != null && sifreObj != DBNull.Value ? sifreObj.ToString() : string.Empty;
                return (id, sifre);
            }
            return null;
        }
    }
}