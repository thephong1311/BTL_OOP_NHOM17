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

  

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaTL.Text) || string.IsNullOrEmpty(txt_TenTL.Text) || string.IsNullOrEmpty(DateTime_NgayTL.Text) || string.IsNullOrEmpty(txt_MaGV.Text) || string.IsNullOrEmpty(txt_MaPTN.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }

            try
            {
               
                con.Open();

                
                string insertQuery = "INSERT INTO THANHLYTS (MATL, TENTHANHLY, NGAYTL, MAGV, MAPTN) VALUES (@MATL, @TENTHANHLY, @NGAYTL, @MAGV, @MAPTN)";

              
                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
               
                    cmd.Parameters.AddWithValue("@MATL", txt_MaTL.Text);
                    cmd.Parameters.AddWithValue("@TENTHANHLY", txt_TenTL.Text);
                    cmd.Parameters.AddWithValue("@NGAYTL",DateTime_NgayTL.Value); 
                    cmd.Parameters.AddWithValue("@MAGV", txt_MaGV.Text);
                    cmd.Parameters.AddWithValue("@MAPTN", txt_MaPTN.Text);

                
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm thông tin thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {

                con.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
                
                if (string.IsNullOrEmpty(txt_MaTL.Text) || string.IsNullOrEmpty(txt_TenTL.Text) || string.IsNullOrEmpty(DateTime_NgayTL.Text) || string.IsNullOrEmpty(txt_MaGV.Text) || string.IsNullOrEmpty(txt_MaPTN.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin để sửa");
                    return;
                }

                try
                {
                  
                    con.Open();

             
                    string updateQuery = "UPDATE THANHLYTS SET TENTHANHLY = @TENTHANHLY, NGAYTL = @NGAYTL, MAGV = @MAGV, MAPTN = @MAPTN WHERE MATL = @MATL";

                 
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                      
                        cmd.Parameters.AddWithValue("@MATL", txt_MaTL.Text);
                        cmd.Parameters.AddWithValue("@TENTHANHLY", txt_TenTL.Text);
                        cmd.Parameters.AddWithValue("@NGAYTL", DateTime_NgayTL.Value);
                        cmd.Parameters.AddWithValue("@MAGV", txt_MaGV.Text);
                        cmd.Parameters.AddWithValue("@MAPTN", txt_MaPTN.Text);

                      
                        int rowsAffected = cmd.ExecuteNonQuery();

                     
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thông tin thất bại. Hãy kiểm tra lại thông tin!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {
                  
                    con.Close();
                }
            

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txt_MaTL.Text) || string.IsNullOrEmpty(txt_TenTL.Text) || string.IsNullOrEmpty(DateTime_NgayTL.Text) || string.IsNullOrEmpty(txt_MaGV.Text) || string.IsNullOrEmpty(txt_MaPTN.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin để xóa");
                return;
            }

            try
            {
                con.Open();

               
                string deleteQuery = "DELETE FROM THANHLYTS WHERE MATL = @MATL AND TENTHANHLY = @TENTHANHLY AND NGAYTL = @NGAYTL AND MAGV = @MAGV AND MAPTN = @MAPTN";

                using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                {
                 
                    cmd.Parameters.AddWithValue("@MATL", txt_MaTL.Text);
                    cmd.Parameters.AddWithValue("@TENTHANHLY", txt_TenTL.Text);
                    cmd.Parameters.AddWithValue("@NGAYTL", DateTime_NgayTL.Value); 
                    cmd.Parameters.AddWithValue("@MAGV", txt_MaGV.Text);
                    cmd.Parameters.AddWithValue("@MAPTN", txt_MaPTN.Text);

                    
                    int rowsAffected = cmd.ExecuteNonQuery();

                        // Làm mới dữ liệu trong DataGridView sau khi xóa
                        InitializeDataGridView();
                    
                        MessageBox.Show("Đã xóa thanh lý thành công!");
                    }
                    // Nếu người dùng chọn No, không thực hiện xóa
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
            // Hiển thị hộp thoại xác nhận sửa
            DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             
            // Kiểm tra xem người dùng đã đồng ý sửa hay không
            if (result == DialogResult.Yes)
            {
                // Lấy dữ liệu từ TextBox

                string magv = txt_MaGV.Text;
                string matl = txt_MaTL.Text;
                string tentl = txt_TenTL.Text;
                string maptn = txt_MaPTN.Text;
                string ngaytl = DateTime_NgayTL.Value.ToString("yyyy-MM-dd");
    
                // Cập nhật dữ liệu trong DataGridView
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["MAGV"].Value = magv;
                selectedRow.Cells["TENTL"].Value = tentl;
                selectedRow.Cells["MAPTN"].Value = maptn;
                selectedRow.Cells["NGAYTL"].Value = ngaytl;
                selectedRow.Cells["MATL"].Value = matl;


                // Hiển thị thông tin trong GroupBox (nếu cần)
                ShowInfo(magv, matl, tentl, maptn, ngaytl);

                // Đặt lại TextBox sau khi cập nhật
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Gọi lại hàm InitializeDataGridView để tải lại dữ liệu ban đầu
            InitializeDataGridView();
            // Xóa nội dung trong các ô TextBox
            ClearTextBoxes();
        }
    }
}
