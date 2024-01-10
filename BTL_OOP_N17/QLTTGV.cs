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
          
            if (dataGridView1.SelectedRows.Count > 0)
            {
           
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string magv = selectedRow.Cells["MaGV"].Value.ToString();
                string username = selectedRow.Cells["TENGV"].Value.ToString();
                string diachi = selectedRow.Cells["DIACHIGV"].Value.ToString();
                string sdt = selectedRow.Cells["SDTGV"].Value.ToString();
                string chucvu = selectedRow.Cells["CHUCVUGV"].Value.ToString();
                string mptn = selectedRow.Cells["MAPTN"].Value.ToString();

           
                DisplayStudentInfo(magv, username, diachi, sdt, chucvu, mptn);
            }
        }

        private void DisplayStudentInfo(string magv, string username, string diachi, string sdt, string chucvu, string mptn)
        {
           
            txtMaGV.Text = magv;
            txtTenGV.Text = username;
            txtDiaChi.Text = diachi;
            txtSDTGV.Text = sdt;
            txtChucvu.Text = chucvu;
            txtMPTN.Text = mptn;
          
        }
        public DataTable SearchQLTTGV(string magv, string username, string diachi, string sdt, string chucvu)
        {
          
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
               
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ThemGVmoi(string magv, string username, string diachi, string sdt, string chucvu, string mptn)
        {
         
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
             
                if (ex.Number == 2627)  
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
        public void DeleteGV(string magv)
        {
           
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

                
                ThemGVmoi(magv, username, diachi, sdt, chucvu, mptn);

                
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
            
                if (dataGridView1.SelectedRows.Count > 0)
                {
                  
                    string magv = dataGridView1.SelectedRows[0].Cells["MaGV"].Value.ToString();

                   
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa giáo viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    
                    if (result == DialogResult.Yes)
                    {
                     
                        DeleteGV(magv);

                       
                        InitializeDataGridView();

                        MessageBox.Show("Đã xóa giáo viên thành công!");
                    }
                   
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
               
                string selectedMaGV = dataGridView1.SelectedRows[0].Cells["MAGV"].Value.ToString();

               
                if (txtMaGV.Text != selectedMaGV)
                {
                    MessageBox.Show("Không được sửa giá trị MAGV.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
            }
           
            DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

           
            if (result == DialogResult.Yes)
            {
           
                string magv = txtMaGV.Text;
                string username = txtTenGV.Text;
                string diachi = txtDiaChi.Text;
                string sdt = txtSDTGV.Text;
                string chucvu = txtChucvu.Text;
                string mptn = txtMPTN.Text;

               
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["MaGV"].Value = magv;
                selectedRow.Cells["TENGV"].Value = username;
                selectedRow.Cells["DIACHIGV"].Value = diachi;
                selectedRow.Cells["SDTGV"].Value = sdt;
                selectedRow.Cells["CHUCVUGV"].Value = chucvu;
                selectedRow.Cells["MAPTN"].Value = mptn;

               
                DisplayStudentInfo(magv, username, diachi, sdt, chucvu, mptn);
                UpdateInfoGV(magv, username, diachi, sdt, chucvu, mptn);

                ClearTextBoxes();
            }
        }

        private void ClearTextBoxes()
        {
          
            txtMaGV.Text = "";
            txtTenGV.Text = "";
            txtDiaChi.Text = "";
            txtSDTGV.Text = "";
            txtChucvu.Text = "";
            txtMPTN.Text = "";
           
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
    }
}