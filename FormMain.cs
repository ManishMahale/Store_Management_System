using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Management_System
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void lblPanal_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (Login_Page.LoginName != null)
            {
                toolStripStatusLabel2.Text = Login_Page.LoginName;
            }
            if (Login_Page.LoginType != null && Login_Page.LoginType == "Seller")
            {
                CategoryToolStripMenuItem.Enabled = false;
                addUserToolStripMenuItem.Enabled = false;
                productToolStripMenuItem.Enabled = false;
            }
        }

        private void CategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            CategoryForm categoryForm = new CategoryForm();
            //categoryForm.ShowDialog();
            categoryForm.Show();
            //this.Show();
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You Want To Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private void sellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewSellerForm fseller = new AddNewSellerForm();
            fseller.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAdminForm fAdmin = new AddAdminForm();
            fAdmin.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sellerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SellingForm Sform = new SellingForm();
            Sform.ShowDialog();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductForm fAddProduct = new AddProductForm();
            fAddProduct.ShowDialog();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
