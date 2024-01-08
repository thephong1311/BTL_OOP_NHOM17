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
    public partial class XemPTN : UserControl
    {

        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public XemPTN()
        {
            InitializeComponent();
            dataGridView1.DataSource = infoPTNGridView();
        }
        public DataTable infoPTNGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from PHONGTHINGHIEM", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable findPTN()
        {
            SqlDataAdapter find = new SqlDataAdapter("SELECT * from PHONGTHINGHIEM WHERE MAPTN = " + txtFind.Text, con);
            DataTable dt_find = new DataTable();
            find.Fill(dt_find);
            return dt_find;
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFind.Text))
            {
                dataGridView1.DataSource = findPTN();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã PTN để tìm kiếm");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFind.Text = "";
            dataGridView1.DataSource = null;
        }
    }
}

 

