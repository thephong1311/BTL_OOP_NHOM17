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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YCmua));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaYC = new System.Windows.Forms.TextBox();
            this.cbbGV = new System.Windows.Forms.ComboBox();
            this.cbbPTN = new System.Windows.Forms.ComboBox();
            this.pHONGTHINGHIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTS2DataSet1 = new BTL_OOP_N17.QLTS2DataSet1();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pHONGTHINGHIEMTableAdapter = new BTL_OOP_N17.QLTS2DataSet1TableAdapters.PHONGTHINGHIEMTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.lstMota = new System.Windows.Forms.ListBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.gpbThongtinchitiet = new System.Windows.Forms.GroupBox();
            this.dgvThongtinchitiet = new System.Windows.Forms.DataGridView();
            this.btnDong = new Guna.UI.WinForms.GunaButton();
            this.btnXemlai = new Guna.UI.WinForms.GunaButton();
            this.btnLuu = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGTHINGHIEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTS2DataSet1)).BeginInit();
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
            this.cbbGV.Text = "Thêm giáo viên";
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
            // pHONGTHINGHIEMBindingSource
            // 
            this.pHONGTHINGHIEMBindingSource.DataMember = "PHONGTHINGHIEM";
            this.pHONGTHINGHIEMBindingSource.DataSource = this.qLTS2DataSet1;
            // 
            // qLTS2DataSet1
            // 
            this.qLTS2DataSet1.DataSetName = "QLTS2DataSet1";
            this.qLTS2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 156);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 22);
            this.dateTimePicker1.TabIndex = 7;
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
            this.dgvThongtinchitiet.Size = new System.Drawing.Size(708, 150);
            this.dgvThongtinchitiet.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.AnimationHoverSpeed = 0.07F;
            this.btnDong.AnimationSpeed = 0.03F;
            this.btnDong.BaseColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDong.BorderColor = System.Drawing.Color.Black;
            this.btnDong.BorderSize = 1;
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDong.FocusedColor = System.Drawing.Color.Empty;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.Black;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDong.Location = new System.Drawing.Point(591, 441);
            this.btnDong.Name = "btnDong";
            this.btnDong.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDong.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDong.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDong.OnHoverImage = null;
            this.btnDong.OnPressedColor = System.Drawing.Color.Black;
            this.btnDong.Size = new System.Drawing.Size(110, 23);
            this.btnDong.TabIndex = 14;
            this.btnDong.Text = "Đóng lại ";
            // 
            // btnXemlai
            // 
            this.btnXemlai.AnimationHoverSpeed = 0.07F;
            this.btnXemlai.AnimationSpeed = 0.03F;
            this.btnXemlai.BaseColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXemlai.BorderColor = System.Drawing.Color.Black;
            this.btnXemlai.BorderSize = 1;
            this.btnXemlai.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXemlai.FocusedColor = System.Drawing.Color.Empty;
            this.btnXemlai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemlai.ForeColor = System.Drawing.Color.Black;
            this.btnXemlai.Image = ((System.Drawing.Image)(resources.GetObject("btnXemlai.Image")));
            this.btnXemlai.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXemlai.Location = new System.Drawing.Point(308, 441);
            this.btnXemlai.Name = "btnXemlai";
            this.btnXemlai.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnXemlai.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXemlai.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXemlai.OnHoverImage = null;
            this.btnXemlai.OnPressedColor = System.Drawing.Color.Black;
            this.btnXemlai.Size = new System.Drawing.Size(197, 23);
            this.btnXemlai.TabIndex = 15;
            this.btnXemlai.Text = "Xem lại danh sách YC";
            // 
            // btnLuu
            // 
            this.btnLuu.AnimationHoverSpeed = 0.07F;
            this.btnLuu.AnimationSpeed = 0.03F;
            this.btnLuu.BaseColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLuu.BorderColor = System.Drawing.Color.Black;
            this.btnLuu.BorderSize = 1;
            this.btnLuu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLuu.FocusedColor = System.Drawing.Color.Empty;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLuu.Location = new System.Drawing.Point(82, 441);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLuu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLuu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLuu.OnHoverImage = null;
            this.btnLuu.OnPressedColor = System.Drawing.Color.Black;
            this.btnLuu.Size = new System.Drawing.Size(113, 23);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu lại";
            this.btnLuu.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // YCmua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXemlai);
            this.Controls.Add(this.btnDong);
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
            ((System.ComponentModel.ISupportInitialize)(this.pHONGTHINGHIEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTS2DataSet1)).EndInit();
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
        private Guna.UI.WinForms.GunaButton btnDong;
        private Guna.UI.WinForms.GunaButton btnXemlai;
        private Guna.UI.WinForms.GunaButton btnLuu;
    }
}