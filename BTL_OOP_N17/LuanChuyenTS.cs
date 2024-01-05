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
    public partial class LuanChuyenTS : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public LuanChuyenTS()
        {
            InitializeComponent();
            dataGridView1.DataSource = infoCHITIETLuanchuyenGridView();
        }

        private void LuanChuyenTS_Load(object sender, EventArgs e)
        {

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {

        }
        public DataTable infoCHITIETLuanchuyenGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from CHITIET_LC", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
