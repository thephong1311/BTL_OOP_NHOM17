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
    public partial class ChartSoLuongGVtaiPTN : Form
    {
        public ChartSoLuongGVtaiPTN()
        {
            InitializeComponent();
        }

        private void ChartSoLuongGVtaiPTN_Load(object sender, EventArgs e)
        {
           
                try
                {
                    string sql = "select COUNT(MAGV) AS SOLUONGGV, MAPTN FROM GIAOVIEN GROUP BY MAPTN";
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
                                    chartGV.Series["giáo viên"].Points.AddXY(row["MAPTN"].ToString(), Convert.ToInt32(row["SOLUONGGV"]));
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
