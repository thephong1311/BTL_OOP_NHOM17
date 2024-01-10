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
    public partial class ACCOUNT : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);

        public ACCOUNT()
        {
            InitializeComponent();
            dataGridView1.DataSource = infoACGridView();
        }
        public DataTable infoACGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from ACCOUNT", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        private void InitializeDataGridView()
        {
            dataGridView1.DataSource = infoACGridView();
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string tk = selectedRow.Cells["TAIKHOAN"].Value.ToString();
                string mk = selectedRow.Cells["MATKHAU"].Value.ToString();
                string quyen = selectedRow.Cells["QUYEN"].Value.ToString();
                DisplayStudentInfo(tk,mk,quyen);
            }
        }

        private void DisplayStudentInfo(string tk, string mk, string quyen)
        {
            txtTK.Text = tk;
            txtMK.Text = mk;
            cbbQuyen.Text = quyen;
        }
        public DataTable SearchQLTTGV(string tk, string mk)
        {
            string query = "SELECT * FROM ACCOUNT WHERE ";
            bool isFirstCondition = true;

            if (!string.IsNullOrEmpty(tk))
            {
                query += $"TAIKHOAN LIKE '%{tk}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(mk))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"MATKHAU LIKE '%{mk}%'";
                isFirstCondition = false;
            }

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string tk = txtTK.Text;
            string mk = txtMK.Text;
            dataGridView1.DataSource = SearchQLTTGV(tk,mk);
        }
        public void UpdateInfoGV(string tk, string mk, string quyen)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE ACCOUNT SET TAIKHOAN = @tk, MATKHAU = @mk , QUYEN = @quyen WHERE TAIKHOAN = @tk", con))
                {
                    cmd.Parameters.AddWithValue("@tk", tk);
                    cmd.Parameters.AddWithValue("@mk", mk);
                    cmd.Parameters.AddWithValue("@quyen", quyen);
                   
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã cập nhật thông tin tài khoản thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không có tài khoản nào được cập nhật. Có thể không tồn tại tài khoản tương ứng hoặc mã tài khoản không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ThemGVmoi(string tk, string mk, string quyen)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO ACCOUNT (TAIKHOAN,MATKHAU,QUYEN) VALUES (@tk,@mk,@quyen)", con))
                {
                    cmd.Parameters.AddWithValue("@tk", tk);
                    cmd.Parameters.AddWithValue("@mk", mk);
                    cmd.Parameters.AddWithValue("@quyen", quyen);
                    
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
                    MessageBox.Show($"Mã '{tk}' đã tồn tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void DeleteGV(string tk)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM ACCOUNT WHERE TAIKHOAN = @tk", con))
            {
                cmd.Parameters.AddWithValue("@tk", tk);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string tk = txtTK.Text;
                string mk = txtMK.Text;
                string quyen = cbbQuyen.Text;
                ThemGVmoi(tk,mk,quyen);

                InitializeDataGridView();

                MessageBox.Show("Đã thêm tài khoản mới thành công! Bạn cần thêm mới thông tin giáo viên");
                QLTTGV f=new QLTTGV();
                f.ShowDialog();
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
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string tk = dataGridView1.SelectedRows[0].Cells["TAIKHOAN"].Value.ToString();

                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        DeleteGV(tk);

                        InitializeDataGridView();

                        MessageBox.Show("Đã xóa tài khoản thành công!");
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


        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string tk = txtTK.Text;
                string mk= txtMK.Text;
                string quyen = cbbQuyen.Text;
               
                UpdateInfoGV(tk, mk, quyen);
                InitializeDataGridView();

                ClearTextBoxes();
            }
        }

        private void ClearTextBoxes()
        {
            txtTK.Text = "";
            txtMK.Text = "";
            cbbQuyen.Text = "";
           
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

        private void ACCOUNT_Load_1(object sender, EventArgs e)
        {
            InitializeDataGridView();
            dataGridView1.SelectionChanged += DataGridView_SelectionChanged;
        }
    }
}
