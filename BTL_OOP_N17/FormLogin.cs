 using BTL_OOP_N17.DAO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_OOP_N17
{
    public partial class FormLogin : Form
    {
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
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM ACCOUNT";

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = new SqlCommand(query, connection);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Dang nhap thanh cong!", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        fDevicemanage f = new fDevicemanage();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Vui long dien thong tin dang nhap");
                    }

                    // Bây giờ bạn có dữ liệu trong DataTable (dt), và bạn có thể làm điều gì đó với nó.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}

