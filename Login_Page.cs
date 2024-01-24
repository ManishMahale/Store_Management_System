using System.Data;
using System.Data.SqlClient;

namespace Store_Management_System
{
    public partial class Login_Page : Form
    {
        DBConnect dBCon = new DBConnect(); // we created obj of DBConnect class To Call connection Mathods
        public static string? LoginName, LoginType;
        public Login_Page()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FormMain formMain = new FormMain();
            //formMain.ShowDialog();
            //this.Show();
            try
            {
                if (cmbRole.SelectedIndex > 0)
                {
                    if (txtUsername.Text == string.Empty)
                    {
                        MessageBox.Show("Please Enter Valid Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Focus();
                        return;
                    }
                    if (txtPassword.Text == string.Empty)
                    {
                        MessageBox.Show("Please Enter Valid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Focus();
                        return;
                    }
                    if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
                    {
                        //Login Code
                        if (cmbRole.Text == "Admin")
                        {
                            // SqlCommand cmd = new SqlCommand("select AdminID, Password, FullName from tblAdmin where AdminID=@AdminID and Password = @Password;", dBCon.GetCon());
                            //cmd.Parameters.AddWithValue("@Admin", txtUsername.Text);
                            //cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                            SqlCommand cmd = new SqlCommand("select AdminID, AdminPass, AdminFullName from tblAdmin where AdminID='" + txtUsername.Text + "' and AdminPass = '" + txtPassword.Text + "'", dBCon.GetCon());
                            dBCon.OpenCon();
                            // SqlDataAdapter aD = new SqlDataAdapter(cmd);
                            //DataTable dt = new DataTable();
                            // aD.Fill(dt);
                            // if(dt.Rows.Count > 0)
                            // {
                            //     MessageBox.Show("Login Success...Welcome!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // }

                            //above code from Youtube Video

                            #region this is my code and it's works
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read()) // .Read()    returns true or false // is there row available the true otherwise false
                            {

                                //MessageBox.Show("Login Seccessful!");
                                MessageBox.Show("Login Success...", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoginName = txtUsername.Text;
                                LoginType = cmbRole.Text;
                                ClrValue();
                                this.Hide();
                                FormMain formMain = new FormMain();
                                formMain.ShowDialog();
                                this.Show();
                            }
                            else
                            {
                                MessageBox.Show("Login Denaid");
                                ClrValue();

                            }
                            dBCon.CloseCon();
                            #endregion
                        }
                        else if (cmbRole.Text == "Seller")
                        {
                            SqlCommand cmd = new SqlCommand("select top 1 SellerName, SellerPass from tblSeller where SellerName='" + txtUsername.Text + "' and SellerPass='" + txtPassword.Text + "' ", dBCon.GetCon());

                            dBCon.OpenCon();
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read()) // .Read()    returns true or false // is there row available the true otherwise false
                            {

                                //MessageBox.Show("Login Seccessful!");
                                MessageBox.Show("Login Success...", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoginName = txtUsername.Text;
                                LoginType = cmbRole.Text;
                                ClrValue();
                                this.Hide();
                                FormMain formMain = new FormMain();
                                formMain.ShowDialog();
                                this.Show();
                            }
                            else
                            {
                                MessageBox.Show("Login Denaid");
                                ClrValue();

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Valid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClrValue();
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Any Role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //ClrValue();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dBCon.CloseCon();
        }
        private void ClrValue()
        {
            cmbRole.SelectedIndex = 0; //to clear box we call this fuction
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void comboBox1(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Page_Load(object sender, EventArgs e)
        {
            #region delete after project complete

            cmbRole.SelectedIndex = 0;
            txtUsername.Text = txtUsername.Text;
            txtPassword.Text = txtPassword.Text;

            #endregion
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClrValue();
        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}