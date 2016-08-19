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
        List<MovieInformation> Movies = new List<MovieInformation>();

        public SelectionForm()
        {
            InitializeComponent();
            PopulateMovieList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string movieName = MovieList.SelectedItem.ToString();
            TitleTextbox.Text = movieName;
            string Images = "../../images/" + movieName + ".jpg";
            pictureBox1.ImageLocation = Images;
            NextButton.Enabled = true;*/

            foreach (var movie in Movies)
            {
                if (movie.MovieTitle.Equals(MovieList.SelectedItem.ToString()))
                {
                    TitleTextbox.Text = movie.MovieTitle;
                    CostTextBox.Text = movie.Cost.ToString();
                    CategoryTextBox.Text = movie.Category;
                    PictureBox.Image = movie.Picture;
                    NextButton.Enabled = true;
                }
            }

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

        private void PopulateMovieList()
        {            
            Movies.Add(new MovieInformation("Cedar Rapids", 1.99, "Comedy"));
            Movies.Add(new MovieInformation("Company Men", 1.99, "Drama"));
            Movies.Add(new MovieInformation("Death Race 2", 2.99, "Action"));
            Movies.Add(new MovieInformation("FootLoose", 4.99, "New Release"));
            Movies.Add(new MovieInformation("Gnomeo and Juliet", 0.99, "Family"));
            Movies.Add(new MovieInformation("I am Number Four", 2.99, "Sci-Fi"));
            Movies.Add(new MovieInformation("Just Go With It", 1.99, "Comedy"));
            Movies.Add(new MovieInformation("No String Attached", 1.99, "Comedy"));
            Movies.Add(new MovieInformation("Real Steel", 4.99, "New Release"));
            Movies.Add(new MovieInformation("Sanctum", 2.99, "Action"));
            Movies.Add(new MovieInformation("Season of the Witch", 2.99, "Sci-Fi"));
            Movies.Add(new MovieInformation("The Dilemma", 1.99, "Comedy"));
            Movies.Add(new MovieInformation("The Eagle", 2.99, "Action"));
            Movies.Add(new MovieInformation("The Green Hornet", 2.99, "Action"));
            Movies.Add(new MovieInformation("The Mechanic", 2.99, "Action"));
            Movies.Add(new MovieInformation("The Other Woman", 2.99, "Action"));
            Movies.Add(new MovieInformation("The Rite", 2.99, "Horror"));
            Movies.Add(new MovieInformation("The Roommate", 1.99, "Thriller"));
            Movies.Add(new MovieInformation("The Way Back", 1.99, "Drama"));
            Movies.Add(new MovieInformation("Waiting for Forever", 1.99, "Drama"));
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CurrentMoviesLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
