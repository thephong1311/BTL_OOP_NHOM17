﻿using BTL_OOP_N17.DAO;
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
    public partial class SuaChuaTS : Form
    {
        public SuaChuaTS()
        {
            InitializeComponent();
            dataGridView1.DataSource = infoSCTSGridView();
        }

        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public DataTable infoSCTSGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from SUACHUATS", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        private void InitializeDataGridView()
        {
            dataGridView1.DataSource = infoSCTSGridView();
        }
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy dữ liệu từ hàng được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string magv = selectedRow.Cells["MAGV"].Value.ToString();
                string masc = selectedRow.Cells["MASC"].Value.ToString();
                string maptn = selectedRow.Cells["MAPTN"].Value.ToString();
                string ttsc = selectedRow.Cells["TRANGTHAISC"].Value.ToString();
                string ngaysc = selectedRow.Cells["NGAYSC"].Value.ToString();

                // Hiển thị thông tin trong GroupBox
                ShowInfo(magv, masc, maptn, ttsc, ngaysc);
            }
        }
        private void ShowInfo(string magv, string masc, string maptn, string ttsc, string ngaysc)
        {

            txtMAGV.Text = magv;
            txtMSC.Text = masc;
            txtMAPTN.Text = maptn;
            txtTTSC.Text = ttsc;
            dtSC.Value = DateTime.Parse(ngaysc);

        }
        private void SuaChuaTS_Load()
        {
            InitializeDataGridView();
            dataGridView1.SelectionChanged += DataGridView_SelectionChanged;

        }
        public DataTable SearchSCTS(string magv, string masc, string maptn, string ttsc, string ngaysc)
        {

            string query = "SELECT * FROM SUACHUATS WHERE ";
            bool isFirstCondition = true;

            if (!string.IsNullOrEmpty(masc))
            {
                query += $"MASC LIKE '%{masc}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(magv))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"MAGV LIKE '%{magv}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(maptn))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"NGAYSC LIKE '%{ngaysc}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(ttsc))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"TRANGTHAISC LIKE '%{ttsc}%'";
            }

            if (!string.IsNullOrEmpty(ngaysc))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"CHUCVUGV LIKE '%{ngaysc}%'";
            }

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            string magv = txtMAGV.Text;
            string masc = txtMSC.Text;
            string maptn = txtMAPTN.Text;
            string ttsc = txtTTSC.Text;
            string ngaysc = dtSC.Value.ToString("yyyy-MM-dd");
            dataGridView1.DataSource = SearchSCTS(magv, masc, maptn, ttsc, ngaysc);

        }
        public void ThemSCmoi(string magv, string masc, string maptn, string ttsc, string ngaysc)
        {


            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO THANHLYTS (MAGV, MASC, TRANGTHAISC, NGAYSC, MAPTN) VALUES (@magv, @masc, @ttsc, @ngaysc, @maptn)", con))
                {
                    cmd.Parameters.AddWithValue("@magv", magv);
                    cmd.Parameters.AddWithValue("@masc", masc);
                    cmd.Parameters.AddWithValue("@maptn", maptn);
                    cmd.Parameters.AddWithValue("@ttsc", ttsc);
                    cmd.Parameters.AddWithValue("@ngaysc", ngaysc);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();


                }


                MessageBox.Show("Đã thêm tài khoản mới thành công!");
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL
                if (ex.Number == 2627)  // 2627 là mã lỗi cho việc vi phạm ràng buộc duy nhất (unique constraint)
                {
                    MessageBox.Show($"Mã '{masc}' đã tồn tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi khác (nếu có)
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đảm bảo rằng kết nối sẽ được đóng dù có lỗi hay không
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        public void DeleteTL(string masc)
        {
            // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ CSDL
            using (SqlCommand cmd = new SqlCommand("DELETE FROM SUACHUATS WHERE MASC = @masc", con))
            {
                cmd.Parameters.AddWithValue("@masc", masc);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string magv = txtMAGV.Text;
                string masc = txtMSC.Text;
                string ttsc = txtTTSC.Text;
                string maptn = txtMAPTN.Text;
                string ngaysc = dtSC.Value.ToString("yyyy-MM-dd");



                ThemSCmoi(magv, masc, maptn, ttsc, ngaysc);

                // Làm mới dữ liệu trong DataGridView bằng cách gọi lại phương thức InitializeDataGridView
                InitializeDataGridView();

                MessageBox.Show("Đã thêm thông tin mới thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {

                    string masc = dataGridView1.SelectedRows[0].Cells["MASC"].Value.ToString();


                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin sửa chữa này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        DeleteTL(masc);


                        InitializeDataGridView();

                        MessageBox.Show("Đã xóa thành công!");
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một thông tin sửa chữa để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra xem người dùng đã đồng ý sửa hay không
            if (result == DialogResult.Yes)
            {
                // Lấy dữ liệu từ TextBox
                string magv = txtMAGV.Text;
                string masc = txtMSC.Text;
                string ttsc = txtTTSC.Text;
                string maptn = txtMAPTN.Text;
                string ngaysc = dtSC.Value.ToString("yyyy-MM-dd");
                // Cập nhật dữ liệu trong DataGridView
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["MAGV"].Value = magv;
                selectedRow.Cells["MASC"].Value = masc;
                selectedRow.Cells["MAPTN"].Value = maptn;
                selectedRow.Cells["NGAYSC"].Value = ngaysc;
                selectedRow.Cells["TRANGTHAISC"].Value = ttsc;


                ShowInfo(magv, masc, maptn, ttsc, ngaysc);

                // Đặt lại TextBox sau khi cập nhật
                ClearTextBoxes();

            }
        }
        private void ClearTextBoxes()
        {

            txtMAGV.Text = "";
            txtMSC.Text = "";
            txtTTSC.Text = "";
            txtMAPTN.Text = "";
            dtSC.Format = DateTimePickerFormat.Custom; ;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Gọi lại hàm InitializeDataGridView để tải lại dữ liệu ban đầu
            InitializeDataGridView();
            // Xóa nội dung trong các ô TextBox
            ClearTextBoxes();
        }

     
        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}