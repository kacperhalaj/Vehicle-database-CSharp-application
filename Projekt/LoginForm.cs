using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt.Data;
using Projekt.Models;

namespace Projekt
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txtUsername.KeyDown += TextBox_KeyDown;
            txtPassword.KeyDown += TextBox_KeyDown;
            txtUsername.Leave += TxtUsername_Leave; // <-- asynchroniczna walidacja loginu po opuszczeniu pola
        }

        // Asynchroniczna walidacja loginu po wpisaniu i opuszczeniu pola
        private async void TxtUsername_Leave(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            if (string.IsNullOrWhiteSpace(username)) return;

            // Przyk�ad: sprawd� asynchronicznie czy u�ytkownik istnieje
            bool exists = await UserExistsAsync(username);
            if (!exists)
            {
                // Opcjonalnie: mo�esz blokowa� dalsze logowanie do czasu poprawy loginu
                MessageBox.Show("Podany login nie istnieje w bazie.", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ASYNC: sprawdza czy u�ytkownik istnieje w bazie
        private async Task<bool> UserExistsAsync(string username)
        {
            using (var db = new AppDbContext())
            {
                return await Task.Run(() => db.Users.Any(u => u.Login == username));
            }
        }

        // Obs�uga przycisku "Zaloguj si�"
        private async void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

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

            // Asynchroniczna walidacja loginu
            if (!await UserExistsAsync(username))
            {
                MessageBox.Show("Podany login nie istnieje w bazie.", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Asynchroniczne sprawdzanie loginu i has�a
            bool correct = await Task.Run(() =>
            {
                using (var db = new AppDbContext())
                {
                    return db.Users.Any(u => u.Login == username && u.Password == password);
                }
            });

            if (correct)
            {
                MessageBox.Show("Logowanie zako�czone sukcesem!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainFrame mainForm = new MainFrame();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nieprawid�owy login lub has�o.", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz zamkn�� aplikacj�?",
                                                  "Zamykanie aplikacji",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e) { }
        private void PanelLogowania_Paint(object sender, PaintEventArgs e) { }

        // ENTER = logowanie
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button1_Click(sender, e);
            }
        }
    }
}