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

namespace Momo.UI
{
    public partial class addmoney : UserControl
    {
        public addmoney()
        {
            InitializeComponent();
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
    }
}
