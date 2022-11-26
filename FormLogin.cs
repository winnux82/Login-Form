using Form_Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculatrice
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public bool IsValidLogin { get; private set; }
        private void Btn_Valider_Click(object sender, EventArgs e)
        {

            if (TxtB_Id.Text == "" && TxtB_Pass.Text == "")
            {
                //this.Dispose();
                //this.Close();
                IsValidLogin = true;
                Close();

                //.Show() peut reouvrir en boucle alors que ShowDialog n'ouvre qu'une fois et plus accès à l'autre
            }
            else
            {
                MessageBox.Show("Vous n'êtes pas autorisé à vous connecter !!!", "login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtB_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                TxtB_Pass.Focus();
            }
        }

        private void TxtB_Pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Btn_Valider_Click(sender, e);
            }
            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                TxtB_Pass.PasswordChar = '\0';
            }
            else
            { TxtB_Pass.PasswordChar = '*';
            }

            //TxtB_Pass.UseSystemPasswordChar = !checkBox1.Checked;

        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            new FormCreate().ShowDialog();
            this.Hide();
            this.Dispose();
        }

        private void Lbl_Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Lbl_Exit_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelExit_MouseHover(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.Red;
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.ForeColor = SystemColors.ControlText;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            
        }

        private void TxtB_Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtB_Id_TextChanged(object sender, EventArgs e)
        {

        }

        //Soon !
        private void IsUserExist(string User)
        {

            bool result = false;

            try
            {
                SqlConnection connect = new("Data Source=localhost;Initial Catalog=login;Integrated Security=True");
                connect.Open();
                SqlCommand voir = new("Select * from users", connect);


                string sqlCheck = string.Format("SELECT * from users WHERE Login = '{0}'", User);

                using (connect)
                {
                    using (SqlCommand sqlCmd = new SqlCommand(sqlCheck, connect))
                    {
                        connect.Open();
                        int dataLogin = (int)sqlCmd.ExecuteScalar();
                        connect.Close();

                        result = (dataLogin > 0);
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
            }

            if (result)
            {
                MessageBox.Show("L'utilisateur existe");
            }
            else
            {
                MessageBox.Show("L'utilsateur n'existe pas");
            }
        }
    }
}