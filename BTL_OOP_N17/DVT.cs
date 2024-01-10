using BTL_OOP_N17.DAO;
using CrystalDecisions.ReportAppServer.DataDefModel;
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
    public partial class DVT : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);

        public DVT()
        {
            InitializeComponent();
            dataGridView1.DataSource = infoGVGridView();

        }
        public DataTable infoGVGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from DVT", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaDVT.Text) && !string.IsNullOrEmpty(txtTenDVT.Text))
            {
                try
                {
                    string sqlInsert = "INSERT INTO DVT(MADVT,TENDVT) VALUES (@madvt,@tendvt)";
                    using (SqlCommand cmd = new SqlCommand(sqlInsert, con))
                    {
                        cmd.Parameters.AddWithValue("@madvt", txtMaDVT.Text);
                        cmd.Parameters.AddWithValue("@tendvt", txtTenDVT.Text);
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm mới đơn vị tính thành công!");
                            InitializeDataGridView();


                        }
                        else
                        {
                            MessageBox.Show("Thêm mới đơn vị tính thất bại. Hãy kiếm tra lại thông tin !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();
                    }
                }
                catch (SqlException ex)
                {

                    // Xử lý lỗi SQL
                    if (ex.Number == 2627)  // 2627 là mã lỗi cho việc vi phạm ràng buộc duy nhất (unique constraint)
                    {
                        MessageBox.Show($"Mã '{txtMaDVT.Text}' đã tồn tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ thông tin !");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaDVT.Text) && !string.IsNullOrEmpty(txtTenDVT.Text))
            {
                try
                {
                    string sqlInsert = "UPDATE DVT SET MADVT=@madvt,TENDVT=@tendvt WHERE MADVT=@madvt";
                    using (SqlCommand cmd = new SqlCommand(sqlInsert, con))
                    {
                        cmd.Parameters.AddWithValue("@madvt", txtMaDVT.Text);
                        cmd.Parameters.AddWithValue("@tendvt", txtTenDVT.Text);
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhập đơn vị tính thành công!");
                            InitializeDataGridView();

                        }
                        else
                        {
                            MessageBox.Show("Cập nhật đơn vị tính thất bại. Hãy kiếm tra lại thông tin !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ thông tin !");
            }
        }
        public void DeleteGV(string madvt)
        {
            // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ CSDL
            using (SqlCommand cmd = new SqlCommand("DELETE FROM DVT WHERE MaDVT = @madvt", con))
            {
                cmd.Parameters.AddWithValue("@madvt", madvt);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        private void InitializeDataGridView()
        {
            dataGridView1.DataSource = infoGVGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã chọn một hàng trong DataGridView chưa
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Lấy mã giáo viên từ hàng được chọn
                    string madvt = dataGridView1.SelectedRows[0].Cells["MADVT"].Value.ToString();

                    // Hiển thị hộp thoại xác nhận
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin đơn vị tính này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Kiểm tra xem người dùng đã nhấn nút Yes hay không
                    if (result == DialogResult.Yes)
                    {
                        // Gọi hàm DeleteGV để xóa giáo viên
                        DeleteGV(madvt);

                        // Làm mới dữ liệu trong DataGridView sau khi xóa
                        InitializeDataGridView();

                        MessageBox.Show("Đã xóa đơn vị tính thành công!");
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
            txtMaDVT.Text = string.Empty;
            txtTenDVT.Text= string.Empty;
            InitializeDataGridView();

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public DataTable findDVT()
        {
            string query = "SELECT * FROM DVT WHERE MADVT = @madvt";

            using (SqlCommand command = new SqlCommand(query, con))
            {
                // Thêm tham số và đặt giá trị
                command.Parameters.AddWithValue("@madvt", txtFind.Text);

                // Thực hiện truy vấn
                SqlDataAdapter find = new SqlDataAdapter(command);
                DataTable dt_find = new DataTable();
                find.Fill(dt_find);

                return dt_find;
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = findDVT();
        }
    }
}
