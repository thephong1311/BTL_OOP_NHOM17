using BTL_OOP_N17.DAO;
using DevExpress.XtraPrinting.Native;
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
    public partial class ChartMua : Form
    {
        public ChartMua()
        {
            InitializeComponent();
        }

        private void ChartMua_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT YC.MAPTN, COUNT(TENTSYC) AS SOYC FROM YEUCAUMUATS YC JOIN CHITIET_YCTS CTYC ON YC.MAYC = CTYC.MAYC GROUP BY MAPTN";
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            
                            dataGridView1.DataSource = dataTable;

                           
                            while (reader.Read())
                            {
                                chartTKMuaTS.Series.Add("Số yêu cầu mua");
                                chartTKMuaTS.Series["Số yêu cầu mua"].Points.AddXY(Convert.ToString(reader[0]), int.Parse(reader[1].ToString()));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
