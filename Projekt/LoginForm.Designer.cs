namespace Projekt
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            PanelLogowania = new Panel();
            btnExit = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            PanelLogowania.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Highlight;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(PanelLogowania, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 2, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(568, 388);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // PanelLogowania
            // 
            PanelLogowania.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel1.SetColumnSpan(PanelLogowania, 3);
            PanelLogowania.Controls.Add(btnExit);
            PanelLogowania.Controls.Add(btnLogin);
            PanelLogowania.Controls.Add(txtPassword);
            PanelLogowania.Controls.Add(txtUsername);
            PanelLogowania.Controls.Add(lblPassword);
            PanelLogowania.Controls.Add(lblUsername);
            PanelLogowania.Location = new Point(23, 95);
            PanelLogowania.Name = "PanelLogowania";
            tableLayoutPanel1.SetRowSpan(PanelLogowania, 3);
            PanelLogowania.Size = new Size(522, 267);
            PanelLogowania.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.Location = new Point(305, 198);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(81, 36);
            btnExit.TabIndex = 6;
            btnExit.Text = "Wyjdź";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(51, 185, 104);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Location = new Point(135, 198);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(87, 36);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Zaloguj się";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(176, 127);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(251, 23);
            txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(176, 55);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(251, 23);
            txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblPassword.Location = new Point(101, 128);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(69, 22);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Hasło:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblUsername.Location = new Point(101, 55);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(70, 22);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Login:";
            // 
            // panel1
            // 
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(199, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 85);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(13, 28);
            label1.Name = "label1";
            label1.Size = new Size(320, 27);
            label1.TabIndex = 0;
            label1.Text = "Logowanie do bazy pojazdów";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(23, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(170, 85);
            panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(58, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 65);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 385);
            Controls.Add(tableLayoutPanel1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Logowanie";
            Load += LoginForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            PanelLogowania.ResumeLayout(false);
            PanelLogowania.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Panel PanelLogowania;
        private Button btnExit;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblPassword;
        private Label lblUsername;
        private Panel panel3;
        private PictureBox pictureBox1;
    }
}
