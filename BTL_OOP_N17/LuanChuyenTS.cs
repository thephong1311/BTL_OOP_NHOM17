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
           
            if (dataGridView1.SelectedRows.Count > 0)
            {
               
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string magv = selectedRow.Cells["MAGV"].Value.ToString();
                string malc = selectedRow.Cells["MAPHIEULC"].Value.ToString();
                string lcdi = selectedRow.Cells["NOILCDI"].Value.ToString();
                string lcden = selectedRow.Cells["NOILCDEN"].Value.ToString();
                string lydo = selectedRow.Cells["LYDOLC"].Value.ToString();
                string ngaylc = selectedRow.Cells["NGAYLC"].Value.ToString();

               
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
           
        }
    
    public void UpdateInfo(string magv, string malc, string lcdi, string lcden, string lydo, string ngaylc)
    {
        try
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE PHIEULCTS SET MAGV = @MAGV , NOILCDI = @NOILCDI , NOILCDEN = @NOILCDEN, NGAYLC = @NGAYLC, LYDOLC = @LYDOLC WHERE MAPHIEULC = @MAPHIEULC", con))
            {
                cmd.Parameters.AddWithValue("@MAGV", magv);
                cmd.Parameters.AddWithValue("@MAPHIEULC", malc);
                cmd.Parameters.AddWithValue("@NOILCDI", lcdi);
                cmd.Parameters.AddWithValue("@NOILCDEN", lcden);
                cmd.Parameters.AddWithValue("@NGAYLC", ngaylc);
                cmd.Parameters.AddWithValue("@LYDOLC", lydo);

                    con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Đã cập nhật thông tin thành công!");
                }
                else
                {
                    MessageBox.Show("Không có thông tin luân chuyển được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
        catch (SqlException ex)
        {
           
            MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


    public DataTable SearchLCTS(string malc, string lcdi, string lcden, string magv, string lydo, string ngaylc)
        {
           
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
                query += $"LYDOLC LIKE '%{lydo}%'";
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
                
                if (ex.Number == 2627) 
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
        public void DeleteLC(string malc)
        {
           
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
               
                if (dataGridView1.SelectedRows.Count > 0)
                {

                    string malc = dataGridView1.SelectedRows[0].Cells["MAPHIEULC"].Value.ToString();

                   
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa luân chuyển này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                   
                    if (result == DialogResult.Yes)
                    {
                       
                        DeleteLC(malc);

                       
                        InitializeDataGridView();

                        MessageBox.Show("Đã xóa thông tin luân chuyển thành công!");
                    }
                    
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
               
                string selectedMaPhieuLC = dataGridView1.SelectedRows[0].Cells["MAPHIEULC"].Value.ToString();

               
                if (txtMP.Text != selectedMaPhieuLC)
                {
                    MessageBox.Show("Không được sửa giá trị MAPHIEULC.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

           
            if (result == DialogResult.Yes)
            {
                
                string magv = txtMaGV.Text;
                string malc = txtMP.Text;
                string lcdi = txtLCdi.Text;
                string lcden = txtLCden.Text;
                string lydo = txtLydo.Text;
                string ngaylc = dt_NgayLC.Value.ToString("yyyy-MM-dd");

                
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["MAGV"].Value = magv;
                selectedRow.Cells["NOILCDI"].Value = lcdi;
                selectedRow.Cells["NOILCDEN"].Value = lcden;
                selectedRow.Cells["NGAYLC"].Value = ngaylc;
                selectedRow.Cells["LYDOLC"].Value = lydo;

               
                ShowInfo(magv, malc, lcdi, lcden, ngaylc, lydo);
                UpdateInfo(magv, malc, lcdi, lcden, lydo, ngaylc);
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
            
            InitializeDataGridView();
            
            ClearTextBoxes();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
   

