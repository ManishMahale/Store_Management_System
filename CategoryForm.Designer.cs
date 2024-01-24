namespace Store_Management_System
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            panel = new Panel();
            lblPanal = new Label();
            AddCatgroupBox = new GroupBox();
            btnClearCat = new Button();
            txtCatID = new TextBox();
            lblCatID = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAddCat = new Button();
            CatrichTextBox = new RichTextBox();
            txtCatName = new TextBox();
            lblCatDesc = new Label();
            lblCatName = new Label();
            CatdataGridView = new DataGridView();
            panel.SuspendLayout();
            AddCatgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CatdataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(255, 192, 128);
            panel.Controls.Add(lblPanal);
            panel.Location = new Point(12, 12);
            panel.Name = "panel";
            panel.Size = new Size(1300, 85);
            panel.TabIndex = 1;
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
            // AddCatgroupBox
            // 
            AddCatgroupBox.Controls.Add(btnClearCat);
            AddCatgroupBox.Controls.Add(txtCatID);
            AddCatgroupBox.Controls.Add(lblCatID);
            AddCatgroupBox.Controls.Add(btnDelete);
            AddCatgroupBox.Controls.Add(btnUpdate);
            AddCatgroupBox.Controls.Add(btnAddCat);
            AddCatgroupBox.Controls.Add(CatrichTextBox);
            AddCatgroupBox.Controls.Add(txtCatName);
            AddCatgroupBox.Controls.Add(lblCatDesc);
            AddCatgroupBox.Controls.Add(lblCatName);
            AddCatgroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddCatgroupBox.Location = new Point(12, 103);
            AddCatgroupBox.Name = "AddCatgroupBox";
            AddCatgroupBox.Size = new Size(541, 524);
            AddCatgroupBox.TabIndex = 2;
            AddCatgroupBox.TabStop = false;
            AddCatgroupBox.Text = "Add Category";
            AddCatgroupBox.Enter += AddCatgroupBox_Enter;
            AddCatgroupBox.Leave += CatdataGridView_Click;
            // 
            // btnClearCat
            // 
            btnClearCat.Location = new Point(411, 387);
            btnClearCat.Name = "btnClearCat";
            btnClearCat.Size = new Size(124, 50);
            btnClearCat.TabIndex = 10;
            btnClearCat.Text = "Clear";
            btnClearCat.UseVisualStyleBackColor = true;
            btnClearCat.Click += btnClearCat_Click;
            // 
            // txtCatID
            // 
            txtCatID.Location = new Point(238, 56);
            txtCatID.Name = "txtCatID";
            txtCatID.ReadOnly = true;
            txtCatID.Size = new Size(125, 34);
            txtCatID.TabIndex = 8;
            // 
            // lblCatID
            // 
            lblCatID.AutoSize = true;
            lblCatID.Location = new Point(94, 56);
            lblCatID.Name = "lblCatID";
            lblCatID.Size = new Size(125, 28);
            lblCatID.TabIndex = 7;
            lblCatID.Text = "Category ID";
            lblCatID.Click += label1_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Wheat;
            btnDelete.Location = new Point(277, 387);
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
            btnUpdate.Location = new Point(139, 387);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(124, 50);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAddCat
            // 
            btnAddCat.BackColor = Color.CornflowerBlue;
            btnAddCat.Location = new Point(1, 387);
            btnAddCat.Name = "btnAddCat";
            btnAddCat.Size = new Size(124, 50);
            btnAddCat.TabIndex = 4;
            btnAddCat.Text = "Add";
            btnAddCat.UseVisualStyleBackColor = false;
            btnAddCat.Click += btnAddCat_Click;
            // 
            // CatrichTextBox
            // 
            CatrichTextBox.Location = new Point(238, 191);
            CatrichTextBox.Name = "CatrichTextBox";
            CatrichTextBox.Size = new Size(297, 128);
            CatrichTextBox.TabIndex = 3;
            CatrichTextBox.Text = "";
            // 
            // txtCatName
            // 
            txtCatName.Location = new Point(238, 113);
            txtCatName.Name = "txtCatName";
            txtCatName.Size = new Size(297, 34);
            txtCatName.TabIndex = 2;
            // 
            // lblCatDesc
            // 
            lblCatDesc.AutoSize = true;
            lblCatDesc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCatDesc.Location = new Point(6, 183);
            lblCatDesc.Name = "lblCatDesc";
            lblCatDesc.Size = new Size(213, 28);
            lblCatDesc.TabIndex = 1;
            lblCatDesc.Text = "Category Description";
            // 
            // lblCatName
            // 
            lblCatName.AutoSize = true;
            lblCatName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCatName.Location = new Point(6, 111);
            lblCatName.Name = "lblCatName";
            lblCatName.Size = new Size(160, 28);
            lblCatName.TabIndex = 0;
            lblCatName.Text = "Category Name";
            // 
            // CatdataGridView
            // 
            CatdataGridView.AllowUserToAddRows = false;
            CatdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CatdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CatdataGridView.Location = new Point(559, 103);
            CatdataGridView.Name = "CatdataGridView";
            CatdataGridView.RowHeadersVisible = false;
            CatdataGridView.RowHeadersWidth = 51;
            CatdataGridView.RowTemplate.Height = 29;
            CatdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CatdataGridView.Size = new Size(753, 524);
            CatdataGridView.TabIndex = 3;
            CatdataGridView.CellContentClick += CatdataGridView_CellContentClick;
            CatdataGridView.Click += CatdataGridView_Click;
            CatdataGridView.DoubleClick += CatdataGridView_Click;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 630);
            Controls.Add(CatdataGridView);
            Controls.Add(AddCatgroupBox);
            Controls.Add(panel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CategoryForm";
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            AddCatgroupBox.ResumeLayout(false);
            AddCatgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CatdataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private Label lblPanal;
        private GroupBox AddCatgroupBox;
        private Label lblCatDesc;
        private Label lblCatName;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAddCat;
        private RichTextBox CatrichTextBox;
        private TextBox txtCatName;
        private DataGridView CatdataGridView;
        private Label lblCatID;
        private TextBox txtCatID;
        private Button btnClearCat;
    }
}