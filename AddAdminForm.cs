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
    public partial class AddAdminForm : Form
    {
        DBConnect dBCon = new DBConnect(); // we created obj of DBConnect class To Call connection Mathods

        public AddAdminForm()
        {
            InitializeComponent();
        }

        private void AddAdminForm_Load(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            txtAdminName.Focus();
            BindAdmin();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAdminName.Text == string.Empty || txtAdminPass.Text == string.Empty || txtAdminID.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter Valid Admin Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAdminName.Focus();
                    txtClear();
                    return;
                }

                else
                {
                    // code cpied from btnAddCat_Click function
                    SqlCommand cmd = new SqlCommand("select AdminFullName from tblAdmin where AdminID='" + txtAdminID.Text + "'", dBCon.GetCon());
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
                        MessageBox.Show(String.Format("Admin Name Already Exist"), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAdminName.Focus();
                        txtClear();
                    }
                    else
                    {
                        cmd = new SqlCommand("insert into tblAdmin(AdminID, AdminFullName, AdminPass) values ('" + txtAdminID.Text + "','" + txtAdminName.Text + "','" + txtAdminPass.Text + "')", dBCon.GetCon());
                        int n = cmd.ExecuteNonQuery();
                        if (n > 0)
                        {
                            MessageBox.Show("Admin Information Inserted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtAdminName.Focus();
                            BindAdmin();
                            txtClear();
                        }
                        else
                        {
                            MessageBox.Show("please insert Admin Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtAdminName.Focus();
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
                if (txtAdminID.Text == string.Empty)
                {
                    MessageBox.Show("Please Select Admin ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAdminID.Focus();
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select AdminFullName from tblAdmin where ADminID='" + txtAdminID.Text + "'", dBCon.GetCon());
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
                        MessageBox.Show(String.Format("Admin Name Already Exist"), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAdminName.Focus();
                        txtClear();
                    }
                    else
                    {
                        cmd = new SqlCommand("update tblAdmin set AdminFullName = '" + txtAdminName.Text + "', AdminPass = " + txtAdminPass.Text + " where AdminID = " + txtAdminID.Text + "", dBCon.GetCon());
                        int n = cmd.ExecuteNonQuery();
                        if (n > 0)
                        {
                            MessageBox.Show("Admin Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtAdminName.Focus();

                            BindAdmin();
                            txtClear();
                        }
                        else
                        {
                            MessageBox.Show("Update Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtAdminName.Focus();
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


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAdminID.Text == string.Empty)
                {
                    MessageBox.Show("Please Select Category");
                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Do You Want To Delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        SqlCommand cmd = new SqlCommand("delete from tblAdmin where AdminID='" + txtAdminID.Text + "'", dBCon.GetCon());
                        dBCon.OpenCon();
                        int n = cmd.ExecuteNonQuery();
                        if (n > 0)
                        {
                            MessageBox.Show("Admin Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtAdminName.Focus();
                            btnUpdate.Visible = false;
                            btnDelete.Visible = false;
                            btnAdd.Visible = true;
                            BindAdmin();
                            txtClear();

                        }
                        else
                        {
                            MessageBox.Show("delete Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtAdminName.Focus();
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
        #region unused mathods
        private void AddAdminGroupBox_Enter(object sender, EventArgs e)
        {
        }

        private void txtAdminID_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void BindAdmin()
        {
            #region  // below code need to be Explained
            SqlCommand cmd = new SqlCommand("select AdminID, AdminFullName, AdminPass from tblAdmin", dBCon.GetCon());
            dBCon.OpenCon();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            AdminDataGridView.DataSource = dt;
            #endregion
            dBCon.CloseCon();
        }

        private void txtClear()
        {
            btnAdd.Visible = true;
            txtAdminID.Clear();
            txtAdminName.Clear();
            txtAdminPass.Clear();
        }

        private void AdminDataGridView_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            btnAdd.Visible = false;
            btnAdd.Visible = true;

            txtAdminID.Text = AdminDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            txtAdminName.Text = AdminDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtAdminPass.Text = AdminDataGridView.SelectedRows[0].Cells[2].Value.ToString();
        }

        //private void btnClearCat_Click(object sender, EventArgs e)
        //{
            
        //}

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            txtClear();
        }
    }
}
