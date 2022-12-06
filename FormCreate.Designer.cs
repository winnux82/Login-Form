namespace Form_Login
{
    partial class FormCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreate));
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_Connect = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_New = new System.Windows.Forms.Button();
            this.Lbl_Titre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.Lbl_Nom = new System.Windows.Forms.Label();
            this.Lbl_Prenom = new System.Windows.Forms.Label();
            this.dateTimeBirthday = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Birthday = new System.Windows.Forms.Label();
            this.Lbl_Login = new System.Windows.Forms.Label();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.Txt_Nom = new System.Windows.Forms.TextBox();
            this.Txt_Prenom = new System.Windows.Forms.TextBox();
            this.Txt_Login = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Btn_Ajouter = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Lbl_Mail = new System.Windows.Forms.Label();
            this.Txt_Mail = new System.Windows.Forms.TextBox();
            this.Lbl_Confim = new System.Windows.Forms.Label();
            this.Txt_Password2 = new System.Windows.Forms.TextBox();
            this.Lbl_V = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Check_Pwd = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Exit.BackgroundImage")));
            this.Btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Exit.Location = new System.Drawing.Point(560, 329);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(87, 86);
            this.Btn_Exit.TabIndex = 99;
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Location = new System.Drawing.Point(534, 130);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(115, 62);
            this.Btn_Connect.TabIndex = 50;
            this.Btn_Connect.Text = "Vérifier Connection";
            this.Btn_Connect.UseVisualStyleBackColor = true;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(9, 429);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowTemplate.Height = 25;
            this.DataGridView1.Size = new System.Drawing.Size(640, 180);
            this.DataGridView1.TabIndex = 16;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // Btn_New
            // 
            this.Btn_New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_New.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_New.ForeColor = System.Drawing.Color.White;
            this.Btn_New.Location = new System.Drawing.Point(534, 60);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(115, 62);
            this.Btn_New.TabIndex = 40;
            this.Btn_New.Text = "Nouvel utilisateur";
            this.Btn_New.UseVisualStyleBackColor = false;
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // Lbl_Titre
            // 
            this.Lbl_Titre.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Titre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Titre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Lbl_Titre.Location = new System.Drawing.Point(0, 20);
            this.Lbl_Titre.Name = "Lbl_Titre";
            this.Lbl_Titre.Size = new System.Drawing.Size(671, 23);
            this.Lbl_Titre.TabIndex = 33;
            this.Lbl_Titre.Text = "Gestion des utilisateurs";
            this.Lbl_Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Lbl_Titre);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 56);
            this.panel1.TabIndex = 100;
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Location = new System.Drawing.Point(10, 15);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(18, 15);
            this.Lbl_ID.TabIndex = 33;
            this.Lbl_ID.Text = "ID";
            this.Lbl_ID.Visible = false;
            // 
            // Lbl_Nom
            // 
            this.Lbl_Nom.AutoSize = true;
            this.Lbl_Nom.Location = new System.Drawing.Point(10, 41);
            this.Lbl_Nom.Name = "Lbl_Nom";
            this.Lbl_Nom.Size = new System.Drawing.Size(34, 15);
            this.Lbl_Nom.TabIndex = 34;
            this.Lbl_Nom.Text = "Nom";
            // 
            // Lbl_Prenom
            // 
            this.Lbl_Prenom.AutoSize = true;
            this.Lbl_Prenom.Location = new System.Drawing.Point(10, 66);
            this.Lbl_Prenom.Name = "Lbl_Prenom";
            this.Lbl_Prenom.Size = new System.Drawing.Size(49, 15);
            this.Lbl_Prenom.TabIndex = 35;
            this.Lbl_Prenom.Text = "Prénom";
            // 
            // dateTimeBirthday
            // 
            this.dateTimeBirthday.Location = new System.Drawing.Point(117, 92);
            this.dateTimeBirthday.Name = "dateTimeBirthday";
            this.dateTimeBirthday.Size = new System.Drawing.Size(200, 23);
            this.dateTimeBirthday.TabIndex = 42;
            // 
            // Lbl_Birthday
            // 
            this.Lbl_Birthday.AutoSize = true;
            this.Lbl_Birthday.Location = new System.Drawing.Point(10, 100);
            this.Lbl_Birthday.Name = "Lbl_Birthday";
            this.Lbl_Birthday.Size = new System.Drawing.Size(101, 15);
            this.Lbl_Birthday.TabIndex = 36;
            this.Lbl_Birthday.Text = "Date de naissance";
            // 
            // Lbl_Login
            // 
            this.Lbl_Login.AutoSize = true;
            this.Lbl_Login.Location = new System.Drawing.Point(10, 164);
            this.Lbl_Login.Name = "Lbl_Login";
            this.Lbl_Login.Size = new System.Drawing.Size(37, 15);
            this.Lbl_Login.TabIndex = 37;
            this.Lbl_Login.Text = "Login";
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(10, 196);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(57, 15);
            this.Lbl_Password.TabIndex = 38;
            this.Lbl_Password.Text = "Password";
            // 
            // Txt_ID
            // 
            this.Txt_ID.Location = new System.Drawing.Point(117, 12);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(200, 23);
            this.Txt_ID.TabIndex = 39;
            this.Txt_ID.Visible = false;
            // 
            // Txt_Nom
            // 
            this.Txt_Nom.Location = new System.Drawing.Point(117, 38);
            this.Txt_Nom.Name = "Txt_Nom";
            this.Txt_Nom.Size = new System.Drawing.Size(200, 23);
            this.Txt_Nom.TabIndex = 40;
            this.Txt_Nom.TextChanged += new System.EventHandler(this.Txt_Nom_Leave);
            this.Txt_Nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Names_KeyPress);
            this.Txt_Nom.Leave += new System.EventHandler(this.Txt_Nom_Leave);
            // 
            // Txt_Prenom
            // 
            this.Txt_Prenom.Location = new System.Drawing.Point(117, 63);
            this.Txt_Prenom.Name = "Txt_Prenom";
            this.Txt_Prenom.Size = new System.Drawing.Size(200, 23);
            this.Txt_Prenom.TabIndex = 41;
            this.Txt_Prenom.TextChanged += new System.EventHandler(this.Txt_Prenom_Leave);
            //this.Txt_Prenom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Prenom_KeyDown);
            this.Txt_Prenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Names_KeyPress);
            this.Txt_Prenom.Leave += new System.EventHandler(this.Txt_Prenom_Leave);
            // 
            // Txt_Login
            // 
            this.Txt_Login.Location = new System.Drawing.Point(117, 161);
            this.Txt_Login.Name = "Txt_Login";
            this.Txt_Login.Size = new System.Drawing.Size(200, 23);
            this.Txt_Login.TabIndex = 44;
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(117, 193);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(200, 23);
            this.Txt_Password.TabIndex = 45;
            this.Txt_Password.TextChanged += new System.EventHandler(this.Txt_Password_TextChanged);
            // 
            // Btn_Ajouter
            // 
            this.Btn_Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Btn_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ajouter.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Ajouter.ForeColor = System.Drawing.Color.White;
            this.Btn_Ajouter.Location = new System.Drawing.Point(46, 313);
            this.Btn_Ajouter.Name = "Btn_Ajouter";
            this.Btn_Ajouter.Size = new System.Drawing.Size(80, 32);
            this.Btn_Ajouter.TabIndex = 52;
            this.Btn_Ajouter.Text = "Ajouter";
            this.Btn_Ajouter.UseVisualStyleBackColor = false;
            this.Btn_Ajouter.Click += new System.EventHandler(this.Btn_Choix_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Update.ForeColor = System.Drawing.Color.White;
            this.Btn_Update.Location = new System.Drawing.Point(151, 313);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(80, 32);
            this.Btn_Update.TabIndex = 53;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Choix_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Delete.ForeColor = System.Drawing.Color.White;
            this.Btn_Delete.Location = new System.Drawing.Point(264, 313);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(80, 32);
            this.Btn_Delete.TabIndex = 54;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Choix_Click);
            // 
            // Lbl_Mail
            // 
            this.Lbl_Mail.AutoSize = true;
            this.Lbl_Mail.Location = new System.Drawing.Point(10, 124);
            this.Lbl_Mail.Name = "Lbl_Mail";
            this.Lbl_Mail.Size = new System.Drawing.Size(30, 15);
            this.Lbl_Mail.TabIndex = 48;
            this.Lbl_Mail.Text = "Mail";
            // 
            // Txt_Mail
            // 
            this.Txt_Mail.Location = new System.Drawing.Point(117, 121);
            this.Txt_Mail.Name = "Txt_Mail";
            this.Txt_Mail.Size = new System.Drawing.Size(200, 23);
            this.Txt_Mail.TabIndex = 43;
            this.ToolTip1.SetToolTip(this.Txt_Mail, "8 caractères minimum, 1 majuscule & 1 chiffre minimum");
            this.Txt_Mail.Leave += new System.EventHandler(this.Txt_Mail_Leave);
            // 
            // Lbl_Confim
            // 
            this.Lbl_Confim.AutoSize = true;
            this.Lbl_Confim.Location = new System.Drawing.Point(10, 224);
            this.Lbl_Confim.Name = "Lbl_Confim";
            this.Lbl_Confim.Size = new System.Drawing.Size(104, 15);
            this.Lbl_Confim.TabIndex = 49;
            this.Lbl_Confim.Text = "Confirm Password";
            // 
            // Txt_Password2
            // 
            this.Txt_Password2.Location = new System.Drawing.Point(117, 221);
            this.Txt_Password2.Name = "Txt_Password2";
            this.Txt_Password2.Size = new System.Drawing.Size(200, 23);
            this.Txt_Password2.TabIndex = 46;
            this.Txt_Password2.TextChanged += new System.EventHandler(this.Txt_Password_TextChanged);
            // 
            // Lbl_V
            // 
            this.Lbl_V.AutoSize = true;
            this.Lbl_V.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_V.Location = new System.Drawing.Point(323, 221);
            this.Lbl_V.Name = "Lbl_V";
            this.Lbl_V.Size = new System.Drawing.Size(21, 21);
            this.Lbl_V.TabIndex = 50;
            this.Lbl_V.Text = "V";
            this.Lbl_V.Visible = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBox1.Location = new System.Drawing.Point(117, 275);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(200, 25);
            this.PictureBox1.TabIndex = 51;
            this.PictureBox1.TabStop = false;
            // 
            // Check_Pwd
            // 
            this.Check_Pwd.AutoSize = true;
            this.Check_Pwd.Location = new System.Drawing.Point(163, 250);
            this.Check_Pwd.Name = "Check_Pwd";
            this.Check_Pwd.Size = new System.Drawing.Size(131, 19);
            this.Check_Pwd.TabIndex = 47;
            this.Check_Pwd.Text = "Voir le mot de passe";
            this.Check_Pwd.UseVisualStyleBackColor = true;
            this.Check_Pwd.CheckedChanged += new System.EventHandler(this.Check_Pwd_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.Check_Pwd);
            this.panel2.Controls.Add(this.PictureBox1);
            this.panel2.Controls.Add(this.Lbl_V);
            this.panel2.Controls.Add(this.Txt_Password2);
            this.panel2.Controls.Add(this.Lbl_Confim);
            this.panel2.Controls.Add(this.Txt_Mail);
            this.panel2.Controls.Add(this.Lbl_Mail);
            this.panel2.Controls.Add(this.Btn_Delete);
            this.panel2.Controls.Add(this.Btn_Update);
            this.panel2.Controls.Add(this.Btn_Ajouter);
            this.panel2.Controls.Add(this.Txt_Password);
            this.panel2.Controls.Add(this.Txt_Login);
            this.panel2.Controls.Add(this.Txt_Prenom);
            this.panel2.Controls.Add(this.Txt_Nom);
            this.panel2.Controls.Add(this.Txt_ID);
            this.panel2.Controls.Add(this.Lbl_Password);
            this.panel2.Controls.Add(this.Lbl_Login);
            this.panel2.Controls.Add(this.Lbl_Birthday);
            this.panel2.Controls.Add(this.dateTimeBirthday);
            this.panel2.Controls.Add(this.Lbl_Prenom);
            this.panel2.Controls.Add(this.Lbl_Nom);
            this.panel2.Controls.Add(this.Lbl_ID);
            this.panel2.Location = new System.Drawing.Point(-1, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 361);
            this.panel2.TabIndex = 101;
            // 
            // FormCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(659, 619);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Btn_New);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Btn_Connect);
            this.Controls.Add(this.Btn_Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCreate";
            this.Text = "Formulaire de création";
            this.Load += new System.EventHandler(this.FormCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Btn_Exit;
        private Button Btn_Connect;
        private DataGridView DataGridView1;
        private Button Btn_New;
        private Label Lbl_Titre;
        private Panel panel1;
        private Label Lbl_ID;
        private Label Lbl_Nom;
        private Label Lbl_Prenom;
        private DateTimePicker dateTimeBirthday;
        private Label Lbl_Birthday;
        private Label Lbl_Login;
        private Label Lbl_Password;
        private TextBox Txt_ID;
        private TextBox Txt_Nom;
        private TextBox Txt_Prenom;
        private TextBox Txt_Login;
        private TextBox Txt_Password;
        private Button Btn_Ajouter;
        private Button Btn_Update;
        private Button Btn_Delete;
        private Label Lbl_Mail;
        private TextBox Txt_Mail;
        private Label Lbl_Confim;
        private TextBox Txt_Password2;
        private Label Lbl_V;
        private PictureBox PictureBox1;
        private CheckBox Check_Pwd;
        private Panel panel2;
        private ToolTip ToolTip1;
    }
}