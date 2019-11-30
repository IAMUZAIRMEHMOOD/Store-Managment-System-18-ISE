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
    public partial class Admin_Options : Form
    {
        public Admin_Options()
        {
            InitializeComponent();
        }

        private void button_add_employees_Click(object sender, EventArgs e)
        {
            Add_Employees add_employees = new Add_Employees();
            add_employees.Show();
        }

        private void button_add_user_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_Item add_item = new Add_Item();
            add_item.Show();
        }
    }
}
