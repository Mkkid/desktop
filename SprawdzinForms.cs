using System.Text;
using System.Windows.Forms;

namespace sprawdzian
{
    public partial class Form1 : Form
    {
        // Text 
        TextBox logintextbox;
        TextBox passwordbox;
        TextBox namebox;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Logowanie i Tablica";
            this.Width = 500;
            this.Height = 500;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Etykieta login
            Label loginLabel = new Label();
            loginLabel.Text = "Login:";
            loginLabel.Location = new System.Drawing.Point(30, 30);
            this.Controls.Add(loginLabel);

            // Pole login
            logintextbox = new TextBox();
            logintextbox.Location = new System.Drawing.Point(30, 60);
            logintextbox.Width = 200; 
            this.Controls.Add(logintextbox);

            // Etykieta password
            Label passwordLabel = new Label();
            passwordLabel.Text = "Hasło:";
            passwordLabel.Location = new System.Drawing.Point(30, 100);
            this.Controls.Add(passwordLabel);

            // Pole password
            passwordbox = new TextBox();
            passwordbox.Location = new System.Drawing.Point(30, 130);
            passwordbox.Width = 200; 
            passwordbox.PasswordChar = '*'; 
            this.Controls.Add(passwordbox );

            // Przycisk zalog
            Button loginButton = new Button();
            loginButton.Text = "Zaloguj się";
            loginButton.Location = new System.Drawing.Point(30, 170);
            loginButton.Click += LoginButton_Click;
            this.Controls.Add(loginButton);

            // Etykieta Imie
            Label nameLabel = new Label();
            nameLabel.Text = "Imię:";
            nameLabel.Location = new System.Drawing.Point(30, 230);
            this.Controls.Add(nameLabel);

            // Pole tekstowe Imie
            namebox = new TextBox();
            namebox.Location = new System.Drawing.Point(30, 260);
            namebox.Width = 200; 
            this.Controls.Add(namebox);

            // Przycisk Imie
            Button nameButton = new Button();
            nameButton.Text = "Imię";
            nameButton.Location = new System.Drawing.Point(30, 290);
            nameButton.Click += NameButton_Click;
            this.Controls.Add(nameButton);

            // Przycisk Tablica
            Button tabButton = new Button();
            tabButton.Text = "Tablica";
            tabButton.Location = new System.Drawing.Point(280, 290);
            tabButton.Click += tabfunc;
            this.Controls.Add(tabButton);

        }
        private void LoginButton_Click(object sender, EventArgs e){
            string login = logintextbox.Text;
            string password = passwordbox.Text;

            if (login == "admin" && password == "1234")
            {
                MessageBox.Show("Zalogowano pomyślnie!", "Sukces");
            }
            else
            {
                MessageBox.Show("Nieprawidłowy login lub hasło.", "Błąd");
            }
        }
        private void NameButton_Click(object sender, EventArgs e){
            string name = namebox.Text;
            StringBuilder message = new StringBuilder();

            if (string.IsNullOrWhiteSpace(name))
            {
                message.Append("Proszę wpisać imię.");
            }
            else
            {
                message.Append("Imię: ").Append(name).Append(" - ");

                if (name.Equals("Mary", StringComparison.OrdinalIgnoreCase))
                {
                    message.Append("Imię żeńskie.");
                }
                else if (name.Equals("Kuba", StringComparison.OrdinalIgnoreCase))
                {
                    message.Append("Imię męskie.");
                }
                else if (name.EndsWith("a", StringComparison.OrdinalIgnoreCase))
                {
                    message.Append("Imię żeńskie.");
                }
                else
                {
                    message.Append("Imię męskie.");
                }
            }

            MessageBox.Show(message.ToString(), "Wynik");
        }

        private void tabfunc(object sender, EventArgs e)
        {
           
            int[,] Tab = new int[2, 5];

            
            int liczba = 9;

            for (int i = 0; i < Tab.GetLength(0); i++) 
            {
                for (int j = 0; j < Tab.GetLength(1); j++) 
                {
                    Tab[i, j] = liczba;
                    liczba++;
                }
            }


            StringBuilder message = new StringBuilder();
            for (int i = 0; i < Tab.GetLength(0); i++)
            {
                for (int j = 0; j < Tab.GetLength(1); j++)
                {
                    message.AppendFormat("Tablica [{0},{1}] = {2}\n", i, j, Tab[i, j]);
                }
            }
            int liczbaWierszy = Tab.GetLength(0); 
            int liczbaKolumn = Tab.GetLength(1);

            message.AppendFormat("Liczba wierszy = {0}\n", liczbaWierszy);
            message.AppendFormat("Liczba kolumn = {0}\n", liczbaKolumn);

            MessageBox.Show(message.ToString(), "Zawartość tablicy");
        }
    }
}
