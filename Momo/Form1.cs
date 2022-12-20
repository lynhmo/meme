using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Momo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //sidepanel.Height = btnHome.Height;
            //sidepanel.Top = btnHome.Top;
            //home.BringToFront();
            login.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnHome.Height;
            sidepanel.Top = btnHome.Top;
            home.BringToFront();
        }

        private void btnWallet_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnWallet.Height;
            sidepanel.Top = btnWallet.Top;
            uudai.BringToFront();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnGiaodich.Height;
            sidepanel.Top = btnGiaodich.Top;
            lichsu1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btn_money.Height;
            sidepanel.Top = btn_money.Top;
            nguontien1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnVicuatoi.Height;
            sidepanel.Top = btnVicuatoi.Top;
            mywallet1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool dragging = false;
        private Point startPoint = new Point();
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            //startPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X,p.Y-this.startPoint.Y);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            login.BringToFront();
        }
    }
}
