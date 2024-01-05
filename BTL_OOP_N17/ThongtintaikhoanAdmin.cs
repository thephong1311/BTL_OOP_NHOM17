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
    public partial class ThongtintaikhoanAdmin : Form 
    {
        string username = FormLogin.user;
        public ThongtintaikhoanAdmin()
        {
            InitializeComponent();
            LoadAccountInfo(username);
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadAccountInfo(string username)
        {
            try
            {
                //Kết nối đến csdl
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    string sqlSelect = "SELECT * FROM ACCOUNT JOIN GIAOVIEN ON ACCOUNT.TAIKHOAN = GIAOVIEN.MAGV WHERE TAIKHOAN =@TAIKHOAN";
                    using (SqlCommand command = new SqlCommand(sqlSelect, connection))
                    {
                        command.Parameters.AddWithValue("@TAIKHOAN", username);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                txtTK.Text = reader["TAIKHOAN"].ToString();
                                txtQuyen.Text = reader["QUYEN"].ToString();
                                txtMaGV.Text = reader["MAGV"].ToString();
                                txtTenGv.Text = reader["TENGV"].ToString() ;
                                txtDiachi.Text = reader["DIACHIGV"].ToString();
                                txtSDT.Text = reader["SDTGV"].ToString();
                                txtChucvu.Text = reader["CHUCVUGV"].ToString();
                                txtMaPTN.Text = reader["MAPTN"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy thông tin tài khoản.");
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
