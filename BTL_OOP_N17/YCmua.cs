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
    public partial class YCmua : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public YCmua()
        {
            InitializeComponent();
            xemCacYCMua1.Visible = false;
            gpbThongtinchitiet.Visible = true;
            dgvThongtinchitiet.DataSource = chitietYCMuaGridView();
        }
        public DataTable chitietYCMuaGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from CHITIET_YCTS", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        private void YCmua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTS2DataSet1.PHONGTHINGHIEM' table. You can move, or remove it, as needed.


        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            xemCacYCMua1.Visible = false;
            gpbThongtinchitiet.Visible = true;
            dgvThongtinchitiet.DataSource = chitietYCMuaGridView();

            txtMaYC.Text = "";
            txtMaGV.Text = "";
            cbbPTN.Text = "";
            txtMota.Text = "";
            txtTrangthai.Text = "";

        }

        private void btnXemlai_Click(object sender, EventArgs e)
        {
            xemCacYCMua1.ResetText();
            xemCacYCMua1.Visible = true;
            gpbThongtinchitiet.Visible = false;

        }
        public bool tt = false;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaYC.Text) && !string.IsNullOrEmpty(txtMaGV.Text) && !string.IsNullOrEmpty(cbbPTN.Text) && !string.IsNullOrEmpty(txtMota.Text)
                && !string.IsNullOrEmpty(txtTrangthai.Text))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO YEUCAUMUATS (MAYC,MAGV,MAPTN,NGAYLAPYC,NOIDUNGYC,TRANGTHAIYC) VALUES (@mayc,@magv,@maptn,@ngaylapyc,@ndyc,@ttyc)", con))
                    {
                        cmd.Parameters.AddWithValue("@mayc", txtMaYC.Text);
                        cmd.Parameters.AddWithValue("@magv", txtMaGV.Text);
                        cmd.Parameters.AddWithValue("@maptn", cbbPTN.Text);
                        cmd.Parameters.AddWithValue("@ngaylapyc", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@ndyc", txtMota.Text);
                        cmd.Parameters.AddWithValue("@ttyc", txtTrangthai.Text);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin thành công! Hãy thêm thông tin chi tiết");
                            tt = true;
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại. Hãy kiếm tra lại thông tin !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();
                    }
                }
                catch (SqlException ex)
                {
                    // Xử lý lỗi SQL
                    if (ex.Number == 2627)  // 2627 là mã lỗi cho việc vi phạm ràng buộc duy nhất (unique constraint)
                    {
                        MessageBox.Show($"Mã '{txtMaYC.Text}' đã tồn tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tt == true)
            {
                fAddYCmua f = new fAddYCmua();
                f.ShowDialog();
                if (f.trangthai)
                {
                    dgvThongtinchitiet.DataSource = chitietYCMuaGridView();
                }
            }
            else
            {
                MessageBox.Show("Hãy tạo phiếu yêu cầu trước khi thêm thông tin chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaYC.Text) && !string.IsNullOrEmpty(txtMaGV.Text) && !string.IsNullOrEmpty(cbbPTN.Text) && !string.IsNullOrEmpty(txtMota.Text) && !string.IsNullOrEmpty(txtTrangthai.Text))
            {
                try
                {
                    // Kiểm tra xem bản ghi đã tồn tại hay chưa
                    bool recordExists = false;
                    using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM YEUCAUMUATS WHERE MAYC = @mayc", con))
                    {
                        checkCmd.Parameters.AddWithValue("@mayc", txtMaYC.Text);
                        con.Open();
                        int recordCount = (int)checkCmd.ExecuteScalar(); //trả về giá trị của cột đầu tiên của hàng đầu tiên 
                        recordExists = recordCount > 0; // nếu số lượng bản ghi lớn hơn 0 đúng thì recordExists = true
                        con.Close();
                    }

                    if (recordExists)
                    {
                        // Nếu bản ghi đã tồn tại, thực hiện câu lệnh UPDATE
                        using (SqlCommand updateCmd = new SqlCommand("UPDATE YEUCAUMUATS SET MAGV = @magv, MAPTN = @maptn, NGAYLAPYC = @ngaylapyc, NOIDUNGYC = @ndyc, TRANGTHAIYC = @ttyc WHERE MAYC = @mayc", con))
                        {
                            updateCmd.Parameters.AddWithValue("@mayc", txtMaYC.Text);
                            updateCmd.Parameters.AddWithValue("@magv", txtMaGV.Text);
                            updateCmd.Parameters.AddWithValue("@maptn", cbbPTN.Text);
                            updateCmd.Parameters.AddWithValue("@ngaylapyc", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                            updateCmd.Parameters.AddWithValue("@ndyc", txtMota.Text);
                            updateCmd.Parameters.AddWithValue("@ttyc", txtTrangthai.Text);

                            con.Open();
                            int rowsAffected = updateCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật thông tin thành công! Hãy thêm thông tin chi tiết");
                                tt = true;
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật thất bại. Hãy kiếm tra lại thông tin !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Mã '{txtMaYC.Text}' không tồn tại trong cơ sở dữ liệu. Hãy thực hiện thêm mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    // Xử lý lỗi SQL
                    if (ex.Number == 2627)  // 2627 là mã lỗi cho việc vi phạm ràng buộc duy nhất (unique constraint)
                    {
                        MessageBox.Show($"Mã '{txtMaYC.Text}' đã tồn tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void DeleteCTYCMUA(string mayc)
        {
            // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ CSDL
            using (SqlCommand cmd = new SqlCommand("DELETE FROM CHITIET_YCTS WHERE MAYC = @mayc", con))
            {
                cmd.Parameters.AddWithValue("@mayc", mayc);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void DeleteYCMUA(string mayc)
        {
            // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ CSDL
            using (SqlCommand cmd = new SqlCommand("DELETE FROM YEUCAUMUATS WHERE MAYC = @mayc", con))
            {
                cmd.Parameters.AddWithValue("@mayc", mayc);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        private void InitializeDataGridView()
        {
            dgvThongtinchitiet.DataSource = chitietYCMuaGridView();
            xemCacYCMua1.dataGridView1.DataSource = xemCacYCMua1.infoYCMuaGridView();

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã chọn một hàng trong DataGridView chưa
                if (dgvThongtinchitiet.SelectedRows.Count > 0)
                {
                    // Lấy mã danh mục thiết bị từ hàng được chọn
                    string mapm1 = dgvThongtinchitiet.SelectedRows[0].Cells["MAYC"].Value.ToString();

                    // Hiển thị hộp thoại xác nhận
                    DialogResult result1 = MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết phiếu yêu cầu mua này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Kiểm tra xem người dùng đã nhấn nút Yes hay không
                    if (result1 == DialogResult.Yes)
                    {
                        // Gọi hàm DeleteGV để xóa DMTB
                        DeleteCTYCMUA(mapm1);

                        // Làm mới dữ liệu trong DataGridView sau khi xóa
                        InitializeDataGridView();

                        MessageBox.Show("Đã xóa chi tiết phiếu yêu cầu thành công!");
                    }
                }
                if (xemCacYCMua1.dataGridView1.SelectedRows.Count > 0)
                {
                    // Lấy mã danh mục thiết bị từ hàng được chọn
                    string mapm2 = xemCacYCMua1.dataGridView1.SelectedRows[0].Cells["MAYC"].Value.ToString();

                    // Hiển thị hộp thoại xác nhận
                    DialogResult result1 = MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết yêu cầu mua này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Kiểm tra xem người dùng đã nhấn nút Yes hay không
                    if (result1 == DialogResult.Yes)
                    {
                        // Gọi hàm DeleteGV để xóa DMTB
                        DeleteYCMUA(mapm2);

                        // Làm mới dữ liệu trong DataGridView sau khi xóa
                        InitializeDataGridView();

                        MessageBox.Show("Đã xóa phiếu yêu cầu thành công!");
                    }
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
        public DataTable findCTYCmua()
        {
            string query = "SELECT * FROM CHITIET_YCTS  WHERE MAYC= @MaYC";

            using (SqlCommand command = new SqlCommand(query, con))
            {
                // Thêm tham số và đặt giá trị
                command.Parameters.AddWithValue("@MaYC", txtMaYC.Text);

                // Thực hiện truy vấn
                SqlDataAdapter find = new SqlDataAdapter(command);
                DataTable dt_find = new DataTable();
                find.Fill(dt_find);

                return dt_find;
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtMaYC.Text))
            {
                dgvThongtinchitiet.DataSource = findCTYCmua();
            }
            else
            {
                MessageBox.Show("Hãy nhập mã yêu cầu muốn tìm kiếm chi tiết");
            }

        }
    }
}

