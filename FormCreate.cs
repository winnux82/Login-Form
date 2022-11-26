using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;
using System.Text.RegularExpressions;


namespace Form_Login
{
    public partial class FormCreate : Form
    {

        SqlConnection connect = new SqlConnection("Data Source=localhost;Initial Catalog=login;Integrated Security=True");

        public FormCreate()
        {
            InitializeComponent();
        }


        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                if(connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    MessageBox.Show("Connection établie");
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void Btn_Choix_Click(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;

            try
            {
                user newuser = new user(Txt_Login.Text, Txt_Password.Text,Txt_Nom.Text,Txt_Prenom.Text,Txt_Mail.Text,dateTimeBirthday.Value);


                if (Btn == Btn_Ajouter)
                {
                    newuser.Ajouter();
                    Actualiser();
                }
                    

            }
            catch(Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void Btn_Ajouter_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        SqlConnection connect = new SqlConnection("Data Source=localhost;Initial Catalog=login;Integrated Security=True");
        //        connect.Open();
        //        SqlCommand insert = new SqlCommand("insert into users(Login,Pwd) values (@Login,@Pwd)", connect);
        //        insert.Parameters.AddWithValue("@Login", Txt_Login.Text);
        //        insert.Parameters.AddWithValue("@Prenom", Txt_Password.Text);
        //        insert.ExecuteNonQuery();
        //        connect.Close();
        //        MessageBox.Show("Ajouté");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }


        //}

        public void Actualiser()
        {
            SqlConnection connect = new SqlConnection("Data Source=localhost;Initial Catalog=login;Integrated Security=True");
            connect.Open();
            SqlCommand voir = new SqlCommand("Select * from users", connect);
            SqlDataAdapter adapter = new SqlDataAdapter(voir);
            DataTable Dt = new DataTable();
            adapter.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void Btn_Table_Click(object sender, EventArgs e)
        {

            Actualiser();

        }
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection("Data Source=localhost;Initial Catalog=login;Integrated Security=True");
                connect.Open();
                SqlCommand update = new SqlCommand("update users set Login=@Login, Pass=@Pwd where ID=@ID", connect);
                update.Parameters.AddWithValue("@ID", Txt_ID.Text);
                update.Parameters.AddWithValue("@Login", Txt_Login.Text);
                update.Parameters.AddWithValue("@Pwd", Txt_Password.Text);
                update.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Mis à jour");
                Btn_Table_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("Data Source=localhost;Initial Catalog=login;Integrated Security=True");
            connect.Open();
            SqlCommand delete = new SqlCommand("Delete users where ID=@ID", connect);
            delete.Parameters.AddWithValue("@ID", int.Parse(Txt_ID.Text));
            delete.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Elément efffacé");
            Btn_Table_Click(sender, e);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                Txt_ID.Text = row.Cells[0].Value.ToString();
                Txt_Login.Text = row.Cells[1].Value.ToString();
                Txt_Password.Text = row.Cells[2].Value.ToString();
                Txt_Nom.Text = row.Cells[3].Value.ToString();
                Txt_Prenom.Text = row.Cells[4].Value.ToString();
                Txt_Mail.Text = row.Cells[5].Value.ToString();
                dateTimeBirthday.Value = Convert.ToDateTime(row.Cells[6].Value.ToString());

            }
        }

        private void Txt_Names_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void FormCreate_Load(object sender, EventArgs e)
        {
            Actualiser();
        }

        private void Txt_Mail_Leave(object sender, EventArgs e)
        {
            try
            {
                new System.Net.Mail.MailAddress(this.Txt_Mail.Text);
                Txt_Mail.BackColor = default(Color);
            }
            catch (ArgumentException)
            {
                //textBox is empty
            }
            catch (FormatException)
            {
                MessageBox.Show("Email non valide");
                Txt_Mail.BackColor = Color.Red;
            }
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            Txt_ID.Clear();
            Txt_ID.Visible= false;
            Lbl_ID.Visible= false;

            Txt_Login.Clear();
            Txt_Password.Clear();
            Txt_Nom.Clear();
            Txt_Prenom.Clear();
            Txt_Mail.Clear();
            dateTimeBirthday.Value = DateTime.Now;
        }

        public static bool IsValidPassword(string PwD)
        {

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            var isValidated = hasNumber.IsMatch(PwD) && hasUpperChar.IsMatch(PwD) && hasMinimum8Chars.IsMatch(PwD);
            return(isValidated);

        }

        private void Txt_Password_Leave(object sender, EventArgs e)
        {
            if(!IsValidPassword(Txt_Password.Text))
                MessageBox.Show("Password non valide");

        }
    }
}
