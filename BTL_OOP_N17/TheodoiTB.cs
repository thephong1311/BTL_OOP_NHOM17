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
            xemCacYCMuon1.Visible = false;  
            xemCacYCMua1.Visible = false;
            xemCacYCsuachua1.Visible = false;
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            thongkeTBcotaiPTN1.ResetState();
            thongkeTBcotaiPTN1.Visible=true;
            xemCacYCMua1.Visible = false;
            xemCacYCMuon1.Visible = false;
            xemCacYCsuachua1.Visible = false;
        }

        private void xemCácYCMượnTBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemCacYCMuon1.ResetText();
            xemCacYCMuon1.Visible=true;
            xemCacYCMua1.Visible = false;
            xemCacYCsuachua1.Visible = false;
            thongkeTBcotaiPTN1.Visible = false;
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemCacYCMua1.ResetText();
            xemCacYCMua1.Visible=true;
            xemCacYCsuachua1.Visible = false;
            thongkeTBcotaiPTN1.Visible = false;
            xemCacYCMuon1.Visible = false;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            xemCacYCsuachua1.ResetText();
            xemCacYCsuachua1.Visible=true;
            thongkeTBcotaiPTN1.Visible = false;
            xemCacYCMuon1.Visible = false;
            xemCacYCMua1.Visible = false;
        }
    }
}
