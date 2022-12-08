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

                if (!ListMethods.IsValidPassword(value))
                {
                    throw new Exceptions.InvalidPassword("Le Mot de passe est invalide !!!");
                }
                else
                {
                    _Pwd = ListMethods.ComputeSha256Hash(value);
                }
            }
        }

        private string _Nom;

        public string Nom
        {
            get { return _Nom; }
            set 
            {

                if (!ListMethods.IsNotEmptyOnlyLetters(value))
                    throw new Exceptions.InvalidLastName("Le nom doit contenir uniquement des lettres");
                else
                    _Nom = value; 
            }
        }
        private string _Prenom;

        public string Prenom
        {
            get { return _Prenom; }
            set
            {

                if (!ListMethods.IsNotEmptyOnlyLetters(value))
                    throw new Exceptions.InvalidFirstName("Le prénom doit contenir uniquement des lettres");
                else
                    _Prenom = value;
            }
        }
        private string _Mail;

        public string Mail
        {
            get { return _Mail; }
            set
            {

                if (!ListMethods.IsValidEmail(value))
                    throw new Exceptions.InvalidFirstName("L'adresse mail n'est pas correcte");
                else
                    _Mail = value;
            }
        }


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
            if (!ListMethods.IsNotEmptyOnlyLetters(Nom))
            {
                return false;
            }

            if (!ListMethods.IsNotEmptyOnlyLetters(Prenom))
            {
                return false;
            }

            if (!ListMethods.IsValidEmail(Mail))
            {
                return false;
            }

            if (DateNaissance > DateTime.Today.AddYears(-18))
            {
                return false;
            }

            if (!ListMethods.IsValidPassword(_Pwd))
            {
                return false;
            }

            return true;
        }


    }
}
