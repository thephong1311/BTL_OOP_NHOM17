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

        private void panel1_Load(object sender, PaintEventArgs e)
        {
            connection.Open();
            string sqlselect = "SELECT * FROM GIAOVIEN WHERE MAGV=@magv";
            using (SqlCommand cmd = new SqlCommand(sqlselect, connection))
            {
                cmd.Parameters.AddWithValue("@magv", txtMAGV.Text);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        txtNguoimuon.Text = reader["TENGV"].ToString();
                        txtSDT.Text = reader["SDTGV"].ToString();
                        txtMaPTN.Text = reader["MAPTN"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin tài khoản giáo viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public DataTable findMuonTS()
        {
            SqlDataAdapter find = new SqlDataAdapter("SELECT * from YEUCAUMUATS WHERE MAPTN = " + txtMaTS.Text, connection);
            DataTable dt_find = new DataTable();
            find.Fill(dt_find);
            return dt_find;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sqlInsert = "INSERT INTO PHIEUMUONTS(MAPM,MAGV,TENNM,DVMUON,EMAIL,SDT,NGAYMUON,TRANGTHAIMUON) VALUES (@mapm,@magv,@tennm,@dvmuon,@email,@sdt,@ngaymuon,@trangthai)";
            using(SqlCommand cmd = new SqlCommand(sqlInsert, connection))
            {
                cmd.Parameters.AddWithValue("@mapm",txtMaMTS.Text);
                cmd.Parameters.AddWithValue("@magv", txtMAGV.Text);
                cmd.Parameters.AddWithValue("@tennm", txtNguoimuon.Text);
                cmd.Parameters.AddWithValue("@dvmuon", txtMaPTN.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                cmd.Parameters.AddWithValue("@ngaymuon", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@trangthai",cbbTrangthai.Text);
            }
            if (!string.IsNullOrEmpty(txtMaTS.Text) && !string.IsNullOrEmpty(txtDungtich.Text) && !string.IsNullOrEmpty(txtSoluongMuon.Text) && !string.IsNullOrEmpty(txtTgianMuon.Text)&& !string.IsNullOrEmpty(txtSLMuonTT.Text))
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
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin giáo viên thành công!");
                        dataGridView1.DataSource = findMuonTS();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại. Hãy kiếm tra lại thông tin !","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Điền thiếu thông tin phần Chi tiết Mượn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
