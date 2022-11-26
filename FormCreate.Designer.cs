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
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_Connect = new System.Windows.Forms.Button();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Lbl_Mail = new System.Windows.Forms.Label();
            this.Txt_Mail = new System.Windows.Forms.TextBox();
            this.Btn_New = new System.Windows.Forms.Button();
            this.Lbl_Confim = new System.Windows.Forms.Label();
            this.Txt_Password2 = new System.Windows.Forms.TextBox();
            this.Lbl_Force = new System.Windows.Forms.Label();
            this.Lbl_V = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Lbl_Titre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackgroundImage = global::Form_Login.Properties.Resources.exit;
            this.Btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Exit.Location = new System.Drawing.Point(565, 259);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(87, 86);
            this.Btn_Exit.TabIndex = 1;
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Location = new System.Drawing.Point(565, 195);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(86, 53);
            this.Btn_Connect.TabIndex = 2;
            this.Btn_Connect.Text = "Vérifier Connection";
            this.Btn_Connect.UseVisualStyleBackColor = true;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Location = new System.Drawing.Point(12, 24);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(18, 15);
            this.Lbl_ID.TabIndex = 3;
            this.Lbl_ID.Text = "ID";
            this.Lbl_ID.Visible = false;
            // 
            // Lbl_Nom
            // 
            this.Lbl_Nom.AutoSize = true;
            this.Lbl_Nom.Location = new System.Drawing.Point(12, 50);
            this.Lbl_Nom.Name = "Lbl_Nom";
            this.Lbl_Nom.Size = new System.Drawing.Size(34, 15);
            this.Lbl_Nom.TabIndex = 4;
            this.Lbl_Nom.Text = "Nom";
            // 
            // Lbl_Prenom
            // 
            this.Lbl_Prenom.AutoSize = true;
            this.Lbl_Prenom.Location = new System.Drawing.Point(12, 75);
            this.Lbl_Prenom.Name = "Lbl_Prenom";
            this.Lbl_Prenom.Size = new System.Drawing.Size(49, 15);
            this.Lbl_Prenom.TabIndex = 5;
            this.Lbl_Prenom.Text = "Prénom";
            // 
            // dateTimeBirthday
            // 
            this.dateTimeBirthday.Location = new System.Drawing.Point(119, 101);
            this.dateTimeBirthday.Name = "dateTimeBirthday";
            this.dateTimeBirthday.Size = new System.Drawing.Size(200, 23);
            this.dateTimeBirthday.TabIndex = 13;
            // 
            // Lbl_Birthday
            // 
            this.Lbl_Birthday.AutoSize = true;
            this.Lbl_Birthday.Location = new System.Drawing.Point(12, 109);
            this.Lbl_Birthday.Name = "Lbl_Birthday";
            this.Lbl_Birthday.Size = new System.Drawing.Size(101, 15);
            this.Lbl_Birthday.TabIndex = 7;
            this.Lbl_Birthday.Text = "Date de naissance";
            // 
            // Lbl_Login
            // 
            this.Lbl_Login.AutoSize = true;
            this.Lbl_Login.Location = new System.Drawing.Point(12, 173);
            this.Lbl_Login.Name = "Lbl_Login";
            this.Lbl_Login.Size = new System.Drawing.Size(37, 15);
            this.Lbl_Login.TabIndex = 8;
            this.Lbl_Login.Text = "Login";
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(12, 205);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(57, 15);
            this.Lbl_Password.TabIndex = 9;
            this.Lbl_Password.Text = "Password";
            // 
            // Txt_ID
            // 
            this.Txt_ID.Location = new System.Drawing.Point(119, 21);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(200, 23);
            this.Txt_ID.TabIndex = 10;
            this.Txt_ID.Visible = false;
            this.Txt_ID.TextChanged += new System.EventHandler(this.Txt_ID_TextChanged);
            // 
            // Txt_Nom
            // 
            this.Txt_Nom.Location = new System.Drawing.Point(119, 47);
            this.Txt_Nom.Name = "Txt_Nom";
            this.Txt_Nom.Size = new System.Drawing.Size(200, 23);
            this.Txt_Nom.TabIndex = 11;
            this.Txt_Nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Names_KeyPress);
            this.Txt_Nom.Leave += new System.EventHandler(this.Txt_Nom_Leave);
            // 
            // Txt_Prenom
            // 
            this.Txt_Prenom.Location = new System.Drawing.Point(119, 72);
            this.Txt_Prenom.Name = "Txt_Prenom";
            this.Txt_Prenom.Size = new System.Drawing.Size(200, 23);
            this.Txt_Prenom.TabIndex = 12;
            this.Txt_Prenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Names_KeyPress);
            this.Txt_Prenom.Leave += new System.EventHandler(this.Txt_Prenom_Leave);
            // 
            // Txt_Login
            // 
            this.Txt_Login.Location = new System.Drawing.Point(119, 170);
            this.Txt_Login.Name = "Txt_Login";
            this.Txt_Login.Size = new System.Drawing.Size(200, 23);
            this.Txt_Login.TabIndex = 15;
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(119, 202);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(200, 23);
            this.Txt_Password.TabIndex = 16;
            this.Txt_Password.TextChanged += new System.EventHandler(this.Txt_Password_TextChanged);
            // 
            // Btn_Ajouter
            // 
            this.Btn_Ajouter.Location = new System.Drawing.Point(10, 327);
            this.Btn_Ajouter.Name = "Btn_Ajouter";
            this.Btn_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ajouter.TabIndex = 30;
            this.Btn_Ajouter.Text = "Ajouter";
            this.Btn_Ajouter.UseVisualStyleBackColor = true;
            this.Btn_Ajouter.Click += new System.EventHandler(this.Btn_Choix_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 356);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(640, 180);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(117, 327);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(75, 23);
            this.Btn_Update.TabIndex = 31;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Choix_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(221, 327);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.Btn_Delete.TabIndex = 32;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Choix_Click);
            // 
            // Lbl_Mail
            // 
            this.Lbl_Mail.AutoSize = true;
            this.Lbl_Mail.Location = new System.Drawing.Point(12, 133);
            this.Lbl_Mail.Name = "Lbl_Mail";
            this.Lbl_Mail.Size = new System.Drawing.Size(30, 15);
            this.Lbl_Mail.TabIndex = 20;
            this.Lbl_Mail.Text = "Mail";
            // 
            // Txt_Mail
            // 
            this.Txt_Mail.Location = new System.Drawing.Point(119, 130);
            this.Txt_Mail.Name = "Txt_Mail";
            this.Txt_Mail.Size = new System.Drawing.Size(200, 23);
            this.Txt_Mail.TabIndex = 14;
            this.Txt_Mail.Leave += new System.EventHandler(this.Txt_Mail_Leave);
            // 
            // Btn_New
            // 
            this.Btn_New.Location = new System.Drawing.Point(346, 44);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(75, 46);
            this.Btn_New.TabIndex = 22;
            this.Btn_New.Text = "Nouvel utilisateur";
            this.Btn_New.UseVisualStyleBackColor = true;
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // Lbl_Confim
            // 
            this.Lbl_Confim.AutoSize = true;
            this.Lbl_Confim.Location = new System.Drawing.Point(12, 233);
            this.Lbl_Confim.Name = "Lbl_Confim";
            this.Lbl_Confim.Size = new System.Drawing.Size(104, 15);
            this.Lbl_Confim.TabIndex = 23;
            this.Lbl_Confim.Text = "Confirm Password";
            // 
            // Txt_Password2
            // 
            this.Txt_Password2.Location = new System.Drawing.Point(119, 230);
            this.Txt_Password2.Name = "Txt_Password2";
            this.Txt_Password2.Size = new System.Drawing.Size(200, 23);
            this.Txt_Password2.TabIndex = 17;
            this.Txt_Password2.TextChanged += new System.EventHandler(this.Txt_Password2_TextChanged);
            this.Txt_Password2.Leave += new System.EventHandler(this.Txt_Password2_Leave);
            // 
            // Lbl_Force
            // 
            this.Lbl_Force.AutoSize = true;
            this.Lbl_Force.Location = new System.Drawing.Point(12, 296);
            this.Lbl_Force.Name = "Lbl_Force";
            this.Lbl_Force.Size = new System.Drawing.Size(36, 15);
            this.Lbl_Force.TabIndex = 25;
            this.Lbl_Force.Text = "Force";
            // 
            // Lbl_V
            // 
            this.Lbl_V.AutoSize = true;
            this.Lbl_V.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_V.Location = new System.Drawing.Point(316, 227);
            this.Lbl_V.Name = "Lbl_V";
            this.Lbl_V.Size = new System.Drawing.Size(21, 21);
            this.Lbl_V.TabIndex = 26;
            this.Lbl_V.Text = "V";
            this.Lbl_V.Visible = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBox1.Location = new System.Drawing.Point(117, 291);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(200, 25);
            this.PictureBox1.TabIndex = 28;
            this.PictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(165, 259);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(131, 19);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Voir le mot de passe";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Lbl_Titre
            // 
            this.Lbl_Titre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Titre.Location = new System.Drawing.Point(-2, 2);
            this.Lbl_Titre.Name = "Lbl_Titre";
            this.Lbl_Titre.Size = new System.Drawing.Size(671, 23);
            this.Lbl_Titre.TabIndex = 33;
            this.Lbl_Titre.Text = "Gestion des utilisateurs";
            this.Lbl_Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(666, 552);
            this.Controls.Add(this.Lbl_Titre);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Lbl_V);
            this.Controls.Add(this.Lbl_Force);
            this.Controls.Add(this.Txt_Password2);
            this.Controls.Add(this.Lbl_Confim);
            this.Controls.Add(this.Btn_New);
            this.Controls.Add(this.Txt_Mail);
            this.Controls.Add(this.Lbl_Mail);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Ajouter);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Txt_Login);
            this.Controls.Add(this.Txt_Prenom);
            this.Controls.Add(this.Txt_Nom);
            this.Controls.Add(this.Txt_ID);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.Lbl_Login);
            this.Controls.Add(this.Lbl_Birthday);
            this.Controls.Add(this.dateTimeBirthday);
            this.Controls.Add(this.Lbl_Prenom);
            this.Controls.Add(this.Lbl_Nom);
            this.Controls.Add(this.Lbl_ID);
            this.Controls.Add(this.Btn_Connect);
            this.Controls.Add(this.Btn_Exit);
            this.Name = "FormCreate";
            this.Text = "Formulaire de création";
            this.Load += new System.EventHandler(this.FormCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn_Exit;
        private Button Btn_Connect;
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
        private DataGridView dataGridView1;
        private Button Btn_Update;
        private Button Btn_Delete;
        private Label Lbl_Mail;
        private TextBox Txt_Mail;
        private Button Btn_New;
        private Label Lbl_Confim;
        private TextBox Txt_Password2;
        private Label Lbl_Force;
        private Label Lbl_V;
        private PictureBox PictureBox1;
        private CheckBox checkBox1;
        private Label Lbl_Titre;
    }
}