using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace SM_Management_System
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (password_textBox == re_password_textBox)
            {
                User user = new User();
                user.setname(name_Textbox.Text);
                user.setusername(username_textBox.Text);
                user.setemail(email_textBox.Text);
                user.setpassword(password_textBox.Text);
                Log_In log_in = new Log_In();
                this.Close();
                log_in.Show();
               // File.Create("C:\\BinSerialization.ex");
                BinaryFormatter formatter = new BinaryFormatter();
                Stream Mystream = new FileStream("C:\\BinSerialization.ex",FileMode.Create, FileAccess.Write);
                formatter.Serialize(Mystream, user);
                Mystream.Close();
            }
            else
            {
                MessageBox.Show("Both Passwords are Incorrect");
            }
          
            
        }
    }
}
