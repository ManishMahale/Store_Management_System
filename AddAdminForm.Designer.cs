namespace Store_Management_System
{
    partial class AddAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdminForm));
            AddAdminGroupBox = new GroupBox();
            txtAdminPass = new TextBox();
            lblAdminPass = new Label();
            btnClear = new Button();
            txtAdminID = new TextBox();
            lblAdminID = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtAdminName = new TextBox();
            lblAdminName = new Label();
            AdminDataGridView = new DataGridView();
            AddAdminGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdminDataGridView).BeginInit();
            SuspendLayout();
            // 
            // AddAdminGroupBox
            // 
            AddAdminGroupBox.Controls.Add(txtAdminPass);
            AddAdminGroupBox.Controls.Add(lblAdminPass);
            AddAdminGroupBox.Controls.Add(btnClear);
            AddAdminGroupBox.Controls.Add(txtAdminID);
            AddAdminGroupBox.Controls.Add(lblAdminID);
            AddAdminGroupBox.Controls.Add(btnDelete);
            AddAdminGroupBox.Controls.Add(btnUpdate);
            AddAdminGroupBox.Controls.Add(btnAdd);
            AddAdminGroupBox.Controls.Add(txtAdminName);
            AddAdminGroupBox.Controls.Add(lblAdminName);
            AddAdminGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddAdminGroupBox.Location = new Point(4, 12);
            AddAdminGroupBox.Name = "AddAdminGroupBox";
            AddAdminGroupBox.Size = new Size(1404, 322);
            AddAdminGroupBox.TabIndex = 5;
            AddAdminGroupBox.TabStop = false;
            AddAdminGroupBox.Text = "Add New Admin";
            // 
            // txtAdminPass
            // 
            txtAdminPass.Location = new Point(181, 166);
            txtAdminPass.Name = "txtAdminPass";
            txtAdminPass.Size = new Size(297, 34);
            txtAdminPass.TabIndex = 16;
            // 
            // lblAdminPass
            // 
            lblAdminPass.AutoSize = true;
            lblAdminPass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdminPass.Location = new Point(6, 166);
            lblAdminPass.Name = "lblAdminPass";
            lblAdminPass.Size = new Size(101, 28);
            lblAdminPass.TabIndex = 15;
            lblAdminPass.Text = "Password";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(765, 255);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(124, 50);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtAdminID
            // 
            txtAdminID.BackColor = Color.White;
            txtAdminID.Location = new Point(181, 50);
            txtAdminID.Name = "txtAdminID";
            txtAdminID.Size = new Size(298, 34);
            txtAdminID.TabIndex = 8;
            txtAdminID.TextChanged += txtAdminID_TextChanged;
            // 
            // lblAdminID
            // 
            lblAdminID.AutoSize = true;
            lblAdminID.Location = new Point(6, 53);
            lblAdminID.Name = "lblAdminID";
            lblAdminID.Size = new Size(101, 28);
            lblAdminID.TabIndex = 7;
            lblAdminID.Text = "Admin ID";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Wheat;
            btnDelete.Location = new Point(631, 255);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 50);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkGoldenrod;
            btnUpdate.Location = new Point(493, 255);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(124, 50);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.CornflowerBlue;
            btnAdd.Location = new Point(355, 255);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 50);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtAdminName
            // 
            txtAdminName.Location = new Point(181, 108);
            txtAdminName.Name = "txtAdminName";
            txtAdminName.Size = new Size(698, 34);
            txtAdminName.TabIndex = 2;
            // 
            // lblAdminName
            // 
            lblAdminName.AutoSize = true;
            lblAdminName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdminName.Location = new Point(6, 111);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(136, 28);
            lblAdminName.TabIndex = 0;
            lblAdminName.Text = "Admin Name";
            // 
            // AdminDataGridView
            // 
            AdminDataGridView.AllowUserToAddRows = false;
            AdminDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AdminDataGridView.BackgroundColor = Color.White;
            AdminDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminDataGridView.Location = new Point(2, 340);
            AdminDataGridView.Name = "AdminDataGridView";
            AdminDataGridView.RowHeadersVisible = false;
            AdminDataGridView.RowHeadersWidth = 51;
            AdminDataGridView.RowTemplate.Height = 29;
            AdminDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AdminDataGridView.Size = new Size(1409, 463);
            AdminDataGridView.TabIndex = 6;
            AdminDataGridView.Click += AdminDataGridView_Click;
            // 
            // AddAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1417, 815);
            Controls.Add(AdminDataGridView);
            Controls.Add(AddAdminGroupBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddAdminForm";
            Load += AddAdminForm_Load;
            AddAdminGroupBox.ResumeLayout(false);
            AddAdminGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AdminDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox AddAdminGroupBox;
        private TextBox txtAdminPass;
        private Label lblAdminPass;
        private Button btnClear;
        private TextBox txtAdminID;
        private Label lblAdminID;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtAdminName;
        private Label lblAdminName;
        private DataGridView AdminDataGridView;
    }
}