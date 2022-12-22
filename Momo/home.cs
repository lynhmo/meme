using Momo.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Momo
{
    public partial class home : UserControl
    {
        public home()
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
        private static string connectionString = "Data Source=(local); Initial Catalog = momo; Integrated Security=SSPI;";
        private static SqlConnection cnn = new SqlConnection(connectionString);
        private int manguoidung;
        public string username_get { get; set; }
        private string cur_mon = "0";
        private void curent_money()
        {
            try
            {
                SqlCommand crruent_money = new SqlCommand("Select * from users WHERE username=@username1", cnn);
                crruent_money.Parameters.AddWithValue("@username1", username_get);
                //open conn
                cnn.Open();
                using (SqlDataReader reader = crruent_money.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cur_mon = Convert.ToDouble(String.Format("{0}", reader["money"])).ToString("C0",
                  CultureInfo.CreateSpecificCulture("vi-VN")); // tien hien tai
                    }
                }
                cnn.Close();
                lbl_user_money.Text = cur_mon;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private chuyentien chuyentien1;
        private void button1_Click(object sender, EventArgs e)
        {

            chuyentien1 = new chuyentien();
            chuyentien1.chuyentien_username = username_get; // chuyen username sang chuyen tien
            chuyentien1.Location = new Point(0, 0);
            chuyentien1.Size = new Size(841, 559);
            this.Controls.Add(chuyentien1);
            chuyentien1.Visible = true;
            chuyentien1.BringToFront();
        }

        private void home_Load(object sender, EventArgs e)
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 20, 20));
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 20, 20));
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 20, 20));
            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, 20, 20));
            panel7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 20, 20));
            panel8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel8.Width, panel8.Height, 20, 20));
            button3.Visible = false;
            button3_Click(sender, e);
        }
        private string money1 = "";
        private string id1 = "";
        private string manguoinhan1 = "";
        private string id2 = "";
        private string money2 = "";
        private string manguoinhan2 = "";
        private string id3 = "";
        private string money3 = "";
        private string manguoinhan3 = "";
        private string id4 = "";
        private string money4 = "";
        private string manguoinhan4 = "";

        private void panel1Load()
        {
            cnn.Open();
            SqlCommand idNguoigui = new SqlCommand("Select id from users WHERE username=@username", cnn);
            idNguoigui.Parameters.AddWithValue("@username", username_get);
            using (SqlDataReader reader = idNguoigui.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    manguoidung = Convert.ToInt32(String.Format("{0}", reader["id"])); //id nguoi gui
                }
            }
            SqlCommand top1 = new SqlCommand("SELECT * " +
                                            "FROM (SELECT t.*, ROW_NUMBER() OVER(ORDER BY ngaygiaodich DESC) AS RowNumber" +
                                                    " FROM lichsu t" +
                                                    " WHERE id_user = @iduser" +
                                                    " )AS tmp" +
                                            " WHERE RowNumber = 1", cnn); // thay thu tu cac record
            top1.Parameters.AddWithValue("@iduser", manguoidung);
            using (SqlDataReader reader = top1.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    money1 = String.Format("{0}", reader["total_money"]);
                    id1 = String.Format("{0}", reader["id_user_revice"]);
                }
            }
            //GET USER NAME
            SqlCommand top2 = new SqlCommand("SELECT username FROM users WHERE id=@iduser", cnn); // thay thu tu cac record
            top2.Parameters.AddWithValue("@iduser", id1);
            using (SqlDataReader reader = top2.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    manguoinhan1 = String.Format("{0}", reader["username"]);
                }
            }
            //
            lbl_amount_1.Text = money1 + "VND";
            lbl_name_lichsu1.Text = manguoinhan1;
            cnn.Close();
        }
        private void panel2Load()
        {
            cnn.Open();
            SqlCommand idNguoigui = new SqlCommand("Select id from users WHERE username=@username", cnn);
            idNguoigui.Parameters.AddWithValue("@username", username_get);
            using (SqlDataReader reader = idNguoigui.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    manguoidung = Convert.ToInt32(String.Format("{0}", reader["id"])); //id nguoi gui
                }
            }
            SqlCommand top1 = new SqlCommand("SELECT * " +
                                            "FROM (SELECT t.*, ROW_NUMBER() OVER(ORDER BY ngaygiaodich DESC) AS RowNumber" +
                                                    " FROM lichsu t" +
                                                    " WHERE id_user = @iduser" +
                                                    " )AS tmp" +
                                            " WHERE RowNumber = 2", cnn);
            top1.Parameters.AddWithValue("@iduser", manguoidung);
            using (SqlDataReader reader = top1.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    id2 = String.Format("{0}", reader["id_user_revice"]);
                    money2 = String.Format("{0}", reader["total_money"]);
                }
            }
            //GET USER NAME
            SqlCommand top2 = new SqlCommand("SELECT username FROM users WHERE id=@iduser", cnn); // thay thu tu cac record
            top2.Parameters.AddWithValue("@iduser", id2);
            using (SqlDataReader reader = top2.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    manguoinhan2 = String.Format("{0}", reader["username"]);
                }
            }
            //
            lbl_amount_2.Text = money2 + "VND";
            lbl_name_lichsu2.Text = manguoinhan2;
            cnn.Close();
        }
        private void panel3Load()
        {
            cnn.Open();
            SqlCommand idNguoigui = new SqlCommand("Select id from users WHERE username=@username", cnn);
            idNguoigui.Parameters.AddWithValue("@username", username_get);
            using (SqlDataReader reader = idNguoigui.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    manguoidung = Convert.ToInt32(String.Format("{0}", reader["id"])); //id nguoi gui
                }
            }
            SqlCommand top1 = new SqlCommand("SELECT * " +
                                            "FROM (SELECT t.*, ROW_NUMBER() OVER(ORDER BY ngaygiaodich DESC) AS RowNumber" +
                                                    " FROM lichsu t" +
                                                    " WHERE id_user = @iduser" +
                                                    " )AS tmp" +
                                            " WHERE RowNumber = 3", cnn);
            top1.Parameters.AddWithValue("@iduser", manguoidung);
            using (SqlDataReader reader = top1.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    id3 = String.Format("{0}", reader["id_user_revice"]);
                    money3 = String.Format("{0}", reader["total_money"]);
                }
            }
            //GET USER NAME
            SqlCommand top2 = new SqlCommand("SELECT username FROM users WHERE id=@iduser", cnn); // thay thu tu cac record
            top2.Parameters.AddWithValue("@iduser", id3);
            using (SqlDataReader reader = top2.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    manguoinhan3 = String.Format("{0}", reader["username"]);
                }
            }
            //
            lbl_amount_3.Text = money3 + "VND";
            lbl_name_lichsu3.Text = manguoinhan3;
            cnn.Close();
        }
        private void panel4Load()
        {
            cnn.Open();
            SqlCommand idNguoigui = new SqlCommand("Select id from users WHERE username=@username", cnn);
            idNguoigui.Parameters.AddWithValue("@username", username_get);
            using (SqlDataReader reader = idNguoigui.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    manguoidung = Convert.ToInt32(String.Format("{0}", reader["id"])); //id nguoi gui
                }
            }
            SqlCommand top1 = new SqlCommand("SELECT * " +
                                            "FROM (SELECT t.*, ROW_NUMBER() OVER(ORDER BY ngaygiaodich DESC) AS RowNumber" +
                                                    " FROM lichsu t" +
                                                    " WHERE id_user = @iduser" +
                                                    " )AS tmp" +
                                            " WHERE RowNumber = 4", cnn);
            top1.Parameters.AddWithValue("@iduser", manguoidung);
            using (SqlDataReader reader = top1.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    id4 = String.Format("{0}", reader["id_user_revice"]);
                    money4 = String.Format("{0}", reader["total_money"]);
                }
            }
            //GET USER NAME
            SqlCommand top2 = new SqlCommand("SELECT username FROM users WHERE id=@iduser", cnn); // thay thu tu cac record
            top2.Parameters.AddWithValue("@iduser", id4);
            using (SqlDataReader reader = top2.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    manguoinhan4 = String.Format("{0}", reader["username"]);
                }
            }
            //
            lbl_amount_4.Text = money4 + "VND";
            lbl_name_lichsu4.Text = manguoinhan4;
            cnn.Close();
        }
        private string money11 = "";
        private string id11 = "";
        private string manguoinhan11 = "";
        private string money22 = "";
        private string id22 = "";
        private string manguoinhan22 = "";
        private string money33 = "";
        private string id33 = "";
        private string manguoinhan33 = "";
        private string money44 = "";
        private string id44 = "";
        private string manguoinhan44 = "";
        private void panelNhan1load()
        {
            cnn.Open();
            SqlCommand idNguoigui = new SqlCommand("Select id from users WHERE username=@username", cnn);
            idNguoigui.Parameters.AddWithValue("@username", username_get);
            using (SqlDataReader reader = idNguoigui.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    manguoidung = Convert.ToInt32(String.Format("{0}", reader["id"])); //id nguoi gui
                }
            }
            SqlCommand top1 = new SqlCommand("SELECT * " +
                                            "FROM (SELECT t.*, ROW_NUMBER() OVER(ORDER BY ngaygiaodich DESC) AS RowNumber" +
                                                    " FROM lichsu t" +
                                                    " WHERE id_user_revice = @iduser" +
                                                    " )AS tmp" +
                                            " WHERE RowNumber = 1", cnn);
            top1.Parameters.AddWithValue("@iduser", manguoidung);
            using (SqlDataReader reader = top1.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    id11 = String.Format("{0}", reader["id_user"]);
                    money11 = String.Format("{0}", reader["total_money"]);
                }
            }
            //GET USER NAME
            SqlCommand top2 = new SqlCommand("SELECT username FROM users WHERE id=@iduser", cnn); // thay thu tu cac record
            top2.Parameters.AddWithValue("@iduser", id11);
            using (SqlDataReader reader = top2.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    manguoinhan11 = String.Format("{0}", reader["username"]);
                }
            }
            //
            lbl_money_nhan1.Text = money11 + "VND";
            lbl_name1.Text = manguoinhan11;
            cnn.Close();
        }
        private void panelNhan2load()
        {
            cnn.Open();
            SqlCommand idNguoigui = new SqlCommand("Select id from users WHERE username=@username", cnn);
            idNguoigui.Parameters.AddWithValue("@username", username_get);
            using (SqlDataReader reader = idNguoigui.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    manguoidung = Convert.ToInt32(String.Format("{0}", reader["id"])); //id nguoi gui
                }
            }
            SqlCommand top1 = new SqlCommand("SELECT * " +
                                            "FROM (SELECT t.*, ROW_NUMBER() OVER(ORDER BY ngaygiaodich DESC) AS RowNumber" +
                                                    " FROM lichsu t" +
                                                    " WHERE id_user_revice = @iduser" +
                                                    " )AS tmp" +
                                            " WHERE RowNumber = 2", cnn);
            top1.Parameters.AddWithValue("@iduser", manguoidung);
            using (SqlDataReader reader = top1.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    id22 = String.Format("{0}", reader["id_user"]);
                    money22 = String.Format("{0}", reader["total_money"]);
                }
            }
            //GET USER NAME
            SqlCommand top2 = new SqlCommand("SELECT username FROM users WHERE id=@iduser", cnn); // thay thu tu cac record
            top2.Parameters.AddWithValue("@iduser", id22);
            using (SqlDataReader reader = top2.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    manguoinhan22 = String.Format("{0}", reader["username"]);
                }
            }
            //
            lbl_money_nhan2.Text = money22 + "VND";
            lbl_name2.Text = manguoinhan22;
            cnn.Close();
        }
        private void panelNhan3load()
        {
            cnn.Open();
            SqlCommand idNguoigui = new SqlCommand("Select id from users WHERE username=@username", cnn);
            idNguoigui.Parameters.AddWithValue("@username", username_get);
            using (SqlDataReader reader = idNguoigui.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    manguoidung = Convert.ToInt32(String.Format("{0}", reader["id"])); //id nguoi gui
                }
            }
            SqlCommand top1 = new SqlCommand("SELECT * " +
                                            "FROM (SELECT t.*, ROW_NUMBER() OVER(ORDER BY ngaygiaodich DESC) AS RowNumber" +
                                                    " FROM lichsu t" +
                                                    " WHERE id_user_revice = @iduser" +
                                                    " )AS tmp" +
                                            " WHERE RowNumber = 3", cnn);
            top1.Parameters.AddWithValue("@iduser", manguoidung);
            using (SqlDataReader reader = top1.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    id33 = String.Format("{0}", reader["id_user"]);
                    money33 = String.Format("{0}", reader["total_money"]);
                }
            }
            //GET USER NAME
            SqlCommand top2 = new SqlCommand("SELECT username FROM users WHERE id=@iduser", cnn); // thay thu tu cac record
            top2.Parameters.AddWithValue("@iduser", id33);
            using (SqlDataReader reader = top2.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    manguoinhan33 = String.Format("{0}", reader["username"]);
                }
            }
            //
            lbl_money_nhan3.Text = money33 + "VND";
            lbl_name3.Text = manguoinhan33;
            cnn.Close();
        }
        private void panelNhan4load()
        {
            cnn.Open();
            SqlCommand idNguoigui = new SqlCommand("Select id from users WHERE username=@username", cnn);
            idNguoigui.Parameters.AddWithValue("@username", username_get);
            using (SqlDataReader reader = idNguoigui.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    manguoidung = Convert.ToInt32(String.Format("{0}", reader["id"])); //id nguoi gui
                }
            }
            SqlCommand top1 = new SqlCommand("SELECT * " +
                                            "FROM (SELECT t.*, ROW_NUMBER() OVER(ORDER BY ngaygiaodich DESC) AS RowNumber" +
                                                    " FROM lichsu t" +
                                                    " WHERE id_user_revice = @iduser" +
                                                    " )AS tmp" +
                                            " WHERE RowNumber = 1", cnn);
            top1.Parameters.AddWithValue("@iduser", manguoidung);
            using (SqlDataReader reader = top1.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    id44 = String.Format("{0}", reader["id_user"]);
                    money44 = String.Format("{0}", reader["total_money"]);
                }
            }
            //GET USER NAME
            SqlCommand top2 = new SqlCommand("SELECT username FROM users WHERE id=@iduser", cnn); // thay thu tu cac record
            top2.Parameters.AddWithValue("@iduser", id44);
            using (SqlDataReader reader = top2.ExecuteReader()) //nguoi chuyen
            {
                if (reader.Read())
                {
                    manguoinhan44 = String.Format("{0}", reader["username"]);
                }
            }
            //
            lbl_money_nhan4.Text = money44 + "VND";
            lbl_name4.Text = manguoinhan44;
            cnn.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            panel1Load();
            panel2Load();
            panel3Load();
            panel4Load();
            panelNhan1load();
            panelNhan2load();
            panelNhan3load();
            panelNhan4load();
            curent_money();
        }

        private addmoney addbank;
        private void btn_naptien_Click(object sender, EventArgs e)
        {
            addbank = new addmoney();
            addbank.addmoney_username = username_get;
            addbank.Location = new Point(0, 0);
            addbank.Size = new Size(841, 559);
            this.Controls.Add(addbank);
            addbank.Visible = true;
            addbank.BringToFront();
        }
    }
}
