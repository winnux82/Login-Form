using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Form_Login
{
    public class Utilisateur
    {
        public int ID { get; set; }
        public string Login { get; set; }

        private string _Pwd;
        public string Pwd
        {
            get { return _Pwd; }
            set
            {

                if (!IsValidPassword(value))
                {
                    throw new Exceptions.UserInvalidPassword("Le Mot de passe est invalide !!!");
                }
                else
                {
                    _Pwd = ListMethods.ComputeSha256Hash(value);
                }
            }
        }
        //public string Pwd { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }

        public DateTime DateNaissance { get; set; }

        public int Grade { get; set; }

        public Utilisateur(int id, string login, string pwd)
        {
            ID = id;
            Login = login;
            Pwd = pwd;
        }

        public Utilisateur(int id,string login, string pwd, string nom, string prenom, string mail) : this(id,login, pwd)
        {
            Nom = nom;
            Prenom = prenom;
            Mail = mail;
        }

        public Utilisateur(int id,string login, string pwd, string nom, string prenom, string mail, DateTime dateNaissance) : this(id,login, pwd, nom, prenom, mail)
        {

            DateNaissance = dateNaissance;

        }


        public bool IsValidUser()
        {
            if (!IsNotEmptyOnlyLetters(Nom))
            {
                return false;
            }

            if (!IsNotEmptyOnlyLetters(Prenom))
            {
                return false;
            }

            if (!IsValidEmail(Mail))
            {
                return false;
            }

            if (DateNaissance > DateTime.Today.AddYears(-18))
            {
                return false;
            }

            if (!IsValidPassword(_Pwd))
            {
                return false;
            }

            return true;
        }
        private bool IsValidPassword(string pass)
        {

            if (pass.Length < 8)
                return false;

            bool ExistUpper = false;
            bool ExistDigit = false;

            foreach (char caractere in pass)
            {
                if (char.IsUpper(caractere))
                    ExistUpper = true;

                if (char.IsDigit(caractere))
                    ExistDigit = true;
            }

            return ExistUpper && ExistDigit;

        }
        private bool IsNotEmptyOnlyLetters(string s)
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
        private bool IsValidEmail(string email)
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
