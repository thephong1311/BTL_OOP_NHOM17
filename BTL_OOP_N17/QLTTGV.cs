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
    public partial class QLTTGV : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public QLTTGV()
        {
            InitializeComponent();
            dataGridView1.DataSource = infoGVGridView();
        }
        public DataTable infoGVGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from GIAOVIEN", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        private void InitializeDataGridView()
        {
            dataGridView1.DataSource = infoGVGridView();
        }


        private void QLTTGV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTS2DataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            InitializeDataGridView();
            dataGridView1.SelectionChanged += DataGridView_SelectionChanged;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy dữ liệu từ hàng được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string magv = selectedRow.Cells["MaGV"].Value.ToString();
                string username = selectedRow.Cells["TENGV"].Value.ToString();
                string diachi = selectedRow.Cells["DIACHIGV"].Value.ToString();
                string sdt = selectedRow.Cells["SDTGV"].Value.ToString();
                string chucvu = selectedRow.Cells["CHUCVUGV"].Value.ToString();
                string mptn = selectedRow.Cells["MAPTN"].Value.ToString();

                // Hiển thị thông tin trong GroupBox
                DisplayStudentInfo(magv, username, diachi, sdt, chucvu,mptn);
            }
        }

        private void DisplayStudentInfo(string magv, string username, string diachi, string sdt, string chucvu, string mptn)
        {
            // Hiển thị thông tin giáo viên trong GroupBox
            txtMaGV.Text = magv;
            txtTenGV.Text = username;
            txtDiaChi.Text = diachi;
            txtSDTGV.Text = sdt;
            txtChucvu.Text = chucvu;
            txtMPTN.Text = mptn;
            // ...Thêm các thuộc tính khác tương ứng
        }
        public DataTable SearchQLTTGV(string magv, string username, string diachi, string sdt, string chucvu)
        {
            // Tạo câu truy vấn SQL động dựa trên số lượng thuộc tính đã nhập
            string query = "SELECT * FROM GIAOVIEN WHERE ";
            bool isFirstCondition = true;

            if (!string.IsNullOrEmpty(magv))
            {
                query += $"MaGV LIKE '%{magv}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(username))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"TENGV LIKE '%{username}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(diachi))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"DIACHIGV LIKE '%{diachi}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(sdt))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"SDTGV LIKE '%{sdt}%'";
            }

            if (!string.IsNullOrEmpty(chucvu))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"CHUCVUGV LIKE '%{chucvu}%'";
            }

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;   
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string magv = txtMaGV.Text;
            string username = txtTenGV.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDTGV.Text;
            string chucvu = txtChucvu.Text;
            dataGridView1.DataSource = SearchQLTTGV(magv, username, diachi, sdt, chucvu);
        }
        public void UpdateInfoGV(string magv, string username, string diachi, string sdt, string chucvu, string mptn)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE GIAOVIEN SET TENGV = @username, MAPTN = @mptn , DIACHIGV = @dc , SDTGV = @sdt , CHUCVUGV = @chucvu, MAGV = @magv WHERE MAGV = @magv", con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@magv", magv);
                    cmd.Parameters.AddWithValue("@mptn", mptn);
                    cmd.Parameters.AddWithValue("@dc", diachi);
                    cmd.Parameters.AddWithValue("@sdt", sdt);
                    cmd.Parameters.AddWithValue("@chucvu", chucvu);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã cập nhật thông tin tài khoản thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không có tài khoản nào được cập nhật. Có thể không tồn tại Mã DD tương ứng hoặc Mã DD không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ThemGVmoi(string magv, string username, string diachi, string sdt, string chucvu, string mptn)
        {
            // Thêm một tài khoản mới vào cơ sở dữ liệu
            // Sử dụng SqlCommand để thực hiện câu truy vấn INSERT
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO GIAOVIEN (MaGV, TENGV, DIACHIGV, SDTGV, CHUCVUGV, MAPTN) VALUES (@magv, @username, @dc, @sdt, @chucvu, @mptn)", con))
                {
                    cmd.Parameters.AddWithValue("@magv", magv);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@dc", diachi);
                    cmd.Parameters.AddWithValue("@sdt", sdt);
                    cmd.Parameters.AddWithValue("@chucvu", chucvu);
                    cmd.Parameters.AddWithValue("@mptn", mptn);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();


                }


                MessageBox.Show("Đã thêm tài khoản mới thành công!");
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL
                if (ex.Number == 2627)  // 2627 là mã lỗi cho việc vi phạm ràng buộc duy nhất (unique constraint)
                {
                    MessageBox.Show($"Mã '{magv}' đã tồn tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi khác (nếu có)
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đảm bảo rằng kết nối sẽ được đóng dù có lỗi hay không
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        public void DeleteGV(string magv)
        {
            // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ CSDL
            using (SqlCommand cmd = new SqlCommand("DELETE FROM GIAOVIEN WHERE MaGV = @magv", con))
            {
                cmd.Parameters.AddWithValue("@magv", magv);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
            string magv = txtMaGV.Text;
            string username = txtTenGV.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDTGV.Text;
            string chucvu = txtChucvu.Text;
                string mptn = txtMPTN.Text;

                // Gọi phương thức ThemGVmoi để thêm giáo viên mới vào cơ sở dữ liệu
                ThemGVmoi(magv, username, diachi, sdt, chucvu, mptn);

                // Làm mới dữ liệu trong DataGridView bằng cách gọi lại phương thức InitializeDataGridView
                InitializeDataGridView();

                MessageBox.Show("Đã thêm giáo viên mới thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã chọn một hàng trong DataGridView chưa
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Lấy mã giáo viên từ hàng được chọn
                    string magv = dataGridView1.SelectedRows[0].Cells["MaGV"].Value.ToString();

                    // Hiển thị hộp thoại xác nhận
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa giáo viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Kiểm tra xem người dùng đã nhấn nút Yes hay không
                    if (result == DialogResult.Yes)
                    {
                        // Gọi hàm DeleteGV để xóa giáo viên
                        DeleteGV(magv);

                        // Làm mới dữ liệu trong DataGridView sau khi xóa
                        InitializeDataGridView();

                        MessageBox.Show("Đã xóa giáo viên thành công!");
                    }
                    // Nếu người dùng chọn No, không thực hiện xóa
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một giáo viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy giá trị của cột MAKK từ hàng đã chọn
                string selectedMaGV = dataGridView1.SelectedRows[0].Cells["MAGV"].Value.ToString();

                // Kiểm tra nếu người dùng chọn sửa MAKK
                if (txtMaGV.Text != selectedMaGV)
                {
                    MessageBox.Show("Không được sửa giá trị MAGV.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng quá trình sửa nếu MAKK được chọn
                }
            }
            // Hiển thị hộp thoại xác nhận sửa
            DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra xem người dùng đã đồng ý sửa hay không
            if (result == DialogResult.Yes)
            {
                // Lấy dữ liệu từ TextBox
                string magv = txtMaGV.Text;
                string username = txtTenGV.Text;
                string diachi = txtDiaChi.Text;
                string sdt = txtSDTGV.Text;
                string chucvu = txtChucvu.Text;
                string mptn = txtMPTN.Text;

                // Cập nhật dữ liệu trong DataGridView
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["MaGV"].Value = magv;
                selectedRow.Cells["TENGV"].Value = username;
                selectedRow.Cells["DIACHIGV"].Value = diachi;
                selectedRow.Cells["SDTGV"].Value = sdt;
                selectedRow.Cells["CHUCVUGV"].Value = chucvu;
                selectedRow.Cells["MAPTN"].Value = mptn;

                // Hiển thị thông tin trong GroupBox (nếu cần)
                DisplayStudentInfo(magv, username, diachi, sdt, chucvu, mptn);
                UpdateInfoGV(magv, username, diachi, sdt, chucvu, mptn);

                // Đặt lại TextBox sau khi cập nhật
                ClearTextBoxes();
            }
        }

        private void ClearTextBoxes()
        {
            // Xóa nội dung trong TextBox
            txtMaGV.Text = "";
            txtTenGV.Text = "";
            txtDiaChi.Text = "";
            txtSDTGV.Text = "";
            txtChucvu.Text = "";
            txtMPTN.Text = "";
            // ...Xóa các TextBox khác tương ứng
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {  
                // Gọi lại hàm InitializeDataGridView để tải lại dữ liệu ban đầu
                InitializeDataGridView();
                // Xóa nội dung trong các ô TextBox
                ClearTextBoxes();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

