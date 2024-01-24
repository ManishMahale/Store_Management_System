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
    public partial class AddNewSellerForm : Form
    {
        DBConnect dBCon = new DBConnect(); // we created obj of DBConnect class To Call connection Mathods
        public AddNewSellerForm()
        {
            InitializeComponent();
        }

        private void AddNewSellerForm_Load(object sender, EventArgs e)
        {
            txtSellerID.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnAdd.Visible = true;
            BindSeller();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSellerName.Text == string.Empty)
                {
                    MessageBox.Show("Please Select Seller Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSellerName.Focus();
                    return;
                }

                else if (txtSellerPass.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSellerPass.Focus();
                    return;
                }
                else
                {
                    // code cpied from btnAddCat_Click function
                    SqlCommand cmd = new SqlCommand("select SellerName from tblSeller where SellerName='" + txtSellerName.Text + "'", dBCon.GetCon());
                    dBCon.OpenCon();

                    #region
                    //ExecuteScalar() only returns the value from the first column of the first row of your query. ExecuteReader() returns an object that can iterate over the entire result set. ExecuteNonQuery() does not return data at all: only the number of rows affected by an insert, update, or delete.

                    //this code also right
                    //SqlDataReader sdr = cmd.ExecuteReader(); // its search operation // read data from Searver
                    //if (sdr.Read())
                    #endregion
                    //Below Code Looks Easy
                    var result = cmd.ExecuteScalar(); //ExecuteScalar() only returns the value from the first column of the first row of your query.
                    if (result != null)
                    {
                        MessageBox.Show(String.Format("Seller Name Already Exist"), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSellerName.Focus();
                        txtClear();
                    }
                    else
                    {
                        cmd = new SqlCommand("insert into tblSeller(SellerName, SellerPass, SellerPhone, SellerAge) values ('" + txtSellerName.Text + "', '" + txtSellerPass.Text + "', '" + txtSellerPhone.Text + "', '" + txtSellerAge.Text + "')", dBCon.GetCon());
                        int n = cmd.ExecuteNonQuery();
                        if (n > 0)
                        {
                            MessageBox.Show("Admin Information Inserted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSellerName.Focus();
                            BindSeller();
                            txtClear();
                        }
                        else
                        {
                            MessageBox.Show("please insert Admin Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtSellerName.Focus();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update code
            try
            {
                if (txtSellerID.Text == string.Empty)
                {
                    MessageBox.Show("Please Select Seller ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSellerName.Focus();
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select SellerName from tblSeller where SellerName='" + txtSellerName.Text + "'", dBCon.GetCon());
                    dBCon.OpenCon();

                    #region 
                    //ExecuteScalar() only returns the value from the first column of the first row of your query. ExecuteReader() returns an object that can iterate over the entire result set. ExecuteNonQuery() does not return data at all: only the number of rows affected by an insert, update, or delete.

                    #region this code also right
                    //SqlDataReader sdr = cmd.ExecuteReader(); // its search operation // read data from Searver
                    //if (sdr.Read())
                    #endregion

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
                    #endregion
                    var result = cmd.ExecuteScalar(); //ExecuteScalar() only returns the value from the first column of the first row of your query.
                    if (result != null)
                    {
                        MessageBox.Show(String.Format("Seller Name Already Exist"), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSellerName.Focus();
                        txtClear();
                    }
                    else
                    {
                        cmd = new SqlCommand("update tblSeller set SellerName = '" + txtSellerName.Text + "', SellerPass = '" + txtSellerPass.Text + "',  SellerPhone ='" + txtSellerPhone.Text + "', SellerAge ='" + txtSellerAge.Text + "' where SellerID=" + txtSellerID.Text + "", dBCon.GetCon());
                        int n = cmd.ExecuteNonQuery();
                        if (n > 0)
                        {
                            MessageBox.Show("Seller Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSellerName.Focus();
                            btnAdd.Visible = true;
                            btnDelete.Visible = false;
                            btnUpdate.Visible = false;
                            BindSeller();
                            txtClear();
                        }
                        else
                        {
                            MessageBox.Show("Update Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtSellerPass.Focus();
                        }
                        dBCon.CloseCon();
                    }
                    //}
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void BindSeller()
        {
             // below code need to be Explained
            SqlCommand cmd = new SqlCommand("select SellerID, SellerName, SellerPhone, SellerAge, SellerPass from tblSeller", dBCon.GetCon());
            dBCon.OpenCon();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            SellerDataGridView.DataSource = dt;
            
            dBCon.CloseCon();
        }

        private void SellerDataGridView_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            btnAdd.Visible = true;

            txtSellerID.Text = SellerDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            txtSellerName.Text = SellerDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtSellerPhone.Text = SellerDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtSellerAge.Text = SellerDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtSellerPass.Text = SellerDataGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSellerID.Text == string.Empty)
                {
                    MessageBox.Show("Please Select Category");
                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Do You Want To Delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        SqlCommand cmd = new SqlCommand("delete from tblSeller where SellerID=" + txtSellerID.Text + "", dBCon.GetCon());
                        dBCon.OpenCon();
                        int n = cmd.ExecuteNonQuery();
                        if (n > 0)
                        {
                            MessageBox.Show("Seller Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSellerName.Focus();
                            btnUpdate.Visible = false;
                            btnDelete.Visible = false;
                            btnAdd.Visible = true;
                            BindSeller();
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
        private void txtClear()
        {
            btnAdd.Visible = true;
            txtSellerName.Clear();
            txtSellerAge.Clear();
            txtSellerID.Clear();
            txtSellerPass.Clear();
            txtSellerPhone.Clear();
        }

        private void btnClearCat_Click(object sender, EventArgs e)
        {
            txtClear();
        }

        private void SellerDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClearCat_Click_1(object sender, EventArgs e)
        {

        }
    }
}