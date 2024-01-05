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
    public partial class fDanhmucthietbi : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public fDanhmucthietbi()
        {
            InitializeComponent();
            dataGridView1.DataSource = infoDMTBGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        public DataTable infoDMTBGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from TAISAN", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện tìm kiếm theo Mã Thiết bị
            string maTSToSearch = textBox2.Text.Trim();

            if (!string.IsNullOrEmpty(maTSToSearch))
            {
                DataTable dt = SearchByMaTB(maTSToSearch);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu cho Mã Thiết bị: " + maTSToSearch, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập Mã Thiết bị để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private DataTable SearchByMaTB(string maTB)
        {
            SqlDataAdapter sda = new SqlDataAdapter($"SELECT * FROM TAISAN WHERE MaTS = 'MaTS'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        private void textBoxMaTB_KeyDown(object sender, KeyEventArgs e)
        {
            // Cho phép người dùng nhấn Enter để thực hiện tìm kiếm
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(sender, e);
            }
        }


    }
}
