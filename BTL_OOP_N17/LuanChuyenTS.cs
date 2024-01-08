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
    public partial class LuanChuyenTS : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public LuanChuyenTS()
        {
            InitializeComponent();
            dataGridView1.DataSource = infoLCTSGridView();
        }

        private void LuanChuyenTS_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            dataGridView1.SelectionChanged += DataGridView_SelectionChanged;
        }


        public DataTable infoLCTSGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from PHIEULCTS", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        private void InitializeDataGridView()
        {
            dataGridView1.DataSource = infoLCTSGridView();
        }
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy dữ liệu từ hàng được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string magv = selectedRow.Cells["MAGV"].Value.ToString();
                string malc = selectedRow.Cells["MAPHIEULC"].Value.ToString();
                string lcdi = selectedRow.Cells["NOILCDI"].Value.ToString();
                string lcden = selectedRow.Cells["NOILCDEN"].Value.ToString();
                string lydo = selectedRow.Cells["LYDOLC"].Value.ToString();
                string ngaylc = selectedRow.Cells["NGAYLC"].Value.ToString();

                // Hiển thị thông tin trong GroupBox
                ShowInfo(malc, lcdi, lcden, magv, ngaylc, lydo);
            }
        }
        private void ShowInfo(string malc, string lcdi, string lcden, string magv, string ngaylc, string lydo)
        {
           
            txtMP.Text = malc;
            txtLCdi.Text = lcdi;
            txtLCden.Text = lcden;
            txtMaGV.Text = magv;
            dt_NgayLC.Value = DateTime.Parse(ngaylc);
            txtLydo.Text = lydo;
            // ...Thêm các thuộc tính khác tương ứng
        }

        public DataTable SearchLCTS(string malc, string lcdi, string lcden, string magv, string lydo, string ngaylc)
        {
            // Tạo câu truy vấn SQL động dựa trên số lượng thuộc tính đã nhập
            string query = "SELECT * FROM PHIEULCTS WHERE ";
            bool isFirstCondition = true;

            if (!string.IsNullOrEmpty(magv))
            {
                query += $"MAGV LIKE '%{magv}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(malc))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"MAPHIEULCTS LIKE '%{malc}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(lcdi))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"NOILCDI LIKE '%{lcdi}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(lcden))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"NOILCDEN LIKE '%{lcden}%'";
            }

            if (!string.IsNullOrEmpty(ngaylc))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"NGAYLC LIKE '%{ngaylc}%'";
            }
            if (!string.IsNullOrEmpty(lydo))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"LYDO LIKE '%{lydo}%'";
            }
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            string magv = txtMaGV.Text;
            string lcdi = txtLCdi.Text;
            string lcden = txtLCden.Text;
            string lydo = txtLydo.Text;
            string ngaylc = dt_NgayLC.Value.ToString("yyyy-MM-dd");
            dataGridView1.DataSource = SearchLCTS(magv, lcdi, lcden, magv, lydo, ngaylc);
        }
        public void ThemLCmoi(string malc, string lcdi, string lcden, string magv, string lydo, string ngaylc)
        {
            // Thêm một tài khoản mới vào cơ sở dữ liệu
            // Sử dụng SqlCommand để thực hiện câu truy vấn INSERT
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO PHIEULCTS (MAPHIEULC, NOILCDI, NOILCDEN, MAGV, LYDOLC, NGAYLC) VALUES (@malc, @lcdi, @lcden, @magv, @lydo, @ngaylc)", con))
                {
                    cmd.Parameters.AddWithValue("@magv", magv);
                    cmd.Parameters.AddWithValue("@lcdi", lcdi);
                    cmd.Parameters.AddWithValue("@lcden", lcden);
                    cmd.Parameters.AddWithValue("@ngaylc", ngaylc);
                    cmd.Parameters.AddWithValue("@malc", malc);
                    cmd.Parameters.AddWithValue("@lydo", lydo);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();


                }


                MessageBox.Show("Đã thêm luân chuyển mới thành công!");
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL
                if (ex.Number == 2627)  // 2627 là mã lỗi cho việc vi phạm ràng buộc duy nhất (unique constraint)
                {
                    MessageBox.Show($"Mã '{malc}' đã tồn tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void DeleteLC(string malc)
        {
            // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ CSDL
            using (SqlCommand cmd = new SqlCommand("DELETE FROM PHIEULCTS WHERE MAPHIEULC = @malc", con))
            {
                cmd.Parameters.AddWithValue("@malc", malc);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                string magv = txtMaGV.Text;
                string malc = txtMP.Text;
                string lcdi = txtLCdi.Text;
                string lcden = txtLCden.Text;
                string ngaylc = dt_NgayLC.Value.ToString("yyyy-MM-dd");
                string lydo = txtLydo.Text;



                ThemLCmoi(malc, lcdi, lcden, magv, lydo, ngaylc);


                InitializeDataGridView();

                MessageBox.Show("Đã thêm thông tin luân chuyển mới thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã chọn một hàng trong DataGridView chưa
                if (dataGridView1.SelectedRows.Count > 0)
                {

                    string malc = dataGridView1.SelectedRows[0].Cells["MAPHIEULC"].Value.ToString();

                    // Hiển thị hộp thoại xác nhận
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa luân chuyển này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Kiểm tra xem người dùng đã nhấn nút Yes hay không
                    if (result == DialogResult.Yes)
                    {
                        // Gọi hàm DeleteGV để xóa giáo viên
                        DeleteLC(malc);

                        // Làm mới dữ liệu trong DataGridView sau khi xóa
                        InitializeDataGridView();

                        MessageBox.Show("Đã xóa thông tin luân chuyển thành công!");
                    }
                    // Nếu người dùng chọn No, không thực hiện xóa
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một luân chuyển để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra xem người dùng đã đồng ý sửa hay không
            if (result == DialogResult.Yes)
            {
                // Lấy dữ liệu từ TextBox

                string magv = txtMaGV.Text;
                string malc = txtMP.Text;
                string lcdi = txtLCdi.Text;
                string lcden = txtLCden.Text;
                string lydo = txtLydo.Text;
                string ngaylc = dt_NgayLC.Value.ToString("yyyy-MM-dd");

                // Cập nhật dữ liệu trong DataGridView
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["MAGV"].Value = magv;
                selectedRow.Cells["NOILCDI"].Value = lcdi;
                selectedRow.Cells["NOILCDEN"].Value = lcden;
                selectedRow.Cells["NGAYLC"].Value = ngaylc;
                selectedRow.Cells["MAPHIEULC"].Value = malc;
                selectedRow.Cells["LYDO"].Value = lydo;

                // Hiển thị thông tin trong GroupBox (nếu cần)
                ShowInfo(malc, lcdi, lcden, magv, ngaylc, lydo);
                // Đặt lại TextBox sau khi cập nhật
                ClearTextBoxes();

            }
        }
        private void ClearTextBoxes()
        {

            txtMaGV.Text = "";
            txtMP.Text = "";
            txtLCdi.Text = "";
            txtLCden.Text = "";
            txtLydo.Text = "";
            dt_NgayLC.Format = DateTimePickerFormat.Custom; ;
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
   

