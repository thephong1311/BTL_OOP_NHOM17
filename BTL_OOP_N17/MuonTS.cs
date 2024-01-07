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
using TheArtOfDevHtmlRenderer.Adapters;

namespace BTL_OOP_N17
{
    public partial class MuonTS : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public MuonTS()
        {
            InitializeComponent();
            daduyetGridView1.DataSource = infoDaDuyetGridView();
            chuaduyetGridView3.DataSource = infoDaDuyetGridView();
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

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }
        public DataTable infoDaDuyetGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from PHIEUMUONTS where TRANGTHAI = N'Đã duyệt'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable infoChuaDuyetGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from CHITIET_MUON where TRANGTHAI = N'Chưa được duyệt'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable findPM()
        {
            string query = "SELECT * FROM PHIEUMUONTS WHERE MAPM = @MaPM";

            using (SqlCommand command = new SqlCommand(query, con))
            {
                // Thêm tham số và đặt giá trị
                command.Parameters.AddWithValue("@MaPM", txt_TimKiem.Text);

                // Thực hiện truy vấn
                SqlDataAdapter find = new SqlDataAdapter(command);
                DataTable dt_find = new DataTable();
                find.Fill(dt_find);

                return dt_find;
            }
        }
        public DataTable findPM2()
        {
            string query = "SELECT * FROM PHIEUMUONTS WHERE MAPM = @MaPM";

            using (SqlCommand command = new SqlCommand(query, con))
            {
                // Thêm tham số và đặt giá trị
                command.Parameters.AddWithValue("@MaPM", txt_TimKiem.Text);

                // Thực hiện truy vấn
                SqlDataAdapter find = new SqlDataAdapter(command);
                DataTable dt_find = new DataTable();
                find.Fill(dt_find);

                return dt_find;
            }
        }
        private void bt_Find_Click(object sender, EventArgs e)
        {
            daduyetGridView1.DataSource = findPM();
        }

        private void btn_Find2_Click(object sender, EventArgs e)
        {
            chuaduyetGridView3.DataSource = findPM2();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ThemMuonTS f = new ThemMuonTS();
            f.ShowDialog();
        }
    }
}
