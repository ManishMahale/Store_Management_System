namespace Store_Management_System
{
    partial class Login_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Page));
            panel = new Panel();
            lblPanal = new Label();
            groupBox = new GroupBox();
            txtUsername = new TextBox();
            cmbRole = new ComboBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            lblRole = new Label();
            btnClear = new Button();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            panel.SuspendLayout();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(255, 192, 128);
            panel.Controls.Add(lblPanal);
            panel.Location = new Point(0, 4);
            panel.Name = "panel";
            panel.Size = new Size(849, 123);
            panel.TabIndex = 0;
            // 
            // lblPanal
            // 
            lblPanal.AutoSize = true;
            lblPanal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPanal.Location = new Point(353, 49);
            lblPanal.Name = "lblPanal";
            lblPanal.Size = new Size(143, 41);
            lblPanal.TabIndex = 0;
            lblPanal.Text = "Go_Store";
            // 
            // groupBox
            // 
            groupBox.Controls.Add(txtUsername);
            groupBox.Controls.Add(cmbRole);
            groupBox.Controls.Add(txtPassword);
            groupBox.Controls.Add(lblPassword);
            groupBox.Controls.Add(lblUsername);
            groupBox.Controls.Add(lblRole);
            groupBox.Controls.Add(btnClear);
            groupBox.Controls.Add(btnLogin);
            groupBox.Location = new Point(333, 130);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(502, 381);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Enter += groupBox_Enter;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(136, 130);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter Username";
            txtUsername.Size = new Size(286, 31);
            txtUsername.TabIndex = 2;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // cmbRole
            // 
            cmbRole.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Select Role", "Admin", "Seller" });
            cmbRole.Location = new Point(136, 81);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(286, 33);
            cmbRole.TabIndex = 1;
            cmbRole.SelectedIndexChanged += comboBox1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(136, 178);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter Password";
            txtPassword.Size = new Size(286, 31);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(21, 179);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(101, 28);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(21, 129);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(106, 28);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRole.Location = new Point(21, 77);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(54, 28);
            lblRole.TabIndex = 2;
            lblRole.Text = "Role";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkOrange;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(255, 271);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(144, 54);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkOrange;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(67, 271);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(144, 54);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 294);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 508);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox);
            Controls.Add(panel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Page";
            Load += Login_Page_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private GroupBox groupBox;
        private Button btnLogin;
        private PictureBox pictureBox1;
        private Label lblPanal;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblRole;
        private Button btnClear;
        private ComboBox cmbRole;
        private TextBox txtUsername;
    }
}