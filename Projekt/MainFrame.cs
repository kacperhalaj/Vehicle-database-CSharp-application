using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Projekt.Data;
using Projekt.Models;
using System.Xml.Serialization;
using System.IO;
using ClosedXML.Excel;
using System.Collections.Generic;

namespace Projekt
{
    public partial class MainFrame : Form
    {
        private AppDbContext dbContext;
        private List<Pojazd> pojazdySource;
        private string lastSortColumn = "";
        private bool sortAscending = true;

        public MainFrame()
        {
            InitializeComponent();

            dbContext = new AppDbContext();

            buttonAddVehicle.Click += ButtonAddVehicle_Click;
            buttonUpdate.Click += ButtonUpdate_Click;
            buttonExit.Click += ButtonExit_Click;
            buttonRefresh.Click += ButtonRefresh_Click;
            buttonDeleteVehicle.Click += ButtonDeleteVehicle_Click;
            buttonDetails.Click += ButtonDetails_Click;
            buttonImportXML.Click += ButtonImportXML_Click;
            buttonExportXML.Click += ButtonExportXML_Click;
            buttonImportXLS.Click += ButtonImportXLS_Click;
            buttonExportXLS.Click += ButtonExportXLS_Click;
            labelSearch.Click += LabelSearch_Click;

            textBoxSearch.KeyDown += TextBoxSearch_KeyDown;

            dataGridViewVehicles.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewVehicles.CellClick += DataGridViewVehicles_CellClick;
            dataGridViewVehicles.ColumnHeaderMouseClick += DataGridViewVehicles_ColumnHeaderMouseClick;

            btnSettings.Click += BtnSettings_Click;
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            using (var settings = new SettingsForm())
            {
                settings.ShowDialog();
            }
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            try
            {
                LoadVehiclesFromDatabase();
            }
            catch (Exception ex)
            {
                ShowConnectionError(ex);
            }
        }

        private void LoadVehiclesFromDatabase(string search = "")
        {
            try
            {
                pojazdySource = dbContext.Pojazdy
                    .Include(p => p.Osobowy)
                    .Include(p => p.Motor)
                    .ToList();

                if (!string.IsNullOrWhiteSpace(search))
                {
                    string s = search.ToLower();
                    pojazdySource = pojazdySource.Where(p =>
                        (p.Marka ?? "").ToLower().Contains(s) ||
                        (p.Model ?? "").ToLower().Contains(s) ||
                        p.RokProdukcji.ToString().Contains(s) ||
                        (p.Typ ?? "").ToLower().Contains(s) ||
                        (p.Typ == "Osobowy" && p.Osobowy != null && p.Osobowy.LiczbaDrzwi.ToString().Contains(s)) ||
                        (p.Typ == "Motor" && p.Motor != null && p.Motor.PojemnoscSilnika.ToString().Contains(s))
                    ).ToList();
                }

                SetDataGridSource(pojazdySource);
            }
            catch (Exception ex)
            {
                ShowConnectionError(ex);
            }
        }

        private void SetDataGridSource(List<Pojazd> list)
        {
            var viewList = list.Select(p => new
            {
                Marka = p.Marka,
                Model = p.Model,
                Rok = p.RokProdukcji,
                Typ = p.Typ,
                Specyficzne = p.Typ == "Osobowy"
                    ? $"{p.Osobowy?.LiczbaDrzwi ?? 0} drzwi"
                    : p.Typ == "Motor"
                        ? $"{p.Motor?.PojemnoscSilnika ?? 0}cc"
                        : ""
            }).ToList();

            dataGridViewVehicles.DataSource = viewList;
            dataGridViewVehicles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVehicles.MultiSelect = false;
            dataGridViewVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string search = textBoxSearch.Text.Trim();
                LoadVehiclesFromDatabase(search);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void DataGridViewVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridViewVehicles.ClearSelection();
                dataGridViewVehicles.Rows[e.RowIndex].Selected = true;
            }
        }

