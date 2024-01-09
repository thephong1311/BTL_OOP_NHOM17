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
    public partial class ChartThongkeMuaTheoTGian : Form
    {
        public ChartThongkeMuaTheoTGian()
        {
            InitializeComponent();
        }
      
        private void btnTK_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = ("select YC.MAPTN, COUNT(TENTSYC) AS SOYC FROM YEUCAUMUATS YC JOIN CHITIET_YCTS CTYC ON YC.MAYC = CTYC.MAYC WHERE NGAYLAPYC BETWEEN '" + dateTimePicker1.Text + "'AND '" + dateTimePicker2.Text + "' GROUP BY YC.MAPTN ");
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                chartTKMuatheoTG.Series.Add("Số Tài sản YC");
                                chartTKMuatheoTG.Series["Số Tài sản YC"].Points.AddXY(Convert.ToString(reader[0]), int.Parse(reader[1].ToString()));
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

        private void ChartThongkeMuaTheoTGian_Load(object sender, EventArgs e)
        {
           
        }
    }
}
