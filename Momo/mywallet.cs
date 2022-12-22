using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Momo
{
    public partial class mywallet : UserControl
    {
        public mywallet()
        {
            InitializeComponent();
            txtbirth.Visible = false;
            txt_cccd.Visible = false;
            txt_diachi.Visible = false;
            txt_fullname.Visible = false;
            btn_exit.Visible = false;
            btn_Done.Visible = false;
            panel_resetPass.Visible = false;
        }
        public string setusername { get; set; }
        private int id_user;
        private string money_curent = "";
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void loadTableBank()
        {
            cnn.Open();
            SqlCommand idNguoigui = new SqlCommand("Select id from users WHERE username=@username", cnn);
            idNguoigui.Parameters.AddWithValue("@username", setusername);
            using (SqlDataReader reader = idNguoigui.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    id_user = Convert.ToInt32(String.Format("{0}", reader["id"]));
                }
            }
            string query = $"SELECT bank.id_bank,bank.bankname FROM bank_user,bank WHERE id_user={id_user} AND bank.id_bank=bank_user.id_bank";
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            tableBank.DataSource = dtbl;
            cnn.Close();
        }
        private static string connectionString = "Data Source=(local); Initial Catalog = momo; Integrated Security=SSPI;";
        private static SqlConnection cnn = new SqlConnection(connectionString);
        private void mywallet_Load(object sender, EventArgs e)
        {
            userInfoLoad();
            loadTableBank();
            //Form1.
            lbl_username_wallet.Text = setusername;
            SqlCommand commandNV = new SqlCommand("Select * from users WHERE username=@username", cnn);
            commandNV.Parameters.AddWithValue("@username", lbl_username_wallet.Text);
            cnn.Open();
            using (SqlDataReader reader = commandNV.ExecuteReader())
            {
                if (reader.Read())
                {
                    money_curent = Convert.ToDouble(String.Format("{0}", reader["money"])).ToString("C0",
                  CultureInfo.CreateSpecificCulture("vi-VN"));
                    id_user =  Convert.ToInt32(String.Format("{0}", reader["id"]));
                    lbl_user_money.Text = "Số dư: " + money_curent;
                }
            }
            cnn.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_profile_Click(object sender, EventArgs e)
        {
            txtbirth.Visible = true;
            txt_cccd.Visible = true;
            txt_diachi.Visible = true;
            txt_fullname.Visible = true;
            btn_exit.Visible = true;
            btn_Done.Visible = true;
        }
        private void userInfoLoad()
        {
            SqlCommand infoUser = new SqlCommand("Select * from users WHERE username=@username1", cnn);
            infoUser.Parameters.AddWithValue("@username1", setusername);
            //open conn
            cnn.Open();
            using (SqlDataReader reader = infoUser.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    lbl_fullname.Text = String.Format("{0}", reader["fullname"]);
                    lbl_birth.Text = String.Format("{0}", reader["birth"]);
                    lbl_cccd.Text = String.Format("{0}", reader["cccd"]);
                    lbl_address.Text = String.Format("{0}", reader["address"]);
                }
            }
            cnn.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            txtbirth.Visible = false;
            txt_cccd.Visible = false;
            txt_diachi.Visible = false;
            txt_fullname.Visible = false;
            btn_exit.Visible = false;
            btn_Done.Visible = false;
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtbirth.Text) || String.IsNullOrEmpty(txt_cccd.Text) || String.IsNullOrEmpty(txt_diachi.Text) || String.IsNullOrEmpty(txt_fullname.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin cá nhân!", "Lỗi");
                }
                else
                {
                    cnn.Open();
                    SqlCommand updateNguoiGui = new SqlCommand("UPDATE users SET fullname = @fullname,birth = @birth,cccd = @cccd,address = @address WHERE id=@iduser", cnn);
                    updateNguoiGui.Parameters.AddWithValue("@iduser", id_user);
                    updateNguoiGui.Parameters.AddWithValue("@fullname", txt_fullname.Text);
                    updateNguoiGui.Parameters.AddWithValue("@birth", txtbirth.Text);
                    updateNguoiGui.Parameters.AddWithValue("@cccd", txt_cccd.Text);
                    updateNguoiGui.Parameters.AddWithValue("@address", txt_diachi.Text);
                    updateNguoiGui.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("Sua thanh cong!");
                    userInfoLoad();
                    txtbirth.Visible = false;
                    txt_cccd.Visible = false;
                    txt_diachi.Visible = false;
                    txt_fullname.Visible = false;
                    btn_exit.Visible = false;
                    btn_Done.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            panel_resetPass.Visible = true;
        }
        private string oldpass = "";
        private void btn_doimatkhau_done_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtConfirmNewPass.Text) || String.IsNullOrEmpty(txtCurr_pass.Text) || String.IsNullOrEmpty(txtNewPass.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi");
            }
            else 
            {
                cnn.Open();
                SqlCommand idNguoigui = new SqlCommand("Select password from users WHERE username=@username", cnn);
                idNguoigui.Parameters.AddWithValue("@username", setusername);
                using (SqlDataReader reader = idNguoigui.ExecuteReader()) //nguoi chuyen
                {
                    if (reader.Read())
                    {
                        oldpass = String.Format("{0}", reader["password"]);
                    }
                }
                if (txtCurr_pass.Text.ToLower().Equals(oldpass) && txtNewPass.Text.ToLower().Equals(txtConfirmNewPass.Text.ToLower()))
                {
                    SqlCommand updatePass = new SqlCommand("UPDATE users SET password =@password WHERE username=@iduser", cnn);
                    updatePass.Parameters.AddWithValue("@iduser", setusername);
                    updatePass.Parameters.AddWithValue("@password", txtConfirmNewPass.Text.ToLower());
                    updatePass.ExecuteNonQuery();
                    MessageBox.Show("Sua thanh cong!");
                }
                else
                {
                    MessageBox.Show("Nhập sai mật khẩu!");
                }
                cnn.Close();
            }
            //done
            panel_resetPass.Visible = false;
            txtConfirmNewPass.Text = null;
            txtCurr_pass.Text = null;
            txtNewPass.Text = null;
        }
    }
}
