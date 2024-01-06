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
    public partial class TiepNhanTaiSan : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public TiepNhanTaiSan()
        {
            InitializeComponent();
        }
        public DataTable infoTAISANGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from TAISAN", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
