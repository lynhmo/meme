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

        private void lichsu_Load(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM lichsu";
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            tableLichSu.DataSource = dtbl;
        }
    }
}
