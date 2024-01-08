namespace BTL_OOP_N17
{
    partial class MuonTS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuonTS));
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.btn_Find = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.chuaduyetGridView3 = new System.Windows.Forms.DataGridView();
            this.txt_TimKiem1 = new Guna.UI.WinForms.GunaTextBox();
            this.btn_Find2 = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.daduyetGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_TimKiem = new Guna.UI.WinForms.GunaTextBox();
            this.btn_Delete = new Guna.UI.WinForms.GunaButton();
            this.btn_Edit = new Guna.UI.WinForms.GunaButton();
            this.btn_Add = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.btnFindCT = new Guna.UI.WinForms.GunaButton();
            this.label4 = new System.Windows.Forms.Label();
            this.ctpmGridView2 = new System.Windows.Forms.DataGridView();
            this.txtFindCT = new Guna.UI.WinForms.GunaTextBox();
            this.btnLoad = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chuaduyetGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daduyetGridView1)).BeginInit();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctpmGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Silver;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.btn_Find);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.chuaduyetGridView3);
            this.gunaGroupBox1.Controls.Add(this.txt_TimKiem1);
            this.gunaGroupBox1.Controls.Add(this.btn_Find2);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.daduyetGridView1);
            this.gunaGroupBox1.Controls.Add(this.txt_TimKiem);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(16, 57);
            this.gunaGroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(1160, 402);
            this.gunaGroupBox1.TabIndex = 39;
            this.gunaGroupBox1.Text = "Thông tin phiếu mượn";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // btn_Find
            // 
            this.btn_Find.AnimationHoverSpeed = 0.07F;
            this.btn_Find.AnimationSpeed = 0.03F;
            this.btn_Find.BaseColor = System.Drawing.Color.Silver;
            this.btn_Find.BorderColor = System.Drawing.Color.Black;
            this.btn_Find.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Find.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Find.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Find.ForeColor = System.Drawing.Color.Black;
            this.btn_Find.Image = null;
            this.btn_Find.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Find.Location = new System.Drawing.Point(383, 64);
            this.btn_Find.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Find.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Find.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Find.OnHoverImage = null;
            this.btn_Find.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Find.Size = new System.Drawing.Size(96, 36);
            this.btn_Find.TabIndex = 20;
            this.btn_Find.Text = "Find";
            this.btn_Find.Click += new System.EventHandler(this.bt_Find_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(596, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Chưa được duyệt";
            // 
            // chuaduyetGridView3
            // 
            this.chuaduyetGridView3.BackgroundColor = System.Drawing.Color.White;
            this.chuaduyetGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chuaduyetGridView3.Location = new System.Drawing.Point(600, 107);
            this.chuaduyetGridView3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chuaduyetGridView3.Name = "chuaduyetGridView3";
            this.chuaduyetGridView3.RowHeadersWidth = 51;
            this.chuaduyetGridView3.Size = new System.Drawing.Size(560, 236);
            this.chuaduyetGridView3.TabIndex = 16;
            // 
            // txt_TimKiem1
            // 
            this.txt_TimKiem1.BaseColor = System.Drawing.Color.White;
            this.txt_TimKiem1.BorderColor = System.Drawing.Color.Silver;
            this.txt_TimKiem1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiem1.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_TimKiem1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TimKiem1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TimKiem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiem1.Location = new System.Drawing.Point(600, 64);
            this.txt_TimKiem1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TimKiem1.Name = "txt_TimKiem1";
            this.txt_TimKiem1.PasswordChar = '\0';
            this.txt_TimKiem1.SelectedText = "";
            this.txt_TimKiem1.Size = new System.Drawing.Size(343, 37);
            this.txt_TimKiem1.TabIndex = 17;
            // 
            // btn_Find2
            // 
            this.btn_Find2.AnimationHoverSpeed = 0.07F;
            this.btn_Find2.AnimationSpeed = 0.03F;
            this.btn_Find2.BaseColor = System.Drawing.Color.Silver;
            this.btn_Find2.BorderColor = System.Drawing.Color.Black;
            this.btn_Find2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Find2.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Find2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Find2.ForeColor = System.Drawing.Color.Black;
            this.btn_Find2.Image = null;
            this.btn_Find2.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Find2.Location = new System.Drawing.Point(951, 64);
            this.btn_Find2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Find2.Name = "btn_Find2";
            this.btn_Find2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Find2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Find2.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Find2.OnHoverImage = null;
            this.btn_Find2.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Find2.Size = new System.Drawing.Size(96, 36);
            this.btn_Find2.TabIndex = 18;
            this.btn_Find2.Text = "Find";
            this.btn_Find2.Click += new System.EventHandler(this.btn_Find2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Đã được duyệt";
            // 
            // daduyetGridView1
            // 
            this.daduyetGridView1.BackgroundColor = System.Drawing.Color.White;
            this.daduyetGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daduyetGridView1.Location = new System.Drawing.Point(32, 107);
            this.daduyetGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.daduyetGridView1.Name = "daduyetGridView1";
            this.daduyetGridView1.RowHeadersWidth = 51;
            this.daduyetGridView1.Size = new System.Drawing.Size(560, 236);
            this.daduyetGridView1.TabIndex = 1;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.BaseColor = System.Drawing.Color.White;
            this.txt_TimKiem.BorderColor = System.Drawing.Color.Silver;
            this.txt_TimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiem.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_TimKiem.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TimKiem.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiem.Location = new System.Drawing.Point(32, 63);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.PasswordChar = '\0';
            this.txt_TimKiem.SelectedText = "";
            this.txt_TimKiem.Size = new System.Drawing.Size(343, 37);
            this.txt_TimKiem.TabIndex = 11;
            // 
            // btn_Delete
            // 
            this.btn_Delete.AnimationHoverSpeed = 0.07F;
            this.btn_Delete.AnimationSpeed = 0.03F;
            this.btn_Delete.BaseColor = System.Drawing.Color.Silver;
            this.btn_Delete.BorderColor = System.Drawing.Color.Black;
            this.btn_Delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Delete.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Delete.Location = new System.Drawing.Point(271, 15);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Delete.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Delete.OnHoverImage = null;
            this.btn_Delete.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Delete.Size = new System.Drawing.Size(104, 34);
            this.btn_Delete.TabIndex = 42;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.AnimationHoverSpeed = 0.07F;
            this.btn_Edit.AnimationSpeed = 0.03F;
            this.btn_Edit.BaseColor = System.Drawing.Color.Silver;
            this.btn_Edit.BorderColor = System.Drawing.Color.Black;
            this.btn_Edit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Edit.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.Black;
            this.btn_Edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.Image")));
            this.btn_Edit.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Edit.Location = new System.Drawing.Point(131, 15);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Edit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Edit.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Edit.OnHoverImage = null;
            this.btn_Edit.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Edit.Size = new System.Drawing.Size(132, 34);
            this.btn_Edit.TabIndex = 41;
            this.btn_Edit.Text = "Chỉnh sửa";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.AnimationHoverSpeed = 0.07F;
            this.btn_Add.AnimationSpeed = 0.03F;
            this.btn_Add.BaseColor = System.Drawing.Color.Silver;
            this.btn_Add.BorderColor = System.Drawing.Color.Black;
            this.btn_Add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Add.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Black;
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Add.Location = new System.Drawing.Point(19, 15);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Add.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Add.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Add.OnHoverImage = null;
            this.btn_Add.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Add.Size = new System.Drawing.Size(104, 34);
            this.btn_Add.TabIndex = 40;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.Silver;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.btnFindCT);
            this.gunaGroupBox2.Controls.Add(this.label4);
            this.gunaGroupBox2.Controls.Add(this.ctpmGridView2);
            this.gunaGroupBox2.Controls.Add(this.txtFindCT);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Location = new System.Drawing.Point(13, 468);
            this.gunaGroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(1163, 291);
            this.gunaGroupBox2.TabIndex = 40;
            this.gunaGroupBox2.Text = "Thông tin chi tiết ";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // btnFindCT
            // 
            this.btnFindCT.AnimationHoverSpeed = 0.07F;
            this.btnFindCT.AnimationSpeed = 0.03F;
            this.btnFindCT.BaseColor = System.Drawing.Color.Silver;
            this.btnFindCT.BorderColor = System.Drawing.Color.Black;
            this.btnFindCT.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFindCT.FocusedColor = System.Drawing.Color.Empty;
            this.btnFindCT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindCT.ForeColor = System.Drawing.Color.Black;
            this.btnFindCT.Image = null;
            this.btnFindCT.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFindCT.Location = new System.Drawing.Point(383, 64);
            this.btnFindCT.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindCT.Name = "btnFindCT";
            this.btnFindCT.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnFindCT.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFindCT.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFindCT.OnHoverImage = null;
            this.btnFindCT.OnPressedColor = System.Drawing.Color.Black;
            this.btnFindCT.Size = new System.Drawing.Size(96, 36);
            this.btnFindCT.TabIndex = 20;
            this.btnFindCT.Text = "Find";
            this.btnFindCT.Click += new System.EventHandler(this.btnFindCT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nhập mã phiếu mượn";
            // 
            // ctpmGridView2
            // 
            this.ctpmGridView2.BackgroundColor = System.Drawing.Color.White;
            this.ctpmGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctpmGridView2.Location = new System.Drawing.Point(32, 107);
            this.ctpmGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.ctpmGridView2.Name = "ctpmGridView2";
            this.ctpmGridView2.RowHeadersWidth = 51;
            this.ctpmGridView2.Size = new System.Drawing.Size(1127, 180);
            this.ctpmGridView2.TabIndex = 1;
            // 
            // txtFindCT
            // 
            this.txtFindCT.BaseColor = System.Drawing.Color.White;
            this.txtFindCT.BorderColor = System.Drawing.Color.Silver;
            this.txtFindCT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindCT.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFindCT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFindCT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFindCT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFindCT.Location = new System.Drawing.Point(32, 63);
            this.txtFindCT.Margin = new System.Windows.Forms.Padding(4);
            this.txtFindCT.Name = "txtFindCT";
            this.txtFindCT.PasswordChar = '\0';
            this.txtFindCT.SelectedText = "";
            this.txtFindCT.Size = new System.Drawing.Size(343, 37);
            this.txtFindCT.TabIndex = 11;
            // 
            // btnLoad
            // 
            this.btnLoad.AnimationHoverSpeed = 0.07F;
            this.btnLoad.AnimationSpeed = 0.03F;
            this.btnLoad.BaseColor = System.Drawing.Color.Silver;
            this.btnLoad.BorderColor = System.Drawing.Color.Black;
            this.btnLoad.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLoad.FocusedColor = System.Drawing.Color.Empty;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Image = global::BTL_OOP_N17.Properties.Resources.exchange;
            this.btnLoad.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLoad.Location = new System.Drawing.Point(388, 15);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLoad.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLoad.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLoad.OnHoverImage = null;
            this.btnLoad.OnPressedColor = System.Drawing.Color.Black;
            this.btnLoad.Size = new System.Drawing.Size(104, 34);
            this.btnLoad.TabIndex = 43;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // MuonTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 798);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.gunaGroupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MuonTS";
            this.Text = "MuonTS";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chuaduyetGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daduyetGridView1)).EndInit();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctpmGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btn_Delete;
        private Guna.UI.WinForms.GunaButton btn_Edit;
        private Guna.UI.WinForms.GunaButton btn_Add;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.DataGridView daduyetGridView1;
        private Guna.UI.WinForms.GunaTextBox txt_TimKiem;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btn_Find;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView chuaduyetGridView3;
        private Guna.UI.WinForms.GunaTextBox txt_TimKiem1;
        private Guna.UI.WinForms.GunaButton btn_Find2;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaButton btnFindCT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ctpmGridView2;
        private Guna.UI.WinForms.GunaTextBox txtFindCT;
        private Guna.UI.WinForms.GunaButton btnLoad;
    }
}