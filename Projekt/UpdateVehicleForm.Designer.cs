namespace Projekt
{
    partial class UpdateVehicleForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            lblBrand = new Label();
            lblModel = new Label();
            lblYear = new Label();
            lblType = new Label();
            txtModel = new TextBox();
            txtYear = new TextBox();
            txtSpecific = new TextBox();
            txtBrand = new TextBox();
            lblSpecific = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            comboType = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Gainsboro;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblBrand, 0, 0);
            tableLayoutPanel1.Controls.Add(lblModel, 0, 1);
            tableLayoutPanel1.Controls.Add(lblYear, 0, 2);
            tableLayoutPanel1.Controls.Add(lblType, 0, 3);
            tableLayoutPanel1.Controls.Add(txtModel, 1, 1);
            tableLayoutPanel1.Controls.Add(txtYear, 1, 2);
            tableLayoutPanel1.Controls.Add(txtSpecific, 1, 4);
            tableLayoutPanel1.Controls.Add(txtBrand, 1, 0);
            tableLayoutPanel1.Controls.Add(lblSpecific, 0, 4);
            tableLayoutPanel1.Controls.Add(btnOK, 0, 5);
            tableLayoutPanel1.Controls.Add(btnCancel, 1, 5);
            tableLayoutPanel1.Controls.Add(comboType, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.Size = new Size(458, 222);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblBrand
            // 
            lblBrand.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(3, 11);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(223, 15);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "Marka:";
            // 
            // lblModel
            // 
            lblModel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblModel.AutoSize = true;
            lblModel.Location = new Point(3, 48);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(223, 15);
            lblModel.TabIndex = 1;
            lblModel.Text = "Model:";
            // 
            // lblYear
            // 
            lblYear.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblYear.AutoSize = true;
            lblYear.Location = new Point(3, 85);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(223, 15);
            lblYear.TabIndex = 2;
            lblYear.Text = "Rok Produkcji:";
            // 
            // lblType
            // 
            lblType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblType.AutoSize = true;
            lblType.Location = new Point(3, 122);
            lblType.Name = "lblType";
            lblType.Size = new Size(223, 15);
            lblType.TabIndex = 3;
            lblType.Text = "Typ (Osobowy/Motor):";
            // 
            // txtModel
            // 
            txtModel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtModel.Location = new Point(232, 44);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(223, 23);
            txtModel.TabIndex = 6;
            // 
            // txtYear
            // 
            txtYear.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtYear.Location = new Point(232, 81);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(223, 23);
            txtYear.TabIndex = 7;
            // 
            // txtSpecific
            // 
            txtSpecific.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSpecific.Location = new Point(232, 155);
            txtSpecific.Name = "txtSpecific";
            txtSpecific.Size = new Size(223, 23);
            txtSpecific.TabIndex = 9;
            // 
            // txtBrand
            // 
            txtBrand.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBrand.Location = new Point(232, 7);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(223, 23);
            txtBrand.TabIndex = 5;
            // 
            // lblSpecific
            // 
            lblSpecific.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblSpecific.AutoSize = true;
            lblSpecific.Location = new Point(3, 159);
            lblSpecific.Name = "lblSpecific";
            lblSpecific.Size = new Size(223, 15);
            lblSpecific.TabIndex = 4;
            lblSpecific.Text = "Specyficzny (Drzwi/Pojemność):";
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Right;
            btnOK.BackColor = Color.SeaGreen;
            btnOK.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnOK.Location = new Point(151, 188);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 31);
            btnOK.TabIndex = 10;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Left;
            btnCancel.BackColor = Color.Gray;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnCancel.Location = new Point(232, 188);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 31);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // comboType
            // 
            comboType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboType.FormattingEnabled = true;
            comboType.Location = new Point(232, 118);
            comboType.Name = "comboType";
            comboType.Size = new Size(223, 23);
            comboType.TabIndex = 12;
            // 
            // UpdateVehicleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 222);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(474, 261);
            Name = "UpdateVehicleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aktualizuj Pojazd";
            Load += UpdateVehicleForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtSpecific;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblSpecific;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboType;
    }
}