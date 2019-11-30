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
using System.Runtime.Serialization;

namespace SM_Management_System
{
     
    public partial class Log_In : Form
    {
        public static char type;
        public static string uname, pass;
        public Log_In()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void forgot_password_Click(object sender, EventArgs e)
        {
            forgot_password forgot = new forgot_password();
            forgot.Show();

        }

        private void Register_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
               uname = username_Textbox.Text;
                pass = password_Textbox.Text;
                if (radiobutton_user.Checked)
                {
                    type = 'U';

                }
                if (radiobutton_admin.Checked)
                {
                    type = 'A';
                }
            if (type == 'A' && uname == "admin" && pass == "admin")
            {
                Admin_Options admin_options = new Admin_Options();
                this.Hide();
                admin_options.Show();
                
            }
            else if (type == 'A' && uname == "admin")
            {
                MessageBox.Show("Incorrect Password");
            }
            else if (type == 'A' && pass == "admin")
            {
                MessageBox.Show("Incorrect Username");
            }
            else if (type == 'U')
            {
                FileStream file = new FileStream("C:\\BinSerialization.ex", FileMode.Open,FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                User user = formatter.Deserialize(file) as User;
                if (uname == user.getusername() && pass == user.getpassword())
                {
                   MessageBox.Show("Loged in");
                }
                else
                {
                    MessageBox.Show("Incorect Username or Password");
                }
            } 
            else
            {
                MessageBox.Show("Please Select Check-Box");
            }
            
        }
    }
}