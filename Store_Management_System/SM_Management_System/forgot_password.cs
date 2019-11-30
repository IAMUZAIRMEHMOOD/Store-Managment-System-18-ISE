using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM_Management_System
{
    public partial class forgot_password : Form
    {
        public forgot_password()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Done_Click(object sender, EventArgs e)
        {
            Log_In log_in = new Log_In();
            this.Close();
            log_in.Show();
        }
    }
}
