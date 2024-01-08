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
    public partial class fAddYCmua : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public bool trangthai = false;
        public fAddYCmua()
        {
            InitializeComponent();
        }
        private void fAddYCmua_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!trangthai)
            {
                DialogResult result = MessageBox.Show("Thông tin chi tiết của phiếu yêu cầu mua của bạn chưa được cập nhập. Bạn có chắc muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Chặn việc đóng form nếu người dùng chọn No
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (trangthai)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Thông tin chi tiết của phiếu yêu cầu mua của bạn chưa được cập nhập. Hãy lưu thông tin trước khi thoát!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtMaYC.Text) && !string.IsNullOrEmpty(txtNCC.Text) && !string.IsNullOrEmpty(txtTenTS.Text) && !string.IsNullOrEmpty(txtMota.Text)
                && !string.IsNullOrEmpty(cbbMaTS.Text)&&!string.IsNullOrEmpty(txtSL.Text)
                && !string.IsNullOrEmpty(txtDongia.Text) && !string.IsNullOrEmpty(cbbDVT.Text))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO CHITIET_YCTS (MAYC,MANCC,TENTSYC,MOTATS,MALOAITS,SOLUONGYC,DONGIAYC,MADVT) VALUES (@mayc,@ncc,@tents,@mota,@lts,@slyc,@dongia,@dvt)", con))
                    {
                        cmd.Parameters.AddWithValue("@mayc", txtMaYC.Text);
                        cmd.Parameters.AddWithValue("@ncc", txtNCC.Text);
                        cmd.Parameters.AddWithValue("@tents", txtTenTS.Text);
                        cmd.Parameters.AddWithValue("@mota",txtMota.Text);
                        cmd.Parameters.AddWithValue("@lts", cbbMaTS.Text);
                        cmd.Parameters.AddWithValue("@slyc", txtSL.Text);
                        cmd.Parameters.AddWithValue("@dongia", txtDongia.Text);
                        cmd.Parameters.AddWithValue("@dvt", cbbDVT.Text);


                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin chi tiết yêu cầu mua thành công!");
                            trangthai = true;
                           
                        }
                        con.Close();
                    }
                }
                catch (SqlException ex)
                {
                    // Xử lý lỗi SQL
                    if (ex.Number == 2627)  // 2627 là mã lỗi cho việc vi phạm ràng buộc duy nhất (unique constraint)
                    {
                        MessageBox.Show($"Mã '{txtMaYC.Text}' đã tồn tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi khác (nếu có)
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
