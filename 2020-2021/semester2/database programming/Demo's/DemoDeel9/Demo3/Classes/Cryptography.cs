using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.Classes
{
    public static class Cryptography
    {
        #region Private members

        private static byte[] _IV = new byte[] { 0x34, 0xAF, 0x82, 0xE5, 0x90, 0xA0, 0xB1, 0xF4, 0x34, 0xAF, 0x82, 0xE5, 0x90, 0xA0, 0xB1, 0xF4 };
        private static byte[] _key = new byte[] { 0xA2, 0x3E, 0x81, 0x4B, 0xC7, 0x37, 0xD6, 0xF5, 0xA2, 0x3E, 0x81, 0x4B, 0xC7, 0x37, 0xD6, 0xF5, 0xA2, 0x3E, 0x81, 0x4B, 0xC7, 0x37, 0xD6, 0xF5, 0xA2, 0x3E, 0x81, 0x4B, 0xC7, 0x37, 0xD6, 0xF5 };

        #endregion

        #region Public methods

        public static string EncryptString(string stringToEncrypt)
        {
            string encrypted = "";

            using (Aes aesAlgorithm = Aes.Create())
            {
                aesAlgorithm.Key = _key;
                aesAlgorithm.IV = _IV;

                ICryptoTransform encryptor = aesAlgorithm.CreateEncryptor(aesAlgorithm.Key, aesAlgorithm.IV);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(cs))
                        {
                            swEncrypt.Write(stringToEncrypt);
                            swEncrypt.Flush();
                        }
                    }

                    encrypted = Convert.ToBase64String(ms.ToArray());
                }
            }

            return encrypted;
        }

        public static string DecryptString(string stringToDecrypt)
        {
            byte[] inputByteArray = new byte[stringToDecrypt.Length];
            string plainText = null;

            using (Aes aesAlgorithm = Aes.Create())
            {
                aesAlgorithm.Key = _key;
                aesAlgorithm.IV = _IV;

                ICryptoTransform decryptor = aesAlgorithm.CreateDecryptor(aesAlgorithm.Key, aesAlgorithm.IV);
                inputByteArray = Convert.FromBase64String(stringToDecrypt);

                using (MemoryStream ms = new MemoryStream(inputByteArray))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            plainText = sr.ReadToEnd();
                        }
                    }
                }
            }

            return plainText;
        }

        #endregion
    }
}
