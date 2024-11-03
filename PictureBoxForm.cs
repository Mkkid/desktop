namespace PictureBoxForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "PictureBoxForm";
            this.Width = 347;
            this.Height = 512;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;  
            this.FormBorderStyle = FormBorderStyle.FixedSingle; 

            //PictureBox
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.ClientSize = new Size(300, 300);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;

            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

            Controls.Add(pictureBox1);

            //Button (flowers)
            Button image1Button = new Button();
            image1Button.Location = new Point(12, 320);
            image1Button.Text = "Image 1 (Flowers)";
            image1Button.Height = 35;
            image1Button.Width = 300;
            image1Button.Click += new EventHandler(image1Button_Click);
            
            Controls.Add(image1Button);

            //Button (bicycles)
            Button image2Button = new Button();
            image2Button.Location = new Point(12, 365);
            image2Button.Text = "Image 1 (Bicycles)";
            image2Button.Height = 35;
            image2Button.Width = 300;
            image2Button.Click += new EventHandler(image2Button_Click);

            Controls.Add(image2Button);

            //Button (moon)
            Button image3Button = new Button();
            image3Button.Location = new Point(12, 410);
            image3Button.Text = "Image 1 (moon)";
            image3Button.Height = 35;
            image3Button.Width = 300;
            image3Button.Click += new EventHandler(image3Button_Click);

            Controls.Add(image3Button);
        }
        private void image1Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("flowers.jpg")) 
                {
                    Image ImageToShow = new Bitmap("flowers.jpg");
                    ((PictureBox)Controls["pictureBox1"]).Image = (Image)ImageToShow;
                }
                else
                {
                    MessageBox.Show("File does not exist!", "Error", MessageBoxButtons.OK);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);  
            }
        }

        private void image2Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("bicycles.jpg"))
                {
                    Image ImageToShow = new Bitmap("bicycles.jpg");
                    ((PictureBox)Controls["pictureBox1"]).Image = (Image)ImageToShow;
                }
                else
                {
                    MessageBox.Show("File does not exist!", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void image3Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("moon.jpg"))
                {
                    Image ImageToShow = new Bitmap("moon.jpg");
                    ((PictureBox)Controls["pictureBox1"]).Image = (Image)ImageToShow;
                }
                else
                {
                    MessageBox.Show("File does not exist!", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
