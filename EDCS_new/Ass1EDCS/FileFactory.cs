using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Ass1EDCS
{
    public class FileFactory
    {
        public static byte[] EncryptAES(byte[] input, string key)
        {
            RijndaelManaged AES = new RijndaelManaged();
            MD5CryptoServiceProvider Hash_AES = new MD5CryptoServiceProvider();
            byte[] encrypted;
            try
            {
                byte[] hash = new byte[32];
                byte[] temp = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(key));
                Array.Copy(temp, 0, hash, 0, 16);
                Array.Copy(temp, 0, hash, 15, 16);
                AES.Key = hash;
                AES.Mode = CipherMode.ECB;
                ICryptoTransform DESEncrypter = AES.CreateEncryptor();
                //byte[] Buffer = System.Text.ASCIIEncoding.UTF8.GetBytes(input);
                //encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length));
                //encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(input, 0, input.Length));
                encrypted = DESEncrypter.TransformFinalBlock(input, 0, input.Length);
                return encrypted;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        
        public static byte[] DecryptAES(byte[] input, string key)
        {
            System.Security.Cryptography.RijndaelManaged AES = new System.Security.Cryptography.RijndaelManaged();
            System.Security.Cryptography.MD5CryptoServiceProvider Hash_AES = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] decrypted;
            try
            {
                byte[] hash = new byte[32];
                byte[] temp = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(key));
                Array.Copy(temp, 0, hash, 0, 16);
                Array.Copy(temp, 0, hash, 15, 16);
                AES.Key = hash;
                AES.Mode = System.Security.Cryptography.CipherMode.ECB;
                System.Security.Cryptography.ICryptoTransform DESDecrypter = AES.CreateDecryptor();
                //byte[] Buffer = Convert.FromBase64String(input);
                //byte[] Buffer = Convert.for;
                //decrypted = System.Text.ASCIIEncoding.UTF8.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length));
                decrypted = DESDecrypter.TransformFinalBlock(input, 0, input.Length);
                return decrypted;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
