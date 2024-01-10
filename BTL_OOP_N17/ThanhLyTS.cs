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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BTL_OOP_N17
{
    public partial class ThanhLyTB : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public ThanhLyTB()
        {
            InitializeComponent();
            dataGridView1.DataSource = infoTHANHLYTSGridView();
        }





        private void btnDsTs_Click(object sender, EventArgs e)
        {

        }
        public DataTable infoTHANHLYTSGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from THANHLYTS", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        private void InitializeDataGridView()
        {
            dataGridView1.DataSource = infoTHANHLYTSGridView();
        }
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
           
            if (dataGridView1.SelectedRows.Count > 0)
            {
               
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string magv = selectedRow.Cells["MaGV"].Value.ToString();
                string matl = selectedRow.Cells["MATL"].Value.ToString();
                string tentl = selectedRow.Cells["TENTL"].Value.ToString();
                string maptn = selectedRow.Cells["MAPTN"].Value.ToString();
                string ngaytl = selectedRow.Cells["NGAYTL"].Value.ToString();

               
                ShowInfo(magv, matl, tentl, maptn, ngaytl);
            }
        }
        private void ShowInfo(string magv, string matl, string tentl, string maptn, string ngaytl)
        {
           
            txt_TenTL.Text = magv;
            txt_MaTL.Text = matl;
            txt_MaPTN.Text = maptn;
            txt_MaGV.Text = magv;
            DateTime_NgayTL.Value = DateTime.Parse(ngaytl);
           
        }
      
        public DataTable SearchTLTS(string magv, string tentl, string matl, string maptn, string ngaytl)
        {
           
            string query = "SELECT * FROM THANHLYTS WHERE ";
            bool isFirstCondition = true;

            if (!string.IsNullOrEmpty(magv))
            {
                query += $"MAGV LIKE '%{magv}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(tentl))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"TENTL LIKE '%{tentl}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(matl))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"MATL LIKE '%{matl}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(maptn))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"MAPTN LIKE '%{maptn}%'";
            }

            if (!string.IsNullOrEmpty(ngaytl))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"NGAYTL LIKE '%{ngaytl}%'";
            }

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        private void btn_Find_Click(object sender, EventArgs e)
        {

            string magv = txt_MaGV.Text;
            string tentl = txt_TenTL.Text;
            string matl = txt_MaTL.Text;
            string maptn = txt_MaPTN.Text;
            string ngaytl = DateTime_NgayTL.Value.ToString("yyyy-MM-dd");
            dataGridView1.DataSource = SearchTLTS(magv, tentl, matl, maptn, ngaytl);
        }
        public void UpdateInfo(string magv, string tentl, string matl, string maptn, string ngaytl)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE THANHLYTS SET MAGV = @MAGV , TENTL = @TENTL , MAPTN = @MAPTN , NGAYTL = @NGAYTL WHERE MATL = @MATL", con))
                {
                    cmd.Parameters.AddWithValue("@MAPTN", maptn);
                    cmd.Parameters.AddWithValue("@TENTL", tentl);
                    cmd.Parameters.AddWithValue("@MATL", matl);
                    cmd.Parameters.AddWithValue("@MAGV", magv);
                    cmd.Parameters.AddWithValue("@NGAYTL", ngaytl);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã cập nhật thông tin th thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không có thông tin thanh lý được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (SqlException ex)
            {
               
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ThemTLmoi(string magv, string tentl, string matl, string maptn, string ngaytl)
        {
          
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO THANHLYTS (MAGV, TENTL, MATL, NGAYTL, MAPTN) VALUES (@magv, @tentl, @matl, @ngaytl, @maptn)", con))
                {
                    cmd.Parameters.AddWithValue("@magv", magv);
                    cmd.Parameters.AddWithValue("@tentl", tentl);
                    cmd.Parameters.AddWithValue("@matl", matl);
                    cmd.Parameters.AddWithValue("@ngaytl", ngaytl);
                    cmd.Parameters.AddWithValue("@maptn", maptn);

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
                    MessageBox.Show($"Mã '{matl}' đã tồn tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void DeleteTL(string matl)
        {
          
            using (SqlCommand cmd = new SqlCommand("DELETE FROM THANHLYTS WHERE MATL = @matl", con))
            {
                cmd.Parameters.AddWithValue("@matl", matl);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string magv = txt_MaGV.Text;
                string matl = txt_MaTL.Text;
                string tentl = txt_TenTL.Text;
                string maptn = txt_MaPTN.Text;
                string ngaytl = DateTime_NgayTL.Value.ToString("yyyy-MM-dd");


               
                ThemTLmoi(magv, tentl, matl, maptn, ngaytl);

               
                InitializeDataGridView();

                MessageBox.Show("Đã thêm thông tin thanh lý mới thành công!");
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
                   
                    string matl = dataGridView1.SelectedRows[0].Cells["MATL"].Value.ToString();

                   
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thanh lý này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                   
                    if (result == DialogResult.Yes)
                    {
                       
                        DeleteTL(matl);

                       
                        InitializeDataGridView();

                        MessageBox.Show("Đã xóa thanh lý thành công!");
                    }
                   
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một thanh lý để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
               
                string selectedMatl = dataGridView1.SelectedRows[0].Cells["MATL"].Value.ToString();

              
                if (txt_MaTL.Text != selectedMatl)
                {
                    MessageBox.Show("Không được sửa giá trị MATL.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        
            if (result == DialogResult.Yes)
            {
               
                string magv = txt_MaGV.Text;
                string matl = txt_MaTL.Text;
                string tentl = txt_TenTL.Text;
                string maptn = txt_MaPTN.Text;
                string ngaytl = DateTime_NgayTL.Value.ToString("yyyy-MM-dd");

               
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["MAGV"].Value = magv;
               
                selectedRow.Cells["TENTL"].Value = tentl;
                selectedRow.Cells["MAPTN"].Value = maptn;
                selectedRow.Cells["NGAYTL"].Value = ngaytl;

              
                ShowInfo(magv, matl, tentl, maptn, ngaytl);
                UpdateInfo(magv, tentl, matl, maptn, ngaytl);
               
                ClearTextBoxes();
            }


        }

        private void ClearTextBoxes()
        {

            txt_MaGV.Text = "";
            txt_TenTL.Text = "";
            txt_MaTL.Text = "";
            txt_MaPTN.Text = "";
            DateTime_NgayTL.Format = DateTimePickerFormat.Custom; ;
        }


        private void btnLoad_Click_1(object sender, EventArgs e)
        {
           
            InitializeDataGridView();
            ClearTextBoxes();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThanhLyTB_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            dataGridView1.SelectionChanged += DataGridView_SelectionChanged;
        }
    }
}
