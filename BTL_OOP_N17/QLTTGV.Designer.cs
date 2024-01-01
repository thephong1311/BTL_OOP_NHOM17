namespace BTL_OOP_N17

{
    partial class QLTTGV
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSDTGV = new System.Windows.Forms.TextBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChucvu = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTS2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.txtFind);
            this.groupBox1.Controls.Add(this.btnXuat);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtSDTGV);
            this.groupBox1.Controls.Add(this.txtTenGV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtChucvu);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtMaGV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(857, 401);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giáo viên ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAGVDataGridViewTextBoxColumn,
            this.tENGVDataGridViewTextBoxColumn,
            this.dIACHIGVDataGridViewTextBoxColumn,
            this.sDTGVDataGridViewTextBoxColumn,
            this.cHUCVUGVDataGridViewTextBoxColumn,
            this.mAPTNDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gIAOVIENBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 150);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(485, 183);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 17;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(25, 185);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(434, 22);
            this.txtFind.TabIndex = 16;
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(528, 128);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(86, 23);
            this.btnXuat.TabIndex = 15;
            this.btnXuat.Text = "Xuất Excel";
            this.btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(415, 128);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(314, 128);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu lại\r\n";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(212, 128);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa bỏ ";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(116, 128);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Chỉnh sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(25, 129);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtSDTGV
            // 
            this.txtSDTGV.Location = new System.Drawing.Point(467, 62);
            this.txtSDTGV.Name = "txtSDTGV";
            this.txtSDTGV.Size = new System.Drawing.Size(225, 22);
            this.txtSDTGV.TabIndex = 9;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(465, 34);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(225, 22);
            this.txtTenGV.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số điện thoại ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên giáo viên";
            // 
            // txtChucvu
            // 
            this.txtChucvu.Location = new System.Drawing.Point(116, 89);
            this.txtChucvu.Name = "txtChucvu";
            this.txtChucvu.Size = new System.Drawing.Size(211, 22);
            this.txtChucvu.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(116, 59);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(211, 22);
            this.txtDiaChi.TabIndex = 4;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(116, 31);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(211, 22);
            this.txtMaGV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã giáo viên ";
            // 
            // qLTS2DataSet
            // 
            this.qLTS2DataSet.DataSetName = "QLTS2DataSet";
            this.qLTS2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIAOVIENBindingSource
            // 
            this.gIAOVIENBindingSource.DataMember = "GIAOVIEN";
            this.gIAOVIENBindingSource.DataSource = this.qLTS2DataSet;
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // mAGVDataGridViewTextBoxColumn
            // 
            this.mAGVDataGridViewTextBoxColumn.DataPropertyName = "MAGV";
            this.mAGVDataGridViewTextBoxColumn.HeaderText = "MAGV";
            this.mAGVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAGVDataGridViewTextBoxColumn.Name = "mAGVDataGridViewTextBoxColumn";
            this.mAGVDataGridViewTextBoxColumn.Width = 125;
            // 
            // tENGVDataGridViewTextBoxColumn
            // 
            this.tENGVDataGridViewTextBoxColumn.DataPropertyName = "TENGV";
            this.tENGVDataGridViewTextBoxColumn.HeaderText = "TENGV";
            this.tENGVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENGVDataGridViewTextBoxColumn.Name = "tENGVDataGridViewTextBoxColumn";
            this.tENGVDataGridViewTextBoxColumn.Width = 125;
            // 
            // dIACHIGVDataGridViewTextBoxColumn
            // 
            this.dIACHIGVDataGridViewTextBoxColumn.DataPropertyName = "DIACHIGV";
            this.dIACHIGVDataGridViewTextBoxColumn.HeaderText = "DIACHIGV";
            this.dIACHIGVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIACHIGVDataGridViewTextBoxColumn.Name = "dIACHIGVDataGridViewTextBoxColumn";
            this.dIACHIGVDataGridViewTextBoxColumn.Width = 125;
            // 
            // sDTGVDataGridViewTextBoxColumn
            // 
            this.sDTGVDataGridViewTextBoxColumn.DataPropertyName = "SDTGV";
            this.sDTGVDataGridViewTextBoxColumn.HeaderText = "SDTGV";
            this.sDTGVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDTGVDataGridViewTextBoxColumn.Name = "sDTGVDataGridViewTextBoxColumn";
            this.sDTGVDataGridViewTextBoxColumn.Width = 125;
            // 
            // cHUCVUGVDataGridViewTextBoxColumn
            // 
            this.cHUCVUGVDataGridViewTextBoxColumn.DataPropertyName = "CHUCVUGV";
            this.cHUCVUGVDataGridViewTextBoxColumn.HeaderText = "CHUCVUGV";
            this.cHUCVUGVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cHUCVUGVDataGridViewTextBoxColumn.Name = "cHUCVUGVDataGridViewTextBoxColumn";
            this.cHUCVUGVDataGridViewTextBoxColumn.Width = 125;
            // 
            // mAPTNDataGridViewTextBoxColumn
            // 
            this.mAPTNDataGridViewTextBoxColumn.DataPropertyName = "MAPTN";
            this.mAPTNDataGridViewTextBoxColumn.HeaderText = "MAPTN";
            this.mAPTNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAPTNDataGridViewTextBoxColumn.Name = "mAPTNDataGridViewTextBoxColumn";
            this.mAPTNDataGridViewTextBoxColumn.Width = 125;
            // 
            // QLTTGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "QLTTGV";
            this.Text = "Giáo viên ";
            this.Load += new System.EventHandler(this.QLTTGV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTS2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSDTGV;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChucvu;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private QLTS2DataSet qLTS2DataSet;
        private System.Windows.Forms.BindingSource gIAOVIENBindingSource;
        private QLTS2DataSetTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHUCVUGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAPTNDataGridViewTextBoxColumn;
    }
}