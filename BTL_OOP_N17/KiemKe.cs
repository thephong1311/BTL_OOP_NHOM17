using BTL_OOP_N17.DAO;
using DevExpress.XtraEditors.Mask.Design;
using DevExpress.XtraPrinting.Native;
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
    public partial class KiemKe : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public KiemKe()
        {
            InitializeComponent();
           dataGridView1.DataSource = infoKKGridView();

        }

        private void KiemKe_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            dataGridView1.SelectionChanged += DataGridView_SelectionChanged;
        }

        public DataTable infoKKGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from KIEMKE", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        private void InitializeDataGridView()
        {
            dataGridView1.DataSource = infoKKGridView();
        }
        private void ShowInfo(string makk, string magv, string maptn, string ngaykk, string mota)
        {
            
            txtMAKK.Text = makk;
            txtMAGV.Text = magv;
            txtMAPTN.Text = maptn;
            txtMOTA.Text = magv;
            dtKK.Value = DateTime.Parse(ngaykk);

            // ...Thêm các thuộc tính khác tương ứng
        }
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy dữ liệu từ hàng được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string magv = selectedRow.Cells["MAGV"].Value.ToString();
                string makk = selectedRow.Cells["MAKK"].Value.ToString();
                string maptn = selectedRow.Cells["MAPTN"].Value.ToString();
                string mota = selectedRow.Cells["MOTAKK"].Value.ToString();
                string ngaykk = selectedRow.Cells["NGAYKK"].Value.ToString();


                // Hiển thị thông tin trong GroupBox
                ShowInfo(makk, magv, maptn, ngaykk, mota);
            }


        }
        public void UpdateInfo(string makk,string magv,string maptn,string ngaykk,string mota)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE KIEMKE SET  MAKK = @MAKK, MAGV = @MAGV, MAPTN = @MAPTN, " +
                    "NGAYKK = @NGAYKK, MOTAKK = @MOTAKK WHERE MAKK = @MAKK", con))
                {
                    cmd.Parameters.AddWithValue("@MAGV", magv);
                    cmd.Parameters.AddWithValue("@MAKK", makk);
                    cmd.Parameters.AddWithValue("@MAPTN", maptn);
                    cmd.Parameters.AddWithValue("@NGAYKK", ngaykk);
                    cmd.Parameters.AddWithValue("@MOTAKK", mota);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã cập nhật thông tin thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không có thông tin kiểm kê được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable SearchKK(string makk, string magv, string maptn, string ngaykk, string mota)
        {
            // Tạo câu truy vấn SQL động dựa trên số lượng thuộc tính đã nhập
            string query = "SELECT * FROM KIEMKE WHERE ";
            bool isFirstCondition = true;

            if (!string.IsNullOrEmpty(magv))
            {
                query += $"MAGV LIKE '%{magv}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(makk))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"MAKK LIKE '%{makk}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(maptn))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"MAPTN LIKE '%{maptn}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(ngaykk))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"NGAYKK LIKE '%{ngaykk}%'";
            }

            if (!string.IsNullOrEmpty(mota))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"MOTAKK LIKE '%{mota}%'";
            }

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            string magv = txtMAGV.Text;
            string makk = txtMAKK.Text;
            string maptn = txtMAPTN.Text;
            string mota = txtMOTA.Text;
            string ngaykk = dtKK.Value.ToString("yyyy-MM-dd");
            dataGridView1.DataSource = SearchKK(makk, magv, maptn, ngaykk, mota);

        }
        public void ThemKKmoi(string makk, string magv, string maptn, string ngaykk, string mota)
        {
           
            // Sử dụng SqlCommand để thực hiện câu truy vấn INSERT
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO KIEMKE (MAKK, MAGV, MAPTN, NGAYKK, MOTAKK) VALUES (@makk,@magv,@maptn,@ngaykk, @mota)", con))
                {
                    cmd.Parameters.AddWithValue("@magv", magv);
                    cmd.Parameters.AddWithValue("@makk", makk);
                    cmd.Parameters.AddWithValue("@maptn", maptn);
                    cmd.Parameters.AddWithValue("@ngaykk", ngaykk);
                    cmd.Parameters.AddWithValue("@mota", mota);

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
                    MessageBox.Show($"Mã '{makk}' đã tồn tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void DeleteKK(string makk)
        {
            // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ CSDL
            using (SqlCommand cmd = new SqlCommand("DELETE FROM KIEMKE WHERE MAKK = @makk", con))
            {
                cmd.Parameters.AddWithValue("@makk", makk);

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

                    string makk = dataGridView1.SelectedRows[0].Cells["MAKK"].Value.ToString();

                    // Hiển thị hộp thoại xác nhận
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin kiểm kê này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Kiểm tra xem người dùng đã nhấn nút Yes hay không
                    if (result == DialogResult.Yes)
                    {
                        
                        DeleteKK(makk);

                        // Làm mới dữ liệu trong DataGridView sau khi xóa
                        InitializeDataGridView();

                        MessageBox.Show("Đã xóa kiểm kê thành công!");
                    }
                    // Nếu người dùng chọn No, không thực hiện xóa
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một thông tin kiểm kê để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string magv = txtMAGV.Text;
                string makk = txtMAKK.Text;
                string maptn = txtMAPTN.Text;
                string mota = txtMOTA.Text;
                string ngaykk = dtKK.Value.ToString("yyyy-MM-dd");



                ThemKKmoi(makk, magv, maptn, ngaykk, mota);

                // Làm mới dữ liệu trong DataGridView bằng cách gọi lại phương thức InitializeDataGridView
                InitializeDataGridView();

                MessageBox.Show("Đã thêm thông tin kiểm kê mới thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận sửa
            DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra xem người dùng đã đồng ý sửa hay không
            if (result == DialogResult.Yes)
            {
                // Lấy dữ liệu từ TextBox

                string magv = txtMAGV.Text;
                string makk = txtMAKK.Text;
                string maptn = txtMAPTN.Text;
                string mota = txtMOTA.Text;
                string ngaykk = dtKK.Value.ToString("yyyy-MM-dd");

                // Cập nhật dữ liệu trong DataGridView
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["MAGV"].Value = magv;
                selectedRow.Cells["MAKK"].Value = makk;
                selectedRow.Cells["MAPTN"].Value = maptn;
                selectedRow.Cells["NGAYKK"].Value = ngaykk;
                selectedRow.Cells["MOTAKK"].Value = mota;


                // Hiển thị thông tin trong GroupBox (nếu cần)
                ShowInfo(makk, magv, maptn, ngaykk, mota);
                UpdateInfo(makk, magv, maptn, ngaykk, mota);

                // Đặt lại TextBox sau khi cập nhật
                ClearTextBoxes();

            }
           

        }
        private void ClearTextBoxes()
        {

            txtMAGV.Text = "";
            txtMAKK.Text = "";
            txtMAPTN.Text = "";
            txtMOTA.Text = "";
            dtKK.Format = DateTimePickerFormat.Custom; ;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
