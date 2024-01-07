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
    public partial class fDanhmucthietbi : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public fDanhmucthietbi()
        {
            InitializeComponent();
            dataGridView1.DataSource = infoDMTBGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtFind.Text = "";
            dataGridView1.DataSource = infoDMTBGridView();
        }
        public DataTable infoDMTBGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from TAISAN", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện tìm kiếm theo Mã Thiết bị
            string maTSToSearch = txtFind.Text.Trim();

            if (!string.IsNullOrEmpty(maTSToSearch))
            {
                DataTable dt = SearchByMaTB(maTSToSearch);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu cho Mã Thiết bị: " + maTSToSearch, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập Mã Thiết bị để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private DataTable SearchByMaTB(string maTB)
        {
            SqlDataAdapter sda = new SqlDataAdapter($"SELECT * FROM TAISAN WHERE MaTS = 'MaTS'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        private void textBoxMaTB_KeyDown(object sender, KeyEventArgs e)
        {
            // Cho phép người dùng nhấn Enter để thực hiện tìm kiếm
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(sender, e);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fAddThietbi f = new fAddThietbi();
            f.ShowDialog();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string delete = "DELETE FROM TAISAN WHERE ";
                if (!string.IsNullOrEmpty(txtMaTS.Text) && string.IsNullOrEmpty(txtTenTS.Text))
                {
                    using (SqlCommand cmd = new SqlCommand(delete + "MATS=@mats", con))
                    {
                        cmd.Parameters.AddWithValue("@mats", txtMaTS.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đã xóa hàng thành công !");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm mã thiết bị cần xóa !");
                        }
                    }
                }
                if (string.IsNullOrEmpty(txtMaTS.Text) && !string.IsNullOrEmpty(txtTenTS.Text))
                {
                    using (SqlCommand cmd1 = new SqlCommand(delete + "TENTS=@tents", con))
                    {
                        cmd1.Parameters.AddWithValue("@tents", txtTenTS.Text);
                        int rowsAffected1 = cmd1.ExecuteNonQuery();
                        if (rowsAffected1 > 0)
                        {
                            MessageBox.Show("Đã xóa hàng thành công !");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm mã thiết bị cần xóa !");
                        }
                    }
                }
                if (!string.IsNullOrEmpty(txtMaTS.Text) && !string.IsNullOrEmpty(txtTenTS.Text))
                {
                    using (SqlCommand cmd2 = new SqlCommand(delete + "MATS=@mats AND TENTS=@tents", con))
                    {
                        cmd2.Parameters.AddWithValue("@mats", txtMaTS.Text);
                        cmd2.Parameters.AddWithValue("@tents", txtTenTS.Text);
                        int rowsAffected2 = cmd2.ExecuteNonQuery();
                        if (rowsAffected2 > 0)
                        {
                            MessageBox.Show("Đã xóa hàng thành công !");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm mã thiết bị cần xóa !");
                        }
                    }
                }
                con.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtMaTS.Text = string.Empty;
            txtTenTS.Text = string.Empty;
            dataGridView1.DataSource = infoDMTBGridView();

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open(); 
                string select = "SELECT * FROM TAISAN WHERE ";
                if (!string.IsNullOrEmpty(txtMaTS.Text))
                {
                    using (SqlCommand cmd = new SqlCommand(select + "MATS=@mats", con))
                    {
                        cmd.Parameters.AddWithValue("@mats", txtMaTS.Text);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                reader.Close();
                                fAddThietbi f = new fAddThietbi();
                                con.Close();
                                SqlConnection.ClearAllPools();
                                f.UpdateTT(txtMaTS.Text);
                                f.Shown += (shownSender, shownArgs) => f.ShowDialog();
                                con.Close();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy mã thiết bị cần sửa !");
                                con.Close();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hãy nhập mã thiết bị !","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    con.Close();
                }
              
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
