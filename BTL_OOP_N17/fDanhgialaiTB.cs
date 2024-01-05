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
    public partial class fDanhgialaiTB : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public fDanhgialaiTB()
        {
            InitializeComponent();
            dataGridView1.DataSource = infoDGTBGridView();
            dataGridView2.DataSource = infoCHITIETDGTBGridView();

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public DataTable infoDGTBGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from DANHGIATS", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable infoCHITIETDGTBGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from CHITIET_DGTS", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
