namespace Store_Management_System
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            ProductDataGridView = new DataGridView();
            AddSellerGroupBox = new GroupBox();
            btnAdd = new Button();
            cmbCategory = new ComboBox();
            btnClear = new Button();
            txtPrice = new TextBox();
            lblProductPrice = new Label();
            txtQty = new TextBox();
            lblProductQuantity = new Label();
            lblProductCategory = new Label();
            txtProductID = new TextBox();
            lblProductID = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtProdName = new TextBox();
            lblProductName = new Label();
            panel1 = new Panel();
            btnSearchCat = new Button();
            cmbsearch = new ComboBox();
            lblSearch = new Label();
            btnRefrash = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).BeginInit();
            AddSellerGroupBox.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ProductDataGridView
            // 
            ProductDataGridView.AllowUserToAddRows = false;
            ProductDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductDataGridView.BackgroundColor = Color.White;
            ProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDataGridView.Location = new Point(7, 410);
            ProductDataGridView.Name = "ProductDataGridView";
            ProductDataGridView.RowHeadersVisible = false;
            ProductDataGridView.RowHeadersWidth = 51;
            ProductDataGridView.RowTemplate.Height = 29;
            ProductDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductDataGridView.Size = new Size(1404, 397);
            ProductDataGridView.TabIndex = 7;
            ProductDataGridView.CellContentClick += ProductDataGridView_CellContentClick;
            ProductDataGridView.Click += ProductDataGridView_Click;
            // 
            // AddSellerGroupBox
            // 
            AddSellerGroupBox.BackColor = Color.CornflowerBlue;
            AddSellerGroupBox.Controls.Add(btnAdd);
            AddSellerGroupBox.Controls.Add(cmbCategory);
            AddSellerGroupBox.Controls.Add(btnClear);
            AddSellerGroupBox.Controls.Add(txtPrice);
            AddSellerGroupBox.Controls.Add(lblProductPrice);
            AddSellerGroupBox.Controls.Add(txtQty);
            AddSellerGroupBox.Controls.Add(lblProductQuantity);
            AddSellerGroupBox.Controls.Add(lblProductCategory);
            AddSellerGroupBox.Controls.Add(txtProductID);
            AddSellerGroupBox.Controls.Add(lblProductID);
            AddSellerGroupBox.Controls.Add(btnDelete);
            AddSellerGroupBox.Controls.Add(btnUpdate);
            AddSellerGroupBox.Controls.Add(txtProdName);
            AddSellerGroupBox.Controls.Add(lblProductName);
            AddSellerGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddSellerGroupBox.Location = new Point(8, 11);
            AddSellerGroupBox.Name = "AddSellerGroupBox";
            AddSellerGroupBox.Size = new Size(1404, 322);
            AddSellerGroupBox.TabIndex = 6;
            AddSellerGroupBox.TabStop = false;
            AddSellerGroupBox.Text = "Manage Product";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.HighlightText;
            btnAdd.Location = new Point(324, 254);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 50);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(777, 176);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(331, 36);
            cmbCategory.TabIndex = 18;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Yellow;
            btnClear.Location = new Point(778, 254);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(124, 50);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(777, 112);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(331, 34);
            txtPrice.TabIndex = 16;
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductPrice.Location = new Point(613, 110);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(59, 28);
            lblProductPrice.TabIndex = 15;
            lblProductPrice.Text = "Price";
            // 
            // txtQty
            // 
            txtQty.Location = new Point(200, 176);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(331, 34);
            txtQty.TabIndex = 14;
            // 
            // lblProductQuantity
            // 
            lblProductQuantity.AutoSize = true;
            lblProductQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductQuantity.Location = new Point(2, 174);
            lblProductQuantity.Name = "lblProductQuantity";
            lblProductQuantity.Size = new Size(95, 28);
            lblProductQuantity.TabIndex = 13;
            lblProductQuantity.Text = "Quantity";
            // 
            // lblProductCategory
            // 
            lblProductCategory.AutoSize = true;
            lblProductCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductCategory.Location = new Point(613, 174);
            lblProductCategory.Name = "lblProductCategory";
            lblProductCategory.Size = new Size(98, 28);
            lblProductCategory.TabIndex = 11;
            lblProductCategory.Text = "Category";
            // 
            // txtProductID
            // 
            txtProductID.BackColor = Color.White;
            txtProductID.Location = new Point(146, 52);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(91, 34);
            txtProductID.TabIndex = 8;
            txtProductID.TextChanged += txtProductID_TextChanged_1;
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Location = new Point(2, 52);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(113, 28);
            lblProductID.TabIndex = 7;
            lblProductID.Text = "Product ID";
            lblProductID.Click += lblProductID_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.Location = new Point(627, 254);
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
            btnUpdate.Location = new Point(489, 254);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(124, 50);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtProdName
            // 
            txtProdName.Location = new Point(200, 112);
            txtProdName.Name = "txtProdName";
            txtProdName.Size = new Size(331, 34);
            txtProdName.TabIndex = 2;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductName.Location = new Point(2, 110);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(148, 28);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Product Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(btnSearchCat);
            panel1.Controls.Add(cmbsearch);
            panel1.Controls.Add(lblSearch);
            panel1.Controls.Add(btnRefrash);
            panel1.Location = new Point(8, 339);
            panel1.Name = "panel1";
            panel1.Size = new Size(1404, 68);
            panel1.TabIndex = 8;
            // 
            // btnSearchCat
            // 
            btnSearchCat.BackColor = Color.DarkGray;
            btnSearchCat.Location = new Point(741, 12);
            btnSearchCat.Name = "btnSearchCat";
            btnSearchCat.Size = new Size(124, 50);
            btnSearchCat.TabIndex = 22;
            btnSearchCat.Text = "Search";
            btnSearchCat.UseVisualStyleBackColor = false;
            btnSearchCat.Click += btnSearchCat_Click;
            // 
            // cmbsearch
            // 
            cmbsearch.FormattingEnabled = true;
            cmbsearch.Location = new Point(246, 20);
            cmbsearch.Name = "cmbsearch";
            cmbsearch.Size = new Size(465, 36);
            cmbsearch.TabIndex = 20;
            cmbsearch.SelectedIndexChanged += cmbSearch_SelectedIndexChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSearch.Location = new Point(14, 18);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(75, 28);
            lblSearch.TabIndex = 19;
            lblSearch.Text = "Search";
            // 
            // btnRefrash
            // 
            btnRefrash.BackColor = Color.CadetBlue;
            btnRefrash.Location = new Point(897, 12);
            btnRefrash.Name = "btnRefrash";
            btnRefrash.Size = new Size(124, 50);
            btnRefrash.TabIndex = 19;
            btnRefrash.Text = "Refresh";
            btnRefrash.UseVisualStyleBackColor = false;
            btnRefrash.Click += btnRefrash_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1417, 815);
            Controls.Add(panel1);
            Controls.Add(ProductDataGridView);
            Controls.Add(AddSellerGroupBox);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProductForm";
            Load += AddProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).EndInit();
            AddSellerGroupBox.ResumeLayout(false);
            AddSellerGroupBox.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ProductDataGridView;
        private GroupBox AddSellerGroupBox;
        private TextBox txtPrice;
        private Label lblProductPrice;
        private TextBox txtQty;
        private Label lblProductQuantity;
        private Label lblProductCategory;
        private TextBox txtProductID;
        private Label lblProductID;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtProdName;
        private Label lblProductName;
        private Button btnClear;
        private ComboBox cmbCategory;
        private Panel panel1;
        private ComboBox cmbsearch;
        private Label lblSearch;
        private Button btnRefrash;
        private Button btnAdd;
        private Button btnSearchCat;
    }
}