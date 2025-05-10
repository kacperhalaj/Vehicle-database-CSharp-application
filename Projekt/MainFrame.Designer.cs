namespace Projekt
{
    partial class MainFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanelMain = new TableLayoutPanel();
            dataGridViewVehicles = new DataGridView();
            tableLayoutPanelBottom = new TableLayoutPanel();
            panelButtons = new TableLayoutPanel();
            buttonExit = new Button();
            buttonExportXLS = new Button();
            buttonImportXLS = new Button();
            buttonExportXML = new Button();
            buttonRefresh = new Button();
            buttonImportXML = new Button();
            buttonDeleteVehicle = new Button();
            buttonAddVehicle = new Button();
            buttonUpdate = new Button();
            buttonDetails = new Button();
            panelSearch = new Panel();
            labelSearch = new Label();
            textBoxSearch = new TextBox();
            btnSettings = new Button();
            tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehicles).BeginInit();
            tableLayoutPanelBottom.SuspendLayout();
            panelButtons.SuspendLayout();
            panelSearch.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(dataGridViewVehicles, 0, 0);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelBottom, 0, 1);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 73.21867F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 26.78133F));
            tableLayoutPanelMain.Size = new Size(800, 450);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // dataGridViewVehicles
            // 
            dataGridViewVehicles.AllowUserToAddRows = false;
            dataGridViewVehicles.AllowUserToDeleteRows = false;
            dataGridViewVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVehicles.Dock = DockStyle.Fill;
            dataGridViewVehicles.Location = new Point(3, 3);
            dataGridViewVehicles.MultiSelect = false;
            dataGridViewVehicles.Name = "dataGridViewVehicles";
            dataGridViewVehicles.ReadOnly = true;
            dataGridViewVehicles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVehicles.Size = new Size(794, 323);
            dataGridViewVehicles.TabIndex = 0;
            // 
            // tableLayoutPanelBottom
            // 
            tableLayoutPanelBottom.BackColor = SystemColors.ControlDarkDark;
            tableLayoutPanelBottom.ColumnCount = 3;
            tableLayoutPanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanelBottom.Controls.Add(panelButtons, 1, 1);
            tableLayoutPanelBottom.Controls.Add(panelSearch, 1, 0);
            tableLayoutPanelBottom.Controls.Add(btnSettings, 0, 1);
            tableLayoutPanelBottom.Dock = DockStyle.Fill;
            tableLayoutPanelBottom.Location = new Point(3, 332);
            tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            tableLayoutPanelBottom.RowCount = 2;
            tableLayoutPanelBottom.RowStyles.Add(new RowStyle(SizeType.Percent, 28.94737F));
            tableLayoutPanelBottom.RowStyles.Add(new RowStyle(SizeType.Percent, 71.05263F));
            tableLayoutPanelBottom.Size = new Size(794, 115);
            tableLayoutPanelBottom.TabIndex = 1;
            // 
            // panelButtons
            // 
            panelButtons.ColumnCount = 5;
            panelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            panelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            panelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            panelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            panelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            panelButtons.Controls.Add(buttonExit, 4, 1);
            panelButtons.Controls.Add(buttonExportXLS, 3, 1);
            panelButtons.Controls.Add(buttonImportXLS, 2, 1);
            panelButtons.Controls.Add(buttonExportXML, 1, 1);
            panelButtons.Controls.Add(buttonRefresh, 0, 0);
            panelButtons.Controls.Add(buttonImportXML, 0, 1);
            panelButtons.Controls.Add(buttonDeleteVehicle, 2, 0);
            panelButtons.Controls.Add(buttonAddVehicle, 1, 0);
            panelButtons.Controls.Add(buttonUpdate, 4, 0);
            panelButtons.Controls.Add(buttonDetails, 3, 0);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(82, 36);
            panelButtons.Name = "panelButtons";
            panelButtons.RowCount = 2;
            panelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelButtons.Size = new Size(629, 76);
            panelButtons.TabIndex = 4;
            // 
            // buttonExit
            // 
            buttonExit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonExit.AutoSize = true;
            buttonExit.BackColor = SystemColors.ActiveBorder;
            buttonExit.FlatStyle = FlatStyle.Popup;
            buttonExit.Location = new Point(503, 41);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(123, 32);
            buttonExit.TabIndex = 10;
            buttonExit.Text = "Wyjdź";
            buttonExit.UseVisualStyleBackColor = false;
            // 
            // buttonExportXLS
            // 
            buttonExportXLS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonExportXLS.AutoSize = true;
            buttonExportXLS.BackColor = Color.MediumSlateBlue;
            buttonExportXLS.FlatStyle = FlatStyle.Popup;
            buttonExportXLS.Location = new Point(378, 41);
            buttonExportXLS.Name = "buttonExportXLS";
            buttonExportXLS.Size = new Size(119, 32);
            buttonExportXLS.TabIndex = 9;
            buttonExportXLS.Text = "Export XLS";
            buttonExportXLS.UseVisualStyleBackColor = false;
            // 
            // buttonImportXLS
            // 
            buttonImportXLS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonImportXLS.AutoSize = true;
            buttonImportXLS.BackColor = Color.RoyalBlue;
            buttonImportXLS.FlatStyle = FlatStyle.Popup;
            buttonImportXLS.Location = new Point(253, 41);
            buttonImportXLS.Name = "buttonImportXLS";
            buttonImportXLS.Size = new Size(119, 32);
            buttonImportXLS.TabIndex = 8;
            buttonImportXLS.Text = "Import XLS";
            buttonImportXLS.UseVisualStyleBackColor = false;
            // 
            // buttonExportXML
            // 
            buttonExportXML.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonExportXML.AutoSize = true;
            buttonExportXML.BackColor = Color.MediumSlateBlue;
            buttonExportXML.FlatStyle = FlatStyle.Popup;
            buttonExportXML.Location = new Point(128, 41);
            buttonExportXML.Name = "buttonExportXML";
            buttonExportXML.Size = new Size(119, 32);
            buttonExportXML.TabIndex = 7;
            buttonExportXML.Text = "Export XML";
            buttonExportXML.UseVisualStyleBackColor = false;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonRefresh.AutoSize = true;
            buttonRefresh.BackColor = Color.CornflowerBlue;
            buttonRefresh.FlatStyle = FlatStyle.Popup;
            buttonRefresh.Location = new Point(3, 3);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(119, 32);
            buttonRefresh.TabIndex = 1;
            buttonRefresh.Text = "Odśwież";
            buttonRefresh.UseVisualStyleBackColor = false;
            // 
            // buttonImportXML
            // 
            buttonImportXML.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonImportXML.AutoSize = true;
            buttonImportXML.BackColor = Color.RoyalBlue;
            buttonImportXML.FlatStyle = FlatStyle.Popup;
            buttonImportXML.Location = new Point(3, 41);
            buttonImportXML.Name = "buttonImportXML";
            buttonImportXML.Size = new Size(119, 32);
            buttonImportXML.TabIndex = 6;
            buttonImportXML.Text = "Import XML";
            buttonImportXML.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteVehicle
            // 
            buttonDeleteVehicle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonDeleteVehicle.AutoSize = true;
            buttonDeleteVehicle.BackColor = Color.Brown;
            buttonDeleteVehicle.FlatStyle = FlatStyle.Popup;
            buttonDeleteVehicle.Location = new Point(253, 3);
            buttonDeleteVehicle.Name = "buttonDeleteVehicle";
            buttonDeleteVehicle.Size = new Size(119, 32);
            buttonDeleteVehicle.TabIndex = 3;
            buttonDeleteVehicle.Text = "Usuń Pojazd";
            buttonDeleteVehicle.UseVisualStyleBackColor = false;
            // 
            // buttonAddVehicle
            // 
            buttonAddVehicle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonAddVehicle.AutoSize = true;
            buttonAddVehicle.BackColor = Color.ForestGreen;
            buttonAddVehicle.FlatStyle = FlatStyle.Popup;
            buttonAddVehicle.Location = new Point(128, 3);
            buttonAddVehicle.Name = "buttonAddVehicle";
            buttonAddVehicle.Size = new Size(119, 32);
            buttonAddVehicle.TabIndex = 2;
            buttonAddVehicle.Text = "Dodaj Pojazd";
            buttonAddVehicle.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonUpdate.AutoSize = true;
            buttonUpdate.BackColor = Color.Gold;
            buttonUpdate.FlatStyle = FlatStyle.Popup;
            buttonUpdate.Location = new Point(503, 3);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(123, 32);
            buttonUpdate.TabIndex = 5;
            buttonUpdate.Text = "Aktualizuj";
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonDetails
            // 
            buttonDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonDetails.AutoSize = true;
            buttonDetails.BackColor = Color.Orange;
            buttonDetails.FlatStyle = FlatStyle.Popup;
            buttonDetails.Location = new Point(378, 3);
            buttonDetails.Name = "buttonDetails";
            buttonDetails.Size = new Size(119, 32);
            buttonDetails.TabIndex = 4;
            buttonDetails.Text = "Szczegóły";
            buttonDetails.UseVisualStyleBackColor = false;
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(labelSearch);
            panelSearch.Controls.Add(textBoxSearch);
            panelSearch.Dock = DockStyle.Fill;
            panelSearch.Location = new Point(82, 3);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(629, 27);
            panelSearch.TabIndex = 6;
            // 
            // labelSearch
            // 
            labelSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelSearch.ForeColor = SystemColors.Control;
            labelSearch.Location = new Point(8, 0);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(79, 20);
            labelSearch.TabIndex = 5;
            labelSearch.Text = "Wyszukaj:";
            labelSearch.TextAlign = ContentAlignment.MiddleLeft;
            labelSearch.Click += LabelSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Location = new Point(97, 0);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(529, 23);
            textBoxSearch.TabIndex = 0;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSettings.BackColor = Color.Bisque;
            btnSettings.Location = new Point(3, 36);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(73, 76);
            btnSettings.TabIndex = 1;
            btnSettings.Text = "Ustawienia połączenia";
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // MainFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanelMain);
            MinimumSize = new Size(816, 489);
            Name = "MainFrame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Baza danych pojazdów";
            Load += MainFrame_Load;
            tableLayoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehicles).EndInit();
            tableLayoutPanelBottom.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            panelButtons.PerformLayout();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.DataGridView dataGridViewVehicles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonAddVehicle;
        private System.Windows.Forms.Button buttonDeleteVehicle;
        private System.Windows.Forms.Button buttonDetails;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonImportXML;
        private System.Windows.Forms.Button buttonExportXML;
        private System.Windows.Forms.Button buttonImportXLS;
        private System.Windows.Forms.Button buttonExportXLS;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TableLayoutPanel panelButtons;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label labelSearch;
        private Button btnSettings;
    }
}