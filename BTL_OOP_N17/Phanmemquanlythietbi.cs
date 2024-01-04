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
    public partial class fDevicemanage : Form
    {
        public fDevicemanage()
        {
            InitializeComponent();
        }
        Panel panel_Body = new Panel();
        private Form currentFormchild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormchild != null)
            {
                currentFormchild.Close();
            }
            currentFormchild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yêuCầuMuaThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhMụcGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLTTGV f = new QLTTGV();
            f.ShowDialog(); 
        }

        private void danhMụcPhòngThíNghiệmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLTTPTN f = new QLTTPTN();
            f.ShowDialog();
        }

        private void danhMụcNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhacungcap f = new Nhacungcap();
            f.ShowDialog();
        }

        private void theoDõiThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTheodoiTB f = new fTheodoiTB();
            f.ShowDialog();
        }

        private void danhMụcThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDanhmucthietbi f = new fDanhmucthietbi();
            f.ShowDialog();
        }

        private void yêuCầuMuaThiếtBịToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            YCmua f = new YCmua();
            f.ShowDialog();
        }

        private void đánhGiáLạiThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDanhgialaiTB f = new fDanhgialaiTB();
            f.ShowDialog();
        }

        private void mượnThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thanhLýThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThanhLyTS f = new ThanhLyTS();
            f.ShowDialog();
        }

        private void luânChuyểnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LuanChuyenTS f = new LuanChuyenTS();
            f.ShowDialog();
        }

        private void kiểmKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KiemKe f = new KiemKe();
            f.ShowDialog();
        }
    }
}
