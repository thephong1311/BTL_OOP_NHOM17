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
using TheArtOfDevHtmlRenderer.Adapters;

namespace BTL_OOP_N17
{
    public partial class MuonTS : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public MuonTS()
        {
            InitializeComponent();
            daduyetGridView1.DataSource = infoDaDuyetGridView();
            chuaduyetGridView3.DataSource = infoChuaDuyetGridView();
            ctpmGridView2.DataSource = infoCTPM();
        }
        public DataTable infoCTPM()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from CHITIET_MUON ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable infoDaDuyetGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from PHIEUMUONTS where TRANGTHAIMUON = N'Đã duyệt'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable infoChuaDuyetGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from PHIEUMUONTS where TRANGTHAIMUON = N'Chưa được duyệt'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable findPM()
        {
            string query = "SELECT * FROM PHIEUMUONTS WHERE MAPM = @MaPM AND TRANGTHAIMUON = N'Đã duyệt'";

            using (SqlCommand command = new SqlCommand(query, con))
            {
               
                command.Parameters.AddWithValue("@MAPM", txt_TimKiem.Text);
                SqlDataAdapter find = new SqlDataAdapter(command);
                DataTable dt_find = new DataTable();
                find.Fill(dt_find);

                return dt_find;
            }
        }
        public DataTable findPM2()
        {
            string query = "SELECT * FROM PHIEUMUONTS WHERE MAPM = @MaPM AND TRANGTHAIMUON = N'Chưa được duyệt'";

            using (SqlCommand command = new SqlCommand(query, con))
            {
                
                command.Parameters.AddWithValue("@MAPM", txt_TimKiem.Text);
                SqlDataAdapter find = new SqlDataAdapter(command);
                DataTable dt_find = new DataTable();
                find.Fill(dt_find);

                return dt_find;
            }
        }
        private void bt_Find_Click(object sender, EventArgs e)
        {
            daduyetGridView1.DataSource = findPM();
        }

        private void btn_Find2_Click(object sender, EventArgs e)
        {
            chuaduyetGridView3.DataSource = findPM2();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ThemMuonTS f = new ThemMuonTS();
            f.ShowDialog();
        }
        public void DeletePhieuMuon(string mapm)
        {
            
            using (SqlCommand cmd = new SqlCommand("DELETE FROM PHIEUMUONTS WHERE MAPM = @mapm", con))
            {
                cmd.Parameters.AddWithValue("@mapm", mapm);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void DeleteCTPM(string mapm)
        {
            
            using (SqlCommand cmd = new SqlCommand("DELETE FROM CHITIET_PM WHERE MAPM = @mapm", con))
            {
                cmd.Parameters.AddWithValue("@mapm", mapm);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        private void InitializeDataGridView()
        {
            daduyetGridView1.DataSource = infoDaDuyetGridView();
            chuaduyetGridView3.DataSource = infoChuaDuyetGridView();
            ctpmGridView2.DataSource = infoCTPM();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (daduyetGridView1.SelectedRows.Count > 0)
                {
                    
                    string mapm1 = daduyetGridView1.SelectedRows[0].Cells["MAPM"].Value.ToString();

                   
                    DialogResult result1 = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu mượn này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    
                    if (result1 == DialogResult.Yes)
                    {
                       
                        DeletePhieuMuon(mapm1);
                        DeleteCTPM(mapm1);
                        InitializeDataGridView();

                        MessageBox.Show("Đã xóa phiếu mượn thành công!");
                    }
                  
                }
                if (chuaduyetGridView3.SelectedRows.Count > 0)
                {
                   
                    string mapm2 = chuaduyetGridView3.SelectedRows[0].Cells["MAPM"].Value.ToString();
                    DialogResult result2 = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu mượn thiết bị này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result2 == DialogResult.Yes)
                    {
                        
                        DeletePhieuMuon(mapm2);
                        DeleteCTPM(mapm2);
                        InitializeDataGridView();
                        MessageBox.Show("Đã xóa phiếu mượn thiết bị thành công!");
                    }
                }
                if (ctpmGridView2.SelectedRows.Count > 0)
                {
                    
                    string mapm3 = ctpmGridView2.SelectedRows[0].Cells["MAPM"].Value.ToString();
                    DialogResult result3 = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu mượn thiết bị này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
                    if (result3 == DialogResult.Yes)
                    {
                       
                        DeleteCTPM(mapm3);
                        InitializeDataGridView();
                        MessageBox.Show("Đã xóa phiếu mượn thiết bị thành công!");
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

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            ThemMuonTS f = new ThemMuonTS();
            f.ShowDialog();
        }
        public DataTable findCTPM()
        {
            string query = "SELECT * FROM CHITIET_MUON WHERE MAPM = @MaPM";

            using (SqlCommand command = new SqlCommand(query, con))
            {
              
                command.Parameters.AddWithValue("@MaPM", txtFindCT.Text);
                SqlDataAdapter find = new SqlDataAdapter(command);
                DataTable dt_find = new DataTable();
                find.Fill(dt_find);

                return dt_find;
            }
        }
        private void btnFindCT_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtFindCT.Text))
            {
                ctpmGridView2.DataSource = findCTPM();

            }
            else
            {
                MessageBox.Show("Hãy nhập mã phiếu mượn để tìm kiếm!");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
           
            InitializeDataGridView();
            ClearTextBoxes();
        }
        private void ClearTextBoxes()
        {
            txtFindCT.Text=string.Empty;
            txt_TimKiem.Text=string.Empty;
            txt_TimKiem1.Text = string.Empty;

        }

    }
}
