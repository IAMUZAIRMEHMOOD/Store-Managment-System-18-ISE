namespace SM_Management_System
{
    partial class Log_In
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_In));
            this.project_Name = new System.Windows.Forms.Label();
            this.username_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.password_Textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radiobutton_user = new System.Windows.Forms.RadioButton();
            this.radiobutton_admin = new System.Windows.Forms.RadioButton();
            this.o = new System.Windows.Forms.Button();
            this.forgot_password = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // project_Name
            // 
            this.project_Name.AutoSize = true;
            this.project_Name.BackColor = System.Drawing.Color.Transparent;
            this.project_Name.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_Name.Location = new System.Drawing.Point(280, 20);
            this.project_Name.Name = "project_Name";
            this.project_Name.Size = new System.Drawing.Size(389, 49);
            this.project_Name.TabIndex = 0;
            this.project_Name.Text = "S.M Mangement System";
            this.project_Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // username_Textbox
            // 
            this.username_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_Textbox.Location = new System.Drawing.Point(486, 190);
            this.username_Textbox.Name = "username_Textbox";
            this.username_Textbox.Size = new System.Drawing.Size(145, 26);
            this.username_Textbox.TabIndex = 1;
            this.username_Textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // password_Textbox
            // 
            this.password_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_Textbox.Location = new System.Drawing.Point(486, 265);
            this.password_Textbox.Name = "password_Textbox";
            this.password_Textbox.Size = new System.Drawing.Size(145, 26);
            this.password_Textbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Log In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // radiobutton_user
            // 
            this.radiobutton_user.AutoSize = true;
            this.radiobutton_user.BackColor = System.Drawing.Color.Transparent;
            this.radiobutton_user.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobutton_user.Location = new System.Drawing.Point(592, 331);
            this.radiobutton_user.Name = "radiobutton_user";
            this.radiobutton_user.Size = new System.Drawing.Size(59, 23);
            this.radiobutton_user.TabIndex = 7;
            this.radiobutton_user.TabStop = true;
            this.radiobutton_user.Text = "User";
            this.radiobutton_user.UseVisualStyleBackColor = false;
            // 
            // radiobutton_admin
            // 
            this.radiobutton_admin.AutoSize = true;
            this.radiobutton_admin.BackColor = System.Drawing.Color.Transparent;
            this.radiobutton_admin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobutton_admin.Location = new System.Drawing.Point(592, 365);
            this.radiobutton_admin.Name = "radiobutton_admin";
            this.radiobutton_admin.Size = new System.Drawing.Size(119, 23);
            this.radiobutton_admin.TabIndex = 8;
            this.radiobutton_admin.TabStop = true;
            this.radiobutton_admin.Text = "Administrator";
            this.radiobutton_admin.UseVisualStyleBackColor = false;
            // 
            // o
            // 
            this.o.BackColor = System.Drawing.Color.Transparent;
            this.o.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o.Location = new System.Drawing.Point(710, 412);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(75, 23);
            this.o.TabIndex = 10;
            this.o.Text = "Log In";
            this.o.UseVisualStyleBackColor = false;
            this.o.Click += new System.EventHandler(this.login_Click);
            // 
            // forgot_password
            // 
            this.forgot_password.BackColor = System.Drawing.Color.Transparent;
            this.forgot_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgot_password.ForeColor = System.Drawing.SystemColors.ControlText;
            this.forgot_password.Location = new System.Drawing.Point(524, 293);
            this.forgot_password.Name = "forgot_password";
            this.forgot_password.Size = new System.Drawing.Size(127, 23);
            this.forgot_password.TabIndex = 12;
            this.forgot_password.Text = "forgot your password?";
            this.forgot_password.UseVisualStyleBackColor = false;
            this.forgot_password.Click += new System.EventHandler(this.forgot_password_Click);
            // 
            // Log_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 600);
            this.Controls.Add(this.forgot_password);
            this.Controls.Add(this.o);
            this.Controls.Add(this.radiobutton_admin);
            this.Controls.Add(this.radiobutton_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password_Textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username_Textbox);
            this.Controls.Add(this.project_Name);
            this.Name = "Log_In";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label project_Name;
        private System.Windows.Forms.TextBox username_Textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_Textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radiobutton_user;
        private System.Windows.Forms.RadioButton radiobutton_admin;
        private System.Windows.Forms.Button o;
        private System.Windows.Forms.Button forgot_password;
    }
}

