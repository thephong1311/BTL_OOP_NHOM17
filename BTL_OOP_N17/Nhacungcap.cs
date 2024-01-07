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
    public partial class Nhacungcap : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public Nhacungcap()
        {
            InitializeComponent();
            dataGridView1.DataSource = infoNCCGridView();
        }
        public DataTable infoNCCGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from NHACUNGCAP", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void InitializeDataGridView()
        {
            dataGridView1.DataSource = infoNCCGridView();
        }

        private void Nhacungcap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTS2DataSet.NHACUNGCAP' table. You can move, or remove it, as needed.
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
                string mancc = selectedRow.Cells["MANCC"].Value.ToString();
                string userncc = selectedRow.Cells["TENNCC"].Value.ToString();
                string diachincc = selectedRow.Cells["DIACHINCC"].Value.ToString();
                string sdtncc = selectedRow.Cells["SDTNCC"].Value.ToString();

                // Hiển thị thông tin trong GroupBox
                DisplayNCCInfo(mancc, userncc, diachincc, sdtncc);
            }
        }
        private void DisplayNCCInfo(string mancc, string userncc, string diachincc, string sdtncc)
        {
            // Hiển thị thông tin giáo viên trong GroupBox
            txtMancc.Text = mancc;
            txtTenncc.Text = userncc;
            txtDiachincc.Text = diachincc;
            txtsdtncc.Text = sdtncc;
            // ...Thêm các thuộc tính khác tương ứng
        }
        public DataTable SearchQLTTNCC(string mancc, string userncc, string diachincc, string sdtncc)
        {
            // Tạo câu truy vấn SQL động dựa trên số lượng thuộc tính đã nhập
            string query = "SELECT * FROM NHACUNGCAP WHERE ";
            bool isFirstCondition = true;

            if (!string.IsNullOrEmpty(mancc))
            {
                query += $"MANCC LIKE '%{mancc}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(userncc))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"TENNCC LIKE '%{userncc}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(diachincc))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"DIACHINCC LIKE '%{diachincc}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(sdtncc))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"SDTNCC LIKE '%{sdtncc}%'";
            }


            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            string mancc = txtMancc.Text;
            string userncc = txtTenncc.Text;
            string diachincc = txtDiachincc.Text;
            string sdtncc = txtsdtncc.Text;
            dataGridView1.DataSource = SearchQLTTNCC(mancc, userncc, diachincc, sdtncc);
        }
        public void UpdateInfoNCC(string mancc, string userncc, string diachincc, string sdtncc)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE NHACUNGCAP SET userncc= @userncc , diachincc = @dcncc , sdtncc = @sdtncc WHERE mancc = @mancc", con))
                {
                    cmd.Parameters.AddWithValue("@userncc", userncc);
                    cmd.Parameters.AddWithValue("@dcncc", diachincc);
                    cmd.Parameters.AddWithValue("@sdtncc", sdtncc);
                    cmd.Parameters.AddWithValue("@mancc", mancc);
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
        public void ThemNCCmoi(string mancc, string userncc, string diachincc, string sdtncc)
        {
            // Thêm một tài khoản mới vào cơ sở dữ liệu
            // Sử dụng SqlCommand để thực hiện câu truy vấn INSERT
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO NHACUNGCAP (MANCC, TENNCC, DIACHINCC, SDTNCC) VALUES (@mancc, @userncc, @dcncc, @sdtncc)", con))
                {
                    cmd.Parameters.AddWithValue("@mancc", mancc);
                    cmd.Parameters.AddWithValue("@userncc", userncc);
                    cmd.Parameters.AddWithValue("@dcncc", diachincc);
                    cmd.Parameters.AddWithValue("@sdtncc", sdtncc);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();


                }


                MessageBox.Show("Đã thêm nhà cung cấp mới thành công!");
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL
                if (ex.Number == 2627)  // 2627 là mã lỗi cho việc vi phạm ràng buộc duy nhất (unique constraint)
                {
                    MessageBox.Show($"Mã '{mancc}' đã tồn tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void DeleteNCC(string mancc)
        {
            // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ CSDL
            using (SqlCommand cmd = new SqlCommand("DELETE FROM NHACUNGCAP WHERE MANCC = @mancc", con))
            {
                cmd.Parameters.AddWithValue("@mancc", mancc);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã chọn một hàng trong DataGridView chưa
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Lấy mã nhà cung cấp từ hàng được chọn
                    string mancc = dataGridView1.SelectedRows[0].Cells["MANCC"].Value.ToString();

                    // Hiển thị hộp thoại xác nhận
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Kiểm tra xem người dùng đã nhấn nút Yes hay không
                    if (result == DialogResult.Yes)
                    {
                        // Gọi hàm DeleteGV để xóa nhà cung cấp
                        DeleteNCC(mancc);

                        // Làm mới dữ liệu trong DataGridView sau khi xóa
                        InitializeDataGridView();

                        MessageBox.Show("Đã xóa nhà cung cấp thành công!");
                    }
                    // Nếu người dùng chọn No, không thực hiện xóa
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhà cung cấp để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mancc = txtMancc.Text;
                string userncc = txtTenncc.Text;
                string diachincc = txtDiachincc.Text;
                string sdtncc = txtsdtncc.Text;

                // Gọi phương thức ThemNCCmoi để thêm nhà cung cấp mới vào cơ sở dữ liệu
                ThemNCCmoi(mancc, userncc, diachincc, sdtncc);

                // Làm mới dữ liệu trong DataGridView bằng cách gọi lại phương thức InitializeDataGridView
                InitializeDataGridView();

                MessageBox.Show("Đã thêm nhà cung cấp mới thành công!");
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
                string mancc = txtMancc.Text;
                string userncc = txtTenncc.Text;
                string diachincc = txtDiachincc.Text;
                string sdtncc = txtsdtncc.Text;

                // Cập nhật dữ liệu trong DataGridView
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["MANCC"].Value = mancc;
                selectedRow.Cells["TENNCC"].Value = userncc;
                selectedRow.Cells["DIACHINCC"].Value = diachincc;
                selectedRow.Cells["SDTNCC"].Value = sdtncc;


                // Hiển thị thông tin trong GroupBox (nếu cần)
                DisplayNCCInfo(mancc, userncc, diachincc, sdtncc);

                // Đặt lại TextBox sau khi cập nhật
                ClearTextBoxes();
            }
        }
        private void ClearTextBoxes()
        {
            // Xóa nội dung trong TextBox
            txtMancc.Text = "";
            txtTenncc.Text = "";
            txtDiachincc.Text = "";
            txtsdtncc.Text = "";
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
