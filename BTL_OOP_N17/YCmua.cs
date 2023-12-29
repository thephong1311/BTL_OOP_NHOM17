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
    public partial class YCmua : Form
    {
        public YCmua()
        {
            InitializeComponent();
        }

        private void YCmua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTS2DataSet1.PHONGTHINGHIEM' table. You can move, or remove it, as needed.
            this.pHONGTHINGHIEMTableAdapter.Fill(this.qLTS2DataSet1.PHONGTHINGHIEM);

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
