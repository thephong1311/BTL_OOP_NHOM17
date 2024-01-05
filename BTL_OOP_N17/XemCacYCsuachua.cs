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
    public partial class XemCacYCsuachua : UserControl
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public XemCacYCsuachua()
        {
            InitializeComponent();
            dataGridView1.DataSource = infoYCsuachuaGridView();
        }
        public DataTable infoYCsuachuaGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from SUACHUATS", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
