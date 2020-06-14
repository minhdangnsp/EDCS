using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Ass1EDCS
{
    public class MD5CheckSum
    {
        public static string MD5Check(byte[] input)
        {
            MD5 test = MD5.Create();
            byte[] arCode = test.ComputeHash(input);
            string strMD5 = "";
            foreach (byte by in arCode)
            {
                strMD5 += by.ToString("x2");
            }
            return strMD5;
        }
    }
}
