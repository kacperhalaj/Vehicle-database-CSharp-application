namespace Projekt
{
    partial class LoginForm
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(PanelLogowania, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 2, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(568, 385);
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
            PanelLogowania.Dock = DockStyle.Fill;
            PanelLogowania.Location = new Point(23, 97);
            PanelLogowania.Margin = new Padding(3, 6, 3, 6);
            PanelLogowania.Name = "PanelLogowania";
            tableLayoutPanel1.SetRowSpan(PanelLogowania, 3);
            PanelLogowania.Size = new Size(522, 261);
            PanelLogowania.TabIndex = 2;
            PanelLogowania.Paint += PanelLogowania_Paint;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Location = new Point(305, 195);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(81, 36);
            btnExit.TabIndex = 6;
            btnExit.Text = "Wyjdź";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.FromArgb(51, 185, 104);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Location = new Point(135, 195);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(87, 36);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Zaloguj się";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(176, 125);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(251, 23);
            txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.Location = new Point(176, 53);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(251, 23);
            txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Left;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblPassword.Location = new Point(101, 126);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(69, 22);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Hasło:";
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Left;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblUsername.Location = new Point(101, 53);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(70, 22);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Login:";
            // 
            // panel1
            // 
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(199, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 85);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
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
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(23, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(170, 85);
            panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 385);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(584, 424);
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

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelLogowania;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}