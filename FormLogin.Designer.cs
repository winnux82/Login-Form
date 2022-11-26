namespace Calculatrice
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.Txt_Pass = new System.Windows.Forms.TextBox();
            this.Btn_Valider = new System.Windows.Forms.Button();
            this.Check_Pwd = new System.Windows.Forms.CheckBox();
            this.Picture_Logo = new System.Windows.Forms.PictureBox();
            this.Btn_Create = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelExit = new System.Windows.Forms.Label();
            this.Picture_ID = new System.Windows.Forms.PictureBox();
            this.Picture_Pwd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Pwd)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Id
            // 
            this.Txt_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txt_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Txt_Id.Location = new System.Drawing.Point(119, 193);
            this.Txt_Id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txt_Id.Multiline = true;
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.PlaceholderText = "Identifiant";
            this.Txt_Id.Size = new System.Drawing.Size(116, 23);
            this.Txt_Id.TabIndex = 2;
            this.Txt_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Id_KeyPress);
            // 
            // Txt_Pass
            // 
            this.Txt_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txt_Pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Txt_Pass.Location = new System.Drawing.Point(120, 234);
            this.Txt_Pass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txt_Pass.Multiline = true;
            this.Txt_Pass.Name = "Txt_Pass";
            this.Txt_Pass.PasswordChar = '*';
            this.Txt_Pass.PlaceholderText = "Password";
            this.Txt_Pass.Size = new System.Drawing.Size(116, 23);
            this.Txt_Pass.TabIndex = 3;
            this.Txt_Pass.TextChanged += new System.EventHandler(this.TxtB_Pass_TextChanged);
            this.Txt_Pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Pass_KeyPress);
            // 
            // Btn_Valider
            // 
            this.Btn_Valider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Btn_Valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Valider.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Valider.ForeColor = System.Drawing.Color.White;
            this.Btn_Valider.Location = new System.Drawing.Point(39, 297);
            this.Btn_Valider.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Valider.Name = "Btn_Valider";
            this.Btn_Valider.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Btn_Valider.Size = new System.Drawing.Size(75, 33);
            this.Btn_Valider.TabIndex = 5;
            this.Btn_Valider.Text = "LOG IN";
            this.Btn_Valider.UseVisualStyleBackColor = false;
            this.Btn_Valider.Click += new System.EventHandler(this.Btn_Valider_Click);
            // 
            // Check_Pwd
            // 
            this.Check_Pwd.AutoSize = true;
            this.Check_Pwd.Location = new System.Drawing.Point(63, 272);
            this.Check_Pwd.Name = "Check_Pwd";
            this.Check_Pwd.Size = new System.Drawing.Size(131, 19);
            this.Check_Pwd.TabIndex = 4;
            this.Check_Pwd.Text = "Voir le mot de passe";
            this.Check_Pwd.UseVisualStyleBackColor = true;
            this.Check_Pwd.CheckedChanged += new System.EventHandler(this.Check_Pwd_CheckedChanged);
            // 
            // Picture_Logo
            // 
            this.Picture_Logo.BackgroundImage = global::Form_Login.Properties.Resources.logo1;
            this.Picture_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Picture_Logo.Location = new System.Drawing.Point(93, 12);
            this.Picture_Logo.Name = "Picture_Logo";
            this.Picture_Logo.Size = new System.Drawing.Size(118, 146);
            this.Picture_Logo.TabIndex = 6;
            this.Picture_Logo.TabStop = false;
            // 
            // Btn_Create
            // 
            this.Btn_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Create.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Create.ForeColor = System.Drawing.Color.White;
            this.Btn_Create.Location = new System.Drawing.Point(165, 297);
            this.Btn_Create.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Create.Name = "Btn_Create";
            this.Btn_Create.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Btn_Create.Size = new System.Drawing.Size(75, 33);
            this.Btn_Create.TabIndex = 6;
            this.Btn_Create.Text = "CREATE";
            this.Btn_Create.UseVisualStyleBackColor = false;
            this.Btn_Create.Click += new System.EventHandler(this.Btn_Create_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(39, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(39, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 11;
            // 
            // labelExit
            // 
            this.labelExit.AutoEllipsis = true;
            this.labelExit.AutoSize = true;
            this.labelExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelExit.Location = new System.Drawing.Point(249, 339);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(26, 15);
            this.labelExit.TabIndex = 12;
            this.labelExit.Text = "Exit";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            this.labelExit.MouseLeave += new System.EventHandler(this.labelExit_MouseLeave);
            this.labelExit.MouseHover += new System.EventHandler(this.labelExit_MouseHover);
            // 
            // Picture_ID
            // 
            this.Picture_ID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Picture_ID.BackgroundImage")));
            this.Picture_ID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Picture_ID.Location = new System.Drawing.Point(39, 183);
            this.Picture_ID.Name = "Picture_ID";
            this.Picture_ID.Size = new System.Drawing.Size(75, 30);
            this.Picture_ID.TabIndex = 13;
            this.Picture_ID.TabStop = false;
            // 
            // Picture_Pwd
            // 
            this.Picture_Pwd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Picture_Pwd.BackgroundImage")));
            this.Picture_Pwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Picture_Pwd.Location = new System.Drawing.Point(38, 227);
            this.Picture_Pwd.Name = "Picture_Pwd";
            this.Picture_Pwd.Size = new System.Drawing.Size(75, 30);
            this.Picture_Pwd.TabIndex = 14;
            this.Picture_Pwd.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(287, 363);
            this.Controls.Add(this.Picture_Pwd);
            this.Controls.Add(this.Picture_ID);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Create);
            this.Controls.Add(this.Picture_Logo);
            this.Controls.Add(this.Check_Pwd);
            this.Controls.Add(this.Btn_Valider);
            this.Controls.Add(this.Txt_Pass);
            this.Controls.Add(this.Txt_Id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormLogin";
            this.Opacity = 0.95D;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Pwd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.TextBox Txt_Pass;
        private System.Windows.Forms.Button Btn_Valider;
        private CheckBox Check_Pwd;
        private PictureBox Picture_Logo;
        private Button Btn_Create;
        private Panel panel1;
        private Panel panel2;
        private Label labelExit;
        private PictureBox Picture_ID;
        private PictureBox Picture_Pwd;
    }
}