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
    }
}
