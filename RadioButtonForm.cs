namespace RadioButtonForm
{
    public partial class Form1 : Form
    {
        private RadioButton selectedRadioButton1;
        private RadioButton selectedRadioButton2;   
        public Form1()
        {
            InitializeComponent();

            this.Text = "RadioButtonForm";
            this.Width = 700;
            this.Height = 300;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //GroupBox1
            GroupBox GroupBox1 = new GroupBox();
            GroupBox1.Location = new Point(12, 12);
            GroupBox1.Name = "GroupBoxNo1";
            GroupBox1.Text = "Select Foreground Color";

            GroupBox1.Width = 250;
            GroupBox1.Height = 135;

            //GroupBox2
            GroupBox GroupBox2 = new GroupBox();
            GroupBox2.Location = new Point(300, 12);
            GroupBox2.Name = "GroupBoxNo2";
            GroupBox2.Text = "Select Background Color";

            GroupBox2.Width = 250;
            GroupBox2.Height = 135;

            //RadioButton in GroupBox1
            RadioButton radioButton1 = new RadioButton();
            radioButton1.Location = new Point(20, 30);
            radioButton1.Name = "radioButtonNo1";
            radioButton1.Text = "White";
            radioButton1.Width = 200;
            radioButton1.Height = 35;
            radioButton1.Checked = true;
            radioButton1.CheckedChanged += new EventHandler(radioButton_CheckedChanged1);
            GroupBox1.Controls.Add(radioButton1);

            this.selectedRadioButton1 = radioButton1; 

            RadioButton radioButton2 = new RadioButton();
            radioButton2.Location = new Point(20, 60);
            radioButton2.Name = "radioButtonNo2";
            radioButton2.Text = "Black";
            radioButton2.Width = 200;
            radioButton2.Height = 35;
            radioButton2.CheckedChanged += new EventHandler(radioButton_CheckedChanged1);

            GroupBox1.Controls.Add(radioButton2);

            RadioButton radioButton3 = new RadioButton();
            radioButton3.Location = new Point(20, 90);
            radioButton3.Name = "radioButtonNo3";
            radioButton3.Text = "Blue";
            radioButton3.Width = 200;
            radioButton3.Height = 35;
            radioButton3.CheckedChanged += new EventHandler(radioButton_CheckedChanged1);

            GroupBox1.Controls.Add(radioButton3);

            //RadioButton in GroupBox2
            RadioButton radioButton4 = new RadioButton();
            radioButton4.Location = new Point(20, 30);
            radioButton4.Name = "radioButtonNo4";
            radioButton4.Text = "White";
            radioButton4.Width = 200;
            radioButton4.Height = 35;
            radioButton4.Checked = true;
            radioButton4.CheckedChanged += new EventHandler(radioButton_CheckedChanged2);
            GroupBox2.Controls.Add(radioButton4);

            RadioButton radioButton5 = new RadioButton();
            radioButton5.Location = new Point(20,60);
            radioButton5.Name = "radioButtonNo5";
            radioButton5.Text = "Black";
            radioButton5.Width = 200;
            radioButton5.Height = 35;
            radioButton5.CheckedChanged += new EventHandler(radioButton_CheckedChanged2);
            GroupBox2.Controls.Add(radioButton5);

            RadioButton radioButton6 = new RadioButton();
            radioButton6.Location = new Point(20, 90);
            radioButton6.Name = "radioButtonNo6";
            radioButton6.Text = "Blue";
            radioButton6.Width = 200;
            radioButton6.Height = 35;
            radioButton6.CheckedChanged += new EventHandler(radioButton_CheckedChanged2);

            GroupBox2.Controls.Add(radioButton6);

            //Add groupBox
            Controls.Add(GroupBox1);
            Controls.Add(GroupBox2);

            //Button
            Button firstButton = new Button();
            firstButton.Location = new Point(12, 160);
            firstButton.Text = "Get Value";
            firstButton.Height = 35;
            firstButton.Width = 512;
            firstButton.Click += new EventHandler(firstButton_Click);
            Controls.Add(firstButton);
        }
        private void radioButton_CheckedChanged1(object sender, EventArgs e)
        {
            RadioButton radioButtinIs = sender as RadioButton;
            if (radioButtinIs != null)
            {
                if(radioButtinIs.Checked)
                {
                    selectedRadioButton1 = radioButtinIs;
                }
            }
        }

        private void radioButton_CheckedChanged2(object sender, EventArgs e)
        {
            RadioButton radioButtinIs = sender as RadioButton;
            if (radioButtinIs != null)
            {
                if (radioButtinIs.Checked)
                {
                    selectedRadioButton2 = radioButtinIs;
                }
            }
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            try
            {
                string ForegroundColor = this.selectedRadioButton1.Text;
                string BackgroundColor = this.selectedRadioButton2.Text;

                string Info = "Foreground color is: " + ForegroundColor + ",Background color si: " + BackgroundColor;
                MessageBox.Show(Info, "Colors", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
