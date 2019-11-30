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
    public partial class Add_Item : Form
    {
         int count = 0;
        public Add_Item()
        {
            InitializeComponent();
        }

        private void itemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.itemDataSet);

        }

        private void Add_Item_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itemDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.itemDataSet.Items);
            timer.Start();

        }

        private void button_add_item_Click(object sender, EventArgs e)
        {
            this.itemsBindingSource.AddNew();
        }

        private void button_save_item_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.itemDataSet);
        }

        private void button_delete_item_Click(object sender, EventArgs e)
        {
            this.itemsBindingSource.RemoveCurrent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            count = itemsBindingSource.Count;
            label_count.Text = "No of Rows:"+ count.ToString();
            if (count>22)
            {
                button_next.Visible = false;
                button_previous.Visible = false;
            }
            else
            {
                button_next.Visible = true;
                button_previous.Visible = true;
            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            itemsBindingSource.MoveNext();
        }

        private void button_previous_Click(object sender, EventArgs e)
        {
            itemsBindingSource.MovePrevious();
        }

        private void button_previous_Click_1(object sender, EventArgs e)
        {

        }

   /*     private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
              //  this.itemsTableAdapter.SearchName(this.itemDataSet.Items, textBox_search.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw;
            }
        }*/

      /*  private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.itemsTableAdapter.Search(this.itemDataSet.Items, nameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        */
        private void search1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.itemsTableAdapter.Search1(this.itemDataSet.Items, nameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
