namespace Store_Management_System
{
    partial class SellingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            panel1 = new Panel();
            lblDate = new Label();
            lblSellingForm = new Label();
            lblID = new Label();
            txtProdID = new TextBox();
            lblQty = new Label();
            lblPrice = new Label();
            lblProduct = new Label();
            txtProduct = new TextBox();
            txtPrice = new TextBox();
            txtQty = new TextBox();
            btnAddOrder = new Button();
            cmbCategory = new ComboBox();
            btnRefCat = new Button();
            dataGridView2_Product = new DataGridView();
            dataGridView1_Order = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductPrice = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            lblSellingList = new Label();
            btnPrint = new Button();
            btnSearchCat = new Button();
            lblAmount = new Label();
            lblGrandTotal = new Label();
            btnSellingAdd = new Button();
            lblBillNum = new Label();
            txtBillNo = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2_Product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1_Order).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblSellingForm);
            panel1.Location = new Point(6, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1527, 56);
            panel1.TabIndex = 0;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblDate.ForeColor = Color.Cornsilk;
            lblDate.Location = new Point(1214, 15);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(87, 25);
            lblDate.TabIndex = 1;
            lblDate.Text = "Jan 2023";
            // 
            // lblSellingForm
            // 
            lblSellingForm.AutoSize = true;
            lblSellingForm.BackColor = Color.CornflowerBlue;
            lblSellingForm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblSellingForm.ForeColor = Color.Cornsilk;
            lblSellingForm.Location = new Point(594, 9);
            lblSellingForm.Name = "lblSellingForm";
            lblSellingForm.Size = new Size(150, 31);
            lblSellingForm.TabIndex = 0;
            lblSellingForm.Text = "Selling Form";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblID.Location = new Point(7, 69);
            lblID.Name = "lblID";
            lblID.Size = new Size(32, 28);
            lblID.TabIndex = 2;
            lblID.Text = "ID";
            // 
            // txtProdID
            // 
            txtProdID.BorderStyle = BorderStyle.FixedSingle;
            txtProdID.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtProdID.Location = new Point(148, 70);
            txtProdID.Name = "txtProdID";
            txtProdID.ReadOnly = true;
            txtProdID.Size = new Size(363, 31);
            txtProdID.TabIndex = 3;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQty.Location = new Point(-1, 218);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(90, 28);
            lblQty.TabIndex = 4;
            lblQty.Text = "Quantity";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.Location = new Point(6, 168);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(56, 28);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblProduct.Location = new Point(6, 116);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(83, 28);
            lblProduct.TabIndex = 6;
            lblProduct.Text = "Product";
            // 
            // txtProduct
            // 
            txtProduct.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtProduct.Location = new Point(148, 120);
            txtProduct.Name = "txtProduct";
            txtProduct.ReadOnly = true;
            txtProduct.Size = new Size(363, 31);
            txtProduct.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrice.Location = new Point(148, 169);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(363, 31);
            txtPrice.TabIndex = 8;
            // 
            // txtQty
            // 
            txtQty.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtQty.Location = new Point(148, 219);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(363, 31);
            txtQty.TabIndex = 9;
            // 
            // btnAddOrder
            // 
            btnAddOrder.BackColor = Color.Red;
            btnAddOrder.FlatStyle = FlatStyle.Flat;
            btnAddOrder.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAddOrder.ForeColor = Color.Cornsilk;
            btnAddOrder.Location = new Point(148, 277);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(363, 54);
            btnAddOrder.TabIndex = 10;
            btnAddOrder.Text = "Add Order";
            btnAddOrder.UseVisualStyleBackColor = false;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(7, 369);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(318, 36);
            cmbCategory.TabIndex = 11;
            // 
            // btnRefCat
            // 
            btnRefCat.BackColor = Color.Green;
            btnRefCat.FlatStyle = FlatStyle.Flat;
            btnRefCat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefCat.ForeColor = Color.Cornsilk;
            btnRefCat.Location = new Point(488, 355);
            btnRefCat.Name = "btnRefCat";
            btnRefCat.Size = new Size(115, 51);
            btnRefCat.TabIndex = 12;
            btnRefCat.Text = "Refresh";
            btnRefCat.UseVisualStyleBackColor = false;
            btnRefCat.Click += btnRefCat_Click;
            // 
            // dataGridView2_Product
            // 
            dataGridView2_Product.AllowUserToAddRows = false;
            dataGridView2_Product.AllowUserToDeleteRows = false;
            dataGridView2_Product.AllowUserToResizeRows = false;
            dataGridView2_Product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2_Product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2_Product.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView2_Product.Location = new Point(7, 422);
            dataGridView2_Product.Margin = new Padding(4);
            dataGridView2_Product.Name = "dataGridView2_Product";
            dataGridView2_Product.RowHeadersVisible = false;
            dataGridView2_Product.RowHeadersWidth = 51;
            dataGridView2_Product.RowTemplate.Height = 29;
            dataGridView2_Product.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2_Product.ShowEditingIcon = false;
            dataGridView2_Product.Size = new Size(596, 318);
            dataGridView2_Product.TabIndex = 13;
            dataGridView2_Product.Click += dataGridView2_Product_Click;
            // 
            // dataGridView1_Order
            // 
            dataGridView1_Order.AllowUserToAddRows = false;
            dataGridView1_Order.AllowUserToDeleteRows = false;
            dataGridView1_Order.AllowUserToResizeRows = false;
            dataGridView1_Order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1_Order.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, ProductPrice, Quantity, Total });
            dataGridView1_Order.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1_Order.Location = new Point(656, 70);
            dataGridView1_Order.Name = "dataGridView1_Order";
            dataGridView1_Order.RowHeadersWidth = 51;
            dataGridView1_Order.RowTemplate.Height = 29;
            dataGridView1_Order.Size = new Size(679, 284);
            dataGridView1_Order.TabIndex = 14;
            // 
            // ProductID
            // 
            ProductID.HeaderText = "ProductID";
            ProductID.MinimumWidth = 6;
            ProductID.Name = "ProductID";
            ProductID.Width = 125;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "ProductName";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.Width = 125;
            // 
            // ProductPrice
            // 
            ProductPrice.HeaderText = "ProductPrice";
            ProductPrice.MinimumWidth = 6;
            ProductPrice.Name = "ProductPrice";
            ProductPrice.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.Width = 125;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(656, 471);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(679, 215);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblSellingList
            // 
            lblSellingList.AutoSize = true;
            lblSellingList.BackColor = Color.Cyan;
            lblSellingList.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSellingList.Location = new Point(656, 443);
            lblSellingList.Name = "lblSellingList";
            lblSellingList.Size = new Size(95, 25);
            lblSellingList.TabIndex = 16;
            lblSellingList.Text = "Selling List";
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Green;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.Cornsilk;
            btnPrint.Location = new Point(1220, 692);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(115, 51);
            btnPrint.TabIndex = 18;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnSearchCat
            // 
            btnSearchCat.BackColor = Color.FromArgb(255, 255, 128);
            btnSearchCat.FlatStyle = FlatStyle.Flat;
            btnSearchCat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchCat.ForeColor = Color.Crimson;
            btnSearchCat.Location = new Point(352, 355);
            btnSearchCat.Name = "btnSearchCat";
            btnSearchCat.Size = new Size(115, 51);
            btnSearchCat.TabIndex = 19;
            btnSearchCat.Text = "Search";
            btnSearchCat.UseVisualStyleBackColor = false;
            btnSearchCat.Click += btnSearchCat_Click;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.BackColor = SystemColors.Control;
            lblAmount.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblAmount.ForeColor = Color.Crimson;
            lblAmount.Location = new Point(1077, 370);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(76, 25);
            lblAmount.TabIndex = 20;
            lblAmount.Text = "Amount";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.BackColor = Color.White;
            lblGrandTotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblGrandTotal.ForeColor = Color.Crimson;
            lblGrandTotal.Location = new Point(1229, 369);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(43, 31);
            lblGrandTotal.TabIndex = 21;
            lblGrandTotal.Text = "0.0";
            // 
            // btnSellingAdd
            // 
            btnSellingAdd.FlatStyle = FlatStyle.Flat;
            btnSellingAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSellingAdd.ForeColor = Color.Red;
            btnSellingAdd.Location = new Point(1241, 424);
            btnSellingAdd.Name = "btnSellingAdd";
            btnSellingAdd.Size = new Size(94, 44);
            btnSellingAdd.TabIndex = 22;
            btnSellingAdd.Text = "Add";
            btnSellingAdd.UseVisualStyleBackColor = true;
            btnSellingAdd.Click += btnSellingAdd_Click;
            // 
            // lblBillNum
            // 
            lblBillNum.AutoSize = true;
            lblBillNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBillNum.ForeColor = Color.Red;
            lblBillNum.Location = new Point(935, 440);
            lblBillNum.Name = "lblBillNum";
            lblBillNum.Size = new Size(115, 28);
            lblBillNum.TabIndex = 23;
            lblBillNum.Text = "Bill Number";
            // 
            // txtBillNo
            // 
            txtBillNo.BackColor = Color.YellowGreen;
            txtBillNo.Location = new Point(1056, 439);
            txtBillNo.Name = "txtBillNo";
            txtBillNo.Size = new Size(156, 27);
            txtBillNo.TabIndex = 24;
            // 
            // SellingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 827);
            Controls.Add(txtBillNo);
            Controls.Add(lblBillNum);
            Controls.Add(btnSellingAdd);
            Controls.Add(lblGrandTotal);
            Controls.Add(lblAmount);
            Controls.Add(btnSearchCat);
            Controls.Add(btnPrint);
            Controls.Add(lblSellingList);
            Controls.Add(dataGridView1);
            Controls.Add(dataGridView1_Order);
            Controls.Add(dataGridView2_Product);
            Controls.Add(btnRefCat);
            Controls.Add(cmbCategory);
            Controls.Add(btnAddOrder);
            Controls.Add(txtQty);
            Controls.Add(txtPrice);
            Controls.Add(txtProduct);
            Controls.Add(lblProduct);
            Controls.Add(lblPrice);
            Controls.Add(lblQty);
            Controls.Add(txtProdID);
            Controls.Add(lblID);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SellingForm";
            Text = "SellingForm";
            Load += SellingForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2_Product).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1_Order).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblSellingForm;
        private Label lblDate;
        private Label lblID;
        private TextBox txtProdID;
        private Label lblQty;
        private Label lblPrice;
        private Label lblProduct;
        private TextBox txtProduct;
        private TextBox txtPrice;
        private TextBox txtQty;
        private Button btnAddOrder;
        private ComboBox cmbCategory;
        private Button btnRefCat;
        private DataGridView dataGridView2_Product;
        private DataGridView dataGridView1_Order;
        private DataGridView dataGridView1;
        private Label lblSellingList;
        private Button btn;
        private Button btnPrint;
        private Button btnSearchCat;
        private Label lblAmount;
        private Label lblGrandTotal;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
        private Button btnSellingAdd;
        private Label lblBillNum;
        private TextBox txtBillNo;
    }
}