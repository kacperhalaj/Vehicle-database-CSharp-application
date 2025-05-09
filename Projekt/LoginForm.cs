using System;
using System.Windows.Forms;

namespace Projekt
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Obs³uga przycisku "Zaloguj siê"
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Walidacja pól
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Proszê wprowadziæ login.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Proszê wprowadziæ has³o.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Przyk³adowa weryfikacja loginu i has³a (do zast¹pienia w przysz³oœci rzeczywist¹ logik¹)
            if (username == "admin" && password == "admin123")
            {
                MessageBox.Show("Logowanie zakoñczone sukcesem!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Przejœcie do kolejnego okna aplikacji (np. MainForm)
                //MainForm mainForm = new MainForm();
                //mainForm.Show();
                this.Hide(); // Ukrywa LoginForm
            }
            else
            {
                MessageBox.Show("Nieprawid³owy login lub has³o.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Obs³uga przycisku "WyjdŸ"
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Potwierdzenie przed zamkniêciem aplikacji
            DialogResult result = MessageBox.Show("Czy na pewno chcesz zamkn¹æ aplikacjê?",
                                                  "Zamykanie aplikacji",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Zamyka aplikacjê
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}