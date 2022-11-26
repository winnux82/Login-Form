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
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;
using TextBox = System.Windows.Forms.TextBox;
using System.Reflection;

namespace Form_Login
{
    public partial class FormCreate : Form
    {
        readonly SqlConnection connect = new("Data Source=localhost;Initial Catalog=login;Integrated Security=True");
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
                    Btn_Connect.Enabled= false;
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void Btn_Choix_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button Btn = (System.Windows.Forms.Button)sender;

            try
            {
                int verifid;
                if(Txt_ID.Text=="")
                {
                    verifid= 0;
                }
                else
                {
                    verifid = int.Parse(Txt_ID.Text);
                }

                Utilisateur DataUser = new(verifid, Txt_Login.Text, Txt_Password.Text,Txt_Nom.Text,Txt_Prenom.Text,Txt_Mail.Text,dateTimeBirthday.Value);


                if (Btn == Btn_Ajouter)
                {
                    if (Lbl_V.Visible)
                    {
                        VerifierData();
                        DataUser.Ajouter();
                        Actualiser();
                    }
                    else
                        MessageBox.Show("Veuillez remplir correctement les champs mot de passe");
                    

                }
                    
                if (Btn == Btn_Update) 
                {
                    if (Lbl_V.Visible)
                    {
                        DataUser.Update();
                        Actualiser();

                    }
                    else
                        MessageBox.Show("Veuillez remplir correctement les champs mot de passe");
                }
                if (Btn== Btn_Delete)
                {
                    if (MessageBox.Show(this, "Etes-vous sûr ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        //Action si l'utilisateur est sûr
                        DataUser.Delete();
                        Actualiser();
                    }

                }

            }
            catch(Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Actualiser()
        {
            SqlConnection connect = new("Data Source=localhost;Initial Catalog=login;Integrated Security=True");
            connect.Open();
            SqlCommand voir = new("Select * from users", connect);
            SqlDataAdapter adapter = new(voir);
            DataTable Dt = new  ();
            adapter.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                Txt_ID.Text = row.Cells[0].Value.ToString();
                Txt_Login.Text = row.Cells[1].Value.ToString();
                Txt_Password.Text = row.Cells[2].Value.ToString();
                Txt_Password2.Text = row.Cells[2].Value.ToString();
                Txt_Nom.Text = row.Cells[3].Value.ToString();
                Txt_Prenom.Text = row.Cells[4].Value.ToString();
                Txt_Mail.Text = row.Cells[5].Value.ToString();
                try
                {
                    dateTimeBirthday.Value = Convert.ToDateTime(row.Cells[6].Value.ToString());
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Txt_Names_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void FormCreate_Load(object sender, EventArgs e)
        {
            Txt_Password.UseSystemPasswordChar = true;
            this.CenterToScreen(); 
            Actualiser();
            ToutEffacer();
            Txt_ID_TextChanged(sender, e);
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

        private void ToutEffacer()
        {
            Txt_ID.Clear();
            Txt_ID.Visible = false;
            Lbl_ID.Visible = false;

            Txt_Login.Clear();
            Txt_Password.Clear();
            Txt_Password2.Clear();

            Txt_Nom.Clear();
            Txt_Prenom.Clear();
            Txt_Mail.Clear();
            dateTimeBirthday.Value = DateTime.Now;
        }
        private void VerifierData()
        {
            if(Txt_Login.Text=="")
            {
                MessageBox.Show("Login Vide");
            }
            if (Txt_Nom.Text == "")
            {
                MessageBox.Show("Nom Vide");
            }

        }
        private void Btn_New_Click(object sender, EventArgs e)
        {
            ToutEffacer();
        }




        private void formfeatures(TextBox pwf1, TextBox pwf2)
        {
            Lbl_V.Visible = pwf1.Text.Length > 0 && pwf2.Text.Equals(pwf1.Text);

        }

        private void Txt_Password_TextChanged(object sender, EventArgs e)
        {
            formfeatures(Txt_Password, Txt_Password2);
            //Stop
            decimal passwordStrength = Convert.ToDecimal(Txt_Password.Text.Length * 2.5);

            Dictionary<string, int> count = new Dictionary<string, int>();
            count.Add("lowercase", 0);
            count.Add("uppercase", 0);
            count.Add("numbers", 0);
            count.Add("symbols", 0);

            for (int x = 0; x < Txt_Password.Text.Length; x++)
            {
                if (char.IsLetter(Txt_Password.Text[x]) & char.IsLower(Txt_Password.Text[x]))
                {
                    count["lowercase"] += 1;
                }
                if (char.IsLetter(Txt_Password.Text[x]) & char.IsUpper(Txt_Password.Text[x]))
                {
                    count["uppercase"] += 1;
                }
                if (char.IsDigit(Txt_Password.Text[x]))
                {
                    count["numbers"] += 1;
                }
                if (char.IsSymbol(Txt_Password.Text[x]) | char.IsPunctuation(Txt_Password.Text[x]))
                {
                    count["symbols"] += 1;
                }
            }

            int c = 0;
            foreach (KeyValuePair<string, int> kvp in count)
            {
                c += (kvp.Value > 0) ? 1 : 0;
            }

            passwordStrength += ((c == 2) ? 20 : ((c == 3) ? 30 : ((c == 4) ? 50 : 0)));

            if (passwordStrength > 0M)
            {

                Bitmap img = new(300, 20);
                Graphics gr = Graphics.FromImage(img);
                gr.Clear(SystemColors.Control);

                Color color = ((passwordStrength < 50M) ? Color.IndianRed : ((passwordStrength < 85M) ? Color.GreenYellow : Color.Gold));
                LinearGradientBrush brush = new(new Rectangle(Point.Empty, new Size(Convert.ToInt32(passwordStrength * 3 + 50), 20)), color, SystemColors.Control, LinearGradientMode.Horizontal);
                gr.FillRectangle(brush, new Rectangle(Point.Empty, new Size(Convert.ToInt32(passwordStrength * 3 + 50), 20)));
                gr.DrawString(((passwordStrength < 50M) ? "Insuffisant" : ((passwordStrength < 85M) ? "Suffisant" : "Excellent")), this.Font, Brushes.Black, 6, 3);

                PictureBox1.Image = img;
            }
            else
            {
                PictureBox1.Image = null;
            }
        }

        private void Txt_Password2_TextChanged(object sender, EventArgs e)
        {
            formfeatures(Txt_Password, Txt_Password2);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Txt_Password.UseSystemPasswordChar = !checkBox1.Checked;
            Txt_Password2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        public static bool IsValidPassword(string PwD)
        {

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            var isValidated = hasNumber.IsMatch(PwD) && hasUpperChar.IsMatch(PwD) && hasMinimum8Chars.IsMatch(PwD);
            return (isValidated);

        }

        private void Txt_Password2_Leave(object sender, EventArgs e)
        {
            if (!IsValidPassword(Txt_Password.Text))
                MessageBox.Show("Password non valide!\n il faut au moins 8 caractères!");

        }

        private void Txt_Nom_Leave(object sender, EventArgs e)
        {
            if (Txt_Nom.Text == "")
            {
                Txt_Nom.BackColor = Color.Crimson;
                MessageBox.Show("Le champ nom ne peut être vide");
                Txt_Nom.Focus();
            }
            else
                Txt_Nom.BackColor = Color.Chartreuse;
        }
        private void Txt_Prenom_Leave(object sender, EventArgs e)
        {
            if (Txt_Prenom.Text == "")
            {
                Txt_Prenom.BackColor = Color.Crimson;
                MessageBox.Show("Le champ prénom ne peut être vide");
                Txt_Prenom.Focus();

            }
            else
                Txt_Prenom.BackColor = Color.Chartreuse;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Txt_ID_TextChanged(object sender, EventArgs e)
        {
            if (Txt_ID.Text == "")
            {
                Btn_Delete.Enabled = false;
                Btn_Update.Enabled = false;
                Btn_Ajouter.Enabled = true;
            }

            else
            {
                Btn_Ajouter.Enabled = false;
                Btn_Delete.Enabled=true;
                Btn_Update.Enabled=true;
            }
                
        }
    }
}
