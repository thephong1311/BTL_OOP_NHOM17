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
    public partial class YCmua : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public YCmua()
        {
            InitializeComponent();
            xemCacYCMua1.Visible = false;
            gpbThongtinchitiet.Visible = true ;
            dgvThongtinchitiet.DataSource = chitietYCMuaGridView();
        }
        public DataTable chitietYCMuaGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from CHITIET_YCTS", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        
        private void YCmua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTS2DataSet1.PHONGTHINGHIEM' table. You can move, or remove it, as needed.
           

        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            xemCacYCMua1.Visible = false;
            gpbThongtinchitiet.Visible = true;
            dgvThongtinchitiet.DataSource = chitietYCMuaGridView();

            txtMaYC.Text = "";
            txtMaGV.Text = "";
            cbbPTN.Text = "";
            txtMota.Text = "";
            txtTrangthai.Text = "";

        }
     
        private void btnXemlai_Click(object sender, EventArgs e)
        {
            xemCacYCMua1.ResetText();
            xemCacYCMua1.Visible = true;
            gpbThongtinchitiet.Visible = false;
           
        }
       public bool tt=false;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaYC.Text) && !string.IsNullOrEmpty(txtMaGV.Text) && !string.IsNullOrEmpty(cbbPTN.Text) && !string.IsNullOrEmpty(txtMota.Text)
                && !string.IsNullOrEmpty(txtTrangthai.Text))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO YEUCAUMUATS (MAYC,MAGV,MAPTN,NGAYLAPYC,NOIDUNGYC,TRANGTHAIYC) VALUES (@mayc,@magv,@maptn,@ngaylapyc,@ndyc,@ttyc)", con))
                    {
                        cmd.Parameters.AddWithValue("@mayc", txtMaYC.Text);
                        cmd.Parameters.AddWithValue("@magv", txtMaGV.Text);
                        cmd.Parameters.AddWithValue("@maptn", cbbPTN.Text);
                        cmd.Parameters.AddWithValue("@ngaylapyc", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@ndyc",txtMota.Text);
                        cmd.Parameters.AddWithValue("@ttyc", txtTrangthai.Text);
                        
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin thành công! Hãy thêm thông tin chi tiết");
                            tt = true;
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại. Hãy kiếm tra lại thông tin !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Hãy nhập đủ thông tin !","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tt==true)
            {
                fAddYCmua f = new fAddYCmua();
                f.ShowDialog();
                if (f.trangthai)
                {
                    dgvThongtinchitiet.DataSource = chitietYCMuaGridView();
                }
            }
            else
            {
                MessageBox.Show("Hãy tạo phiếu yêu cầu trước khi thêm thông tin chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
