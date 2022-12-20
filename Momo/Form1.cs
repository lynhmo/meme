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
using System.Xml.Linq;

namespace Momo
{
    public partial class Form1 : Form
    {
        private static string connectionString = "Data Source=(local); Initial Catalog = momo; Integrated Security=SSPI;";
        private static SqlConnection cnn = new SqlConnection(connectionString);
        public Form1()
        {
            InitializeComponent();
            //sidepanel.Height = btnHome.Height;
            //sidepanel.Top = btnHome.Top;
            //home.BringToFront();
            home1.Visible = false;
            left_panel.Visible = false;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnHome.Height;
            sidepanel.Top = btnHome.Top;
            home1.Visible = true;
        }

        private void btnWallet_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnWallet.Height;
            sidepanel.Top = btnWallet.Top;
            //uudai.BringToFront();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnGiaodich.Height;
            sidepanel.Top = btnGiaodich.Top;
            //lichsu1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btn_money.Height;
            sidepanel.Top = btn_money.Top;
            //nguontien1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnVicuatoi.Height;
            sidepanel.Top = btnVicuatoi.Top;
            //mywallet1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool dragging = false;
        private Point startPoint = new Point();
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            //startPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X,p.Y-this.startPoint.Y);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            home1.Visible = false;
            left_panel.Visible = false;
        }

        private void btn_dautu_click(object sender, EventArgs e)
        {
            sidepanel.Height = btn_dautu.Height;
            sidepanel.Top = btn_dautu.Top;
            //dautu1.BringToFront();
        }

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
                    left_panel.Visible = true;
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu hoặc tài khoản!!!", "Validate Error");
                }
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
                btnLogin_Click(sender, e);
                e.SuppressKeyPress = true;
                this.ActiveControl = null;
                btnHome_Click(sender, e);
            }
        }
    }
}
