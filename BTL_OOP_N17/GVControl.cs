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

     


        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DoiMK());
        }









        private void mượnThiếtBịToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new MuonTS());
        }

      

        private void sửaChữaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new SuaChuaTS());
        }

        private void thôngTinTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongtintaikhoanAdmin());
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new DoiMK());
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn muốn đăng xuất không ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void theoDõiThiếtBịToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new TheodoiTB());
        }

        private void danhMụcThiếtBịToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new fDanhmucthietbi());
        }

        private void yêuCầuMuaThiếtBịToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            OpenChildForm(new fDanhmucthietbi());
        }

        private void đánhGiáLạiThiếtBịToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new ThanhLyTB());
        }

        private void thanhLýThiếtBịToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new ThanhLyTB());
        }

        private void luânChuyểnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new LuanChuyenTS());
        }

        private void kiểmKêToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new KiemKe());
        }

        private void danhMụcNhàCungCấpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Nhacungcap());
        }

       

        private void thốngKêYêuCầuMuaTạiPTNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChartMua());
        }

        private void thốngKêYêuCầuMuaTheoThờiGianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChartThongkeMuaTheoTGian());
        }

        private void thốngKêSốLượngThiếtBịTạiPTNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChartSoluongTBcotaiPTN());
        }

        private void thốngKêSốTiềnTrongPTNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChartSoTienTrongPTN());
        }

        private void thốngKêMượnThiếtBịTạiPTNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChartTKMuon());
        }

        private void danhMụcPhòngThíNghiệmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLTTPTN());
        }

        private void GVControl_Load(object sender, EventArgs e)
        {

        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }  
}
