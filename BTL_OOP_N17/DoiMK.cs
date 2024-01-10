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
                string sqlSelect = $"SELECT MATKHAU FROM ACCOUNT WHERE TAIKHOAN = '{txtAccount.Text}'";

                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlSelect, connection))
                    {
                        object result = command.ExecuteScalar();

                        if (result != null) 
                        {
                            string currentPassword = result.ToString();
                            if (currentPassword == txtOldPass.Text)
                            {
                                string sqlUpdate = $"UPDATE ACCOUNT SET MATKHAU = '{txtNewPass.Text}' WHERE TAIKHOAN = '{txtAccount.Text}'";

                                using (SqlCommand updateCommand = new SqlCommand(sqlUpdate, connection))
                                {
                                    int rowsAffected = updateCommand.ExecuteNonQuery();

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
              
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close (); ;
        }
    }
}
