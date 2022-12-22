using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

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
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_bank_Click(object sender, EventArgs e)
        {
            panelAddBank.Visible = true;
            btn_add_bank_close.Visible= true;
        }

        private void btn_add_done_Click(object sender, EventArgs e)
        {
            panelAddBank.Visible = false;
            btn_add_bank_close.Visible = false;
        }

        private void btn_add_bank_Click_close(object sender, EventArgs e)
        {
            panelAddBank.Visible = false;
            btn_add_bank_close.Visible = false;
        }
    }
}
