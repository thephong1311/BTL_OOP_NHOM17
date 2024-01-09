using BTL_OOP_N17.DAO;
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
            ycThanhly1.Visible = false;
            yckk1.Visible = false;
            danhgiaTB1.Visible = false;
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            thongkeTBcotaiPTN1.ResetState();
            thongkeTBcotaiPTN1.Visible = true;
            xemCacYCMua1.Visible = false;
            xemCacYCMuon1.Visible = false;
            xemCacYCsuachua1.Visible = false;
            ycThanhly1.Visible = false;
            yckk1.Visible = false;
            danhgiaTB1.Visible = false;
        }

        private void xemCácYCMượnTBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemCacYCMuon1.ResetText();
            xemCacYCMuon1.Visible = true;
            xemCacYCMua1.Visible = false;
            xemCacYCsuachua1.Visible = false;
            thongkeTBcotaiPTN1.Visible = false;
            ycThanhly1.Visible = false;
            yckk1.Visible = false;
            danhgiaTB1.Visible = false;
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemCacYCMua1.ResetText();
            xemCacYCMua1.Visible = true;
            xemCacYCsuachua1.Visible = false;
            thongkeTBcotaiPTN1.Visible = false;
            xemCacYCMuon1.Visible = false;
            ycThanhly1.Visible = false;
            yckk1.Visible = false;
            danhgiaTB1.Visible = false;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            xemCacYCsuachua1.ResetText();
            xemCacYCsuachua1.Visible = true;
            thongkeTBcotaiPTN1.Visible = false;
            xemCacYCMuon1.Visible = false;
            xemCacYCMua1.Visible = false;
            ycThanhly1.Visible = false;
            yckk1.Visible = false;
            danhgiaTB1.Visible = false;
        }

        private void xemCácYCThanhLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ycThanhly1.ResetText();
            ycThanhly1.Visible = true;
            yckk1.Visible = false;
            danhgiaTB1.Visible = false;
            xemCacYCsuachua1.Visible = false;
            thongkeTBcotaiPTN1.Visible = false;
            xemCacYCMuon1.Visible = false;
            xemCacYCMua1.Visible = false;

        }

        private void cácYCKiểmKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yckk1.ResetText();
            yckk1.Visible = true;
            ycThanhly1.Visible = false;
            danhgiaTB1.Visible = false;
            xemCacYCsuachua1.Visible = false;
            thongkeTBcotaiPTN1.Visible = false;
            xemCacYCMuon1.Visible = false;
            xemCacYCMua1.Visible = false;
        }

        private void đánhGiáTBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            danhgiaTB1.ResetText();
            danhgiaTB1.Visible = true;
            ycThanhly1.Visible = false;
            xemCacYCsuachua1.Visible = false;
            thongkeTBcotaiPTN1.Visible = false;
            xemCacYCMuon1.Visible = false;
            xemCacYCMua1.Visible = false;
            xemCacYCsuachua1.Visible = false;
        }


        private void btnThemYCmuon_Click(object sender, EventArgs e)
        {
            ThemMuonTS f = new ThemMuonTS();
            f.ShowDialog();
        }

        private void btnThemSC_Click(object sender, EventArgs e)
        {
            fAddYeucausuachuaTB f = new fAddYeucausuachuaTB();
            f.ShowDialog();
        }

        private void btnThemLC_Click(object sender, EventArgs e)
        {
            fAddLuanChuyen f= new fAddLuanChuyen();
            f.ShowDialog();
        }
    }
}
