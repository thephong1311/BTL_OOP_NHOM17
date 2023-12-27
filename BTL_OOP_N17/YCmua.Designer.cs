namespace BTL_OOP_N17
{
    partial class YCmua
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaYC = new System.Windows.Forms.TextBox();
            this.cbbGV = new System.Windows.Forms.ComboBox();
            this.cbbPTN = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.qLTS2DataSet1 = new BTL_OOP_N17.QLTS2DataSet1();
            this.pHONGTHINGHIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHONGTHINGHIEMTableAdapter = new BTL_OOP_N17.QLTS2DataSet1TableAdapters.PHONGTHINGHIEMTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.lstMota = new System.Windows.Forms.ListBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.gpbThongtinchitiet = new System.Windows.Forms.GroupBox();
            this.dgvThongtinchitiet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.qLTS2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGTHINGHIEMBindingSource)).BeginInit();
            this.gpbThongtinchitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtinchitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã yêu cầu ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giáo viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nơi yêu cầu ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày tạo đơn ";
            // 
            // txtMaYC
            // 
            this.txtMaYC.Location = new System.Drawing.Point(135, 49);
            this.txtMaYC.Name = "txtMaYC";
            this.txtMaYC.Size = new System.Drawing.Size(280, 22);
            this.txtMaYC.TabIndex = 4;
            // 
            // cbbGV
            // 
            this.cbbGV.FormattingEnabled = true;
            this.cbbGV.Location = new System.Drawing.Point(135, 81);
            this.cbbGV.Name = "cbbGV";
            this.cbbGV.Size = new System.Drawing.Size(280, 24);
            this.cbbGV.TabIndex = 5;
            this.cbbGV.Tag = "";
            // 
            // cbbPTN
            // 
            this.cbbPTN.DataSource = this.pHONGTHINGHIEMBindingSource;
            this.cbbPTN.FormattingEnabled = true;
            this.cbbPTN.Location = new System.Drawing.Point(135, 118);
            this.cbbPTN.Name = "cbbPTN";
            this.cbbPTN.Size = new System.Drawing.Size(280, 24);
            this.cbbPTN.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 156);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // qLTS2DataSet1
            // 
            this.qLTS2DataSet1.DataSetName = "QLTS2DataSet1";
            this.qLTS2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHONGTHINGHIEMBindingSource
            // 
            this.pHONGTHINGHIEMBindingSource.DataMember = "PHONGTHINGHIEM";
            this.pHONGTHINGHIEMBindingSource.DataSource = this.qLTS2DataSet1;
            // 
            // pHONGTHINGHIEMTableAdapter
            // 
            this.pHONGTHINGHIEMTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mô tả";
            // 
            // lstMota
            // 
            this.lstMota.FormattingEnabled = true;
            this.lstMota.ItemHeight = 16;
            this.lstMota.Location = new System.Drawing.Point(543, 49);
            this.lstMota.Name = "lstMota";
            this.lstMota.Size = new System.Drawing.Size(228, 84);
            this.lstMota.TabIndex = 9;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(748, 49);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(23, 84);
            this.vScrollBar1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Trạng thái";
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Location = new System.Drawing.Point(557, 156);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(214, 22);
            this.txtTrangthai.TabIndex = 12;
            // 
            // gpbThongtinchitiet
            // 
            this.gpbThongtinchitiet.Controls.Add(this.dgvThongtinchitiet);
            this.gpbThongtinchitiet.Location = new System.Drawing.Point(33, 208);
            this.gpbThongtinchitiet.Name = "gpbThongtinchitiet";
            this.gpbThongtinchitiet.Size = new System.Drawing.Size(738, 218);
            this.gpbThongtinchitiet.TabIndex = 13;
            this.gpbThongtinchitiet.TabStop = false;
            this.gpbThongtinchitiet.Text = "Thông tin chi tiết ";
            // 
            // dgvThongtinchitiet
            // 
            this.dgvThongtinchitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongtinchitiet.Location = new System.Drawing.Point(8, 22);
            this.dgvThongtinchitiet.Name = "dgvThongtinchitiet";
            this.dgvThongtinchitiet.RowHeadersWidth = 51;
            this.dgvThongtinchitiet.RowTemplate.Height = 24;
            this.dgvThongtinchitiet.Size = new System.Drawing.Size(447, 150);
            this.dgvThongtinchitiet.TabIndex = 0;
            // 
            // YCmua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbThongtinchitiet);
            this.Controls.Add(this.txtTrangthai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.lstMota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbbPTN);
            this.Controls.Add(this.cbbGV);
            this.Controls.Add(this.txtMaYC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "YCmua";
            this.Text = "Yêu cầu mua tài sản ";
            this.Load += new System.EventHandler(this.YCmua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLTS2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGTHINGHIEMBindingSource)).EndInit();
            this.gpbThongtinchitiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtinchitiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaYC;
        private System.Windows.Forms.ComboBox cbbGV;
        private System.Windows.Forms.ComboBox cbbPTN;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private QLTS2DataSet1 qLTS2DataSet1;
        private System.Windows.Forms.BindingSource pHONGTHINGHIEMBindingSource;
        private QLTS2DataSet1TableAdapters.PHONGTHINGHIEMTableAdapter pHONGTHINGHIEMTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstMota;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTrangthai;
        private System.Windows.Forms.GroupBox gpbThongtinchitiet;
        private System.Windows.Forms.DataGridView dgvThongtinchitiet;
    }
}