using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Net.Mail;

namespace Form_Login
{
    public static class ListMethods
    {
        public static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            // ComputeHash - returns byte array  
            byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(rawData));

            // Convert byte array to a string   
            StringBuilder builder = new();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("X"));
            }
            return builder.ToString();
        }


        public static bool IsValidPassword(string password)
        {

            if (password.Length < 8)
                return false;

            bool ExistUpper = false;
            bool ExistDigit = false;
            int nbDigits = 0;
            bool TwoDigits = false;

            foreach (char caractere in password)
            {
                if (char.IsUpper(caractere))
                    ExistUpper = true;

                if (char.IsDigit(caractere))
                    nbDigits++;
                ExistDigit = true;
            }
            if (nbDigits >= 2)
                return TwoDigits = true;

            return ExistUpper && ExistDigit && TwoDigits;

        }
        public static bool IsNotEmptyOnlyLetters(string s)
        {
            if (string.IsNullOrEmpty(s))
                return false;

            foreach (char caractere in s)
            {
                if (!char.IsLetter(caractere))
                    return false;
            }

            return true;
        }
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            try
            {
                MailAddress address = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }

        }


    }
}
