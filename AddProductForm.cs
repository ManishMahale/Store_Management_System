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
    public partial class AddProductForm : Form
    {
        DBConnect dBCon = new DBConnect(); // we created obj of DBConnect class To Call connection Mathods

        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            BindCategory();
            BindProductList();
            txtProductID.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnAdd.Visible = true;
            SearcgBy_Category();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProdName.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter Product name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProdName.Focus();
                    return;
                }
                else if (Convert.ToInt32(txtPrice.Text) < 0 || txtPrice.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter valid price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrice.Focus();
                    return;
                }
                else if (txtQty.Text == String.Empty || Convert.ToInt32(txtQty.Text) < 0)
                {
                    MessageBox.Show("Please Enter valid Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQty.Focus();
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("spCheckDuplicateProduct", dBCon.GetCon());
                    cmd.Parameters.AddWithValue("@ProdName", txtProdName.Text);
                    cmd.Parameters.AddWithValue("@ProdCatID", cmbCategory.SelectedValue);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dBCon.OpenCon();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("Product Name already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtClear();
                    }
                    else
                    {
                        cmd = new SqlCommand("spInsertProduct", dBCon.GetCon());
                        cmd.Parameters.AddWithValue("@ProdName", txtProdName.Text);
                        cmd.Parameters.AddWithValue("@ProdCatID", cmbCategory.SelectedValue);
                        cmd.Parameters.AddWithValue("@ProdPrice", Convert.ToDecimal(txtPrice.Text));
                        cmd.Parameters.AddWithValue("@ProdQty", Convert.ToInt32(txtQty.Text));
                        cmd.CommandType = CommandType.StoredProcedure;
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Product Inserted Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtClear();
                            BindProductList();
                        }
                    }
                    dBCon.CloseCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update code
            try
            {
                if (txtProductID.Text == "" && txtProdName.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter ProductID and name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProdName.Focus();
                    return;
                }
                else if (txtPrice.Text == String.Empty && Convert.ToInt32(txtPrice.Text) >= 0)
                {
                    MessageBox.Show("Please Enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrice.Focus();
                    return;
                }
                else if (txtQty.Text == String.Empty && Convert.ToInt32(txtQty.Text) >= 0)
                {
                    MessageBox.Show("Please Enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQty.Focus();
                    return;
                }
                else
                {

                    SqlCommand cmd = new SqlCommand("spUpdateProduct", dBCon.GetCon());
                    cmd.Parameters.AddWithValue("@ProductName", txtProdName.Text);
                    cmd.Parameters.AddWithValue("@ProductCatID", cmbCategory.SelectedValue);
                    cmd.Parameters.AddWithValue("@ProductPrice", Convert.ToDecimal(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@ProductQty", Convert.ToInt32(txtQty.Text));
                    cmd.Parameters.AddWithValue("@ProductID", Convert.ToInt32(txtProductID.Text));
                    cmd.CommandType = CommandType.StoredProcedure;
                    dBCon.OpenCon();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Product Updated Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtClear();
                        BindProductList();
                        txtProductID.Visible = false;
                        btnAdd.Visible = true;
                        btnUpdate.Visible = false;
                        btnDelete.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Updation Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dBCon.CloseCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductID.Text == String.Empty)
                {
                    MessageBox.Show("Please select Product ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtProductID.Text != String.Empty)
                {
                    if (DialogResult.Yes == MessageBox.Show("Do You Want to Delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        SqlCommand cmd = new SqlCommand("spDeleteProduct", dBCon.GetCon());
                        cmd.Parameters.AddWithValue("@ProdID", Convert.ToInt32(txtProductID.Text));
                        cmd.CommandType = CommandType.StoredProcedure;
                        dBCon.OpenCon();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Product Deleted Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtClear();
                            BindProductList();
                            btnUpdate.Visible = false;
                            btnDelete.Visible = false;
                            btnAdd.Visible = true;
                            txtProductID.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Delete failed...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtClear();
                        }
                        dBCon.CloseCon();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void ProductDataGridView_Click(object sender, EventArgs e)
        {
            try
            {
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                txtProductID.Visible = true;
                btnAdd.Visible = false;

                txtProductID.Text = ProductDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                txtProdName.Text = ProductDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                cmbCategory.SelectedValue = ProductDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                txtPrice.Text = ProductDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                txtQty.Text = ProductDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No Data Available", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClear();
        }
        private void txtClear()
        {
            btnSearchCat.Visible = true;
            btnAdd.Visible = true;
            txtProdName.Clear();
            txtPrice.Clear();
            txtQty.Clear();
            txtProductID.Clear();
        }

        private void ProductDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearcgBy_Category()
        {
            // below code need to be Explained
            SqlCommand cmd = new SqlCommand("spGetCategory", dBCon.GetCon());
            cmd.CommandType = CommandType.StoredProcedure;
            dBCon.OpenCon();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbsearch.DataSource = dt;
            cmbsearch.DisplayMember = "CategoryName";
            cmbsearch.ValueMember = "CatID";
            dBCon.CloseCon();
        }

        private void BindCategory()
        {
            // below code need to be Explained
            SqlCommand cmd = new SqlCommand("spGetCategory", dBCon.GetCon());
            /*  create procedure spGetCategory1
                as
                begin
                set nocount on;
                select CatID,CategoryName from tblCategory order by CategoryName asc
                end
                go                          */
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

        private void BindProductList()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spGetAllProductList", dBCon.GetCon());
                cmd.CommandType = CommandType.StoredProcedure;
                dBCon.OpenCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ProductDataGridView.DataSource = dt;
                dBCon.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Searched_ProductList()
        {
            try
            {
                // below quary to display category name on gridview

                SqlCommand cmd = new SqlCommand("spGetAllProductList_SearchByCat", dBCon.GetCon());
                cmd.Parameters.AddWithValue("@ProductCatID", cmbsearch.SelectedValue);
                cmd.CommandType = CommandType.StoredProcedure;
                dBCon.OpenCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ProductDataGridView.DataSource = dt;
                dBCon.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefrash_Click(object sender, EventArgs e)
        {
            BindProductList();
        }

        private void btnSearchCat_Click(object sender, EventArgs e)
        {
            Searched_ProductList();
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductID_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblProductID_Click(object sender, EventArgs e)
        {

        }
    }
}
