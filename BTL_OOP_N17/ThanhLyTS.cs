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
    public partial class ThanhLyTB : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public ThanhLyTB()
        {
            InitializeComponent();
            dataGridView1.DataSource = infoCHITIETTHANHLYGridView();
        }





        private void btnDsTs_Click(object sender, EventArgs e)
        {

        }
        public DataTable infoCHITIETTHANHLYGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from CHITIET_TL", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
