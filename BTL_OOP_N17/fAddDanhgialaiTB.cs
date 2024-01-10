using BTL_OOP_N17.DAO;
using DevExpress.XtraBars.Docking2010.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_OOP_N17
{
    public partial class fAddDanhgialaiTB : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public fAddDanhgialaiTB()
        {
            InitializeComponent();
            dataTable = infoCHITIETDGTBGridView();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;
        }
        public DataTable infoCHITIETDGTBGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from CHITIET_DGTS", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        private void LuuDuLieuVaoCSDL()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["DaThayDoi"].Value != null && (bool)row.Cells["DaThayDoi"].Value)
                {
                    decimal ng_truocdc;
                    if (decimal.TryParse(row.Cells["NG_TRUOCDC"].Value.ToString(), out ng_truocdc))
                    {
                        string query = $"UPDATE CHITIET_DGTS SET " +
                                       $"MATS = '{row.Cells["MATS"].Value}', " +
                                       $"NG_TRUOCDC = {ng_truocdc}, " +
                                       $"TG_KH = '{row.Cells["TG_KH"].Value}', " +
                                       $"MUCKH_TBNAM = '{row.Cells["MUCKH_TBNAM"].Value}', " +
                                       $"NAM_DUAVAOSD = '{row.Cells["NAM_DUAVAOSD"].Value}', " +
                                       $"NAM_DANHGIA = '{row.Cells["NAM_DANHGIA"].Value}', " +
                                       $"TG_SD = '{row.Cells["TG_SD"].Value}', " +
                                       $"NG_SAUDC = '{row.Cells["NG_SAUDC"].Value}', " +
                                       $"SOKHLUYKE_DATRICH = '{row.Cells["SOKHLUYKE_DATRICH"].Value}', " +
                                       $"GTCL_TS = '{row.Cells["GTCL_TS"].Value}' " +
                                       $"WHERE MADGLTS = '{row.Cells["MADGLTS"].Value}'";

                        using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                        {
                            con.Open();
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.ExecuteNonQuery();
                            }
                            con.Close();
                        }

                        row.Cells["DaThayDoi"].Value = false;
                    }
                    else
                    {
                        MessageBox.Show($"Giá trị của NG_TRUOCDC không hợp lệ: {row.Cells["NG_TRUOCDC"].Value}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            MessageBox.Show("Dữ liệu đã được cập nhật vào CSDL.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                LuuDuLieuVaoCSDL();
                dataGridView1.DataSource = infoCHITIETDGTBGridView();

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapnhat_phieu_Click(object sender, EventArgs e)
        {

            try
            {
                if (!string.IsNullOrEmpty(txtMDGLTS.Text) && !string.IsNullOrEmpty(txtMaGV.Text) && !string.IsNullOrEmpty(cbbPTN.Text) && !string.IsNullOrEmpty(txtLydo.Text))
                {
                    using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                    {
                        con.Open();
                        string update = "UPDATE DANHGIATS SET MADGLTS=@madg,MAGV=@magv,MAPTN=@ptn,LYDODG=@lydo,NGAYDG=@ngay WHERE MADGLTS=@madg;";
                        using (SqlCommand cmd = new SqlCommand(update, con))
                        {
                            cmd.Parameters.AddWithValue("@madg", txtMDGLTS.Text);
                            cmd.Parameters.AddWithValue("@magv", txtMaGV.Text);
                            cmd.Parameters.AddWithValue("@ptn", cbbPTN.Text);
                            cmd.Parameters.AddWithValue("@lydo", txtLydo.Text);
                            cmd.Parameters.AddWithValue("@ngay", dateTimePicker1.Value.ToString("yyyy-MM-dd"));

                            try
                            {
                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Cập nhật phiếu đánh giá lại thiết bị thành công!");
                                    dataGridView1.DataSource = infoCHITIETDGTBGridView();

                                }
                                else
                                {
                                    MessageBox.Show("Cập nhật thất bại. Hãy kiểm tra lại thông tin !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Hãy nhập đủ thông tin !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private BindingSource bindingSource = new BindingSource();
        private DataTable dataTable;

        private void ThemDLCT()
        {
            DataRow newRow = dataTable.NewRow();

            newRow["MADGLTS"] = "MADGLTS_Value";
            newRow["MATS"] = "MATS_Value";
            newRow["NG_TRUOCDC"] = Convert.ToDecimal("NG_TRUOCDC_Value");
            newRow["TG_KH"] = "TG_KH_Value";
            newRow["MUCKH_TBNAM"] = Convert.ToDecimal("MUCKH_TBNAM_Value");
            newRow["NAM_DUAVAOSD"] = "NAM_DUAVAOSD_Value";
            newRow["NAM_DANHGIA"] = "NAM_DANHGIA_Value";
            newRow["TG_SD"] = "TG_SD_Value";
            newRow["NG_SAUDC"] = Convert.ToDecimal("NG_SAUDC_Value");
            newRow["SOKHLUYKE_DATRICH"] = Convert.ToDecimal("SOKHLUYKE_DATRICH_Value"); 
            newRow["GTCL_TS"] = Convert.ToDecimal("GTCL_TS_Value"); 


            dataTable.Rows.Add(newRow);

           
            string madglts = newRow["MADGLTS"].ToString();
            string mats = newRow["MATS"].ToString();
            decimal ng_truocdc = (decimal)newRow["NG_TRUOCDC"];
            string tg_kh = newRow["TG_KH"].ToString();
            decimal muckh_tbnam = (decimal)newRow["MUCKH_TBNAM"];
            string namsd = newRow["NAM_DUAVAOSD"].ToString();
            string namdg = newRow["NAM_DANHGIA"].ToString();
            string tgsd = newRow["TG_SD"].ToString();
            decimal ng_saudc = (decimal)newRow["NG_SAUDC"];
            decimal sokhlk = (decimal)newRow["SOKHLUYKE_DATRICH"];
            decimal gtcl = (decimal)newRow["GTCL_TS"];
            
            string query = "INSERT INTO CHITIET_DGTS (MADGLTS,MATS,NG_TRUOCDC,TG_KH,MUCKH_TBNAM,NAM_DUAVAOSD,NAM_DANHGIA,TG_SD,NG_SAUDC,SOKHLUYKE_DATRICH,GTCL_TS) " +
                           $"VALUES ('{madglts}', '{mats}', '{ng_truocdc}', '{tg_kh}', '{muckh_tbnam}', '{namsd}', '{namdg}', '{tgsd}','{ng_saudc}','{sokhlk}','{gtcl}')";

            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }

            dataGridView1.DataSource = bindingSource.DataSource;

            MessageBox.Show("Dữ liệu đã được lưu vào CSDL.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ThemDLCT();
                dataGridView1.DataSource = infoCHITIETDGTBGridView();
            }
            catch (SqlException ex)
            {
                
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
               
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_phieu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtMDGLTS.Text) && !string.IsNullOrEmpty(txtMaGV.Text) && !string.IsNullOrEmpty(cbbPTN.Text) && !string.IsNullOrEmpty(txtLydo.Text))
                {
                    using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                    {
                        con.Open();
                        string insert = "INSERT INTO DANHGIATS (MADGLTS, MAGV, MAPTN, LYDODG, NGAYDG) " +
                                        "VALUES (@madg, @magv, @ptn, @lydo, @ngay);";
                        using (SqlCommand cmd = new SqlCommand(insert, con))
                        {
                            cmd.Parameters.AddWithValue("@madg", txtMDGLTS.Text);
                            cmd.Parameters.AddWithValue("@magv", txtMaGV.Text);
                            cmd.Parameters.AddWithValue("@ptn", cbbPTN.Text);
                            cmd.Parameters.AddWithValue("@lydo", txtLydo.Text);
                            cmd.Parameters.AddWithValue("@ngay", dateTimePicker1.Value.ToString("yyyy-MM-dd"));

                            try
                            {
                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Thêm phiếu đánh giá lại thiết bị thành công!");
                                    dataGridView1.DataSource = infoCHITIETDGTBGridView();


                                }
                                else
                                {
                                    MessageBox.Show("Thêm thất bại. Hãy kiểm tra lại thông tin !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Hãy nhập đủ thông tin !");
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}