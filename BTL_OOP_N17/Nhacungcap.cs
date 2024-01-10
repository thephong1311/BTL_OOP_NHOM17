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
        private void InitializeDataGridView()
        {
            dataGridView1.DataSource = infoNCCGridView();
        }

        private void Nhacungcap_Load(object sender, EventArgs e)
        {
           
            InitializeDataGridView();
            dataGridView1.SelectionChanged += DataGridView_SelectionChanged;
        }
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
          
            if (dataGridView1.SelectedRows.Count > 0)
            {
               
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string mancc = selectedRow.Cells["MANCC"].Value.ToString();
                string userncc = selectedRow.Cells["TENNCC"].Value.ToString();
                string diachincc = selectedRow.Cells["DIACHINCC"].Value.ToString();
                string sdtncc = selectedRow.Cells["SDTNCC"].Value.ToString();

                DisplayNCCInfo(mancc, userncc, diachincc, sdtncc);
            }
        }
        private void DisplayNCCInfo(string mancc, string userncc, string diachincc, string sdtncc)
        {
         
            txtMancc.Text = mancc;
            txtTenncc.Text = userncc;
            txtDiachincc.Text = diachincc;
            txtsdtncc.Text = sdtncc;
     
        }
        public DataTable SearchQLTTNCC(string mancc, string userncc, string diachincc, string sdtncc)
        {
        
            string query = "SELECT * FROM NHACUNGCAP WHERE ";
            bool isFirstCondition = true;

            if (!string.IsNullOrEmpty(mancc))
            {
                query += $"MANCC LIKE '%{mancc}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(userncc))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"TENNCC LIKE '%{userncc}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(diachincc))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"DIACHINCC LIKE '%{diachincc}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(sdtncc))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"SDTNCC LIKE '%{sdtncc}%'";
            }


            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            string mancc = txtMancc.Text;
            string userncc = txtTenncc.Text;
            string diachincc = txtDiachincc.Text;
            string sdtncc = txtsdtncc.Text;
            dataGridView1.DataSource = SearchQLTTNCC(mancc, userncc, diachincc, sdtncc);
        }
        public void UpdateInfoNCC(string mancc, string userncc, string diachincc, string sdtncc)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE NHACUNGCAP SET userncc= @userncc , diachincc = @dcncc , sdtncc = @sdtncc WHERE mancc = @mancc", con))
                {
                    cmd.Parameters.AddWithValue("@userncc", userncc);
                    cmd.Parameters.AddWithValue("@dcncc", diachincc);
                    cmd.Parameters.AddWithValue("@sdtncc", sdtncc);
                    cmd.Parameters.AddWithValue("@mancc", mancc);
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã cập nhật thông tin tài khoản thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không có tài khoản nào được cập nhật. Có thể không tồn tại Mã DD tương ứng hoặc Mã DD không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (SqlException ex)
            {
               
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ThemNCCmoi(string mancc, string userncc, string diachincc, string sdtncc)
        {
          
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO NHACUNGCAP (MANCC, TENNCC, DIACHINCC, SDTNCC) VALUES (@mancc, @userncc, @dcncc, @sdtncc)", con))
                {
                    cmd.Parameters.AddWithValue("@mancc", mancc);
                    cmd.Parameters.AddWithValue("@userncc", userncc);
                    cmd.Parameters.AddWithValue("@dcncc", diachincc);
                    cmd.Parameters.AddWithValue("@sdtncc", sdtncc);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();


                }


                MessageBox.Show("Đã thêm nhà cung cấp mới thành công!");
            }
            catch (SqlException ex)
            {
               
                if (ex.Number == 2627)  
                {
                    MessageBox.Show($"Mã '{mancc}' đã tồn tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            finally
            {
                
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        public void DeleteNCC(string mancc)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM NHACUNGCAP WHERE MANCC = @mancc", con))
            {
                cmd.Parameters.AddWithValue("@mancc", mancc);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (dataGridView1.SelectedRows.Count > 0)
                {
               
                    string mancc = dataGridView1.SelectedRows[0].Cells["MANCC"].Value.ToString();
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        DeleteNCC(mancc);
                        InitializeDataGridView();

                        MessageBox.Show("Đã xóa nhà cung cấp thành công!");
                    }
  
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhà cung cấp để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mancc = txtMancc.Text;
                string userncc = txtTenncc.Text;
                string diachincc = txtDiachincc.Text;
                string sdtncc = txtsdtncc.Text;
                ThemNCCmoi(mancc, userncc, diachincc, sdtncc);
                InitializeDataGridView();

                MessageBox.Show("Đã thêm nhà cung cấp mới thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
        
            DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
 
                string mancc = txtMancc.Text;
                string userncc = txtTenncc.Text;
                string diachincc = txtDiachincc.Text;
                string sdtncc = txtsdtncc.Text;
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["MANCC"].Value = mancc;
                selectedRow.Cells["TENNCC"].Value = userncc;
                selectedRow.Cells["DIACHINCC"].Value = diachincc;
                selectedRow.Cells["SDTNCC"].Value = sdtncc;

                DisplayNCCInfo(mancc, userncc, diachincc, sdtncc);

                ClearTextBoxes();
            }
        }
        private void ClearTextBoxes()
        {

            txtMancc.Text = "";
            txtTenncc.Text = "";
            txtDiachincc.Text = "";
            txtsdtncc.Text = "";

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
    
            InitializeDataGridView();
            ClearTextBoxes();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
