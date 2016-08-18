using System;
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
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string movieName = MovieList.SelectedItem.ToString();
            TitleTextbox.Text = movieName;
            string Images = "../../images/" + movieName + ".jpg";
            pictureBox1.ImageLocation = Images;
            NextButton.Enabled = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            
            //Bitmap image = new Bitmap(movieName);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            List<string> movieInfo = new List<String>();
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
            this.Hide();

           
        }
    }
}
