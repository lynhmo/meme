using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Momo
{
    public partial class mywallet : UserControl
    {
        public mywallet()
        {
            InitializeComponent();
        }
        public string setusername { get; set; }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private static string connectionString = "Data Source=(local); Initial Catalog = momo; Integrated Security=SSPI;";
        private static SqlConnection cnn = new SqlConnection(connectionString);
        private void mywallet_Load(object sender, EventArgs e)
        {
            //Form1.
            lbl_username_wallet.Text = setusername;
            SqlCommand commandNV = new SqlCommand("Select * from users WHERE username=@username", cnn);
            commandNV.Parameters.AddWithValue("@username", lbl_username_wallet.Text);
            cnn.Open();
            using (SqlDataReader reader = commandNV.ExecuteReader())
            {
                if (reader.Read())
                {
                    lbl_user_money.Text = String.Format("{0}", reader["money"]);
                }
            }
            cnn.Close();
        }
    }
    //class user
    //{
    //    private string username = "";

    //    public string setusername { get; set { }; }
    //}
}
