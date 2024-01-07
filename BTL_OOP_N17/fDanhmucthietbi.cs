﻿using BTL_OOP_N17.DAO;
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
    public partial class fDanhmucthietbi : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public fDanhmucthietbi()
        {
            InitializeComponent();
            dataGridView1.DataSource = infoDMTBGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        public DataTable infoDMTBGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from TAISAN", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        private void InitializeDataGridView()
        {
            dataGridView1.DataSource = infoDMTBGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }


        private DataTable SearchByMaTB(string maTB)
        {
            SqlDataAdapter sda = new SqlDataAdapter($"SELECT * FROM TAISAN WHERE MaTS = 'MaTS'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        private void textBoxMaTB_KeyDown(object sender, KeyEventArgs e)
        {
        
        }

        private void btnThem_Click(object sender, EventArgs e) //Thêm mới
        {
            try
            {
                string mats = txtMaTS.Text;
                string userts = txtTenTS.Text;


                // Gọi phương thức ThemDMTB để thêm danh mục thiết bị mới vào cơ sở dữ liệu
                ThemTS(mats, userts);

                // Làm mới dữ liệu trong DataGridView bằng cách gọi lại phương thức InitializeDataGridView
                InitializeDataGridView();

                MessageBox.Show("Đã thêm danh mục thiết bị mới thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteDMTS(string mats)
        {
            // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ CSDL
            using (SqlCommand cmd = new SqlCommand("DELETE FROM TAISAN WHERE MATS = @mats", con))
            {
                cmd.Parameters.AddWithValue("@mats", mats);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã chọn một hàng trong DataGridView chưa
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Lấy mã danh mục thiết bị từ hàng được chọn
                    string mats = dataGridView1.SelectedRows[0].Cells["MATS"].Value.ToString();

                    // Hiển thị hộp thoại xác nhận
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục thiết bị này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Kiểm tra xem người dùng đã nhấn nút Yes hay không
                    if (result == DialogResult.Yes)
                    {
                        // Gọi hàm DeleteGV để xóa DMTB
                        DeleteDMTS(mats);

                        // Làm mới dữ liệu trong DataGridView sau khi xóa
                        InitializeDataGridView();

                        MessageBox.Show("Đã xóa danh mục thiết bị thành công!");
                    }
                    // Nếu người dùng chọn No, không thực hiện xóa
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận sửa
            DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra xem người dùng đã đồng ý sửa hay không
            if (result == DialogResult.Yes)
            {
                // Lấy dữ liệu từ TextBox
                string mats = txtMaTS.Text;
                string userts = txtTenTS.Text;


                // Cập nhật dữ liệu trong DataGridView
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["MATS"].Value = mats;
                selectedRow.Cells["TENTS"].Value = userts;

                // Hiển thị thông tin trong GroupBox (nếu cần)
                DisplayTSInfo(mats, userts);

                // Đặt lại TextBox sau khi cập nhật
                ClearTextBoxes();
            }
        }
        private void ClearTextBoxes()
        {
            // Xóa nội dung trong TextBox
            txtMaTS.Text = "";
            txtTenTS.Text = "";

            // ...Xóa các TextBox khác tương ứng
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            // Tìm
            string mats = txtMaTS.Text;
            string userts = txtTenTS.Text;
            dataGridView1.DataSource = SearchTS(mats, userts);
        }

        private void fDanhmucthietbi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTS2DataSet.TAISAN' table. You can move, or remove it, as needed.
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
                string mats = selectedRow.Cells["MATS"].Value.ToString();
                string userts = selectedRow.Cells["TENTS"].Value.ToString();


                // Hiển thị thông tin trong GroupBox
                DisplayTSInfo(mats, userts);
            }
        }
        private void DisplayTSInfo(string mats, string userts)
        {
            // Hiển thị thông tin giáo viên trong GroupBox
            txtMaTS.Text = mats;
            txtTenTS.Text = userts;
            // ...Thêm các thuộc tính khác tương ứng
        }
        public DataTable SearchTS(string mats, string userts)
        {
            // Tạo câu truy vấn SQL động dựa trên số lượng thuộc tính đã nhập
            string query = "SELECT * FROM TAISAN WHERE ";
            bool isFirstCondition = true;

            if (!string.IsNullOrEmpty(mats))
            {
                query += $"MATS LIKE '%{mats}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(userts))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"TENTS LIKE '%{userts}%'";
                isFirstCondition = false;
            }


            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public void UpdateTS(string mats, string userts)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE TAISAN SET userts = @userts WHERE mats = @mats", con))
                {
                    cmd.Parameters.AddWithValue("@userts", userts);
                    cmd.Parameters.AddWithValue("@mats", mats);


                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã cập nhật thông tin danh mục thiết bị thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không có danh muc thiết bị nào được cập nhật. Có thể không tồn tại Mã TS tương ứng hoặc Mã TS không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ThemTS(string mats, string userts)
        {
            try
            {
                // Sử dụng SqlCommand để thực hiện câu truy vấn INSERT
                using (SqlCommand cmd = new SqlCommand("INSERT INTO TAISAN (MATS, TENTS) VALUES (@mats, @userts)", con))
                {
                    cmd.Parameters.AddWithValue("@mats", mats);
                    cmd.Parameters.AddWithValue("@userts", userts);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                // Làm mới dữ liệu trong DataGridView
                InitializeDataGridView();

                MessageBox.Show("Đã thêm danh mục thiết bị mới thành công!");
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL
                if (ex.Number == 2627)  // 2627 là mã lỗi cho việc vi phạm ràng buộc duy nhất (unique constraint)
                {
                    MessageBox.Show($"Mã '{mats}' đã tồn tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    }
}
