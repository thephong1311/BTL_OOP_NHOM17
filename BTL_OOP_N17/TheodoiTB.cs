using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_OOP_N17
{
    public partial class TheodoiTB : Form
    {
        public TheodoiTB()
        {
            InitializeComponent();
            thongkeTBcotaiPTN1.Visible = false;
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            thongkeTBcotaiPTN1.Visible=true;
        }
    }
}
