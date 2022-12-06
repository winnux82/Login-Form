using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Form_Login
{
    public class Utilisateur
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string Pwd { get; set; }

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

        public Utilisateur(int id,
                           string login,
                           string pwd,
                           string nom,
                           string prenom,
                           string mail) : this(id, login, pwd)
        {
            Nom = nom;
            Prenom = prenom;
            Mail = mail;
        }

        public Utilisateur(int id, string login, string pwd, string nom, string prenom, string mail, DateTime dateNaissance) : this(id, login, pwd, nom, prenom, mail)
        {
            DateNaissance = dateNaissance;
        }

        public void Ajouter()
        {
            //using (SqlConnection conn = new SqlConnection("Server=DESKTOP-DE6QBNP\\SQLEXPRESS;Database=Login;Trusted_Connection=True;MultipleActiveResultSets=true"))

            using (SqlConnection connect = new SqlConnection("Data Source=localhost;Initial Catalog=login;Integrated Security=True"))

            {
                try
                {
                    connect.Open();
                    //using (SqlCommand cmd = new SqlCommand($"INSERT INTO Utilisateurs (Nom, Prenom, DateNaissance, Mail) VALUES ('{tbxNom.Text}','{tbxPrenom.Text}','{dtpNaissance.Value}', '{tbxMail.Text}');SELECT SCOPE_IDENTITY()", conn))
                    using (SqlCommand insert = new("insert into users(Login,Pwd,Nom,Prenom,Mail,DateNaissance) values (@Login,@Pwd,@Nom,@Prenom,@Mail,@DateNaissance)", connect))
                    {
                        //int IdUtilisateur = Convert.ToInt32(cmd.ExecuteScalar());
                        //cmd.CommandText = $"INSERT INTO Connexions (IdUtilisateur, Identifiant, Password) VALUES ({IdUtilisateur},'{tbxPrenom.Text}','{tbxPassword.Text}')";
                        //cmd.ExecuteNonQuery();
                        insert.Parameters.AddWithValue("@Login", Login);
                        insert.Parameters.AddWithValue("@Pwd", Pwd);
                        insert.Parameters.AddWithValue("@Nom", Nom);
                        insert.Parameters.AddWithValue("@Prenom", Prenom);
                        insert.Parameters.AddWithValue("@Mail", Mail);
                        insert.Parameters.AddWithValue("@DateNaissance", DateNaissance);
                        insert.ExecuteNonQuery();
                        connect.Close();
                        MessageBox.Show("Utilisateur ajouté", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public void Update()
    {
        try
        {
            SqlConnection connect = new("Data Source=localhost;Initial Catalog=login;Integrated Security=True");
            connect.Open();
            SqlCommand update = new("update users set Login=@Login, Pwd=@Pwd, Nom=@Nom, Prenom=@Prenom, Mail=@Mail, DateNaissance=@DateNaissance where ID=@ID", connect);
            update.Parameters.AddWithValue("@ID", ID);
            update.Parameters.AddWithValue("@Login", Login);
            update.Parameters.AddWithValue("@Pwd", Pwd);
            update.Parameters.AddWithValue("@Nom", Nom);
            update.Parameters.AddWithValue("@Prenom", Prenom);
            update.Parameters.AddWithValue("@Mail", Mail);
            update.Parameters.AddWithValue("@DateNaissance", DateNaissance);
            update.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Informations utilisateur mis à jour", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void Delete()
    {
        SqlConnection connect = new("Data Source=localhost;Initial Catalog=login;Integrated Security=True");
        connect.Open();
        SqlCommand delete = new("Delete users where ID=@ID", connect);
        delete.Parameters.AddWithValue("@ID", ID);
        delete.ExecuteNonQuery();
        connect.Close();
        MessageBox.Show("Utilisateur effacé", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
}
}