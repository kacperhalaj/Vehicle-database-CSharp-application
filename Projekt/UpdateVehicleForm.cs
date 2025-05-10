using System;
using System.Windows.Forms;

namespace Projekt
{
    public partial class UpdateVehicleForm : Form
    {
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public string Type { get; private set; }
        public int SpecificValue
        {
            get
            {
                int value = 0;
                int.TryParse(txtSpecific.Text.Trim(), out value);
                return value;
            }
        }

        public UpdateVehicleForm(string brand, string model, int year, string type, string specific)
        {
            InitializeComponent();

            if (comboType.Items.Count == 0)
            {
                comboType.Items.AddRange(new string[] { "Osobowy", "Motor", "Ciężarowy", "Inny" });
            }

            txtBrand.Text = brand;
            txtModel.Text = model;
            txtYear.Text = year.ToString();
            comboType.SelectedItem = type;
            txtSpecific.Text = specific;

            btnOK.Click += btnOK_Click;
            btnCancel.Click += btnCancel_Click;

            this.AcceptButton = btnOK;
            this.CancelButton = btnCancel;

            txtBrand.KeyDown += EnterKeyToOk;
            txtModel.KeyDown += EnterKeyToOk;
            txtYear.KeyDown += EnterKeyToOk;
            txtSpecific.KeyDown += EnterKeyToOk;
            comboType.KeyDown += EnterKeyToOk;
        }

        private void EnterKeyToOk(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                Brand = txtBrand.Text.Trim();
                Model = txtModel.Text.Trim();
                Year = int.Parse(txtYear.Text.Trim());
                Type = comboType.SelectedItem.ToString();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtBrand.Text))
            {
                MessageBox.Show("Podaj markę pojazdu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Podaj model pojazdu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(txtYear.Text, out int year) || year < 1886 || year > DateTime.Now.Year)
            {
                MessageBox.Show("Podaj poprawny rok produkcji (od 1886 do obecnego roku).", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboType.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz typ pojazdu z listy.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string typ = comboType.SelectedItem.ToString();
            if (typ == "Osobowy")
            {
                if (!int.TryParse(txtSpecific.Text, out int val) || val < 1 || val > 5)
                {
                    MessageBox.Show("Dla pojazdu osobowego liczba drzwi musi być całkowitą liczbą od 1 do 5.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (typ == "Motor")
            {
                if (!int.TryParse(txtSpecific.Text, out int val) || val <= 0)
                {
                    MessageBox.Show("Dla motocykla pojemność silnika musi być liczbą większą od 0.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (string.IsNullOrWhiteSpace(txtSpecific.Text))
            {
                MessageBox.Show("Podaj specyficzne informacje o pojeździe.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void UpdateVehicleForm_Load(object sender, EventArgs e) { }
    }
}