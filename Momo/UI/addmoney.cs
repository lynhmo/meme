using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public string addmoney_username { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
