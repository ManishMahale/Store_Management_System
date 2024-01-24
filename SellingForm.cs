using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Management_System
{
    public partial class SellingForm : Form
    {
        DBConnect dBCon = new DBConnect(); // we created obj of DBConnect class To Call connection Mathods
        public SellingForm()
        {
            InitializeComponent();
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            BindCategory();
            BindBillList();

            lblDate.Text = DateTime.Now.ToShortDateString();
        }
        double GrandTotal = 0.0;
        int n = 0;
        private void BindCategory()
        {
            try
            {
                //below code need to be Explained
                SqlCommand cmd = new SqlCommand("spGetCategory", dBCon.GetCon());
                cmd.CommandType = CommandType.StoredProcedure;
                dBCon.OpenCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbCategory.DataSource = dt;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CatID";

                dBCon.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void Searched_ProductList()
        {


            // below quary to display category name on gridview
            try
            {
                SqlCommand cmd = new SqlCommand("spGetAllProductList_SearchByCat", dBCon.GetCon());
                cmd.Parameters.AddWithValue("@ProductCatID", cmbCategory.SelectedValue);
                cmd.CommandType = CommandType.StoredProcedure;
                dBCon.OpenCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2_Product.DataSource = dt;
                dBCon.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRefCat_Click(object sender, EventArgs e)
        {
            BindBillList();
        }

        private void btnSearchCat_Click(object sender, EventArgs e)
        {
            Searched_ProductList();
        }

        private void dataGridView2_Product_Click(object sender, EventArgs e)
        {
            try
            {
                txtProdID.Clear();
                txtProdID.Text = dataGridView2_Product.SelectedRows[0].Cells[0].Value.ToString();

                txtProduct.Clear();
                txtProduct.Text = dataGridView2_Product.SelectedRows[0].Cells[1].Value.ToString();
                //cmbCategory.SelectedValue = ProductDataGridView.SelectedRows[0].Cells[3].Value.ToString();

                txtPrice.Clear();
                txtPrice.Text = dataGridView2_Product.SelectedRows[0].Cells[4].Value.ToString();
                //txtQty.Text = dataGridView2_Product.SelectedRows[0].Cells[5].Value.ToString();
                txtQty.Clear();
                txtQty.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No Data Available", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPrice.Text == "" || txtQty.Text == "")
                {
                    MessageBox.Show("Enter Valid Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    double Total = Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtQty.Text);
                    DataGridViewRow addrow = new DataGridViewRow();
                    addrow.CreateCells(dataGridView1_Order);
                    addrow.Cells[0].Value = ++n;
                    addrow.Cells[1].Value = txtProduct.Text;
                    addrow.Cells[2].Value = txtPrice.Text;
                    addrow.Cells[3].Value = txtQty.Text;
                    addrow.Cells[4].Value = Total;
                    dataGridView1_Order.Rows.Add(addrow);
                    GrandTotal += Total;
                    lblGrandTotal.Text = "Rs." + GrandTotal;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSellingAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBillNo.Text == "")
                {
                    MessageBox.Show("Enter Bill Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("spInsertBill", dBCon.GetCon());
                    cmd.Parameters.AddWithValue("@Bill_ID", txtBillNo.Text);
                    cmd.Parameters.AddWithValue("@SellerID", Login_Page.LoginName);
                    cmd.Parameters.AddWithValue("@SellDate", lblDate.Text);
                    cmd.Parameters.AddWithValue("@TotalAmt", Convert.ToDouble(GrandTotal)) ;                   
                    cmd.CommandType = CommandType.StoredProcedure;

                    dBCon.OpenCon();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        BindBillList();
                        MessageBox.Show("Bill Added Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtClear();
                    }
                    dBCon.CloseCon();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void BindBillList()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spGetBillList", dBCon.GetCon());
                cmd.CommandType = CommandType.StoredProcedure;
                dBCon.OpenCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dBCon.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtClear()
        {
            btnSearchCat.Visible = true;
            txtBillNo.Visible = true;
            txtPrice.Clear();
            txtProdID.Clear();
            txtQty.Clear();
            txtProduct.Clear();
            lblGrandTotal.Text = "0.0";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}