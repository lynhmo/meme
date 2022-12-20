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
    public partial class login : UserControl
    {
        public login()
        {
            InitializeComponent();
            //panel1.BringToFront();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
    
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.SendToBack();

        }

        private void loginclose(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }
    }
}
