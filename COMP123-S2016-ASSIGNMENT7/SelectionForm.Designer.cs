namespace COMP123_S2016_ASSIGNMENT7
{
    partial class SelectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MovieList = new System.Windows.Forms.ListBox();
            this.yourSelection = new System.Windows.Forms.GroupBox();
            this.TitleTextbox = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.yourSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieList
            // 
            this.MovieList.FormattingEnabled = true;
            this.MovieList.Items.AddRange(new object[] {
            "Cedar Rapids",
            "Company Men",
            "Death Race 2",
            "FootLoose",
            "Gnomeo and Juliet",
            "I am Number Four",
            "Just Go With It",
            "No String Attached",
            "Real Steel",
            "Sanctum",
            "Season of the Witch",
            "The Dilemma",
            "The Eagle",
            "The Green Hornet",
            "The Mechanic",
            "The Other Woman",
            "The Rite",
            "The Roommate",
            "The Way Back",
            "Waiting for Forever"});
            this.MovieList.Location = new System.Drawing.Point(12, 78);
            this.MovieList.Name = "MovieList";
            this.MovieList.Size = new System.Drawing.Size(145, 199);
            this.MovieList.Sorted = true;
            this.MovieList.TabIndex = 0;
            this.MovieList.Click += new System.EventHandler(this.listBox1_Click);
            this.MovieList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // yourSelection
            // 
            this.yourSelection.Controls.Add(this.pictureBox1);
            this.yourSelection.Controls.Add(this.CostLabel);
            this.yourSelection.Controls.Add(this.CategoryLabel);
            this.yourSelection.Controls.Add(this.TitleLabel);
            this.yourSelection.Controls.Add(this.textBox3);
            this.yourSelection.Controls.Add(this.Category);
            this.yourSelection.Controls.Add(this.TitleTextbox);
            this.yourSelection.Location = new System.Drawing.Point(178, 28);
            this.yourSelection.Name = "yourSelection";
            this.yourSelection.Size = new System.Drawing.Size(644, 348);
            this.yourSelection.TabIndex = 1;
            this.yourSelection.TabStop = false;
            this.yourSelection.Text = "Your Selection";
            // 
            // TitleTextbox
            // 
            this.TitleTextbox.Location = new System.Drawing.Point(284, 132);
            this.TitleTextbox.Name = "TitleTextbox";
            this.TitleTextbox.ReadOnly = true;
            this.TitleTextbox.Size = new System.Drawing.Size(316, 20);
            this.TitleTextbox.TabIndex = 0;
            // 
            // Category
            // 
            this.Category.Location = new System.Drawing.Point(284, 229);
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Size = new System.Drawing.Size(182, 20);
            this.Category.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(502, 229);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(293, 93);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(43, 20);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Title";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(293, 197);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(81, 20);
            this.CategoryLabel.TabIndex = 4;
            this.CategoryLabel.Text = "Category";
            this.CategoryLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(539, 197);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(46, 20);
            this.CostLabel.TabIndex = 5;
            this.CostLabel.Text = "Cost";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::COMP123_S2016_ASSIGNMENT7.Properties.Resources.cedarrapids;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(16, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 270);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Location = new System.Drawing.Point(631, 382);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(96, 42);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 465);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.yourSelection);
            this.Controls.Add(this.MovieList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectionForm";
            this.Load += new System.EventHandler(this.SelectionForm_Load);
            this.yourSelection.ResumeLayout(false);
            this.yourSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox MovieList;
        private System.Windows.Forms.GroupBox yourSelection;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox Category;
        private System.Windows.Forms.TextBox TitleTextbox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button NextButton;
    }
}