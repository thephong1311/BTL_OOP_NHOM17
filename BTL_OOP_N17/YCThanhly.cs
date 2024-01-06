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
    public partial class YCThanhly : UserControl
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public YCThanhly()
        {
            InitializeComponent();
            dataGridView1.DataSource = infoYCTLGridView();
        }
        public DataTable infoYCTLGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from THANHLYTS", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable findThanhly()
        {
            string query = "SELECT * FROM THANHLYTS WHERE DVMUON = @MaPTN";

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
            dataGridView1.DataSource = findThanhly();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtFind.Text = "";
            dataGridView1.DataSource = null;
        }
    }
}
