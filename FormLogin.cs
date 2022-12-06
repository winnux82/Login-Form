using Form_Login;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

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

            if (IsUserExist(Txt_Id.Text))
            {
                //MessageBox.Show("ok");
                if(IsAccountExist(Txt_Id.Text,Txt_Pass.Text))
                {
                    //this.Dispose();
                    //this.Close();
                    
                    IsValidLogin = true;
                    this.Hide();
                }
                else
                {
                    Txt_Pass.BackColor = Color.Crimson;
                }


            } else
                MessageBox.Show("Vous n'êtes pas autorisé à vous connecter !!!", "login", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void Check_Pwd_CheckedChanged(object sender, EventArgs e)
        {
            if (Check_Pwd.Checked)
            {
                Txt_Pass.PasswordChar = '\0';
            }
            else
            {
                Txt_Pass.PasswordChar = '*';
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
            //LabelExit.ForeColor = Color.Crimson;
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            //LabelExit.ForeColor = SystemColors.ControlText;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
               //Txt_Pass.Focused = false;
        }

        //Soon !
        private bool IsUserExist(string User)
        {

            bool result = false;

            try
            {
                SqlConnection connect = new("Data Source=localhost;Initial Catalog=login;Integrated Security=True");
                //connect.Open();
                SqlCommand voir = new("Select * from users", connect);
                string sqlCheck = string.Format("SELECT * from users WHERE Login = '{0}'", User);
                using (connect)
                {
                    using (SqlCommand sqlCmd = new(sqlCheck, connect))
                    {
                        connect.Open();
                        //Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                        Int32 dataLogin = Convert.ToInt32(sqlCmd.ExecuteScalar());
                        connect.Close();
                        return result = (dataLogin > 0);
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (result)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        private bool IsAccountExist(string User, string Password)
        {
            bool result = false;

            try
            {
                SqlConnection connect = new("Data Source=localhost;Initial Catalog=login;Integrated Security=True");
                //connect.Open();
                var PwdHash = ComputeSha256Hash(Password);
                string sqlCheck = string.Format("SELECT * from users WHERE Login = '{0}' AND Pwd = '{1}'", User, PwdHash);
                using (connect)
                {
                    using (SqlCommand sqlCmd = new(sqlCheck, connect))
                    {
                        connect.Open();
                        //Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                        Int32 dataLogin = Convert.ToInt32(sqlCmd.ExecuteScalar());
                        connect.Close();
                        return result = (dataLogin > 0);
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (result)
            {
                return true;
            }
            else
            {
                return false;
            }


        }


        private void Txt_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Txt_Pass.Focus();
            }
        }

        private void Txt_Pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Btn_Valider_Click(sender, e);
            }
        }

        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            // ComputeHash - returns byte array  
            byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(rawData));

            // Convert byte array to a string   
            StringBuilder builder = new();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }
}