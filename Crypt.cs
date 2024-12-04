using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ATBMTT
{
    internal class Crypt
    {
        // Salt 
        private static readonly byte[] DefaultSalt = new byte[] { 0x11, 0x22, 0x33, 0x44, 0x55, 0x66, 0x77, 0x88, 0x99, 0xAA, 0xBB, 0xCC, 0xDD, 0xEE, 0xFF, 0x00 };

        // Tạo khóa từ mật khẩu và salt
        private static byte[] GenerateKey(string password, byte[] salt)
        {
            using (var keyGen = new Rfc2898DeriveBytes(password, salt, 2000))
            {
                return keyGen.GetBytes(32); // 32 bytes cho AES-256
            }
        }

        // Tạo IV từ mật khẩu và salt
        private static byte[] GenerateIV(string password, byte[] salt)
        {
            using (var ivGen = new Rfc2898DeriveBytes(password, salt, 2000))
            {
                return ivGen.GetBytes(16); // 16 bytes cho AES block size
            }
        }

        // Mã hóa dữ liệu
        public static byte[] Encrypt(string password, byte[] data, string saltInput)
        {
            byte[] salt = string.IsNullOrEmpty(saltInput) ? DefaultSalt : Encoding.UTF8.GetBytes(saltInput);
            byte[] encryptedData;

            try
            {
                using (var aes = Aes.Create())
                {
                    aes.Mode = CipherMode.CBC;
                    aes.Padding = PaddingMode.PKCS7;
                    aes.KeySize = 256;
                    aes.BlockSize = 128;

                    aes.Key = GenerateKey(password, salt);
                    aes.IV = GenerateIV(password, salt);

                    using (var memoryStream = new MemoryStream())
                    using (var cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(data, 0, data.Length);
                        cryptoStream.FlushFinalBlock();
                        encryptedData = memoryStream.ToArray();
                    }
                }
                return encryptedData;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during encryption: {ex.Message}");
                return null;
            }
        }

        // Giải mã dữ liệu
        public static byte[] Decrypt(string password, byte[] encryptedData, string saltInput)
        {
            byte[] salt = string.IsNullOrEmpty(saltInput) ? DefaultSalt : Encoding.UTF8.GetBytes(saltInput);
            byte[] decryptedData;

            try
            {
                using (var aes = Aes.Create())
                {
                    aes.Mode = CipherMode.CBC;
                    aes.Padding = PaddingMode.PKCS7;
                    aes.KeySize = 256;
                    aes.BlockSize = 128;

                    aes.Key = GenerateKey(password, salt);
                    aes.IV = GenerateIV(password, salt);

                    using (var memoryStream = new MemoryStream())
                    using (var cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(encryptedData, 0, encryptedData.Length);
                        cryptoStream.FlushFinalBlock();
                        decryptedData = memoryStream.ToArray();
                    }
                }
                return decryptedData;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during decryption: {ex.Message}");
                return null;
            }
        }
    }
}
