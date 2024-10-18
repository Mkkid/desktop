using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_good
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.Text = "ListViewForm";
            this.Width = 396;
            this.Height = 333;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //ListView
            ListView listView1 = new ListView();
            listView1.Size = new Size(350, 200);
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";

            ListViewItem item1 = new ListViewItem("Krzysztof");
            item1.Checked = false;
            item1.SubItems.Add("Kozłowski");
            item1.SubItems.Add("28");
            item1.SubItems.Add("2");

            ListViewItem item2 = new ListViewItem("Mariusz");
            item2.Checked = true;
            item2.SubItems.Add("Kotkowski");
            item2.SubItems.Add("40");
            item2.SubItems.Add("2");

            ListViewItem item3 = new ListViewItem("Anna");
            item3.Checked = false;
            item3.SubItems.Add("Miluśinka");
            item3.SubItems.Add("18");
            item3.SubItems.Add("5");

            listView1.Columns.Add("Name", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Surname", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Age", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Children", -2, HorizontalAlignment.Center);

            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });

            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.Sorting = SortOrder.Ascending;
            listView1.CheckBoxes = true; 
            listView1.MultiSelect = false;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            Controls.Add(listView1);

            // Button
            Button firstButton = new Button();
            firstButton.Location = new Point(12, 226);
            firstButton.Text = "Show Surname";
            firstButton.Height = 35;
            firstButton.Width = 350;
            firstButton.Click += new EventHandler(firstButton_Click);
            Controls.Add(firstButton);
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
                try
                {
                    StringBuilder checkedSurnames = new StringBuilder();

                    foreach (ListViewItem item in ((ListView)Controls["listView1"]).Items)
                    {
                        if (item.Checked) 
                        {
                            checkedSurnames.AppendLine(item.SubItems[1].Text);
                        }
                    }

                    if (checkedSurnames.Length > 0)
                    {
                        MessageBox.Show(checkedSurnames.ToString(), "Checked Surnames", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("No items checked!", "Error", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
        }
    }
}

