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

            // Przyk³ad: sprawdŸ asynchronicznie czy u¿ytkownik istnieje
            bool exists = await UserExistsAsync(username);
            if (!exists)
            {
                // Opcjonalnie: mo¿esz blokowaæ dalsze logowanie do czasu poprawy loginu
                MessageBox.Show("Podany login nie istnieje w bazie.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ASYNC: sprawdza czy u¿ytkownik istnieje w bazie
        private async Task<bool> UserExistsAsync(string username)
        {
            using (var db = new AppDbContext())
            {
                return await Task.Run(() => db.Users.Any(u => u.Login == username));
            }
        }

        // Obs³uga przycisku "Zaloguj siê"
        private async void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

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

            // Asynchroniczna walidacja loginu
            if (!await UserExistsAsync(username))
            {
                MessageBox.Show("Podany login nie istnieje w bazie.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Asynchroniczne sprawdzanie loginu i has³a
            bool correct = await Task.Run(() =>
            {
                using (var db = new AppDbContext())
                {
                    return db.Users.Any(u => u.Login == username && u.Password == password);
                }
            });

            if (correct)
            {
                MessageBox.Show("Logowanie zakoñczone sukcesem!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainFrame mainForm = new MainFrame();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nieprawid³owy login lub has³o.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz zamkn¹æ aplikacjê?",
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