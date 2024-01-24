namespace Store_Management_System
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel = new Panel();
            lblPanal = new Label();
            menuStrip1 = new MenuStrip();
            CategoryToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            sellerToolStripMenuItem1 = new ToolStripMenuItem();
            addUserToolStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            sellerToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripSplitButton1 = new ToolStripSplitButton();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            pictureBox1 = new PictureBox();
            panel.SuspendLayout();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(255, 192, 128);
            panel.Controls.Add(lblPanal);
            panel.Location = new Point(0, 45);
            panel.Name = "panel";
            panel.Size = new Size(1131, 57);
            panel.TabIndex = 1;
            // 
            // lblPanal
            // 
            lblPanal.AutoSize = true;
            lblPanal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPanal.Location = new Point(522, 15);
            lblPanal.Name = "lblPanal";
            lblPanal.Size = new Size(96, 28);
            lblPanal.TabIndex = 0;
            lblPanal.Text = "Go_Store";
            lblPanal.Click += lblPanal_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { CategoryToolStripMenuItem, productToolStripMenuItem, sellerToolStripMenuItem1, addUserToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1139, 36);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // CategoryToolStripMenuItem
            // 
            CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem";
            CategoryToolStripMenuItem.Size = new Size(107, 32);
            CategoryToolStripMenuItem.Text = "Categoty";
            CategoryToolStripMenuItem.Click += CategoryToolStripMenuItem_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(97, 32);
            productToolStripMenuItem.Text = "Product";
            productToolStripMenuItem.Click += productToolStripMenuItem_Click;
            // 
            // sellerToolStripMenuItem1
            // 
            sellerToolStripMenuItem1.Name = "sellerToolStripMenuItem1";
            sellerToolStripMenuItem1.Size = new Size(87, 32);
            sellerToolStripMenuItem1.Text = "Selling";
            sellerToolStripMenuItem1.Click += sellerToolStripMenuItem1_Click;
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adminToolStripMenuItem, sellerToolStripMenuItem });
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(110, 32);
            addUserToolStripMenuItem.Text = "Add User";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(158, 32);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // sellerToolStripMenuItem
            // 
            sellerToolStripMenuItem.Name = "sellerToolStripMenuItem";
            sellerToolStripMenuItem.Size = new Size(158, 32);
            sellerToolStripMenuItem.Text = "Seller";
            sellerToolStripMenuItem.Click += sellerToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(58, 32);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(458, 115);
            label1.Name = "label1";
            label1.Size = new Size(215, 28);
            label1.TabIndex = 3;
            label1.Text = "Welcome To Go Store";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripSplitButton1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 684);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1139, 26);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(78, 20);
            toolStripStatusLabel1.Text = "UserName";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(39, 24);
            toolStripSplitButton1.Text = "toolStripSplitButton1";
            toolStripSplitButton1.ButtonClick += toolStripSplitButton1_ButtonClick;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel2.ForeColor = Color.Green;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(160, 20);
            toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            toolStripStatusLabel2.Click += toolStripStatusLabel2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Storeimg1;
            pictureBox1.Location = new Point(438, 259);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 258);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 710);
            Controls.Add(pictureBox1);
            Controls.Add(statusStrip1);
            Controls.Add(label1);
            Controls.Add(panel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Go Store";
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel;
        private Label lblPanal;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem CategoryToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem sellerToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label label1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripMenuItem sellerToolStripMenuItem1;
        private PictureBox pictureBox1;
    }
}