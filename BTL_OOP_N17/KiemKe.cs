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
    public partial class KiemKe : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public KiemKe()
        {
            InitializeComponent();
            dgvThongTinKK.DataSource = infoKKGridView();
            dgvChitietKKTS.DataSource = infoCHITIETKKGridView();
        }

        private void KiemKe_Load(object sender, EventArgs e)
        {

        }
        public DataTable infoCHITIETKKGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from CHITIET_KK", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable infoKKGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from KIEMKE", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
