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
    public partial class Nhacungcap : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public Nhacungcap()
        {
            InitializeComponent();
            dataGridView1.DataSource = infoNCCGridView();
        }
        public DataTable infoNCCGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from NHACUNGCAP", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
