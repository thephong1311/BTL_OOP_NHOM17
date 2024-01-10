 using BTL_OOP_N17.DAO;
using CrystalDecisions.ReportAppServer.ReportDefModel;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_OOP_N17
{
    public partial class FormLogin : Form
    {
        public static string user;
        public static string UserRole;
        public FormLogin()
        {
            InitializeComponent();
            btnDong.Click += new EventHandler(btnDong_Click);
            btnLuu.Click += new EventHandler(btnLuu_Click);
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
               
                string selectedRole = comboBox1.SelectedItem.ToString();

                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();


                    string query = "SELECT * FROM ACCOUNT WHERE TAIKHOAN = @TAIKHOAN AND MATKHAU = @MATKHAU";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                       
                        command.Parameters.AddWithValue("@TAIKHOAN", txtMaTL.Text);
                        command.Parameters.AddWithValue("@MATKHAU", textBox1.Text);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                               
                                string actualRole = reader["QUYEN"].ToString();

                              
                                if (actualRole == selectedRole)
                                {
                                   
                                    UserRole = actualRole;

                                 
                                    user = reader["TAIKHOAN"].ToString();

                                   
                                    if (UserRole == "Admin")
                                    {
                                        fDevicemanage f = new fDevicemanage();
                                        f.Show();
                                        this.Hide();
                                    }
                                    else if (UserRole == "Nhân viên")
                                    {
                                        GVControl giaoVienForm = new GVControl();
                                        giaoVienForm.Show();
                                        this.Hide();
                                    }
                                    else if(UserRole == "Super admin")
                                    {
                                        SuperAdControl SAForm = new SuperAdControl();
                                        SAForm.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Không có quyền truy cập.");
                                    }
                                }
                                else
                                {
                                   
                                    MessageBox.Show("Quyền không khớp với tài khoản đã đăng ký.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                               
                                MessageBox.Show("Đăng nhập không thành công. Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

    }

}




