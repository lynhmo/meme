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

namespace Momo
{
    public partial class register : UserControl
    {
        public register()
        {
            InitializeComponent();
        }
        private static string connectionString = "Data Source=(local); Initial Catalog = momo; Integrated Security=SSPI;";
        private static SqlConnection cnn = new SqlConnection(connectionString);
        private void gobacklogin_Click(object sender, EventArgs e)
        {
            this.Visible=false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim().ToLower();
            string password = txtPassword.Text.Trim();
            string confirmPass = txtConfirmPassword.Text.Trim();
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Nhập đầy đủ username va pass!");
            }
            else if (password.Equals(confirmPass))
            {
                cnn.Open();
                SqlCommand insertLichSu = new SqlCommand("INSERT INTO users (username,password) VALUES (@username,@id_nhan)", cnn);
                insertLichSu.Parameters.AddWithValue("@username", username);
                insertLichSu.Parameters.AddWithValue("@id_nhan", confirmPass);
                insertLichSu.ExecuteNonQuery();
                this.Visible = false;
                MessageBox.Show("Đăng ký thành công!");
                cnn.Close();
            }
            else
            {
                MessageBox.Show("Confirm Pass Sai!");
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtConfirmPassword.Focus();
                e.SuppressKeyPress = true;
                //this.ActiveControl = null;
            }
        }

        private void txtConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegister_Click(sender, e);
                e.SuppressKeyPress = true;
                this.ActiveControl = null;
            }
        }
    }
}
