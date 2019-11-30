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
    public partial class Add_Employees : Form
    {
        public Add_Employees()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employees);

        }

        private void Add_Employees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employees.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.employees.Table);

        }

        private void genderCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.Search(this.employees.Table, emailToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
