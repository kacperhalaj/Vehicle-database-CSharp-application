using System;
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
            txtUsername.Leave += TxtUsername_Leave;
            btnSettings.Click += BtnSettings_Click;
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            using (var settings = new SettingsForm())
            {
                settings.ShowDialog();
            }
        }

        // Asynchroniczna walidacja loginu po wpisaniu i opuszczeniu pola
        private async void TxtUsername_Leave(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            if (string.IsNullOrWhiteSpace(username)) return;

            try
            {
                bool exists = await UserExistsAsync(username);
                if (!exists)
                {
                    MessageBox.Show("Podany login nie istnieje w bazie.", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                ShowConnectionError(ex);
            }
        }

        // ASYNC: sprawdza czy u�ytkownik istnieje w bazie
        private async Task<bool> UserExistsAsync(string username)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    return await Task.Run(() => db.Users.Any(u => u.Login == username));
                }
            }
            catch (Exception ex)
            {
                ShowConnectionError(ex);
                return false;
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

            try
            {
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
            catch (Exception ex)
            {
                ShowConnectionError(ex);
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

        // Helper do wy�wietlania b��d�w po��czenia z baz�
        private void ShowConnectionError(Exception ex)
        {
            MessageBox.Show(
                "Nie mo�na po��czy� si� z baz� danych. Sprawd� ustawienia po��czenia.\n\nSzczeg�y:\n" + ex.Message,
                "B��d po��czenia z baz�",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}