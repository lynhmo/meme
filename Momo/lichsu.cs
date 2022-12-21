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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Momo
{
    public partial class lichsu : UserControl
    {
        public lichsu()
        {
            InitializeComponent();
        }
        private static string connectionString = "Data Source=(local); Initial Catalog = momo; Integrated Security=SSPI;";
        private static SqlConnection cnn = new SqlConnection(connectionString);
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string username_get_lichsu { get; set; }
        private int manguoidung;
        private void lichsu_Load(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand idNguoigui = new SqlCommand("Select id from users WHERE username=@username", cnn);
            idNguoigui.Parameters.AddWithValue("@username", username_get_lichsu);
            using (SqlDataReader reader = idNguoigui.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    manguoidung = Convert.ToInt32(String.Format("{0}", reader["id"])); //id nguoi gui
                }
            }
            string query = $"SELECT * FROM lichsu WHERE id_user={manguoidung}";
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            tableLichSu.DataSource = dtbl;
            cnn.Close();
        }
    }
}
