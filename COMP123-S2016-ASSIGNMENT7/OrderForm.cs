﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMP123_S2016_ASSIGNMENT7;

namespace COMP123_S2016_ASSIGNMENT7
{
    public partial class OrderForm : Form
    {
        public SelectionForm orderformer { get; set; }

        List<MovieInformation> Movies = new List<MovieInformation>();
        public OrderForm()
        {

           
            InitializeComponent();

           
           // textBox1.Text = SelectionForm.TitleTextbox.Text;
            AdditionalChargeLabel.Visible = false;
            textBox7.Visible = false;
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
                AdditionalChargeLabel.Visible = true;
            }
            else
            {

                textBox7.Visible = false;
                AdditionalChargeLabel.Visible = false;
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("PRINTING YOUR ORDER");
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Program.aboutBox.Show();
          
        }

        private void BackButtonLabel_Click(object sender, EventArgs e)
        {
            SelectionForm selectionForm = new SelectionForm();
            selectionForm.Show();
            this.Hide();
        }
    }
}
