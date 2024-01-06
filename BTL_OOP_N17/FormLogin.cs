 using BTL_OOP_N17.DAO;
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
        /* private void btnLuu_Click(object sender, EventArgs e)
             {
                 try
                 {
                     using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                     {
                         connection.Open();

                         // Sử dụng tham số trong truy vấn SQL để tránh SQL Injection
                         string query = "SELECT * FROM ACCOUNT WHERE TAIKHOAN = @TAIKHOAN AND MATKHAU = @MATKHAU";

                         using (SqlCommand command = new SqlCommand(query, connection))
                         {
                             // Sét các giá trị tham số
                             command.Parameters.AddWithValue("@TAIKHOAN", txtMaTL.Text);
                             command.Parameters.AddWithValue("@MATKHAU", textBox1.Text);

                             using (SqlDataReader reader = command.ExecuteReader())
                             {
                             user = reader["TAIKHOAN"].ToString();   
                             if (reader.Read())
                                 {
                                     // Lấy quyền và lưu vào biến tĩnh
                                     UserRole = reader["QUYEN"].ToString();

                                     // Kiểm tra quyền và mở form tương ứng
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
                                     else
                                     {
                                         // Hiển thị thông báo nếu có quyền khác mà bạn chưa xử lý
                                         MessageBox.Show("Không có quyền truy cập.");
                                     }
                                 }
                                 else
                                 {
                                     // Hiển thị thông báo đăng nhập không thành công
                                     MessageBox.Show("Đăng nhập không thành công. Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                 }
                             }
                         }
                     }
                 }
                 catch (Exception ex)
                 {
                     // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                     MessageBox.Show("Lỗi: " + ex.Message);
                 }
             }*/
        /* private void btnLuu_Click(object sender, EventArgs e)
         {
             try
             {
                 string selectedRole = comboBox1.SelectedItem.ToString();

                 using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                 {
                     connection.Open();

                     // Sử dụng tham số trong truy vấn SQL để tránh SQL Injection
                     string query = "SELECT * FROM ACCOUNT WHERE TAIKHOAN = @TAIKHOAN AND MATKHAU = @MATKHAU";

                     using (SqlCommand command = new SqlCommand(query, connection))
                     {
                         // Sét các giá trị tham số
                         command.Parameters.AddWithValue("@TAIKHOAN", txtMaTL.Text);
                         command.Parameters.AddWithValue("@MATKHAU", textBox1.Text);
                         command.Parameters.AddWithValue("@QUYEN", selectedRole);

                         using (SqlDataReader reader = command.ExecuteReader())
                         {
                            // user = reader["TAIKHOAN"].ToString();

                             if (reader.Read())
                             {
                                 // Lấy quyền và lưu vào biến tĩnh
                                 UserRole = reader["QUYEN"].ToString();

                                 // Lấy tài khoản và lưu vào biến tĩnh
                                user = reader["TAIKHOAN"].ToString();

                                 // Kiểm tra quyền và mở form tương ứng
                                 if (UserRole.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                                 {
                                     fDevicemanage f = new fDevicemanage();
                                     f.Show();
                                     this.Hide();
                                 }
                                 else if (UserRole.Equals("Nhân viên", StringComparison.OrdinalIgnoreCase))
                                 {
                                     GVControl giaoVienForm = new GVControl();
                                     giaoVienForm.Show();
                                     this.Hide();
                                 }
                                 else
                                 {
                                     // Hiển thị thông báo nếu có quyền khác mà bạn chưa xử lý
                                     MessageBox.Show("Không có quyền truy cập.");
                                 }
                             }
                             else
                             {
                                 // Hiển thị thông báo đăng nhập không thành công
                                 MessageBox.Show("Đăng nhập không thành công. Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             }
                         }
                     }
                 }
             }
             catch (Exception ex)
             {
                 // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                 MessageBox.Show("Lỗi: " + ex.Message);
             }
         }*/
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị được chọn từ ComboBox
                string selectedRole = comboBox1.SelectedItem.ToString();

                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    // Sử dụng tham số trong truy vấn SQL để tránh SQL Injection
                    string query = "SELECT * FROM ACCOUNT WHERE TAIKHOAN = @TAIKHOAN AND MATKHAU = @MATKHAU";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Sét các giá trị tham số
                        command.Parameters.AddWithValue("@TAIKHOAN", txtMaTL.Text);
                        command.Parameters.AddWithValue("@MATKHAU", textBox1.Text);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Lấy quyền từ cơ sở dữ liệu
                                string actualRole = reader["QUYEN"].ToString();

                                // Kiểm tra giá trị thực tế của quyền và giá trị được chọn từ ComboBox
                                if (actualRole == selectedRole)
                                {
                                    // Lấy quyền và lưu vào biến tĩnh
                                    UserRole = actualRole;

                                    // Lấy tài khoản và lưu vào biến tĩnh
                                    user = reader["TAIKHOAN"].ToString();

                                    // Kiểm tra quyền và mở form tương ứng
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
                                    else
                                    {
                                        // Hiển thị thông báo nếu có quyền khác mà bạn chưa xử lý
                                        MessageBox.Show("Không có quyền truy cập.");
                                    }
                                }
                                else
                                {
                                    // Hiển thị thông báo nếu quyền không khớp
                                    MessageBox.Show("Quyền không khớp với tài khoản đã đăng ký.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                // Hiển thị thông báo đăng nhập không thành công
                                MessageBox.Show("Đăng nhập không thành công. Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

    }

}




