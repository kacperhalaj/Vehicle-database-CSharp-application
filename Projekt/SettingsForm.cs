using System;
using System.Windows.Forms;

namespace Projekt
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            // Wczytaj aktualny connection string przy otwarciu okna
            txtConnectionString.Text = ConfigHelper.GetConnectionString();

            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newConnStr = txtConnectionString.Text.Trim();
            if (string.IsNullOrWhiteSpace(newConnStr))
            {
                MessageBox.Show("Connection string nie może być pusty.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                ConfigHelper.SetConnectionString(newConnStr);
                MessageBox.Show("Zapisano connection string. Uruchom ponownie aplikację, aby zmiana zaczęła działać.",
                    "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas zapisu pliku konfiguracyjnego:\n" + ex.Message,
                    "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}