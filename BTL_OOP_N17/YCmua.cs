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
    public partial class YCmua : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public YCmua()
        {
            InitializeComponent();
            dgvThongtinchitiet.DataSource = infoYCMuaGridView();
        }
        public DataTable infoYCMuaGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from YEUCAUMUATS", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        private void YCmua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTS2DataSet1.PHONGTHINGHIEM' table. You can move, or remove it, as needed.
           

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
