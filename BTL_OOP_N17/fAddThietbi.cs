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
        public bool tt=false;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtMaTS.Text) && !string.IsNullOrEmpty(cbbDVT.Text) && !string.IsNullOrEmpty(cbbLoaiTB.Text) &&
                   !string.IsNullOrEmpty(txtTinhtrang.Text) && !string.IsNullOrEmpty(cbbMaPTN.Text) && !string.IsNullOrEmpty(cbbMaNCC.Text))
                {
                    string insert = "INSERT INTO TAISAN(MATS,SOLUONGTS,MADVT,MALOAITS,MATT,TENTS,NUOCSX,NAMSX,THOIGIANBH," +
                    "GIANHAP,NGAYNHAP,THONGSOKYTHUAT,TG_TINHKH,NAMDUAVAO_SD,CHUCNANG,MAPTN,MANCC) VALUES " +
                    "(@mats,@slts,@madvt,@maloaits,@matt,@tents,@nuocsx,@namsx,@tgianbh,@gianhap,@ngaynhap" +
                    ",@tskt,@tg_kh,@namsd,@cn,@maptn,@mancc)";
                using (SqlCommand cmd = new SqlCommand(insert, con))
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
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm thiết bị thành công!");
                            tt = true;
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại. Hãy kiếm tra lại thông tin !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Hãy nhập đủ thông tin!");
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

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtMaTS.Text) && !string.IsNullOrEmpty(cbbDVT.Text) && !string.IsNullOrEmpty(cbbLoaiTB.Text) &&
                    !string.IsNullOrEmpty(txtTinhtrang.Text) && !string.IsNullOrEmpty(cbbMaPTN.Text) && !string.IsNullOrEmpty(cbbMaNCC.Text))
                {
                    using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                    {
                        con.Open();
                        string update = "UPDATE TAISAN SET MATS=@mats,SOLUONGTS=@slts,MADVT=@madvt,MALOAITS=@maloaits,MATT=@matt,TENTS=@tents,NUOCSX=@nuocsx,NAMSX=@namsx,THOIGIANBH=@tgianbh," +
                            "GIANHAP=@gianhap,THONGSOKYTHUAT=@tskt,TG_TINHKH=@tg_kh,NAMDUAVAO_SD=@namsd,CHUCNANG=@cn,MAPTN=@maptn,MANCC=@mancc WHERE MATS=@mats;";
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
                            cmd1.Parameters.AddWithValue("@mancc", cbbMaNCC.Text);
                            cmd1.Parameters.AddWithValue("@maptn", cbbMaPTN.Text);
                            try
                            {
                                int rowsAffected1 = cmd1.ExecuteNonQuery();
                                if (rowsAffected1 > 0)
                                {
                                    MessageBox.Show("Cập nhật thiết bị thành công!");
                                    tt = true;
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
                    }
                }
                else
                {
                    MessageBox.Show("Hãy nhập đủ thông tin!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
