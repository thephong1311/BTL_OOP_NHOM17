using BTL_OOP_N17.DAO;
using CrystalDecisions.ReportAppServer.DataDefModel;
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
    public partial class DoiMK: Form
    {
        public DoiMK()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }
        public string user {  get; set; }
        private void DoiMK_Load(object sender, EventArgs e)
        {
            txtAccount.Text = user;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mật khẩu hiện tại từ cơ sở dữ liệu dựa trên tên tài khoản
                string sqlSelect = $"SELECT MATKHAU FROM ACCOUNT WHERE TAIKHOAN = '{txtAccount.Text}'";

                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlSelect, connection))
                    {
                        // Thực hiện truy vấn để lấy mật khẩu hiện tại
                        object result = command.ExecuteScalar();

                        if (result != null) // Kiểm tra xem tài khoản có tồn tại hay không
                        {
                            string currentPassword = result.ToString();

                            // So sánh mật khẩu hiện tại với mật khẩu cũ được nhập
                            if (currentPassword == txtOldPass.Text)
                            {
                                // Chuẩn bị câu lệnh SQL UPDATE
                                string sqlUpdate = $"UPDATE ACCOUNT SET MATKHAU = '{txtNewPass.Text}' WHERE TAIKHOAN = '{txtAccount.Text}'";

                                // Thực thi câu lệnh SQL
                                using (SqlCommand updateCommand = new SqlCommand(sqlUpdate, connection))
                                {
                                    int rowsAffected = updateCommand.ExecuteNonQuery();// trả về số dòng bị ảnh hưởng khi thực hiện update

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Không tìm thấy tài khoản để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Mật khẩu cũ không đúng. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản không tồn tại. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu cần
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close (); ;
        }
    }
}
