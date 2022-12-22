using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Momo.UI
{
    public partial class addmoney : UserControl
    {
        public addmoney()
        {
            InitializeComponent();
            comboboxBank_Load();
        }
        private static string connectionString = "Data Source=(local); Initial Catalog = momo; Integrated Security=SSPI;";
        private static SqlConnection cnn = new SqlConnection(connectionString);
        public string addmoney_username { get; set; }
        private int id_user;
        private void loadTableBank()
        {
            cnn.Open();
            SqlCommand idNguoigui = new SqlCommand("Select id from users WHERE username=@username", cnn);
            idNguoigui.Parameters.AddWithValue("@username", addmoney_username);
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void addmoney_Load(object sender, EventArgs e)
        {
            loadTableBank();

        }
        private void comboboxBank_Load()
        {
            cnn.Open();
            string cmbNhanvien = $"SELECT bankname FROM bank_user,bank WHERE id_user={id_user} AND bank.id_bank=bank_user.id_bank";
            SqlDataAdapter cmbNhanvien_ = new SqlDataAdapter(cmbNhanvien, cnn);
            DataSet ds1 = new DataSet();
            cmbNhanvien_.Fill(ds1, "bankname1");
            cbb_bankname.DisplayMember = "bankname";
            //cbb_bankname.ValueMember = "id_bank";
            cbb_bankname.DataSource = ds1.Tables["bankname1"];
            cnn.Close();

        }
        private int naptien=0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (naptienNumber.Value > 0)
            {
                currMoney();
                naptien = Convert.ToInt32(naptienNumber.Value);
                cnn.Open();
                SqlCommand updateNguoiGui = new SqlCommand("UPDATE users SET money = @nap WHERE id=@id", cnn);
                updateNguoiGui.Parameters.AddWithValue("@id", id_user);
                updateNguoiGui.Parameters.AddWithValue("@nap", naptien+ current_Money);
                updateNguoiGui.ExecuteNonQuery();
                cnn.Close();
                button1_Click(sender,e);
                MessageBox.Show("Đã nạp "+naptien+ " VNĐ vào tài khoản!", "Thành công");
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi khi thực hiện");
            }
        }
        private int current_Money=0;
        private void currMoney()
        {
            SqlCommand commandNV = new SqlCommand("Select money from users WHERE id=@id", cnn);
            commandNV.Parameters.AddWithValue("@id", id_user);
            cnn.Open();
            using (SqlDataReader reader = commandNV.ExecuteReader())
            {
                if (reader.Read())
                {
                    current_Money = Convert.ToInt32(String.Format("{0}", reader["money"]));
                }
            }
            cnn.Close();
        }
    }
}
