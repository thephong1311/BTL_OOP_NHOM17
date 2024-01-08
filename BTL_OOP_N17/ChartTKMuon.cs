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
    public partial class ChartTKMuon : Form
    {
        public ChartTKMuon()
        {
            InitializeComponent();
        }

        private void ChartTKMuon_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT MAPTN, COUNT(TS.MATS) AS SOLANMUON FROM TAISAN TS JOIN CHITIET_MUON CTM ON TS.MATS = CTM.MATS GROUP BY MAPTN";
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                chartTKMuonTS.Series.Add("Số yêu cầu mượn");
                                chartTKMuonTS.Series["Số yêu cầu mượn"].Points.AddXY(Convert.ToString(reader[0]), int.Parse(reader[1].ToString()));
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
