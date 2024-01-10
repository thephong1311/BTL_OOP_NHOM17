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
    public partial class LOAITS : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);

        public LOAITS()
        {
            InitializeComponent();
            dataGridView1.DataSource = infoGVGridView();

        }
        public DataTable infoGVGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from LOAITS", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaLTS.Text) && !string.IsNullOrEmpty(txtTenLTS.Text))
            {
                try
                {
                    string sqlInsert = "INSERT INTO LOAITS(MALOAITS,TENLOAITS) VALUES (@malts,@tenlts)";
                    using (SqlCommand cmd = new SqlCommand(sqlInsert, con))
                    {
                        cmd.Parameters.AddWithValue("@malts", txtMaLTS.Text);
                        cmd.Parameters.AddWithValue("@tenlts", txtTenLTS.Text);
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm mới loại thiết bị thành công!");
                            InitializeDataGridView();


                        }
                        else
                        {
                            MessageBox.Show("Thêm mới loại thiết bị thất bại. Hãy kiếm tra lại thông tin !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();
                    }
                }
                catch (SqlException ex)
                {

                  
                    if (ex.Number == 2627) 
                    {
                        MessageBox.Show($"Mã '{txtMaLTS.Text}' đã tồn tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ thông tin !");
            }
        }

      
        public void DeleteGV(string malts)
        {
          
            using (SqlCommand cmd = new SqlCommand("DELETE FROM LOAITS WHERE MALOAITS = @malts", con))
            {
                cmd.Parameters.AddWithValue("@malts", malts);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        private void InitializeDataGridView()
        {
            dataGridView1.DataSource = infoGVGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (dataGridView1.SelectedRows.Count > 0)
                {
                   
                    string madvt = dataGridView1.SelectedRows[0].Cells["MALOAITS"].Value.ToString();

                   
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin loại tài sản này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                   
                    if (result == DialogResult.Yes)
                    {
                       
                        DeleteGV(madvt);

                      
                        InitializeDataGridView();

                        MessageBox.Show("Đã xóa loại tài sản thành công!");
                    }
                   
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtFind.Text = string.Empty;
            txtMaLTS.Text = string.Empty;
            txtTenLTS.Text = string.Empty;
            InitializeDataGridView();

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public DataTable findLTS()
        {
            string query = "SELECT * FROM LOAITS WHERE MALOAITS = @malts";

            using (SqlCommand command = new SqlCommand(query, con))
            {
               
                command.Parameters.AddWithValue("@malts", txtFind.Text);

               
                SqlDataAdapter find = new SqlDataAdapter(command);
                DataTable dt_find = new DataTable();
                find.Fill(dt_find);

                return dt_find;
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = findLTS();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaLTS.Text) && !string.IsNullOrEmpty(txtTenLTS.Text))
            {
                try
                {
                   
                    if (txtMaLTS.Text != dataGridView1.SelectedRows[0].Cells["MALOAITS"].Value.ToString())
                    {
                        MessageBox.Show("Không được sửa mã loại tài sản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string sqlUpdate = "UPDATE LOAITS SET TENLOAITS=@tenlts WHERE MALOAITS=@malts";
                    using (SqlCommand cmd = new SqlCommand(sqlUpdate, con))
                    {
                        cmd.Parameters.AddWithValue("@malts", txtMaLTS.Text);
                        cmd.Parameters.AddWithValue("@tenlts", txtTenLTS.Text);
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật loại tài sản thành công!");
                            InitializeDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật loại tài sản thất bại. Hãy kiểm tra lại thông tin !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ thông tin !");
            }
        }
    }
}

