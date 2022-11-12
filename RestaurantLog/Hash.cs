using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLog
{
    internal class Hash
    {
        public string sha256_hash(string password)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 sha256Hash = SHA256.Create())
            {

                byte[] sourseBytePassw = Encoding.UTF8.GetBytes(password);
                byte[] hashSourseBytePassw = sha256Hash.ComputeHash(sourseBytePassw);
                string hashPassw = BitConverter.ToString(hashSourseBytePassw).Replace("-", String.Empty);
                return hashPassw;
            }
        }
    }
}
