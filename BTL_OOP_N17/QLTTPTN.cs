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
    public partial class QLTTPTN : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public QLTTPTN()
        {
            InitializeComponent();
            dataGridView1.DataSource = infoPTNGridView();
        }
        public DataTable infoPTNGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from PHONGTHINGHIEM", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void InitializeDataGridView()
        {
            dataGridView1.DataSource = infoPTNGridView();
        }

        private void QLTTPTN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTS2DataSet.PTN' table. You can move, or remove it, as needed.
            InitializeDataGridView();
            dataGridView1.SelectionChanged += DataGridView_SelectionChanged;
        }
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy dữ liệu từ hàng được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string maptn = selectedRow.Cells["MAPTN"].Value.ToString();
                string userptn = selectedRow.Cells["TENPTN"].Value.ToString();
                //string sophong = selectedRow.Cells["SOPHONG"].Value.ToString();
                //string dientich = selectedRow.Cells["DIENTICH"].Value.ToString();
                string vitri = selectedRow.Cells["VITRI"].Value.ToString();
                //string trangthaiptn = selectedRow.Cells["TRANGTHAIPTN"].Value.ToString();

                // Hiển thị thông tin trong GroupBox
                DisplayPTNInfo(maptn, userptn, vitri);
            }
        }
        private void DisplayPTNInfo(string maptn, string userptn, string vitri)
        {
            // Hiển thị thông tin giáo viên trong GroupBox
            txtMaPTN.Text = maptn;
            txtTenPTN.Text = userptn;
            txtVitri.Text = vitri;
            // ...Thêm các thuộc tính khác tương ứng
        }
        public DataTable SearchQLTTPTN(string maptn, string userptn, string vitri)
        {
            // Tạo câu truy vấn SQL động dựa trên số lượng thuộc tính đã nhập
            string query = "SELECT * FROM PHONGTHINGHIEM WHERE ";
            bool isFirstCondition = true;

            if (!string.IsNullOrEmpty(maptn))
            {
                query += $"MAPTN LIKE '%{maptn}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(userptn))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"TENPTN LIKE '%{userptn}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(vitri))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"VITRI LIKE '%{vitri}%'";
                isFirstCondition = false;
            }


            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string maptn = txtMaPTN.Text;
            string userptn = txtTenPTN.Text;
            string vitri = txtVitri.Text;
            dataGridView1.DataSource = SearchQLTTPTN(maptn, userptn, vitri);
        }
        public void UpdateInfoPTN(string maptn, string userptn, string vitri)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE PHONGTHINGHIEM SET TENPTN = @userptn , vitri = @vt WHERE maptn = @maptn", con))
                {
                    cmd.Parameters.AddWithValue("@userptn", userptn);
                    cmd.Parameters.AddWithValue("@maptn", maptn);
                    cmd.Parameters.AddWithValue("@vt", vitri);

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
        public void ThemPTNmoi(string maptn, string userptn, string vitri)
        {
            // Thêm một tài khoản mới vào cơ sở dữ liệu
            // Sử dụng SqlCommand để thực hiện câu truy vấn INSERT
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO PHONGTHINGHIEM (MaGV, TENGV, DIACHIGV, SDTGV, CHUCVUGV) VALUES (@magv, @username, @dc, @sdt, @chucvu)", con))
                {
                    cmd.Parameters.AddWithValue("@maptn", maptn);
                    cmd.Parameters.AddWithValue("@userptn", userptn);
                    cmd.Parameters.AddWithValue("@vt", vitri);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();


                }

                MessageBox.Show("Đã thêm phòng thí nghiệm mới thành công!");
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL
                if (ex.Number == 2627)  // 2627 là mã lỗi cho việc vi phạm ràng buộc duy nhất (unique constraint)
                {
                    MessageBox.Show($"Mã '{maptn}' đã tồn tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void DeletePTN(string maptn)
        {
            // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ CSDL
            using (SqlCommand cmd = new SqlCommand("DELETE FROM PHONGTHINGHIEM WHERE MAPTN = @maptn", con))
            {
                cmd.Parameters.AddWithValue("@maptn", maptn);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maptn = txtMaPTN.Text;
                string userptn = txtTenPTN.Text;
                string vitri = txtVitri.Text;

                // Gọi phương thức ThemPTNmoi để thêm phòng thí nghiệm mới vào cơ sở dữ liệu
                ThemPTNmoi(maptn, userptn, vitri);
                // Làm mới dữ liệu trong DataGridView bằng cách gọi lại phương thức InitializeDataGridView
                InitializeDataGridView();

                MessageBox.Show("Đã thêm phòng thí nghiệm mới thành công!");
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
                    // Lấy mã PTN từ hàng được chọn
                    string maptn = dataGridView1.SelectedRows[0].Cells["MAPTN"].Value.ToString();

                    // Hiển thị hộp thoại xác nhận
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng thí nghiệm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Kiểm tra xem người dùng đã nhấn nút Yes hay không
                    if (result == DialogResult.Yes)
                    {
                        // Gọi hàm DeleteGV để xóa PTN
                        DeletePTN(maptn);

                        // Làm mới dữ liệu trong DataGridView sau khi xóa
                        InitializeDataGridView();

                        MessageBox.Show("Đã xóa phòng thí nghiệm thành công!");
                    }
                    // Nếu người dùng chọn No, không thực hiện xóa
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một phòng thí nghiệm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string selectedMaPTN = dataGridView1.SelectedRows[0].Cells["MAPTN"].Value.ToString();

                // Kiểm tra nếu người dùng chọn sửa MAKK
                if (txtMaPTN.Text != selectedMaPTN)
                {
                    MessageBox.Show("Không được sửa giá trị MAPTN.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng quá trình sửa nếu MAKK được chọn
                }
            }
            // Hiển thị hộp thoại xác nhận sửa
            DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra xem người dùng đã đồng ý sửa hay không
            if (result == DialogResult.Yes)
            {
                // Lấy dữ liệu từ TextBox
                string maptn = txtMaPTN.Text;
                string userptn = txtTenPTN.Text;
                string vitri = txtVitri.Text;


                // Cập nhật dữ liệu trong DataGridView
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["MAPTN"].Value = maptn;
                selectedRow.Cells["TENPTN"].Value = userptn;
                selectedRow.Cells["VITRI"].Value = vitri;

                // Hiển thị thông tin trong GroupBox (nếu cần)
                DisplayPTNInfo(maptn, userptn, vitri);
                UpdateInfoPTN(maptn, userptn, vitri);

                // Đặt lại TextBox sau khi cập nhật
                ClearTextBoxes();
            }
        }
        private void ClearTextBoxes()
        {
            // Xóa nội dung trong TextBox
            txtMaPTN.Text = "";
            txtTenPTN.Text = "";
            txtVitri.Text = "";
            // ...Xóa các TextBox khác tương ứng
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Gọi lại hàm InitializeDataGridView để tải lại dữ liệu ban đầu
            InitializeDataGridView();
            // Xóa nội dung trong các ô TextBox
            ClearTextBoxes();
        }

    }
}