        private void DataGridViewVehicles_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dataGridViewVehicles.Columns[e.ColumnIndex].Name;

            Func<Pojazd, object> keySelector = p => "";
            switch (columnName)
            {
                case "Marka":
                    keySelector = p => p.Marka;
                    break;
                case "Model":
                    keySelector = p => p.Model;
                    break;
                case "Rok":
                    keySelector = p => p.RokProdukcji;
                    break;
                case "Typ":
                    keySelector = p => p.Typ;
                    break;
                case "Specyficzne":
                    keySelector = p => p.Typ == "Osobowy"
                        ? $"{p.Osobowy?.LiczbaDrzwi ?? 0} drzwi"
                        : p.Typ == "Motor"
                            ? $"{p.Motor?.PojemnoscSilnika ?? 0}cc"
                            : "";
                    break;
                default:
                    return;
            }

            if (lastSortColumn == columnName)
                sortAscending = !sortAscending;
            else
                sortAscending = true;
            lastSortColumn = columnName;

            var sorted = sortAscending
                ? pojazdySource.OrderBy(keySelector).ToList()
                : pojazdySource.OrderByDescending(keySelector).ToList();

            SetDataGridSource(sorted);
        }

        private void LabelSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Focus();
        }

        private void ButtonAddVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                using (var addVehicleForm = new AddVehicleForm())
                {
                    if (addVehicleForm.ShowDialog() == DialogResult.OK)
                    {
                        var typ = addVehicleForm.Type;
                        var spec = addVehicleForm.SpecificValue;

                        var pojazd = new Pojazd
                        {
                            Marka = addVehicleForm.Brand,
                            Model = addVehicleForm.Model,
                            RokProdukcji = addVehicleForm.Year,
                            Typ = typ
                        };

                        if (typ == "Osobowy")
                        {
                            if (spec >= 1 && spec <= 5)
                            {
                                pojazd.Osobowy = new Osobowy { LiczbaDrzwi = spec };
                                pojazd.Motor = null;
                            }
                            else
                            {
                                MessageBox.Show("Dla pojazdu osobowego liczba drzwi musi być od 1 do 5.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else if (typ == "Motor")
                        {
                            if (spec > 0)
                            {
                                pojazd.Motor = new Motor { PojemnoscSilnika = spec };
                                pojazd.Osobowy = null;
                            }
                            else
                            {
                                MessageBox.Show("Dla motocykla pojemność silnika musi być liczbą większą od 0.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        dbContext.Pojazdy.Add(pojazd);
                        dbContext.SaveChanges();
                        LoadVehiclesFromDatabase();
                    }
                }
            }
            catch (Exception ex)
            {
                ShowConnectionError(ex);
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewVehicles.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridViewVehicles.SelectedRows[0];
                    string marka = selectedRow.Cells["Marka"].Value.ToString();
                    string model = selectedRow.Cells["Model"].Value.ToString();
                    int rok = int.Parse(selectedRow.Cells["Rok"].Value.ToString());

                    var pojazd = dbContext.Pojazdy
                        .Include(p => p.Osobowy)
                        .Include(p => p.Motor)
                        .FirstOrDefault(p => p.Marka == marka && p.Model == model && p.RokProdukcji == rok);

                    if (pojazd != null)
                    {
                        using (var updateVehicleForm = new UpdateVehicleForm(
                            pojazd.Marka,
                            pojazd.Model,
                            pojazd.RokProdukcji,
                            pojazd.Typ,
                            pojazd.Typ == "Osobowy" ? pojazd.Osobowy?.LiczbaDrzwi.ToString() :
                            pojazd.Typ == "Motor" ? pojazd.Motor?.PojemnoscSilnika.ToString() : ""))
                        {
                            if (updateVehicleForm.ShowDialog() == DialogResult.OK)
                            {
                                var typ = updateVehicleForm.Type;
                                var spec = updateVehicleForm.SpecificValue;

                                pojazd.Marka = updateVehicleForm.Brand;
                                pojazd.Model = updateVehicleForm.Model;
                                pojazd.RokProdukcji = updateVehicleForm.Year;
                                pojazd.Typ = typ;

                                if (typ == "Osobowy")
                                {
                                    if (spec >= 1 && spec <= 5)
                                    {
                                        if (pojazd.Osobowy == null)
                                            pojazd.Osobowy = new Osobowy();
                                        pojazd.Osobowy.LiczbaDrzwi = spec;
                                        pojazd.Motor = null;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Dla pojazdu osobowego liczba drzwi musi być od 1 do 5.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                                else if (typ == "Motor")
                                {
                                    if (spec > 0)
                                    {
                                        if (pojazd.Motor == null)
                                            pojazd.Motor = new Motor();
                                        pojazd.Motor.PojemnoscSilnika = spec;
                                        pojazd.Osobowy = null;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Dla motocykla pojemność silnika musi być liczbą większą od 0.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                                else
                                {
                                    pojazd.Osobowy = null;
                                    pojazd.Motor = null;
                                }
                                dbContext.SaveChanges();
                                LoadVehiclesFromDatabase();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nie można znaleźć pojazdu w bazie!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Wybierz rekord do aktualizacji.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                ShowConnectionError(ex);
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy na pewno chcesz wyjść?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxSearch.Text = "";
                LoadVehiclesFromDatabase();
                MessageBox.Show("Odświeżono dane", "Informacja", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                ShowConnectionError(ex);
            }
        }

        private void ButtonDeleteVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewVehicles.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridViewVehicles.SelectedRows[0];
                    string marka = selectedRow.Cells["Marka"].Value.ToString();
                    string model = selectedRow.Cells["Model"].Value.ToString();
                    int rok = int.Parse(selectedRow.Cells["Rok"].Value.ToString());

                    var pojazd = dbContext.Pojazdy
                        .FirstOrDefault(p => p.Marka == marka && p.Model == model && p.RokProdukcji == rok);

                    if (pojazd != null)
                    {
                        dbContext.Pojazdy.Remove(pojazd);
                        dbContext.SaveChanges();
                        LoadVehiclesFromDatabase();
                        MessageBox.Show("Pojazd został usunięty!", "Informacja", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Nie udało się znaleźć pojazdu w bazie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Wybierz pojazd do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                ShowConnectionError(ex);
            }
        }

        private void ButtonDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewVehicles.SelectedRows.Count > 0)
                {
                    var row = dataGridViewVehicles.SelectedRows[0];
                    string details = $"Marka: {row.Cells["Marka"].Value}\n" +
                                     $"Model: {row.Cells["Model"].Value}\n" +
                                     $"Rok Produkcji: {row.Cells["Rok"].Value}\n" +
                                     $"Typ: {row.Cells["Typ"].Value}\n" +
                                     $"Specyficzne: {row.Cells["Specyficzne"].Value}";
                    MessageBox.Show(details, "Szczegóły pojazdu", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Wybierz pojazd, aby wyświetlić szczegóły.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                ShowConnectionError(ex);
            }
        }

        private void ButtonExportXML_Click(object sender, EventArgs e)
        {
            try
            {
                using (var saveFileDialog = new SaveFileDialog { Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*" })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var pojazdy = dbContext.Pojazdy
                            .Include(p => p.Osobowy)
                            .Include(p => p.Motor)
                            .ToList();

                        XmlSerializer serializer = new XmlSerializer(typeof(List<Pojazd>));
                        using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                        {
                            serializer.Serialize(fs, pojazdy);
                        }
                        MessageBox.Show("Eksport do XML zakończony!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowConnectionError(ex);
            }
        }

        private void ButtonImportXML_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog { Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*" })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        List<Pojazd> pojazdy;
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Pojazd>));
                        using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                        {
                            pojazdy = (List<Pojazd>)serializer.Deserialize(fs);
                        }

                        foreach (var p in pojazdy)
                        {
                            bool exists = dbContext.Pojazdy.Any(x => x.Marka == p.Marka && x.Model == p.Model && x.RokProdukcji == p.RokProdukcji);
                            if (!exists)
                                dbContext.Pojazdy.Add(p);
                        }
                        dbContext.SaveChanges();
                        LoadVehiclesFromDatabase();
                        MessageBox.Show("Import z XML zakończony!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowConnectionError(ex);
            }
        }

        private void ButtonExportXLS_Click(object sender, EventArgs e)
        {
            try
            {
                using (var saveFileDialog = new SaveFileDialog { Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*" })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var pojazdy = dbContext.Pojazdy
                            .Include(p => p.Osobowy)
                            .Include(p => p.Motor)
                            .ToList();

                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Pojazdy");
                            worksheet.Cell(1, 1).Value = "Marka";
                            worksheet.Cell(1, 2).Value = "Model";
                            worksheet.Cell(1, 3).Value = "Rok";
                            worksheet.Cell(1, 4).Value = "Typ";
                            worksheet.Cell(1, 5).Value = "Specyficzne";

                            int row = 2;
                            foreach (var p in pojazdy)
                            {
                                worksheet.Cell(row, 1).Value = p.Marka;
                                worksheet.Cell(row, 2).Value = p.Model;
                                worksheet.Cell(row, 3).Value = p.RokProdukcji;
                                worksheet.Cell(row, 4).Value = p.Typ;
                                worksheet.Cell(row, 5).Value = p.Typ == "Osobowy"
                                    ? $"{p.Osobowy?.LiczbaDrzwi ?? 0} drzwi"
                                    : p.Typ == "Motor"
                                        ? $"{p.Motor?.PojemnoscSilnika ?? 0}cc"
                                        : "";
                                row++;
                            }

                            workbook.SaveAs(saveFileDialog.FileName);
                        }
                        MessageBox.Show("Eksport do Excela zakończony!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowConnectionError(ex);
            }
        }

        private void ButtonImportXLS_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog { Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*" })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var workbook = new XLWorkbook(openFileDialog.FileName))
                        {
                            var worksheet = workbook.Worksheet(1);
                            var rows = worksheet.RangeUsed().RowsUsed().Skip(1);

                            foreach (var row in rows)
                            {
                                string marka = row.Cell(1).GetString();
                                string model = row.Cell(2).GetString();
                                int rok = row.Cell(3).GetValue<int>();
                                string typ = row.Cell(4).GetString();
                                string specific = row.Cell(5).GetString();

                                if (!dbContext.Pojazdy.Any(x => x.Marka == marka && x.Model == model && x.RokProdukcji == rok))
                                {
                                    var pojazd = new Pojazd
                                    {
                                        Marka = marka,
                                        Model = model,
                                        RokProdukcji = rok,
                                        Typ = typ
                                    };

                                    if (typ == "Osobowy")
                                    {
                                        int liczbaDrzwi = 0;
                                        int.TryParse(specific.Replace(" drzwi", ""), out liczbaDrzwi);
                                        if (liczbaDrzwi >= 1 && liczbaDrzwi <= 5)
                                            pojazd.Osobowy = new Osobowy { LiczbaDrzwi = liczbaDrzwi };
                                    }
                                    else if (typ == "Motor")
                                    {
                                        int pojemnosc = 0;
                                        int.TryParse(specific.Replace("cc", ""), out pojemnosc);
                                        if (pojemnosc > 0)
                                            pojazd.Motor = new Motor { PojemnoscSilnika = pojemnosc };
                                    }

                                    dbContext.Pojazdy.Add(pojazd);
                                }
                            }
                            dbContext.SaveChanges();
                        }
                        LoadVehiclesFromDatabase();
                        MessageBox.Show("Import z Excela zakończony!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowConnectionError(ex);
            }
        }

        // Wspólna metoda do pokazywania błędów połączenia z bazą
        private void ShowConnectionError(Exception ex)
        {
            MessageBox.Show(
                "Nie można połączyć się z bazą danych. Sprawdź ustawienia połączenia.\n\nSzczegóły:\n" + ex.Message,
                "Błąd połączenia z bazą",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}