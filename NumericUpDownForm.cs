namespace NumericUpDownForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "NumericUpDownForm";
            this.Width = 600;
            this.Height = 200;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //NumericUpDown
            NumericUpDown firstNumercUpDown = new NumericUpDown();
            firstNumercUpDown.Location = new Point(12, 12);
            firstNumercUpDown.Name = "firstNumericUpDown";

            firstNumercUpDown.Width = 500;
            firstNumercUpDown.Height = 25;

            firstNumercUpDown.Minimum = -25;
            firstNumercUpDown.Maximum = 25;//ustawienie zakresu w polu numerycznym

            firstNumercUpDown.Value = 10 ;//ustawienie wybranej waroœci w polu numerycznym
            firstNumercUpDown.ValueChanged += new System.EventHandler(firstNumericUpDown_ValueChanged);

            Controls.Add(firstNumercUpDown);//dodawanie do formularza pola numerycznego

            //Buttom
            Button firstButton = new Button();
            firstButton.Location = new Point(12, 52);

            firstButton.Text = "Value from Numeric fild to Text field.";

            firstButton.Height = 35;
            firstButton.Width = 500;

            firstButton.Click += new EventHandler(firstButton_Click);

            Controls.Add(firstButton);

            //Input
            TextBox firstInput = new TextBox();
            firstInput.Name = "inputBoxInForm";
            firstInput.Location = new Point(12, 95);

            firstInput.Width = 500;
            firstInput.Height = 25;

            Controls.Add(firstInput);
        }

        private void firstNumericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            try
            {
                var ValueOfNumericField = ((NumericUpDown)Controls["firstNumericUpDown"]).Value;
                if (ValueOfNumericField == null)
                {
                    MessageBox.Show("Value in field is not set!", " Error", MessageBoxButtons.OK);
                }
                else
                {
                    if(ValueOfNumericField > 20)
                    {
                        MessageBox.Show("Value field is higher than 20!", " Error", MessageBoxButtons.OK);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, " Error", MessageBoxButtons.OK);
            }
            
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            try
            {
                var ValueOfField = ((NumericUpDown)Controls["firstNumericUpDown"]).Value;
                string ValueOfFieldString = ValueOfField.ToString();
                ((TextBox)Controls["inputBoxInForm"]).Text = ValueOfFieldString;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
