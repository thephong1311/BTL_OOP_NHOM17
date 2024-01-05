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
    public partial class GVControl : Form
    {
        public GVControl()
        {
            InitializeComponent();
        }
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
            OpenChildForm(new ThongtintaikhoanAdmin());
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn muốn đăng xuất không ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void yêuCầuMuaThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YCmua f = new YCmua();
            f.ShowDialog();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            TheodoiTB f = new TheodoiTB();
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
            ThanhLyTB f = new ThanhLyTB();
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

        private void thiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DoiMK());
        }

        private void báoCáoTổngHợpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportKiemKeTS f = new ReportKiemKeTS();
            f.ShowDialog();
        }

        private void báoCáoLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportLuanChuyenTS f = new ReportLuanChuyenTS();
            f.ShowDialog();
        }

        private void báoCáoMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportMuonTS f = new ReportMuonTS();
            f.ShowDialog();
        }

        private void báoCáoSửaChữaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportSuaChuaTS f = new ReportSuaChuaTS();
            f.ShowDialog();
        }

        private void báoCáoThanhLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportThanhLy f = new ReportThanhLy();
            f.ShowDialog();
        }

        private void báoCáoTìnhTrạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportTinhTrangTS f = new ReportTinhTrangTS();
            f.ShowDialog();
        }

        private void báoCáoYêuCầuMuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportYCmua f = new ReportYCmua();
            f.ShowDialog();
        }
    }
}
