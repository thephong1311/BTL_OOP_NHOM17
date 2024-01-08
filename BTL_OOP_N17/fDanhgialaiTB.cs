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
    public partial class fDanhgialaiTB : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public fDanhgialaiTB()
        {
            InitializeComponent();
            dataGridView1.DataSource = infoDGTBGridView();
            dataGridView2.DataSource = infoCHITIETDGTBGridView();

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public DataTable infoDGTBGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from DANHGIATS", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable infoCHITIETDGTBGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from CHITIET_DGTS", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fAddDanhgialaiTB f=new fAddDanhgialaiTB();
            f.ShowDialog();
        }
        public void DeleteDGTS(string mats)
        {
            // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ CSDL
            using (SqlCommand cmd = new SqlCommand("DELETE FROM DANHGIATS WHERE MADGKTS = @madglts", con))
            {
                cmd.Parameters.AddWithValue("@madglts", mats);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void DeleteCTDGTS(string mats)
        {
            // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ CSDL
            using (SqlCommand cmd = new SqlCommand("DELETE FROM CHITIET_DGTS WHERE MADGKTS = @madglts", con))
            {
                cmd.Parameters.AddWithValue("@madglts", mats);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        private void InitializeDataGridView()
        {
            dataGridView1.DataSource = infoDGTBGridView();
            dataGridView2.DataSource = infoCHITIETDGTBGridView();
        }

        private void bthXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã chọn một hàng trong DataGridView chưa
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Lấy mã danh mục thiết bị từ hàng được chọn
                    string mats = dataGridView1.SelectedRows[0].Cells["MADGLTS"].Value.ToString();

                    // Hiển thị hộp thoại xác nhận
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Kiểm tra xem người dùng đã nhấn nút Yes hay không
                    if (result == DialogResult.Yes)
                    {
                        // Gọi hàm DeleteGV để xóa DMTB
                        DeleteDGTS(mats);

                        // Làm mới dữ liệu trong DataGridView sau khi xóa
                        InitializeDataGridView();

                        MessageBox.Show("Đã xóa thành công!");
                    }
                    // Nếu người dùng chọn No, không thực hiện xóa
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    // Lấy mã danh mục thiết bị từ hàng được chọn
                    string mats = dataGridView2.SelectedRows[0].Cells["MADGLTS"].Value.ToString();

                    // Hiển thị hộp thoại xác nhận
                    DialogResult result1 = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Kiểm tra xem người dùng đã nhấn nút Yes hay không
                    if (result1 == DialogResult.Yes)
                    {
                        // Gọi hàm DeleteGV để xóa DMTB
                        DeleteCTDGTS(mats);

                        // Làm mới dữ liệu trong DataGridView sau khi xóa
                        InitializeDataGridView();

                        MessageBox.Show("Đã xóa thành công!");
                    }
                    // Nếu người dùng chọn No, không thực hiện xóa
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtFind.Text = string.Empty;
            dataGridView1.DataSource = infoDGTBGridView();
            dataGridView2.DataSource = infoCHITIETDGTBGridView();
        }
        public DataTable findDGTS()
        {
            string query = "SELECT * FROM DANHGIATS WHERE MADGLTS = @MADGLTS ";

            using (SqlCommand command = new SqlCommand(query, con))
            {
                // Thêm tham số và đặt giá trị
                command.Parameters.AddWithValue("@MADGLTS", txtFind.Text);

                // Thực hiện truy vấn
                SqlDataAdapter find = new SqlDataAdapter(command);
                DataTable dt_find = new DataTable();
                find.Fill(dt_find);

                return dt_find;
            }
        }
        public DataTable findCTDGTS()
        {
            string query = "SELECT * FROM CHITIET_DGTS WHERE MADGLTS = @MADGLTS ";

            using (SqlCommand command = new SqlCommand(query, con))
            {
                // Thêm tham số và đặt giá trị
                command.Parameters.AddWithValue("@MADGLTS", txtFind.Text);

                // Thực hiện truy vấn
                SqlDataAdapter find = new SqlDataAdapter(command);
                DataTable dt_find = new DataTable();
                find.Fill(dt_find);

                return dt_find;
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtFind.Text))
            {
                dataGridView1.DataSource = findDGTS();
                dataGridView2.DataSource = findCTDGTS();
            }
            else
            {
                MessageBox.Show("Hãy nhập mã đánh giá lại tài sản để thực hiện tìm kiếm !");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
                fAddDanhgialaiTB f=new fAddDanhgialaiTB();
                f.ShowDialog();

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
