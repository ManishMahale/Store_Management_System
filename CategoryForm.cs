using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Management_System
{
    public partial class CategoryForm : Form
    {
        DBConnect dBCon = new DBConnect(); // we created obj of DBConnect class To Call connection Mathods
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            btnAddCat.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            lblCatID.Visible = true;
            BindCategory();
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            if (lblCatID.Text == string.Empty)
            {
                MessageBox.Show("Please Select Category ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCatName.Focus();
                return;
            }
            if (txtCatName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Category Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCatName.Focus();
                return;
            }
            else if (CatrichTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CatrichTextBox.Focus();
                return;
            }
            else
            {
                // code cpied from btnAddCat_Click function
                SqlCommand cmd = new SqlCommand("select CategoryName from tblCategory where CategoryName='" + txtCatName.Text + "'", dBCon.GetCon());

                try
                {
                    //ExecuteScalar() only returns the value from the first column of the first row of your query. ExecuteReader() returns an object that can iterate over the entire result set. ExecuteNonQuery() does not return data at all: only the number of rows affected by an insert, update, or delete.

                    #region this code also right
                    //SqlDataReader sdr = cmd.ExecuteReader(); // its search operation // read data from Searver
                    //if (sdr.Read())
                    #endregion
                    dBCon.OpenCon();
                    //Below Code Looks Easy
                    var result = cmd.ExecuteScalar(); //ExecuteScalar() only returns the value from the first column of the first row of your query.
                    if (result != null)
                    {
                        MessageBox.Show(String.Format("Category Name Already Exist"), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CatrichTextBox.Focus();
                        txtClear();
                    }
                    else
                    {
                        cmd = new SqlCommand("insert into tblCategory(CategoryName, CategoryDesc) values ('" + txtCatName.Text + "', '" + CatrichTextBox.Text + "')", dBCon.GetCon());
                        int n = cmd.ExecuteNonQuery();
                        if (n > 0)
                        {
                            MessageBox.Show("Category Name Inserted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CatrichTextBox.Focus();
                            BindCategory();
                            txtClear();
                        }
                        else
                        {
                            MessageBox.Show("please insert Category", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            CatrichTextBox.Focus();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            dBCon.CloseCon();

        }

        #region  unused mathods
        private void CatdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion    

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update code
            try
            {

                if (txtCatID.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter Category ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCatName.Focus();
                    return;
                }
                else if (txtCatName.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter Category Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CatrichTextBox.Focus();
                    return;
                }
                else if (CatrichTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter Category Desctription", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CatrichTextBox.Focus();
                    return;
                }
                else
                {
                    //SqlCommand cmd = new SqlCommand("select CategoryName from tblCategory where CategoryName='" + txtCatName.Text + "'", dBCon.GetCon());

                    #region 
                    //ExecuteScalar() only returns the value from the first column of the first row of your query. ExecuteReader() returns an object that can iterate over the entire result set. ExecuteNonQuery() does not return data at all: only the number of rows affected by an insert, update, or delete.

                    //this code also right
                    //SqlDataReader sdr = cmd.ExecuteReader(); // its search operation // read data from Searver
                    //if (sdr.Read())

                    //Below Code Looks Easy
                    //var result = cmd.ExecuteScalar(); //ExecuteScalar() only returns the value from the first column of the first row of your query.
                    //if (result != null)
                    //{
                    //    MessageBox.Show(String.Format("Category Name Already Exist"), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    CatrichTextBox.Focus();
                    //    txtClear();
                    //}
                    //else
                    //{                    
                    //}
                    #endregion

                    SqlCommand cmd = new SqlCommand("select CategoryName from tblCategory where CategoryName='" + txtCatName.Text + "'", dBCon.GetCon());
                    dBCon.OpenCon();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show(String.Format("Category Name Already Exist"), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CatrichTextBox.Focus();
                        txtClear();
                    }

                    else
                    {
                        cmd = new SqlCommand("update tblCategory set CategoryName = '" + txtCatName.Text + "', " +
                       "CategoryDesc = '" + CatrichTextBox.Text + "' where CatID=" + txtCatID.Text + "", dBCon.GetCon());
                        int n = cmd.ExecuteNonQuery();
                        if (n > 0)
                        {
                            MessageBox.Show("Category Name Inserted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCatName.Focus();
                            BindCategory();
                            txtClear();
                        }

                        else
                        {
                            MessageBox.Show("Update Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            CatrichTextBox.Focus();
                        }
                    }
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            dBCon.CloseCon();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCatID.Text == string.Empty)
                {
                    MessageBox.Show("Please Select Category");
                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Do You Want To Delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        SqlCommand cmd = new SqlCommand("delete from tblCategory where CatID=" + txtCatID.Text + "", dBCon.GetCon());
                        dBCon.OpenCon();
                        int n = cmd.ExecuteNonQuery();
                        if (n > 0)
                        {
                            MessageBox.Show("Category Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCatName.Focus();
                            BindCategory();
                            txtClear();

                        }
                        else
                        {
                            MessageBox.Show("delete Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            CatrichTextBox.Focus();
                        }
                        dBCon.CloseCon();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CatdataGridView_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            btnAddCat.Visible = false;
            lblCatID.Visible = true;
            txtCatID.Text = CatdataGridView.SelectedRows[0].Cells[0].Value.ToString();
            txtCatName.Text = CatdataGridView.SelectedRows[0].Cells[1].Value.ToString();
            CatrichTextBox.Text = CatdataGridView.SelectedRows[0].Cells[2].Value.ToString();
        }
        private void BindCategory()
        {
            #region  // below code need to be Explained
            SqlCommand cmd = new SqlCommand("select CatID as 'Category ID',  CategoryName as 'Category Name', CategoryDesc as 'Category Description' from tblCategory", dBCon.GetCon());
            dBCon.OpenCon();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            CatdataGridView.DataSource = dt;
            #endregion
            dBCon.CloseCon();
        }

        private void btnClearCat_Click(object sender, EventArgs e)
        {
            txtClear();
        }
        private void txtClear()
        {
            txtCatName.Clear();
            CatrichTextBox.Clear();
            txtCatID.Clear();
            btnAddCat.Visible = true;
        }

        private void AddCatgroupBox_Enter(object sender, EventArgs e)
        {

        }
    }

}