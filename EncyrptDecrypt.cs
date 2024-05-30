using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
     class EncyrptDecrypt{
        // Change these keys
        private static readonly byte[] Key = new byte[32] { 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF, 0xFE, 0xDC, 0xBA, 0x98, 0x76, 0x54, 0x32, 0x10,
                                                          0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF, 0xFE, 0xDC, 0xBA, 0x98, 0x76, 0x54, 0x32, 0x10 };
        private static readonly byte[] IV = new byte[16] { 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF, 0xFE, 0xDC, 0xBA, 0x98, 0x76, 0x54, 0x32, 0x10 };

        public static void EncryptFile(string inputFile, string outputFile)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;

                using (FileStream fsInput = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
                using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
                using (ICryptoTransform encryptor = aes.CreateEncryptor())
                using (CryptoStream cryptoStream = new CryptoStream(fsOutput, encryptor, CryptoStreamMode.Write))
                {
                    fsInput.CopyTo(cryptoStream);
                }
            }
        }

        public static void DecryptFile(string inputFile, string outputFile)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;

                using (FileStream fsInput = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
                using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
                using (ICryptoTransform decryptor = aes.CreateDecryptor())
                using (CryptoStream cryptoStream = new CryptoStream(fsInput, decryptor, CryptoStreamMode.Read))
                {
                    cryptoStream.CopyTo(fsOutput);
                }
            }
        }

        public static void EncryptFolder(string folderPath)
        {
            string[] files = Directory.GetFiles(folderPath);
            foreach (string file in files)
            {
                string encryptedFile = Path.Combine(folderPath, Path.GetFileNameWithoutExtension(file) + "_encrypted" + Path.GetExtension(file));
                EncryptFile(file, encryptedFile);
                File.Delete(file);

            }
        }

        public static void DecryptFolder(string folderPath)
        {
            string[] files = Directory.GetFiles(folderPath);
            foreach (string file in files)
            {
                if (Path.GetFileName(file).Contains("_encrypted"))
                {
                    string decryptedFile = Path.Combine(folderPath, Path.GetFileNameWithoutExtension(file).Replace("_encrypted", "") + Path.GetExtension(file));
                    DecryptFile(file, decryptedFile);
                    File.Delete(file);

                }
            }
        }
        public static void ManualDecryptFolder(string folderPath) {
            string[] files = Directory.GetFiles(folderPath);
            foreach (string file in files) {
                string decryptedFile = Path.Combine(folderPath, Path.GetFileNameWithoutExtension(file).Replace("_encrypted", "") + Path.GetExtension(file));
                DecryptFile(file, decryptedFile);
                File.Delete(file);
            }
        }

    }
}
