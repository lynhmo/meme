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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Momo
{
    public partial class Form1 : Form
    {
        private static string connectionString = "Data Source=(local); Initial Catalog = momo; Integrated Security=SSPI;";
        private static SqlConnection cnn = new SqlConnection(connectionString);
        public Form1()
        {
            InitializeComponent();
            //home1.Visible = false;
            left_panel.Visible = false;

        }
        //Khởi tạo các panel
        private uudai uudai1 = new uudai();
        private lichsu lichsu1 = new lichsu();
        private mywallet mywallet1 = new mywallet();
        private nguontien nguontien1 = new nguontien();
        private dautu dautu1 = new dautu();
        private home home1 = new home();
        private void btnHome_Click(object sender, EventArgs e)
        {
            //HOME
            home1.Dispose();
            home1 = new home();
            home1.username_get = lbl_username.Text; // lay data username sang panel home
            sidepanel.Height = btnHome.Height;
            home1.Location = new Point(200, 22);
            home1.Size = new Size(841, 559);
            this.Controls.Add(home1);
            sidepanel.Top = btnHome.Top;
            home1.Visible = true;
            home1.BringToFront();
        }
        
        private void btnWallet_Click(object sender, EventArgs e)
        {
            //UU DAI
            sidepanel.Height = btnWallet.Height;
            sidepanel.Top = btnWallet.Top;
            uudai1.Location = new Point(200, 22);
            uudai1.Size = new Size(841, 559);
            this.Controls.Add(uudai1);
            uudai1.Visible = true;
            uudai1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //LICH SU GIAO DICH
            lichsu1.Dispose();
            lichsu1 = new lichsu();
            lichsu1.username_get_lichsu = lbl_username.Text; // get username
            sidepanel.Height = btnGiaodich.Height;
            sidepanel.Top = btnGiaodich.Top;
            lichsu1.Location = new Point(200, 22);
            lichsu1.Size = new Size(841, 559);
            this.Controls.Add(lichsu1);
            lichsu1.Visible = true;
            lichsu1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //NGUON TIEN
            sidepanel.Height = btn_money.Height;
            sidepanel.Top = btn_money.Top;
            nguontien1.Location = new Point(200, 22);
            nguontien1.Size = new Size(841, 559);
            this.Controls.Add(nguontien1);
            nguontien1.Visible = true;
            nguontien1.BringToFront();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //MY WALLET
            mywallet1.Dispose();
            mywallet1 = new mywallet();
            mywallet1.setusername = lbl_username.Text;// construct lay ten
            sidepanel.Height = btnVicuatoi.Height;
            sidepanel.Top = btnVicuatoi.Top;
            mywallet1.Location = new Point(200, 22);
            mywallet1.Size = new Size(841,559);
            this.Controls.Add(mywallet1);
            mywallet1.Visible = true;
            mywallet1.BringToFront();
        }
        private void btn_dautu_click(object sender, EventArgs e)
        {
            //DAU TU
            sidepanel.Height = btn_dautu.Height;
            sidepanel.Top = btn_dautu.Top;
            dautu1.Location = new Point(200, 22);
            dautu1.Size = new Size(841, 599);
            this.Controls.Add(dautu1);
            dautu1.Visible = true;
            dautu1.BringToFront();
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
            //home1.Visible = false;
            home1.Dispose();
            left_panel.Visible = false;
            uudai1.Visible= false;
            //lichsu1.Visible= false;
            lichsu1.Dispose();
            nguontien1.Visible= false;
            dautu1.Visible= false;
            //mywallet1.Visible = false;
            mywallet1.Dispose();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(local); Initial Catalog = momo; Integrated Security=SSPI;";
            SqlConnection cnn = new SqlConnection(connectionString);
            string pass = txtPassword.Text;
            string name = txtUsername.Text.Trim().ToLower();
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
                    lbl_username.Text = name;
                    txtPassword.Text = null;
                    txtUsername.Text = null;
                    left_panel.Visible = true;
                    btnHome_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu hoặc tài khoản!!!", "Validate Error");
                }
                cnn.Close();
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
            }
        }
    }
}
