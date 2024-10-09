using System.Drawing.Text;

namespace PolaWyboru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "CheckBoxForm";
            this.Width = 300;
            this.Height = 217;
            this.MaximizeBox = false;
            this.MinimizeBox = false; ;
            this.StartPosition = FormStartPosition.CenterScreen; 
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //CheckBox No 1
            CheckBox checkBox1 = new CheckBox();
            checkBox1.Location = new Point(12, 12);
            checkBox1.Name = "checkBoxNo1";
            checkBox1.Text = "Some option #1";

            checkBox1.Width = 200;

            Controls.Add(checkBox1);

            //CheckBox No2
            CheckBox checkBox2 = new CheckBox();
            checkBox2.Location = new Point(12, 42);
            checkBox2.Name = "checkBoxNo2";
            checkBox2.Text = "Some option #2";

            checkBox2.Width = 200;
            checkBox2.Checked = true;

           Controls.Add(checkBox2);

            //CheckBox No3
            CheckBox checkBox3 = new CheckBox();
            checkBox3.Location = new Point(12, 73);
            checkBox3.Name = "checkBoxNo3";
            checkBox3.Text = "Some options #3";

            checkBox3.Width = 200;

            Controls.Add(checkBox3);

            //Button
            Button firstButton = new Button();
            firstButton.Location = new Point(12, 110);
            firstButton.Text = "Get Values";

            firstButton.Width = 250;
            firstButton.Height = 35;

            firstButton.Click += new EventHandler(firstButton_Click);

            Controls.Add(firstButton);
            }
        private void firstButton_Click(object sender, EventArgs e)
        {
            try
            {
                string fieldNo1Status;
                string fieldNo2Status;
                string fieldNo3Status;

                if (((CheckBox)Controls["checkBoxNo1"]).Checked)
                {
                    fieldNo1Status = "Checked";
                }
                else
                {
                    fieldNo1Status = "Unchecked";
                }
                if (((CheckBox)Controls["checkBoxNo2"]).Checked)
                {
                    fieldNo2Status = "Checked";
                }
                else
                {
                    fieldNo2Status = "Unchecked";
                }
                if (((CheckBox)Controls["checkBoxNo3"]).Checked)
                {
                    fieldNo3Status = "Checked";
                }
                else
                {
                    fieldNo3Status = "Unchecked";
                }
                string Info = "Field status:\n";
                Info += "Field 1 is: " + fieldNo1Status + " \n";
                Info += "Field 2 is: " + fieldNo2Status + " \n";
                Info += "Field 3 is: " + fieldNo3Status + " \n";

                MessageBox.Show(Info, "Status ", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK);
            }
        }
    }
}
