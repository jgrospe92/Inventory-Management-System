using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Identity;

namespace Inventory_Management_System.Helper
{
    public class LockPickHelper
    {
        LockPickHelper() { }


        public static string HashPassword(string password)
        {
            string hashedPassword = new PasswordHasher<object?>().HashPassword(null, password);
            return hashedPassword;
        }

        public static bool VerifyPassword(string hashedPassword, string password) 
        {
            var checkPass = new PasswordHasher<object?>().VerifyHashedPassword(null, hashedPassword, password);

            bool isMatch = false;
            switch (checkPass)
            {
                case PasswordVerificationResult.Failed:
                    Console.WriteLine("Password incorrect.");
                    isMatch = false;
                    break;
                case PasswordVerificationResult.Success:
                    isMatch = true;
                    break;
            }
            return isMatch;
        }
    }
}
