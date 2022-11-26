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
            this.TxtB_Id = new System.Windows.Forms.TextBox();
            this.TxtB_Pass = new System.Windows.Forms.TextBox();
            this.Btn_Valider = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Create = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtB_Id
            // 
            this.TxtB_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtB_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtB_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.TxtB_Id.Location = new System.Drawing.Point(119, 193);
            this.TxtB_Id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtB_Id.Multiline = true;
            this.TxtB_Id.Name = "TxtB_Id";
            this.TxtB_Id.PlaceholderText = "Identifiant";
            this.TxtB_Id.Size = new System.Drawing.Size(116, 23);
            this.TxtB_Id.TabIndex = 2;
            this.TxtB_Id.TextChanged += new System.EventHandler(this.TxtB_Id_TextChanged);
            this.TxtB_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_Id_KeyPress);
            // 
            // TxtB_Pass
            // 
            this.TxtB_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtB_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtB_Pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.TxtB_Pass.Location = new System.Drawing.Point(120, 234);
            this.TxtB_Pass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtB_Pass.Multiline = true;
            this.TxtB_Pass.Name = "TxtB_Pass";
            this.TxtB_Pass.PasswordChar = '*';
            this.TxtB_Pass.PlaceholderText = "Password";
            this.TxtB_Pass.Size = new System.Drawing.Size(116, 23);
            this.TxtB_Pass.TabIndex = 6;
            this.TxtB_Pass.TextChanged += new System.EventHandler(this.TxtB_Pass_TextChanged);
            this.TxtB_Pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_Pass_KeyPress);
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
            this.Btn_Valider.TabIndex = 4;
            this.Btn_Valider.Text = "LOG IN";
            this.Btn_Valider.UseVisualStyleBackColor = false;
            this.Btn_Valider.Click += new System.EventHandler(this.Btn_Valider_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(63, 272);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(131, 19);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Voir le mot de passe";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Form_Login.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(93, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 146);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
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
            this.Btn_Create.TabIndex = 7;
            this.Btn_Create.Text = "CREATE";
            this.Btn_Create.UseVisualStyleBackColor = false;
            this.Btn_Create.Click += new System.EventHandler(this.Btn_Create_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Form_Login.Properties.Resources.favlogin;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(39, 186);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 23);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(39, 231);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(74, 23);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
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
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(287, 363);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Btn_Create);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Btn_Valider);
            this.Controls.Add(this.TxtB_Pass);
            this.Controls.Add(this.TxtB_Id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormLogin";
            this.Opacity = 0.95D;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtB_Id;
        private System.Windows.Forms.TextBox TxtB_Pass;
        private System.Windows.Forms.Button Btn_Valider;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private Button Btn_Create;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Panel panel2;
        private Label labelExit;
    }
}