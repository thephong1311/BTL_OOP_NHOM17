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
    public partial class YCKK : UserControl
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public YCKK()
        {
            InitializeComponent();
            dataGridView1.DataSource = infoYCKKGridView();
        }
        public DataTable infoYCKKGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from KIEMKE", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable findYCKK()
        {
            string query = "SELECT * FROM KIEMKE WHERE DVMUON = @MaPTN";

            using (SqlCommand command = new SqlCommand(query, con))
            {
                // Thêm tham số và đặt giá trị
                command.Parameters.AddWithValue("@MaPTN", txtFind.Text);

                // Thực hiện truy vấn
                SqlDataAdapter find = new SqlDataAdapter(command);
                DataTable dt_find = new DataTable();
                find.Fill(dt_find);

                return dt_find;
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFind.Text))
            {
                dataGridView1.DataSource = findYCKK();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã PTN để tìm kiếm");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFind.Text = "";
            dataGridView1.DataSource = infoYCKKGridView();
        }
    }
}
