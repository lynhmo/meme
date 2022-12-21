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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Momo.UI
{
    public partial class chuyentien : UserControl
    {
        public chuyentien()
        {
            InitializeComponent();
            dataLoadDanhBa();
        }
        private static string connectionString = "Data Source=(local); Initial Catalog = momo; Integrated Security=SSPI;";
        private static SqlConnection cnn = new SqlConnection(connectionString);

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public string chuyentien_username { get; set; }
        private string username = "";
        private int cur_money = 0;
        private int id_user = 0;
        private int money_receive = 0;
        private int id_user_reveice = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            //CHUYEN TIEN BUTTON
            username = chuyentien_username;
            //select
            //nguoi chuyen
            SqlCommand infoUserGui = new SqlCommand("Select * from users WHERE username=@username", cnn);
            infoUserGui.Parameters.AddWithValue("@username", username);
            //nguoi nhan
            SqlCommand command_user_receive = new SqlCommand("Select * from users WHERE username=@username1", cnn);
            command_user_receive.Parameters.AddWithValue("@username1", txtusername_receive.Text);
            //open conn
            cnn.Open();
            using (SqlDataReader reader = infoUserGui.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    cur_money = Convert.ToInt32(String.Format("{0}", reader["money"])); // tien hien tai cua nguoi gui
                    id_user = Convert.ToInt32(String.Format("{0}", reader["id"])); //id nguoi gui
                }
            }
            using (SqlDataReader reader = command_user_receive.ExecuteReader()) //nguoi nhan
            {
                if (reader.Read())
                {
                    money_receive = Convert.ToInt32(String.Format("{0}", reader["money"])); // TIEN HIEN TAI CUA NGUOI NHAN
                    id_user_reveice = Convert.ToInt32(String.Format("{0}", reader["id"]));  // id nguoi nhan
                }
            }
            int transferMoney = Convert.ToInt32(txt_money_transfer.Text); // TIEN GUI
            int finalMoneyTrans = cur_money - transferMoney;//TIEN CHECK 
            int FinalMoneyReceive = transferMoney + money_receive;//tien nhan
            string dateTransfer = string.Format(DateTime.Now.ToString("yyyy-MM-dd"));
            if (finalMoneyTrans >= 0) // neu tien gui it hon tien hien co bao không du so du
            {
                //update money cua nguoi chuyen
                SqlCommand updateNguoiGui = new SqlCommand("UPDATE users SET money = @moneychuyen WHERE id=@id_gui", cnn);
                updateNguoiGui.Parameters.AddWithValue("@id_gui", id_user);
                updateNguoiGui.Parameters.AddWithValue("@moneychuyen", finalMoneyTrans);
                updateNguoiGui.ExecuteNonQuery();
                //update money cua nguoi nhan
                SqlCommand updateNguoiNhan = new SqlCommand("UPDATE users SET money = @moneynhan WHERE id=@id_gui", cnn);
                updateNguoiNhan.Parameters.AddWithValue("@moneynhan", FinalMoneyReceive);
                updateNguoiNhan.Parameters.AddWithValue("@id_gui", id_user_reveice);
                updateNguoiNhan.ExecuteNonQuery();
                //insert
                SqlCommand insertLichSu = new SqlCommand("INSERT INTO lichsu (id_user,id_user_revice,total_money,ngaygiaodich) VALUES (@id_gui,@id_nhan,@totalMoney,@date)", cnn);
                insertLichSu.Parameters.AddWithValue("@id_gui", id_user);
                insertLichSu.Parameters.AddWithValue("@id_nhan", id_user_reveice);
                insertLichSu.Parameters.AddWithValue("@totalMoney", transferMoney);
                insertLichSu.Parameters.AddWithValue("@date", dateTransfer);
                insertLichSu.ExecuteNonQuery();
                cnn.Close();
                //refresh
                txtusername_receive.Text = null;
                txt_money_transfer.Text = null;
                txtMessage.Text = null;
                //thong bao
                button1_Click(sender, e);
                MessageBox.Show("Chuyen tien thanh cong!","Successed");
            }
            else
            {
                MessageBox.Show("Tài khoản không đủ!");
            }
            cnn.Close();
        }
        private void dataLoadDanhBa()
        {
            cnn.Open();
            string query = $"SELECT id,username,fullname FROM users";
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            tableDanhBa.DataSource = dtbl;
            cnn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tableDanhBa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tableDanhBa.CurrentRow.Selected = true;
            }
        }
    }
}
