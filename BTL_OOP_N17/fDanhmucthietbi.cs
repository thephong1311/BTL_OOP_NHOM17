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
        public DataTable infoDMTBGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from TAISAN", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        private void InitializeDataGridView()
        {
            dataGridView1.DataSource = infoDMTBGridView();
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

        }

        private void btnThem_Click(object sender, EventArgs e) 
        {
            fAddThietbi f=new fAddThietbi();
            f.ShowDialog();
            if (f.tt)
            {
                dataGridView1.DataSource = infoDMTBGridView();
            }
        }
        public void DeleteDMTS(string mats)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM TAISAN WHERE MATS = @mats", con))
            {
                cmd.Parameters.AddWithValue("@mats", mats);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string mats = dataGridView1.SelectedRows[0].Cells["MATS"].Value.ToString();

                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục thiết bị này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        DeleteDMTS(mats);

                        InitializeDataGridView();

                        MessageBox.Show("Đã xóa danh mục thiết bị thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một danh mục thiết bị để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnSua_Click(object sender, EventArgs e)
        {
          fAddThietbi fAddThietbi = new fAddThietbi();
          fAddThietbi.ShowDialog();
            if (fAddThietbi.tt)
            {
                dataGridView1.DataSource = infoDMTBGridView();
            }
        }
        private void ClearTextBoxes()
        {
            txtMaTS.Text = "";
            txtTenTS.Text = "";

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string mats = txtMaTS.Text;
            string userts = txtTenTS.Text;
            dataGridView1.DataSource = SearchTS(mats, userts);
        }

        private void fDanhmucthietbi_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            dataGridView1.SelectionChanged += DataGridView_SelectionChanged;
        }
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string mats = selectedRow.Cells["MATS"].Value.ToString();
                string userts = selectedRow.Cells["TENTS"].Value.ToString();


                DisplayTSInfo(mats, userts);
            }
        }
        private void DisplayTSInfo(string mats, string userts)
        {
            txtMaTS.Text = mats;
            txtTenTS.Text = userts;
        }
        public DataTable SearchTS(string mats, string userts)
        {
            string query = "SELECT * FROM TAISAN WHERE ";
            bool isFirstCondition = true;

            if (!string.IsNullOrEmpty(mats))
            {
                query += $"MATS LIKE '%{mats}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(userts))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"TENTS LIKE '%{userts}%'";
                isFirstCondition = false;
            }


            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
