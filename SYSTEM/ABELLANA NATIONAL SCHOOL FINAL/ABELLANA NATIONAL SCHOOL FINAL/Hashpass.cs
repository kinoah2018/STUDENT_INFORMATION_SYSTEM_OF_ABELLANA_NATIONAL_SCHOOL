using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ABELLANA_NATIONAL_SCHOOL_FINAL
{
    class Hashpass
    {
        public string hashpass(string password)
        {
            SHA1 sha = new SHA1CryptoServiceProvider();

            //Compute hash from the bytes of text
            sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));

            //Get hash result after computing
            byte[] result = sha.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }
    }
}
