using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace app
{
    public class AESHelper
    {
        public static void EncryptFile(string inFile, string outFile)
        {
            Aes aes = Aes.Create();
            ICryptoTransform transform = aes.CreateEncryptor();

            //string inFile = ApplicationUser.AccountFilePath!;
            //string outFile = ApplicationUser.AccountFilePathEnc!;

            using var outFS = new FileStream(outFile, FileMode.Create);

            var keyLength = aes.Key.Length;
            var ivLength = aes.IV.Length;
            var keyLengthB = BitConverter.GetBytes(keyLength);
            var ivLengthB = BitConverter.GetBytes(ivLength);

            // write length of key and iv
            outFS.Write(keyLengthB, 0, 4);
            outFS.Write(ivLengthB, 0, 4);
            // write key and iv
            outFS.Write(aes.Key);
            outFS.Write(aes.IV);

            using var outStreamEncrypted = new CryptoStream(outFS, transform, CryptoStreamMode.Write);

            int count = 0;
            int offset = 0;

            int blockSizeBytes = aes.BlockSize / 8;
            byte[] data = new byte[blockSizeBytes];
            int bytesRead = 0;

            using (var inFs = new FileStream(inFile, FileMode.Open))
            {
                do
                {
                    count = inFs.Read(data, 0, blockSizeBytes);
                    offset += count;
                    outStreamEncrypted.Write(data, 0, count);
                    bytesRead += blockSizeBytes;
                } while (count > 0);
            }
            outStreamEncrypted.FlushFinalBlock();

            FileManager.DeleteFile(inFile);
        }

        public static void DecryptFile(string inFile, string outFile)
        {
            Aes aes = Aes.Create();

            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];

            //string inFile = ApplicationUser.AccountFilePathEnc!;
            //string outFile = ApplicationUser.AccountFilePath!;

            using (var inFs = new FileStream(inFile, FileMode.Open))
            {
                inFs.Seek(0, SeekOrigin.Begin);
                inFs.Read(LenK, 0, 3);
                inFs.Seek(4, SeekOrigin.Begin);
                inFs.Read(LenIV, 0, 3);

                int lenK = BitConverter.ToInt32(LenK, 0);
                int lenIV = BitConverter.ToInt32(LenIV, 0);

                int startC = lenK + lenIV + 8;
                int lenC = (int)inFs.Length - startC;

                byte[] key = new byte[lenK];
                byte[] IV = new byte[lenIV];

                inFs.Seek(8, SeekOrigin.Begin);
                inFs.Read(key, 0, lenK);
                inFs.Seek(8 + lenK, SeekOrigin.Begin);
                inFs.Read(IV, 0, lenIV);


                ICryptoTransform transform = aes.CreateDecryptor(key, IV);

                using var outFs = new FileStream(outFile, FileMode.Create);
                int count = 0;
                int offset = 0;

                // blockSizeBytes can be any arbitrary size.
                int blockSizeBytes = aes.BlockSize / 8;
                byte[] data = new byte[blockSizeBytes];

                inFs.Seek(startC, SeekOrigin.Begin);
                using var outStreamDecrypted =
                    new CryptoStream(outFs, transform, CryptoStreamMode.Write);
                do
                {
                    count = inFs.Read(data, 0, blockSizeBytes);
                    offset += count;
                    outStreamDecrypted.Write(data, 0, count);
                } while (count > 0);

                outStreamDecrypted.FlushFinalBlock();
            }

            FileManager.DeleteFile(inFile);
        }
    }

    
}