namespace BTL_OOP_N17
{
    partial class TonghopYCmua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TonghopYCmua));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.licensing1 = new Guna.UI.Licensing.Licensing();
            this.btn_Close = new Guna.UI.WinForms.GunaButton();
            this.btn_Edit = new Guna.UI.WinForms.GunaButton();
            this.btn_Add = new Guna.UI.WinForms.GunaButton();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Clear);
            this.groupBox1.Controls.Add(this.btn_Find);
            this.groupBox1.Controls.Add(this.txt_Input);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(743, 301);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng hợp yêu cầu mua tài sản ";
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(338, 25);
            this.btn_Find.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(56, 26);
            this.btn_Find.TabIndex = 2;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = true;
            // 
            // txt_Input
            // 
            this.txt_Input.Location = new System.Drawing.Point(14, 25);
            this.txt_Input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(296, 26);
            this.txt_Input.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 56);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(700, 241);
            this.dataGridView1.TabIndex = 0;
            // 
            // licensing1
            // 
            this.licensing1.BackColor = System.Drawing.Color.White;
            this.licensing1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.licensing1.Location = new System.Drawing.Point(0, 0);
            this.licensing1.Margin = new System.Windows.Forms.Padding(4);
            this.licensing1.MaximumSize = new System.Drawing.Size(464, 597);
            this.licensing1.MinimumSize = new System.Drawing.Size(464, 597);
            this.licensing1.Name = "licensing1";
            this.licensing1.Size = new System.Drawing.Size(464, 597);
            this.licensing1.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.AnimationHoverSpeed = 0.07F;
            this.btn_Close.AnimationSpeed = 0.03F;
            this.btn_Close.BaseColor = System.Drawing.SystemColors.Menu;
            this.btn_Close.BorderColor = System.Drawing.Color.Black;
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Close.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Black;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Close.Location = new System.Drawing.Point(266, 25);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Close.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Close.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Close.OnHoverImage = null;
            this.btn_Close.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Close.Size = new System.Drawing.Size(82, 19);
            this.btn_Close.TabIndex = 14;
            this.btn_Close.Text = "Đóng ";
            this.btn_Close.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.AnimationHoverSpeed = 0.07F;
            this.btn_Edit.AnimationSpeed = 0.03F;
            this.btn_Edit.BaseColor = System.Drawing.SystemColors.Menu;
            this.btn_Edit.BorderColor = System.Drawing.Color.Black;
            this.btn_Edit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Edit.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.Black;
            this.btn_Edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.Image")));
            this.btn_Edit.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Edit.Location = new System.Drawing.Point(140, 23);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Edit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Edit.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Edit.OnHoverImage = null;
            this.btn_Edit.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Edit.Size = new System.Drawing.Size(107, 19);
            this.btn_Edit.TabIndex = 11;
            this.btn_Edit.Text = "Chỉnh sửa";
            this.btn_Edit.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.AnimationHoverSpeed = 0.07F;
            this.btn_Add.AnimationSpeed = 0.03F;
            this.btn_Add.BaseColor = System.Drawing.SystemColors.Menu;
            this.btn_Add.BorderColor = System.Drawing.Color.Black;
            this.btn_Add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Add.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Black;
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Add.Location = new System.Drawing.Point(24, 23);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Add.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Add.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Add.OnHoverImage = null;
            this.btn_Add.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Add.Size = new System.Drawing.Size(112, 19);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "Thêm mới";
            this.btn_Add.Click += new System.EventHandler(this.gunaButton5_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(418, 26);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(56, 26);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // TonghopYCmua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 366);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Edit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TonghopYCmua";
            this.Text = "Tổng hợp yêu cầu mua";
            this.Load += new System.EventHandler(this.TonghopYCmua_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.Licensing.Licensing licensing1;
        private Guna.UI.WinForms.GunaButton btn_Close;
        private Guna.UI.WinForms.GunaButton btn_Edit;
        private Guna.UI.WinForms.GunaButton btn_Add;
        private System.Windows.Forms.Button btn_Clear;
    }
}