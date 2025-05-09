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

        // Obs�uga przycisku "Zaloguj si�"
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Walidacja p�l
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Prosz� wprowadzi� login.", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Prosz� wprowadzi� has�o.", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Przyk�adowa weryfikacja loginu i has�a (do zast�pienia w przysz�o�ci rzeczywist� logik�)
            if (username == "admin" && password == "admin123")
            {
                MessageBox.Show("Logowanie zako�czone sukcesem!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Przej�cie do kolejnego okna aplikacji (np. MainForm)
                //MainForm mainForm = new MainForm();
                //mainForm.Show();
                this.Hide(); // Ukrywa LoginForm
            }
            else
            {
                MessageBox.Show("Nieprawid�owy login lub has�o.", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Obs�uga przycisku "Wyjd�"
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Potwierdzenie przed zamkni�ciem aplikacji
            DialogResult result = MessageBox.Show("Czy na pewno chcesz zamkn�� aplikacj�?",
                                                  "Zamykanie aplikacji",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Zamyka aplikacj�
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}