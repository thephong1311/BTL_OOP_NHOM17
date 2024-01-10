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
           
            InitializeDataGridView();
            dataGridView1.SelectionChanged += DataGridView_SelectionChanged;
        }
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
           
            if (dataGridView1.SelectedRows.Count > 0)
            {
               
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string maptn = selectedRow.Cells["MAPTN"].Value.ToString();
                string userptn = selectedRow.Cells["TENPTN"].Value.ToString();
                string vitri = selectedRow.Cells["VITRI"].Value.ToString();
               
                DisplayPTNInfo(maptn, userptn, vitri);
            }
        }
        private void DisplayPTNInfo(string maptn, string userptn, string vitri)
        {
           
            txtMaPTN.Text = maptn;
            txtTenPTN.Text = userptn;
            txtVitri.Text = vitri;
           
        }
        public DataTable SearchQLTTPTN(string maptn, string userptn, string vitri)
        {
            
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
               
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ThemPTNmoi(string maptn, string userptn, string vitri)
        {
           
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
               
                if (ex.Number == 2627)  
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
        public void DeletePTN(string maptn)
        {
         
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

                
                ThemPTNmoi(maptn, userptn, vitri);
               
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
                
                if (dataGridView1.SelectedRows.Count > 0)
                {
                   
                    string maptn = dataGridView1.SelectedRows[0].Cells["MAPTN"].Value.ToString();

                   
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng thí nghiệm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                   
                    if (result == DialogResult.Yes)
                    {
                        
                        DeletePTN(maptn);

                       
                        InitializeDataGridView();

                        MessageBox.Show("Đã xóa phòng thí nghiệm thành công!");
                    }
                   
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
                
                string selectedMaPTN = dataGridView1.SelectedRows[0].Cells["MAPTN"].Value.ToString();

              
                if (txtMaPTN.Text != selectedMaPTN)
                {
                    MessageBox.Show("Không được sửa giá trị MAPTN.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
            }
           
            DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

          
            if (result == DialogResult.Yes)
            {
               
                string maptn = txtMaPTN.Text;
                string userptn = txtTenPTN.Text;
                string vitri = txtVitri.Text;


               
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["MAPTN"].Value = maptn;
                selectedRow.Cells["TENPTN"].Value = userptn;
                selectedRow.Cells["VITRI"].Value = vitri;

               
                DisplayPTNInfo(maptn, userptn, vitri);
                UpdateInfoPTN(maptn, userptn, vitri);

              
                ClearTextBoxes();
            }
        }
        private void ClearTextBoxes()
        {
           
            txtMaPTN.Text = "";
            txtTenPTN.Text = "";
            txtVitri.Text = "";
           
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
            InitializeDataGridView();
           
            ClearTextBoxes();
        }

    }
}
