using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_ASSIGNMENT7
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {

           
            InitializeComponent();

            label1.Visible = false;
            textBox7.Visible = false;
        }
        
        private void Hello(object sender, EventArgs e)
        {
           
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            SelectionForm selectionForm = new SelectionForm();
            this.Close();
            selectionForm.Show();

        }

        private void StreamButton_Click(object sender, EventArgs e)
        {
            StreamForm streamForm = new StreamForm();
            this.Close();
            streamForm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox7.Visible = true;
                label1.Visible = true;
            }
            else
            {

                textBox7.Visible = false;
                label1.Visible = false;
            }
        }
    }
}
