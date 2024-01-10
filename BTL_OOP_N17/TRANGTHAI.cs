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

  
    public partial class TRANGTHAI : Form
    {

        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public TRANGTHAI()
        {
            InitializeComponent();
            dataGridView1.DataSource = infoGVGridView();
        }
        public DataTable infoGVGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from TRANGTHAI", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        private void InitializeDataGridView()
        {
            dataGridView1.DataSource = infoGVGridView();
        }
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
         
            if (dataGridView1.SelectedRows.Count > 0)
            {
               
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string matt = selectedRow.Cells["MATT"].Value.ToString();
                string tentt = selectedRow.Cells["TENTT"].Value.ToString();

                DisplayInfo(matt, tentt);
            }
        }

        private void TRANGTHAI_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            dataGridView1.SelectionChanged += DataGridView_SelectionChanged;
        }
        private void DisplayInfo(string matt, string tentt)
        {
            txtMTT.Text = matt;
            txtTTT.Text = tentt;

        }

        public DataTable SearchTT(string matt, string tentt)
        {
           
            string query = "SELECT * FROM TRANGTHAI WHERE ";
            bool isFirstCondition = true;

            if (!string.IsNullOrEmpty(matt))
            {
                query += $"MATT LIKE '%{matt}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(tentt))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"TENTT LIKE '%{tentt}%'";
                isFirstCondition = false;
            }

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public void UpdateInfoTT(string matt, string tentt)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE TRANGTHAI SET TENTT = @tentt WHERE MATT = @matt", con))
                {
                    cmd.Parameters.AddWithValue("@tentt", tentt);
                    cmd.Parameters.AddWithValue("@matt", matt);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã cập nhật thông tin trạng thái thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không có trạng thái nào được cập nhật. Có thể không tồn tại Mã trạng thái tương ứng hoặc Mã trạng thái không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        public void ThemTTmoi(string matt, string tentt)
        {
           
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO TRANGTHAI(MATT, TENTT) VALUES (@matt, @tentt)", con))
                {
                    cmd.Parameters.AddWithValue("@matt", matt);
                    cmd.Parameters.AddWithValue("@tentt", tentt);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();


                }


                MessageBox.Show("Đã thêm tài khoản mới thành công!");
            }
            catch (SqlException ex)
            {
               
                if (ex.Number == 2627)  
                {
                    MessageBox.Show($"Mã '{matt}' đã tồn tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
               
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
               
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        public void DeleteTT(string matt)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM TRANGTHAI WHERE MATT = @matt", con))
            {
                cmd.Parameters.AddWithValue("@matt", matt);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string matt = txtMTT.Text;
            string tentt = txtTTT.Text;

            dataGridView1.DataSource = SearchTT (matt, tentt);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string matt = txtMTT.Text;
                string tentt = txtTTT.Text;
                ThemTTmoi(matt, tentt);
                InitializeDataGridView();
                MessageBox.Show("Đã thêm trạng thái mới thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
               
                string matt = txtMTT.Text;
                string tentt = txtTTT.Text;

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["MATT"].Value = matt;
                selectedRow.Cells["TENTT"].Value = tentt;

              
                DisplayInfo(matt, tentt);
                UpdateInfoTT(matt, tentt);
              
                ClearTextBoxes();
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
                    string matt = dataGridView1.SelectedRows[0].Cells["MATT"].Value.ToString();

                    // Hiển thị hộp thoại xác nhận
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa trạng thái này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Kiểm tra xem người dùng đã nhấn nút Yes hay không
                    if (result == DialogResult.Yes)
                    {

                        DeleteTT(matt);

                        // Làm mới dữ liệu trong DataGridView sau khi xóa
                        InitializeDataGridView();

                        MessageBox.Show("Đã xóa trạng thái thành công!");
                    }
                    // Nếu người dùng chọn No, không thực hiện xóa
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một trạng thái để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            InitializeDataGridView();
            ClearTextBoxes();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearTextBoxes()
        {
            // Xóa nội dung trong TextBox
            txtMTT.Text = "";
            txtTTT.Text = "";
        }
    }
}
