namespace BTL_OOP_N17
{
    partial class ReportYCmua
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbBCtheoPTN = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btn_bcPTN = new Guna.UI.WinForms.GunaButton();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbBCtheoTG = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_BCtheoTG = new Guna.UI.WinForms.GunaButton();
            this.gbIn = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btn_All = new Guna.UI.WinForms.GunaButton();
            this.btn_PTN_TG = new Guna.UI.WinForms.GunaButton();
            this.gbBCtheoPTN.SuspendLayout();
            this.gbBCtheoTG.SuspendLayout();
            this.gbIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(29, 102);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(983, 255);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // gbBCtheoPTN
            // 
            this.gbBCtheoPTN.Controls.Add(this.btn_bcPTN);
            this.gbBCtheoPTN.Controls.Add(this.guna2TextBox1);
            this.gbBCtheoPTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBCtheoPTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbBCtheoPTN.Location = new System.Drawing.Point(26, 12);
            this.gbBCtheoPTN.Name = "gbBCtheoPTN";
            this.gbBCtheoPTN.Size = new System.Drawing.Size(227, 84);
            this.gbBCtheoPTN.TabIndex = 1;
            this.gbBCtheoPTN.Text = "Báo cáo theo phòng thí nghiệm";
            // 
            // btn_bcPTN
            // 
            this.btn_bcPTN.AnimationHoverSpeed = 0.07F;
            this.btn_bcPTN.AnimationSpeed = 0.03F;
            this.btn_bcPTN.BaseColor = System.Drawing.Color.Silver;
            this.btn_bcPTN.BorderColor = System.Drawing.Color.Black;
            this.btn_bcPTN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_bcPTN.FocusedColor = System.Drawing.Color.Empty;
            this.btn_bcPTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bcPTN.ForeColor = System.Drawing.Color.Black;
            this.btn_bcPTN.Image = null;
            this.btn_bcPTN.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_bcPTN.Location = new System.Drawing.Point(141, 49);
            this.btn_bcPTN.Name = "btn_bcPTN";
            this.btn_bcPTN.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_bcPTN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_bcPTN.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_bcPTN.OnHoverImage = null;
            this.btn_bcPTN.OnPressedColor = System.Drawing.Color.Black;
            this.btn_bcPTN.Size = new System.Drawing.Size(78, 23);
            this.btn_bcPTN.TabIndex = 28;
            this.btn_bcPTN.Text = "BC theo PTN";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(3, 49);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(132, 23);
            this.guna2TextBox1.TabIndex = 0;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // gbBCtheoTG
            // 
            this.gbBCtheoTG.Controls.Add(this.label2);
            this.gbBCtheoTG.Controls.Add(this.dateTimePicker2);
            this.gbBCtheoTG.Controls.Add(this.dateTimePicker1);
            this.gbBCtheoTG.Controls.Add(this.btn_BCtheoTG);
            this.gbBCtheoTG.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBCtheoTG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbBCtheoTG.Location = new System.Drawing.Point(259, 12);
            this.gbBCtheoTG.Name = "gbBCtheoTG";
            this.gbBCtheoTG.Size = new System.Drawing.Size(614, 84);
            this.gbBCtheoTG.TabIndex = 2;
            this.gbBCtheoTG.Text = "Báo cáo theo thời gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(239, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "đến";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(287, 47);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(223, 25);
            this.dateTimePicker2.TabIndex = 30;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(212, 25);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // btn_BCtheoTG
            // 
            this.btn_BCtheoTG.AnimationHoverSpeed = 0.07F;
            this.btn_BCtheoTG.AnimationSpeed = 0.03F;
            this.btn_BCtheoTG.BaseColor = System.Drawing.Color.Silver;
            this.btn_BCtheoTG.BorderColor = System.Drawing.Color.Black;
            this.btn_BCtheoTG.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_BCtheoTG.FocusedColor = System.Drawing.Color.Empty;
            this.btn_BCtheoTG.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BCtheoTG.ForeColor = System.Drawing.Color.Black;
            this.btn_BCtheoTG.Image = null;
            this.btn_BCtheoTG.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_BCtheoTG.Location = new System.Drawing.Point(516, 49);
            this.btn_BCtheoTG.Name = "btn_BCtheoTG";
            this.btn_BCtheoTG.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_BCtheoTG.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_BCtheoTG.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_BCtheoTG.OnHoverImage = null;
            this.btn_BCtheoTG.OnPressedColor = System.Drawing.Color.Black;
            this.btn_BCtheoTG.Size = new System.Drawing.Size(78, 23);
            this.btn_BCtheoTG.TabIndex = 28;
            this.btn_BCtheoTG.Text = "BC theo TG";
            // 
            // gbIn
            // 
            this.gbIn.Controls.Add(this.btn_All);
            this.gbIn.Controls.Add(this.btn_PTN_TG);
            this.gbIn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbIn.Location = new System.Drawing.Point(879, 12);
            this.gbIn.Name = "gbIn";
            this.gbIn.Size = new System.Drawing.Size(206, 84);
            this.gbIn.TabIndex = 3;
            this.gbIn.Text = "In tất cả";
            // 
            // btn_All
            // 
            this.btn_All.AnimationHoverSpeed = 0.07F;
            this.btn_All.AnimationSpeed = 0.03F;
            this.btn_All.BaseColor = System.Drawing.Color.Silver;
            this.btn_All.BorderColor = System.Drawing.Color.Black;
            this.btn_All.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_All.FocusedColor = System.Drawing.Color.Empty;
            this.btn_All.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_All.ForeColor = System.Drawing.Color.Black;
            this.btn_All.Image = null;
            this.btn_All.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_All.Location = new System.Drawing.Point(139, 49);
            this.btn_All.Name = "btn_All";
            this.btn_All.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_All.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_All.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_All.OnHoverImage = null;
            this.btn_All.OnPressedColor = System.Drawing.Color.Black;
            this.btn_All.Size = new System.Drawing.Size(62, 23);
            this.btn_All.TabIndex = 29;
            this.btn_All.Text = "BC tất cả";
            // 
            // btn_PTN_TG
            // 
            this.btn_PTN_TG.AnimationHoverSpeed = 0.07F;
            this.btn_PTN_TG.AnimationSpeed = 0.03F;
            this.btn_PTN_TG.BaseColor = System.Drawing.Color.Silver;
            this.btn_PTN_TG.BorderColor = System.Drawing.Color.Black;
            this.btn_PTN_TG.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_PTN_TG.FocusedColor = System.Drawing.Color.Empty;
            this.btn_PTN_TG.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PTN_TG.ForeColor = System.Drawing.Color.Black;
            this.btn_PTN_TG.Image = null;
            this.btn_PTN_TG.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_PTN_TG.Location = new System.Drawing.Point(8, 49);
            this.btn_PTN_TG.Name = "btn_PTN_TG";
            this.btn_PTN_TG.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_PTN_TG.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_PTN_TG.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_PTN_TG.OnHoverImage = null;
            this.btn_PTN_TG.OnPressedColor = System.Drawing.Color.Black;
            this.btn_PTN_TG.Size = new System.Drawing.Size(128, 23);
            this.btn_PTN_TG.TabIndex = 28;
            this.btn_PTN_TG.Text = "BC theo PTN và TG";
            // 
            // ReportYCmua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 450);
            this.Controls.Add(this.gbIn);
            this.Controls.Add(this.gbBCtheoTG);
            this.Controls.Add(this.gbBCtheoPTN);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportYCmua";
            this.Text = "ReportYCmua";
            this.Load += new System.EventHandler(this.ReportYCmua_Load);
            this.gbBCtheoPTN.ResumeLayout(false);
            this.gbBCtheoTG.ResumeLayout(false);
            this.gbBCtheoTG.PerformLayout();
            this.gbIn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2GroupBox gbBCtheoPTN;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI.WinForms.GunaButton btn_bcPTN;
        private Guna.UI2.WinForms.Guna2GroupBox gbBCtheoTG;
        private Guna.UI.WinForms.GunaButton btn_BCtheoTG;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GroupBox gbIn;
        private Guna.UI.WinForms.GunaButton btn_All;
        private Guna.UI.WinForms.GunaButton btn_PTN_TG;
    }
}