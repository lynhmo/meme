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
    public partial class dautu : UserControl
    {
        public dautu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dautu_Load(object sender, EventArgs e)
        {
            loadTableALL_Bank();
        }
        private static string connectionString = "Data Source=(local); Initial Catalog = momo; Integrated Security=SSPI;";
        private static SqlConnection cnn = new SqlConnection(connectionString);
        private void loadTableALL_Bank()
        {
            cnn.Open();
            string query = $"SELECT * FROM bank";
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            table_all_Bank.DataSource = dtbl;
            cnn.Close();
        }
    }
}
