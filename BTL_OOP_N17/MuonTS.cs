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
            ctpmGridView2.DataSource = infoCTPM();
        }
        public DataTable infoCTPM()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from CHITIET_MUON ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable infoDaDuyetGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from PHIEUMUONTS where TRANGTHAIMUON = N'Đã duyệt'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable infoChuaDuyetGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from PHIEUMUONTS where TRANGTHAIMUON = N'Chưa được duyệt'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable findPM()
        {
            string query = "SELECT * FROM PHIEUMUONTS WHERE MAPM = @MaPM AND TRANGTHAIMUON = N'Đã duyệt'";

            using (SqlCommand command = new SqlCommand(query, con))
            {
                // Thêm tham số và đặt giá trị
                command.Parameters.AddWithValue("@MAPM", txt_TimKiem.Text);

                // Thực hiện truy vấn
                SqlDataAdapter find = new SqlDataAdapter(command);
                DataTable dt_find = new DataTable();
                find.Fill(dt_find);

                return dt_find;
            }
        }
        public DataTable findPM2()
        {
            string query = "SELECT * FROM PHIEUMUONTS WHERE MAPM = @MaPM AND TRANGTHAIMUON = N'Chưa được duyệt'";

            using (SqlCommand command = new SqlCommand(query, con))
            {
                // Thêm tham số và đặt giá trị
                command.Parameters.AddWithValue("@MAPM", txt_TimKiem.Text);

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
        public void DeletePhieuMuon(string mapm)
        {
            // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ CSDL
            using (SqlCommand cmd = new SqlCommand("DELETE FROM PHIEUMUONTS WHERE MAPM = @mapm", con))
            {
                cmd.Parameters.AddWithValue("@mapm", mapm);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void DeleteCTPM(string mapm)
        {
            // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ CSDL
            using (SqlCommand cmd = new SqlCommand("DELETE FROM CHITIET_PM WHERE MAPM = @mapm", con))
            {
                cmd.Parameters.AddWithValue("@mapm", mapm);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        private void InitializeDataGridView()
        {
            daduyetGridView1.DataSource = infoDaDuyetGridView();
            chuaduyetGridView3.DataSource = infoDaDuyetGridView();
            ctpmGridView2.DataSource = infoCTPM();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã chọn một hàng trong DataGridView chưa
                if (daduyetGridView1.SelectedRows.Count > 0)
                {
                    // Lấy mã danh mục thiết bị từ hàng được chọn
                    string mapm1 = daduyetGridView1.SelectedRows[0].Cells["MAPM"].Value.ToString();

                    // Hiển thị hộp thoại xác nhận
                    DialogResult result1 = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu mượn này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Kiểm tra xem người dùng đã nhấn nút Yes hay không
                    if (result1 == DialogResult.Yes)
                    {
                        // Gọi hàm DeleteGV để xóa DMTB
                        DeletePhieuMuon(mapm1);

                        // Làm mới dữ liệu trong DataGridView sau khi xóa
                        InitializeDataGridView();

                        MessageBox.Show("Đã xóa phiếu mượn thành công!");
                    }
                    // Nếu người dùng chọn No, không thực hiện xóa
                }
                if (chuaduyetGridView3.SelectedRows.Count > 0)
                {
                    // Lấy mã danh mục thiết bị từ hàng được chọn
                    string mapm2 = chuaduyetGridView3.SelectedRows[0].Cells["MAPM"].Value.ToString();

                    // Hiển thị hộp thoại xác nhận
                    DialogResult result2 = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu mượn thiết bị này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Kiểm tra xem người dùng đã nhấn nút Yes hay không
                    if (result2 == DialogResult.Yes)
                    {
                        // Gọi hàm DeleteGV để xóa DMTB
                        DeletePhieuMuon(mapm2);

                        // Làm mới dữ liệu trong DataGridView sau khi xóa
                        InitializeDataGridView();

                        MessageBox.Show("Đã xóa phiếu mượn thiết bị thành công!");
                    }
                }
                if (ctpmGridView2.SelectedRows.Count > 0)
                {
                    // Lấy mã danh mục thiết bị từ hàng được chọn
                    string mapm3 = ctpmGridView2.SelectedRows[0].Cells["MAPM"].Value.ToString();

                    // Hiển thị hộp thoại xác nhận
                    DialogResult result3 = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu mượn thiết bị này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Kiểm tra xem người dùng đã nhấn nút Yes hay không
                    if (result3 == DialogResult.Yes)
                    {
                        // Gọi hàm DeleteGV để xóa DMTB
                        DeleteCTPM(mapm3);

                        // Làm mới dữ liệu trong DataGridView sau khi xóa
                        InitializeDataGridView();

                        MessageBox.Show("Đã xóa phiếu mượn thiết bị thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một danh mục thiết bị để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            ThemMuonTS f = new ThemMuonTS();
            f.ShowDialog();
        }
        public DataTable findCTPM()
        {
            string query = "SELECT * FROM CHITIET_MUON WHERE MAPM = @MaPM";

            using (SqlCommand command = new SqlCommand(query, con))
            {
                // Thêm tham số và đặt giá trị
                command.Parameters.AddWithValue("@MaPM", txtFindCT.Text);

                // Thực hiện truy vấn
                SqlDataAdapter find = new SqlDataAdapter(command);
                DataTable dt_find = new DataTable();
                find.Fill(dt_find);

                return dt_find;
            }
        }
        private void btnFindCT_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtFindCT.Text))
            {
                ctpmGridView2.DataSource = findCTPM();

            }
            else
            {
                MessageBox.Show("Hãy nhập mã phiếu mượn để tìm kiếm!");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Gọi lại hàm InitializeDataGridView để tải lại dữ liệu ban đầu
            InitializeDataGridView();
            // Xóa nội dung trong các ô TextBox
            ClearTextBoxes();
        }
        private void ClearTextBoxes()
        {
            txtFindCT.Text=string.Empty;
            txt_TimKiem.Text=string.Empty;
            txt_TimKiem1.Text = string.Empty;

        }

    }
}
