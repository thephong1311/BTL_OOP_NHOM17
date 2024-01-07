using BTL_OOP_N17.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_OOP_N17
{
    public partial class fAddThietbi : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public fAddThietbi()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        public void UpdateTT(string s)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                string select = "SELECT * FROM TAISAN WHERE MATS=@mats";
                string update = "UPDATE TAISAN SET MATS=@mats,SOLUONGTS=@slts,MADVT=@madvt,MALOAITS=@maloaits,MATT=@matt,TENTS=@tents,NUOCSX=@nuocsx,NAMSX=@namsx,THOIGIANBH=@tgianbh," +
                    "GIANHAP=@gianhap,THONGSOKYTHUAT=@tskt,TG_TINHKH=@tg_kh,NAMDUAVAO_SD=@namsd,CHUCNANG=@cn,MAPTN=@maptn,MANCC=@mancc WHERE MATS=@mats;";
                using (SqlCommand cmd = new SqlCommand(select, con))
                {
                    cmd.Parameters.AddWithValue("@mats", s);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtMaTS.Text = reader["MATS"].ToString();
                            txtTenTS.Text = reader["TENTS"].ToString();
                            cbbLoaiTB.Text = reader["MALOAITS"].ToString();
                            txtTinhtrang.Text = reader["MATT"].ToString();
                            txtSL.Text = reader["SOLUONGTS"].ToString();
                            txtGiaNhap.Text = reader["GIANHAP"].ToString();
                            txtTgian.Text = reader["TG_TINHKH"].ToString();
                            cbbDVT.Text = reader["MADVT"].ToString();
                            txtNamSD.Text = reader["NAMDUAVAO_SD"].ToString();
                            txtNoiSX.Text = reader["NUOCSX"].ToString();
                            txtNamSX.Text = reader["NAMSX"].ToString();
                            txtTgianBH.Text = reader["THOIGIANBH"].ToString();
                            string ngay = reader["NGAYNHAP"].ToString();
                            if (!string.IsNullOrEmpty(ngay))
                            {
                                // Sử dụng phương thức TryParseExact để tránh lỗi FormatException
                                if (DateTime.TryParseExact(ngay, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result))
                                {
                                    // Nếu chuyển đổi thành công, sử dụng giá trị result
                                    dateTimePicker1.Value = result;
                                }
                            }
                            else
                            {
                                dateTimePicker1.Value = DateTime.Now;
                            }
                            txtTSKT.Text = reader["THONGSOKYTHUAT"].ToString();
                            txtChucnang.Text = reader["CHUCNANG"].ToString();
                            cbbMaPTN.Text = reader["MAPTN"].ToString();
                            cbbMaNCC.Text = reader["MANCC"].ToString();
                            reader.Close();
                            //Mở ra form có sẵn thông tin để chỉnh sửa 
                            fAddThietbi f = new fAddThietbi();
                            f.UpdateTT(txtMaTS.Text);
                            f.Shown += (shownSender, shownArgs) => f.ShowDialog();
                        }
                    }
                }
                using (SqlCommand cmd1 = new SqlCommand(update, con))
                {
                    cmd1.Parameters.AddWithValue("@mats", txtMaTS.Text);
                    cmd1.Parameters.AddWithValue("@slts", txtSL.Text);
                    cmd1.Parameters.AddWithValue("@madvt", cbbDVT.Text);
                    cmd1.Parameters.AddWithValue("@maloaits", cbbLoaiTB.Text);
                    cmd1.Parameters.AddWithValue("@matt", txtTinhtrang.Text);
                    cmd1.Parameters.AddWithValue("@tents", txtTenTS.Text);
                    cmd1.Parameters.AddWithValue("@nuocsx", txtNoiSX.Text);
                    cmd1.Parameters.AddWithValue("@namsx", txtNamSX.Text);
                    cmd1.Parameters.AddWithValue("@tgianbh", txtTgianBH.Text);
                    cmd1.Parameters.AddWithValue("@gianhap", txtGiaNhap.Text);
                    cmd1.Parameters.AddWithValue("@ngaynhap", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    cmd1.Parameters.AddWithValue("@tskt", txtTSKT.Text);
                    cmd1.Parameters.AddWithValue("@tg_kh", txtTgian.Text);
                    cmd1.Parameters.AddWithValue("@namsd", txtNamSD.Text);
                    cmd1.Parameters.AddWithValue("@cn", txtChucnang.Text);
                    cmd1.Parameters.AddWithValue("@maptn", cbbMaPTN.Text);
                    try
                    {
                        int rowsAffected1 = cmd1.ExecuteNonQuery();
                        if (rowsAffected1 > 0)
                        {
                            MessageBox.Show("Cập nhật thiết bị thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại. Hãy kiểm tra lại thông tin !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                con.Close();
                SqlConnection.ClearAllPools();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string insert = "INSERT INTO TAISAN(MATS,SOLUONGTS,MADVT,MALOAITS,MATT,TENTS,NUOCSX,NAMSX,THOIGIANBH," +
                    "GIANHAP,THONGSOKYTHUAT,TG_TINHKH,NAMDUAVAO_SD,CHUCNANG,MAPTN,MANCC) VALUES " +
                    "(@mats,@slts,@madvt,@maloaits,@matt,@tents,@nuocsx,@namsx,@tgianbh,@gianhap,@ngaynhap" +
                    ",@tskt,@tg_kh,@namsd,@cn,@maptn,@mancc)";
                using (SqlCommand cmd = new SqlCommand(insert, con))
                {
                    if (!string.IsNullOrEmpty(txtMaTS.Text) && !string.IsNullOrEmpty(cbbDVT.Text) && !string.IsNullOrEmpty(cbbLoaiTB.Text) &&
                    !string.IsNullOrEmpty(txtTinhtrang.Text) && !string.IsNullOrEmpty(cbbMaPTN.Text) && !string.IsNullOrEmpty(cbbMaNCC.Text))
                    {
                        cmd.Parameters.AddWithValue("@mats", txtMaTS.Text);
                        cmd.Parameters.AddWithValue("@slts", txtSL.Text);
                        cmd.Parameters.AddWithValue("@madvt", cbbDVT.Text);
                        cmd.Parameters.AddWithValue("@maloaits", cbbLoaiTB.Text);
                        cmd.Parameters.AddWithValue("@matt", txtTinhtrang.Text);
                        cmd.Parameters.AddWithValue("@tents", txtTenTS.Text);
                        cmd.Parameters.AddWithValue("@nuocsx", txtNoiSX.Text);
                        cmd.Parameters.AddWithValue("@namsx", txtNamSX.Text);
                        cmd.Parameters.AddWithValue("@tgianbh", txtTgianBH.Text);
                        cmd.Parameters.AddWithValue("@gianhap", txtGiaNhap.Text);
                        cmd.Parameters.AddWithValue("@ngaynhap", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@tskt", txtTSKT.Text);
                        cmd.Parameters.AddWithValue("@tg_kh", txtTgian.Text);
                        cmd.Parameters.AddWithValue("@namsd", txtNamSD.Text);
                        cmd.Parameters.AddWithValue("@cn", txtChucnang.Text);
                        cmd.Parameters.AddWithValue("@maptn", cbbMaPTN.Text);
                        cmd.Parameters.AddWithValue("@mancc", cbbMaNCC.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm thiết bị thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại. Hãy kiếm tra lại thông tin !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
