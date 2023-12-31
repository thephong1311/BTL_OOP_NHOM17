using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_OOP_N17
{
    public partial class ReportYCmua : Form
    {
        public ReportYCmua()
        {
            InitializeComponent();
        }

        private void ReportYCmua_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
