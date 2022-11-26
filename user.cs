using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_Login
{
    public class user
    {
        public int ID { get; init; }
        public string Login { get; set; }
        public string Pwd { get; set; }

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }

        public DateTime DateNaissance { get; set; }

        public int Grade { get; set; }

        public user(string login, string pwd)
        {
            Login = login;
            Pwd = pwd;
        }

        public user(string login, string pwd, string nom, string prenom, string mail) : this(login, pwd)
        {
            Nom = nom;
            Prenom = prenom;
            Mail = mail;
        }

        public user(string login, string pwd, string nom, string prenom, string mail, DateTime dateNaissance) : this(login, pwd, nom, prenom, mail)
        {
            DateNaissance = dateNaissance;
            
        }

        public void Ajouter() 
        {

            SqlConnection connect = new SqlConnection("Data Source=localhost;Initial Catalog=login;Integrated Security=True");
            connect.Open();
            SqlCommand insert = new SqlCommand("insert into users(Login,Pwd,Nom,Prenom,Mail,DateNaissance) values (@Login,@Pwd,@Nom,@Prenom,@Mail,@DateNaissance)", connect);
            insert.Parameters.AddWithValue("@Login", Login);
            insert.Parameters.AddWithValue("@Pwd", Pwd);
            insert.Parameters.AddWithValue("@Nom", Nom);
            insert.Parameters.AddWithValue("@Prenom", Prenom);
            insert.Parameters.AddWithValue("@Mail", Mail);
            insert.Parameters.AddWithValue("@DateNaissance", DateNaissance);
            insert.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Ajouté");

            

        }

    }
}
