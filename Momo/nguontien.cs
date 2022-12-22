using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Momo
{
    public partial class nguontien : UserControl
    {
        public nguontien()
        {
            InitializeComponent();
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public string usernameForBank { get; set; }
        private int id_user;

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string setusername { get; set; }

        private void nguontien_Load(object sender, EventArgs e)
        {
            panelAddBank.Visible = false;
            btn_add_bank_close.Visible = false;
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            panel7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            panel8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            panel9.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            panel10.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            panel11.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            panel12.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            panelAddBank.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelAddBank.Width, panelAddBank.Height, 20, 20));
            //take id user
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
            cnn.Close();
            //
            loadTableBank_add();
            loadTableALL_Bank();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_bank_Click(object sender, EventArgs e)
        {
            panelAddBank.Visible = true;
            btn_add_bank_close.Visible= true;
        }
        private static string connectionString = "Data Source=(local); Initial Catalog = momo; Integrated Security=SSPI;";
        private static SqlConnection cnn = new SqlConnection(connectionString);
        private string bankID = "";
        private void btn_add_done_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBankName.Text.ToLower().Trim()))
            {
                MessageBox.Show("Nhập đầy đủ tên ngân hàng!");
            }
            else
            {
                //take out bank
                cnn.Open();
                SqlCommand bankName_insert = new SqlCommand("Select id_bank from bank WHERE bankname=@bankname", cnn);
                bankName_insert.Parameters.AddWithValue("@bankname", txtBankName.Text.ToLower().Trim());
                using (SqlDataReader reader = bankName_insert.ExecuteReader()) //nguoi chuyen
                {
                    if (reader.Read())
                    {
                        bankID = String.Format("{0}", reader["id_bank"]);
                    }
                }
                //insert bank
                string query = $"SELECT count(*) FROM bank_user WHERE id_bank = {bankID} AND id_user={id_user}";
                SqlCommand cmd = new SqlCommand(query, cnn);
                int sl = (int)cmd.ExecuteScalar();
                if (sl == 0)
                {
                    SqlCommand addBANK = new SqlCommand("INSERT INTO bank_user (id_bank,id_user,money_bank) VALUES (@id_bank,@id_user,0)", cnn);
                    addBANK.Parameters.AddWithValue("@id_bank", bankID);
                    addBANK.Parameters.AddWithValue("@id_user", id_user);
                    addBANK.ExecuteNonQuery();
                    MessageBox.Show("Thêm ngân hàng thành công!");
                }
                else 
                {
                    MessageBox.Show("Ngân hàng vừa thêm đã tồn tại!!!");
                }
                cnn.Close();
            }
            panelAddBank.Visible = false;
            btn_add_bank_close.Visible = false;
        }

        private void btn_add_bank_Click_close(object sender, EventArgs e)
        {
            panelAddBank.Visible = false;
            btn_add_bank_close.Visible = false;
        }
        private void loadTableBank_add()
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
        private void loadTableALL_Bank()
        {
            cnn.Open();
            string query = $"SELECT id_bank,bankname FROM bank";
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            table_all_Bank.DataSource = dtbl;
            cnn.Close();
        }
    }
}
