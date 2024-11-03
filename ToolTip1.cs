namespace ToolTipForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "ToolTipForm";
            this.Width = 350;
            this.Height = 120;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //Buttom
            Button firstButton = new Button();
            firstButton.Name = "firstButton";
            firstButton.Location = new Point(12, 12);
            firstButton.Text = "Button";

            firstButton.Width = 300;
            firstButton.Height = 35;

            Controls.Add(firstButton);

            //ToolTip
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(firstButton, "Help about click this button");

        }
    }
}
