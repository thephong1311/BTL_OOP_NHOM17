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
    public partial class ChartSoTienTrongPTN : Form
    {
        public ChartSoTienTrongPTN()
        {
            InitializeComponent();
        }

        private void ChartSoTienTrongPTN_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT MAPTN, SUM(ISNULL([GIANHAP], 0) * ISNULL([SOLUONGTS], 0)) AS THANHTIENTS FROM TAISAN GROUP BY MAPTN";
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Tạo DataTable và đọc dữ liệu từ reader
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            // Đặt DataTable làm nguồn dữ liệu cho dataGridView1
                            dataGridView1.DataSource = dataTable;

                            // Thêm dữ liệu vào biểu đồ
                            foreach (DataRow row in dataTable.Rows)
                            {
                                string maptn = row["MAPTN"].ToString();
                                int thanhTienTS = row["THANHTIENTS"] != DBNull.Value ? Convert.ToInt32(row["THANHTIENTS"]) : 0;

                                chartMoneyinLab.Series["đồng"].Points.AddXY(maptn, thanhTienTS);
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

