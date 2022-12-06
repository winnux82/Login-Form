using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//coucou
using System.Data.SqlClient;
using Microsoft.VisualBasic.Logging;

namespace Form_Login
{
    public static class userBDD
    {
        private static string _connexionString = "Data Source = localhost; Initial Catalog = login; Integrated Security = True";

        public static void AddUser(Utilisateur user)
        {
            using (SqlConnection connect = new SqlConnection(_connexionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = $"INSERT INTO users (Login,Pwd,Nom,Prenom,Mail,DateNaissance) VALUES ('{user.Login}','{user.Pwd}','{user.Nom}','{user.Prenom}','{user.Mail}','{user.DateNaissance}')";
                    cmd.Connection = connect;

                    connect.Open();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void Update(Utilisateur user)
        {
            using (SqlConnection connect = new SqlConnection(_connexionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = $"update users set Login='{user.Login}',Pwd='{user.Pwd}',Nom='{user.Nom}',Prenom='{user.Prenom}',Mail='{user.Mail}',DateNaissance='{user.DateNaissance}' where ID='{user.ID}'";
                    cmd.Connection = connect;

                    connect.Open();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Utilisateur ajouté", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void Delete(Utilisateur user)
        {
            using (SqlConnection connect = new SqlConnection(_connexionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = $"Delete users where ID='{user.ID}'";
                    cmd.Connection = connect;

                    connect.Open();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Utilisateur effacé", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}