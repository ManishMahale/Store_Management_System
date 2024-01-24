namespace Store_Management_System
{
    partial class AddNewSellerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewSellerForm));
            AddSellerGroupBox = new GroupBox();
            txtSellerPass = new TextBox();
            lblSellerPass = new Label();
            txtSellerPhone = new TextBox();
            lblPhone = new Label();
            txtSellerAge = new TextBox();
            lblSellerAge = new Label();
            btnClearCat = new Button();
            txtSellerID = new TextBox();
            lblSellerID = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtSellerName = new TextBox();
            lblSellerName = new Label();
            panel = new Panel();
            lblPanal = new Label();
            SellerDataGridView = new DataGridView();
            AddSellerGroupBox.SuspendLayout();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SellerDataGridView).BeginInit();
            SuspendLayout();
            // 
            // AddSellerGroupBox
            // 
            AddSellerGroupBox.Controls.Add(txtSellerPass);
            AddSellerGroupBox.Controls.Add(lblSellerPass);
            AddSellerGroupBox.Controls.Add(txtSellerPhone);
            AddSellerGroupBox.Controls.Add(lblPhone);
            AddSellerGroupBox.Controls.Add(txtSellerAge);
            AddSellerGroupBox.Controls.Add(lblSellerAge);
            AddSellerGroupBox.Controls.Add(btnClearCat);
            AddSellerGroupBox.Controls.Add(txtSellerID);
            AddSellerGroupBox.Controls.Add(lblSellerID);
            AddSellerGroupBox.Controls.Add(btnDelete);
            AddSellerGroupBox.Controls.Add(btnUpdate);
            AddSellerGroupBox.Controls.Add(btnAdd);
            AddSellerGroupBox.Controls.Add(txtSellerName);
            AddSellerGroupBox.Controls.Add(lblSellerName);
            AddSellerGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddSellerGroupBox.Location = new Point(9, 103);
            AddSellerGroupBox.Name = "AddSellerGroupBox";
            AddSellerGroupBox.Size = new Size(1404, 322);
            AddSellerGroupBox.TabIndex = 4;
            AddSellerGroupBox.TabStop = false;
            AddSellerGroupBox.Text = "Add New Seller";
            // 
            // txtSellerPass
            // 
            txtSellerPass.Location = new Point(849, 113);
            txtSellerPass.Name = "txtSellerPass";
            txtSellerPass.Size = new Size(297, 34);
            txtSellerPass.TabIndex = 16;
            // 
            // lblSellerPass
            // 
            lblSellerPass.AutoSize = true;
            lblSellerPass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSellerPass.Location = new Point(617, 111);
            lblSellerPass.Name = "lblSellerPass";
            lblSellerPass.Size = new Size(101, 28);
            lblSellerPass.TabIndex = 15;
            lblSellerPass.Text = "Password";
            // 
            // txtSellerPhone
            // 
            txtSellerPhone.Location = new Point(238, 177);
            txtSellerPhone.Name = "txtSellerPhone";
            txtSellerPhone.Size = new Size(297, 34);
            txtSellerPhone.TabIndex = 14;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhone.Location = new Point(6, 175);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(130, 28);
            lblPhone.TabIndex = 13;
            lblPhone.Text = "Seller Phone";
            // 
            // txtSellerAge
            // 
            txtSellerAge.Location = new Point(849, 177);
            txtSellerAge.Name = "txtSellerAge";
            txtSellerAge.Size = new Size(297, 34);
            txtSellerAge.TabIndex = 12;
            // 
            // lblSellerAge
            // 
            lblSellerAge.AutoSize = true;
            lblSellerAge.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSellerAge.Location = new Point(617, 175);
            lblSellerAge.Name = "lblSellerAge";
            lblSellerAge.Size = new Size(108, 28);
            lblSellerAge.TabIndex = 11;
            lblSellerAge.Text = "Seller Age";
            // 
            // btnClearCat
            // 
            btnClearCat.Location = new Point(765, 255);
            btnClearCat.Name = "btnClearCat";
            btnClearCat.Size = new Size(124, 50);
            btnClearCat.TabIndex = 10;
            btnClearCat.Text = "Clear";
            btnClearCat.UseVisualStyleBackColor = true;
            btnClearCat.Click += btnClearCat_Click_1;
            // 
            // txtSellerID
            // 
            txtSellerID.BackColor = Color.White;
            txtSellerID.Location = new Point(150, 53);
            txtSellerID.Name = "txtSellerID";
            txtSellerID.ReadOnly = true;
            txtSellerID.Size = new Size(91, 34);
            txtSellerID.TabIndex = 8;
            // 
            // lblSellerID
            // 
            lblSellerID.AutoSize = true;
            lblSellerID.Location = new Point(6, 53);
            lblSellerID.Name = "lblSellerID";
            lblSellerID.Size = new Size(92, 28);
            lblSellerID.TabIndex = 7;
            lblSellerID.Text = "Seller ID";
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
            // txtSellerName
            // 
            txtSellerName.Location = new Point(238, 113);
            txtSellerName.Name = "txtSellerName";
            txtSellerName.Size = new Size(297, 34);
            txtSellerName.TabIndex = 2;
            // 
            // lblSellerName
            // 
            lblSellerName.AutoSize = true;
            lblSellerName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSellerName.Location = new Point(6, 111);
            lblSellerName.Name = "lblSellerName";
            lblSellerName.Size = new Size(127, 28);
            lblSellerName.TabIndex = 0;
            lblSellerName.Text = "Seller Name";
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(255, 192, 128);
            panel.Controls.Add(lblPanal);
            panel.Location = new Point(12, 12);
            panel.Name = "panel";
            panel.Size = new Size(1401, 84);
            panel.TabIndex = 3;
            // 
            // lblPanal
            // 
            lblPanal.AutoSize = true;
            lblPanal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPanal.Location = new Point(602, 31);
            lblPanal.Name = "lblPanal";
            lblPanal.Size = new Size(96, 28);
            lblPanal.TabIndex = 0;
            lblPanal.Text = "Go_Store";
            // 
            // SellerDataGridView
            // 
            SellerDataGridView.AllowUserToAddRows = false;
            SellerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SellerDataGridView.BackgroundColor = Color.White;
            SellerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SellerDataGridView.Location = new Point(4, 424);
            SellerDataGridView.Name = "SellerDataGridView";
            SellerDataGridView.RowHeadersVisible = false;
            SellerDataGridView.RowHeadersWidth = 51;
            SellerDataGridView.RowTemplate.Height = 29;
            SellerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SellerDataGridView.Size = new Size(1409, 388);
            SellerDataGridView.TabIndex = 5;
            SellerDataGridView.CellMouseLeave += SellerDataGridView_CellMouseLeave;
            SellerDataGridView.Click += SellerDataGridView_Click;
            // 
            // AddNewSellerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1417, 815);
            Controls.Add(SellerDataGridView);
            Controls.Add(AddSellerGroupBox);
            Controls.Add(panel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddNewSellerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewSellerForm";
            Load += AddNewSellerForm_Load;
            AddSellerGroupBox.ResumeLayout(false);
            AddSellerGroupBox.PerformLayout();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SellerDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox AddSellerGroupBox;
        private Button btnClearCat;
        private TextBox txtSellerID;
        private Label lblSellerID;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private RichTextBox CatrichTextBox;
        private TextBox txtSellerName;
        private Label lblCatDesc;
        private Label lblSellerName;
        private Panel panel;
        private Label lblPanal;
        private TextBox txtSellerAge;
        private Label lblSellerAge;
        private TextBox txtSellerPass;
        private Label lblSellerPass;
        private TextBox txtSellerPhone;
        private Label lblPhone;
        private DataGridView SellerDataGridView;
    }
}