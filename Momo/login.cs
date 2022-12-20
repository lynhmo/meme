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
    public partial class login : UserControl
    {
        public login()
        {
            InitializeComponent();
            //panel1.BringToFront();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
    
        }
        public string textUser { get; set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(local); Initial Catalog = momo; Integrated Security=SSPI;";
            SqlConnection cnn = new SqlConnection(connectionString);
            string pass = txtPassword.Text;
            string name = txtUsername.Text;
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Nhập đầy đủ username va pass!");
            }
            else
            {
                string query = $"SELECT count(*) FROM users WHERE username = '{name}' AND password = '{pass}' ";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cnn.Open();
                int sl = (int)cmd.ExecuteScalar();
                if (sl == 1)
                {
                    txtPassword.Text = null; 
                    txtUsername.Text = null;
                    this.SendToBack();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu hoặc tài khoản!!!", "Validate Error");
                }
            }
        }

        private void loginclose(object sender, EventArgs e)
        {
            Application.Exit();

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
                btnLogin_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
    }
}
