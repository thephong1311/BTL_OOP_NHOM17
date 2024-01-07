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
    public partial class fAddDanhgialaiTB : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public fAddDanhgialaiTB()
        {
            InitializeComponent();
        }
       

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                {
                    con.Open();
                    string update = "UPDATE CHITIET_DGTS SET MADGLTS=@mats,SOLUONGTS=@slts,MADVT=@madvt,MALOAITS=@maloaits,MATT=@matt,TENTS=@tents,NUOCSX=@nuocsx,NAMSX=@namsx,THOIGIANBH=@tgianbh," +
                        "GIANHAP=@gianhap,THONGSOKYTHUAT=@tskt,TG_TINHKH=@tg_kh,NAMDUAVAO_SD=@namsd,CHUCNANG=@cn,MAPTN=@maptn,MANCC=@mancc WHERE MATS=@mats;";
                    using (SqlCommand cmd1 = new SqlCommand(update, con))
                    {
                        
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

                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi khác (nếu có)
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
