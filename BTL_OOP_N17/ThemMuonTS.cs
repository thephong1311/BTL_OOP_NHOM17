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
    public partial class ThemMuonTS : Form
    {
        private SqlConnection connection = new SqlConnection(ConnectionString.connectionString);
        public ThemMuonTS()
        {
            InitializeComponent();
        }
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public DataTable findMuonTS()
        {
            SqlDataAdapter find = new SqlDataAdapter("SELECT * from CHITIET_MUON WHERE MAPM="+txtMaMTS.Text, connection);
            DataTable dt_find = new DataTable();
            find.Fill(dt_find);
            return dt_find;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (!string.IsNullOrEmpty(txtMaTS.Text) && !string.IsNullOrEmpty(txtDungtich.Text) && !string.IsNullOrEmpty(txtSoluongMuon.Text) && !string.IsNullOrEmpty(txtTgianMuon.Text) && !string.IsNullOrEmpty(txtSLMuonTT.Text))
                {
                    string sqlInsert_Chitiet = "INSERT INTO CHITIET_MUON(MAPM,MATS,DUNGTICH,SOLUONG_MUON,THOIGIANSD,SOLUONG_MUONTT) VALUES (@mapm,@mats,@dungtich,@slmuon,@tgian,@slmuontt)";
                    using (SqlCommand cmd = new SqlCommand(sqlInsert_Chitiet, connection))
                    {
                        cmd.Parameters.AddWithValue("@mapm", txtMaMTS.Text);
                        cmd.Parameters.AddWithValue("@mats", txtMaTS.Text);
                        cmd.Parameters.AddWithValue("@dungtich", txtDungtich.Text);
                        cmd.Parameters.AddWithValue("@slmuon", txtSoluongMuon.Text);
                        cmd.Parameters.AddWithValue("@tgian", txtTgianMuon.Text);
                        cmd.Parameters.AddWithValue("@slmuontt", txtSLMuonTT.Text);
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        connection.Close();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin thành công!");
                            dataGridView1.DataSource = findMuonTS();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại. Hãy kiếm tra lại thông tin !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Điền thiếu thông tin phần Chi tiết Mượn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        }

        private void btnThemphieu_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (!string.IsNullOrEmpty(txtMaMTS.Text) && !string.IsNullOrEmpty(txtMAGV.Text) && !string.IsNullOrEmpty(txtNguoimuon.Text) && !string.IsNullOrEmpty(txtMaPTN.Text) && !string.IsNullOrEmpty(txtEmail.Text)
                    && !string.IsNullOrEmpty(txtSDT.Text)&&!string.IsNullOrEmpty(cbbTrangthai.Text))
                {
                    string sqlInsert = "INSERT INTO PHIEUMUONTS(MAPM,MAGV,TENNM,DVMUON,EMAIL,SDT,NGAYMUON,TRANGTHAIMUON) VALUES (@mapm,@magv,@tennm,@dvmuon,@email,@sdt,@ngaymuon,@trangthai)";
                    using (SqlCommand cmd = new SqlCommand(sqlInsert, connection))
                    {
                        cmd.Parameters.AddWithValue("@mapm", txtMaMTS.Text);
                        cmd.Parameters.AddWithValue("@magv", txtMAGV.Text);
                        cmd.Parameters.AddWithValue("@tennm", txtNguoimuon.Text);
                        cmd.Parameters.AddWithValue("@dvmuon", txtMaPTN.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                        cmd.Parameters.AddWithValue("@ngaymuon", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@trangthai", cbbTrangthai.Text);
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        connection.Close();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm mới phiếu mượn tài sản thành công!");
                           
                        }
                        else
                        {
                            MessageBox.Show("Thêm mới phiếu mượn tài sản thất bại. Hãy kiếm tra lại thông tin !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hãy nhập đủ thông tin !");
                }
            }
             catch (SqlException ex)
            {
               
                if (ex.Number == 2627)  
                {
                    MessageBox.Show($"Mã '{txtMaMTS.Text}' đã tồn tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCapnhat_phieu_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (!string.IsNullOrEmpty(txtMaMTS.Text) && !string.IsNullOrEmpty(txtMAGV.Text) && !string.IsNullOrEmpty(txtNguoimuon.Text) && !string.IsNullOrEmpty(txtMaPTN.Text) && !string.IsNullOrEmpty(txtEmail.Text)
                    && !string.IsNullOrEmpty(txtSDT.Text) && !string.IsNullOrEmpty(cbbTrangthai.Text))
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE PHIEUMUONTS SET MAPM=@mapm,MAGV=@magv,TENNM=@tennm,DVMUON=@dvmuon,EMAIL=@email,SDT=@sdt,NGAYMUON=@ngaymuon,TRANGTHAIMUON=@trangthai WHERE MAPM = @mapm", connection))
                    {
                        cmd.Parameters.AddWithValue("@mapm", txtMaMTS.Text);
                        cmd.Parameters.AddWithValue("@magv", txtMAGV.Text);
                        cmd.Parameters.AddWithValue("@tennm", txtNguoimuon.Text);
                        cmd.Parameters.AddWithValue("@dvmuon", txtMaPTN.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                        cmd.Parameters.AddWithValue("@ngaymuon", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@trangthai", cbbTrangthai.Text);

                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        connection.Close();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đã cập nhật thông tin phiếu mượn thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không có thông tin nào được cập nhật. Có thể không tồn tại Mã TS tương ứng hoặc Mã TS không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hãy nhập đủ thông tin !");
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
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtMaTS.Text) && !string.IsNullOrEmpty(txtDungtich.Text) && !string.IsNullOrEmpty(txtSoluongMuon.Text) && !string.IsNullOrEmpty(txtTgianMuon.Text) && !string.IsNullOrEmpty(txtSLMuonTT.Text))
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE CHITIET_MUON SET MAPM=@mapm,MATS=@mats,DUNGTICH=@dungtich,SOLUONG_MUON=@slmuon,THOIGIANSD=@tgian,SOLUONG_MUONTT=@slmuontt WHERE MAPM = @mapm", connection))
                    {
                        cmd.Parameters.AddWithValue("@mapm", txtMaMTS.Text);
                        cmd.Parameters.AddWithValue("@mats", txtMaTS.Text);
                        cmd.Parameters.AddWithValue("@dungtich", txtDungtich.Text);
                        cmd.Parameters.AddWithValue("@slmuon", txtSoluongMuon.Text);
                        cmd.Parameters.AddWithValue("@tgian", txtTgianMuon.Text);
                        cmd.Parameters.AddWithValue("@slmuontt", txtSLMuonTT.Text);

                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        connection.Close();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đã cập nhật thông tin chi tiết phiếu mượn thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không có thông tin chi tiết nào được cập nhật. Có thể không tồn tại Mã TS tương ứng hoặc Mã TS không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hãy nhập đủ thông tin !");

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
        }
    }
}
