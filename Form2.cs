namespace LabelEtykieta1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Label Form";
            this.Width = 600;
            this.Height = 160;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //Label
            Label firstLabel = new Label();
            firstLabel.Location = new Point(20, 14);

            firstLabel.Text = "first the sentence ";
            firstLabel.Width = 190;

            Controls.Add(firstLabel);

            //Input
            TextBox firstInput = new TextBox();
            firstInput.Name = "inputBoxInForm";
            firstInput.Location = new Point(210, 12);
            firstInput.Width = 300;
            Controls.Add(firstInput);

            //Button
            Button firstButton = new Button();
            firstButton.Location = new Point(210, 50);
            firstButton.Text = "Clic me now";

            firstButton.Height = 35;
            firstButton.Width = 300;

            firstButton.Click += new EventHandler(firstButton_Click);

            Controls.Add(firstButton);
        }
        private void firstButton_Click(object sender, EventArgs e) 
        {
            string ValueOfField = ((TextBox)Controls["inputBoxInForm"]).Text;
            if(ValueOfField == " ")
            {
                MessageBox.Show("Fild empty!","Alert",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(ValueOfField, " Alert", MessageBoxButtons.OK);
            }
        }
    }
}
