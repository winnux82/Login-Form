using Form_Login;
using System.Data.SqlClient;

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

            //if (Txt_Id.Text == "" && Txt_Pass.Text == "")
            if (IsUserExist(Txt_Id.Text,Txt_Pass.Text))
                {
                //this.Dispose();
                
                IsValidLogin = true;
                Close();

                //.Show() peut reouvrir en boucle alors que ShowDialog n'ouvre qu'une fois et plus accès à l'autre
            }
            else
            {
                MessageBox.Show("Vous n'êtes pas autorisé à vous connecter !!!", "login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            labelExit.ForeColor = Color.Red;
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.ForeColor = SystemColors.ControlText;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
               //Txt_Pass.Focused = false;


        }

        private void TxtB_Pass_TextChanged(object sender, EventArgs e)
        {
            
        }

        //Soon !
        private bool IsUserExist(string User,string Pwd)
        {

            bool result = false;

            try
            {
                SqlConnection connect = new("Data Source=localhost;Initial Catalog=login;Integrated Security=True");
                SqlCommand voir = new("Select * from users", connect);
                Pwd = ListMethods.ComputeSha256Hash(Pwd);
                string sqlCheck = string.Format("SELECT * from users WHERE Login = '{0}' AND Pwd='{1}' ", User, Pwd);

                using (connect)
                {
                    using (SqlCommand sqlCmd = new(sqlCheck, connect))
                    {
                        connect.Open();
                        int dataLogin = (int)sqlCmd.ExecuteScalar();
                        connect.Close();

                        return result = (dataLogin > 0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}