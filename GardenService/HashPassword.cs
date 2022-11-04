using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace GardenService
{
    public class HashPassword
    {
        private byte[] saltBytes;
        private RNGCryptoServiceProvider provider;
        public string RandomPasswordGenrator()
        {
            //Store the password generated into a string variable
            //The password will have a length of 8 characters and 3 non alphanumeric characters
            return Membership.GeneratePassword(8, 3);
        }
        // Making Dictionary so that it can be returned and salt and Hashed password can be differntiated
        public Dictionary<string, string> GenerateSaltedHash(string password)
        {
            Dictionary<string, string> hashedPassword = new Dictionary<string, string>();
            byte[] saltBytes = new byte[32];
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            provider.GetNonZeroBytes(saltBytes);
            string salt = Convert.ToBase64String(saltBytes);
            // adding to dictionary so that it can be returned
            hashedPassword.Add("Salt", salt);



            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, 10000);
            string hashPassword = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(32)); //using 32 bits
            // adding to dictionary so that it can be returned
            hashedPassword.Add("HashedPassword", hashPassword);
            return hashedPassword;
        }



        public static bool ComparingPasswordToHash(string enteredPassword, string storedSalt, string hashedPassword)
        {
            byte[] saltBytes = Convert.FromBase64String(storedSalt);
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(enteredPassword, saltBytes, 10000);
            return hashedPassword == Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(32)); // using 32 bits
        }
    }
}
