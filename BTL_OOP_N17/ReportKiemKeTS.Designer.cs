namespace BTL_OOP_N17
{
    partial class ReportKiemKeTS
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
            this.gbBaocaoPTN = new Guna.UI.WinForms.GunaGroupBox();
            this.gbBaocaoTgian = new Guna.UI.WinForms.GunaGroupBox();
            this.gbIntatca = new Guna.UI.WinForms.GunaGroupBox();
            this.cbbPTN = new System.Windows.Forms.ComboBox();
            this.btnBaocaotheoPTN = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaDateTimePicker1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaDateTimePicker2 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btnBaocaotheotgian = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reportDocument1 = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            this.gbBaocaoPTN.SuspendLayout();
            this.gbBaocaoTgian.SuspendLayout();
            this.gbIntatca.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBaocaoPTN
            // 
            this.gbBaocaoPTN.BackColor = System.Drawing.Color.Transparent;
            this.gbBaocaoPTN.BaseColor = System.Drawing.Color.Gainsboro;
            this.gbBaocaoPTN.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbBaocaoPTN.Controls.Add(this.btnBaocaotheoPTN);
            this.gbBaocaoPTN.Controls.Add(this.cbbPTN);
            this.gbBaocaoPTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBaocaoPTN.LineColor = System.Drawing.Color.DarkGray;
            this.gbBaocaoPTN.Location = new System.Drawing.Point(23, 13);
            this.gbBaocaoPTN.Name = "gbBaocaoPTN";
            this.gbBaocaoPTN.Size = new System.Drawing.Size(372, 107);
            this.gbBaocaoPTN.TabIndex = 0;
            this.gbBaocaoPTN.Text = "Báo cáo theo phòng thí nghiệm ";
            this.gbBaocaoPTN.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gbBaocaoTgian
            // 
            this.gbBaocaoTgian.BackColor = System.Drawing.Color.Transparent;
            this.gbBaocaoTgian.BaseColor = System.Drawing.Color.Gainsboro;
            this.gbBaocaoTgian.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbBaocaoTgian.Controls.Add(this.btnBaocaotheotgian);
            this.gbBaocaoTgian.Controls.Add(this.gunaDateTimePicker2);
            this.gbBaocaoTgian.Controls.Add(this.label1);
            this.gbBaocaoTgian.Controls.Add(this.gunaDateTimePicker1);
            this.gbBaocaoTgian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBaocaoTgian.LineColor = System.Drawing.Color.DarkGray;
            this.gbBaocaoTgian.Location = new System.Drawing.Point(401, 12);
            this.gbBaocaoTgian.Name = "gbBaocaoTgian";
            this.gbBaocaoTgian.Size = new System.Drawing.Size(512, 107);
            this.gbBaocaoTgian.TabIndex = 1;
            this.gbBaocaoTgian.Text = "Báo cáo theo thời gian";
            this.gbBaocaoTgian.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gbIntatca
            // 
            this.gbIntatca.BackColor = System.Drawing.Color.Transparent;
            this.gbIntatca.BaseColor = System.Drawing.Color.Gainsboro;
            this.gbIntatca.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbIntatca.Controls.Add(this.gunaAdvenceButton2);
            this.gbIntatca.Controls.Add(this.gunaAdvenceButton1);
            this.gbIntatca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIntatca.LineColor = System.Drawing.Color.DarkGray;
            this.gbIntatca.Location = new System.Drawing.Point(919, 13);
            this.gbIntatca.Name = "gbIntatca";
            this.gbIntatca.Size = new System.Drawing.Size(382, 107);
            this.gbIntatca.TabIndex = 2;
            this.gbIntatca.Text = "In tất cả";
            this.gbIntatca.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // cbbPTN
            // 
            this.cbbPTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPTN.FormattingEnabled = true;
            this.cbbPTN.Location = new System.Drawing.Point(17, 54);
            this.cbbPTN.Name = "cbbPTN";
            this.cbbPTN.Size = new System.Drawing.Size(189, 26);
            this.cbbPTN.TabIndex = 0;
            this.cbbPTN.Text = "Chọn phòng thí nghiệm...";
            // 
            // btnBaocaotheoPTN
            // 
            this.btnBaocaotheoPTN.AnimationHoverSpeed = 0.07F;
            this.btnBaocaotheoPTN.AnimationSpeed = 0.03F;
            this.btnBaocaotheoPTN.BaseColor = System.Drawing.Color.White;
            this.btnBaocaotheoPTN.BorderColor = System.Drawing.Color.Black;
            this.btnBaocaotheoPTN.BorderSize = 1;
            this.btnBaocaotheoPTN.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBaocaotheoPTN.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBaocaotheoPTN.CheckedForeColor = System.Drawing.Color.White;
            this.btnBaocaotheoPTN.CheckedImage = null;
            this.btnBaocaotheoPTN.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBaocaotheoPTN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBaocaotheoPTN.FocusedColor = System.Drawing.Color.Empty;
            this.btnBaocaotheoPTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaocaotheoPTN.ForeColor = System.Drawing.Color.Black;
            this.btnBaocaotheoPTN.Image = null;
            this.btnBaocaotheoPTN.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBaocaotheoPTN.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBaocaotheoPTN.Location = new System.Drawing.Point(212, 54);
            this.btnBaocaotheoPTN.Name = "btnBaocaotheoPTN";
            this.btnBaocaotheoPTN.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBaocaotheoPTN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBaocaotheoPTN.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBaocaotheoPTN.OnHoverImage = null;
            this.btnBaocaotheoPTN.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBaocaotheoPTN.OnPressedColor = System.Drawing.Color.Black;
            this.btnBaocaotheoPTN.Size = new System.Drawing.Size(150, 25);
            this.btnBaocaotheoPTN.TabIndex = 1;
            this.btnBaocaotheoPTN.Text = "Báo cáo theo PTN";
            // 
            // gunaDateTimePicker1
            // 
            this.gunaDateTimePicker1.BaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.BorderColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.BorderSize = 1;
            this.gunaDateTimePicker1.CustomFormat = null;
            this.gunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDateTimePicker1.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.gunaDateTimePicker1.Location = new System.Drawing.Point(19, 55);
            this.gunaDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePicker1.Name = "gunaDateTimePicker1";
            this.gunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Size = new System.Drawing.Size(134, 25);
            this.gunaDateTimePicker1.TabIndex = 0;
            this.gunaDateTimePicker1.Text = "29/12/2023";
            this.gunaDateTimePicker1.Value = new System.DateTime(2023, 12, 29, 17, 13, 41, 300);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "đến ";
            // 
            // gunaDateTimePicker2
            // 
            this.gunaDateTimePicker2.BaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker2.BorderColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker2.BorderSize = 1;
            this.gunaDateTimePicker2.CustomFormat = null;
            this.gunaDateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePicker2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDateTimePicker2.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.gunaDateTimePicker2.Location = new System.Drawing.Point(193, 55);
            this.gunaDateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePicker2.Name = "gunaDateTimePicker2";
            this.gunaDateTimePicker2.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker2.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker2.Size = new System.Drawing.Size(135, 26);
            this.gunaDateTimePicker2.TabIndex = 2;
            this.gunaDateTimePicker2.Text = "29/12/2023";
            this.gunaDateTimePicker2.Value = new System.DateTime(2023, 12, 29, 17, 13, 41, 300);
            // 
            // btnBaocaotheotgian
            // 
            this.btnBaocaotheotgian.AnimationHoverSpeed = 0.07F;
            this.btnBaocaotheotgian.AnimationSpeed = 0.03F;
            this.btnBaocaotheotgian.BaseColor = System.Drawing.Color.White;
            this.btnBaocaotheotgian.BorderColor = System.Drawing.Color.Black;
            this.btnBaocaotheotgian.BorderSize = 1;
            this.btnBaocaotheotgian.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBaocaotheotgian.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBaocaotheotgian.CheckedForeColor = System.Drawing.Color.White;
            this.btnBaocaotheotgian.CheckedImage = null;
            this.btnBaocaotheotgian.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBaocaotheotgian.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBaocaotheotgian.FocusedColor = System.Drawing.Color.Empty;
            this.btnBaocaotheotgian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaocaotheotgian.ForeColor = System.Drawing.Color.Black;
            this.btnBaocaotheotgian.Image = null;
            this.btnBaocaotheotgian.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBaocaotheotgian.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBaocaotheotgian.Location = new System.Drawing.Point(334, 55);
            this.btnBaocaotheotgian.Name = "btnBaocaotheotgian";
            this.btnBaocaotheotgian.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBaocaotheotgian.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBaocaotheotgian.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBaocaotheotgian.OnHoverImage = null;
            this.btnBaocaotheotgian.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBaocaotheotgian.OnPressedColor = System.Drawing.Color.Black;
            this.btnBaocaotheotgian.Size = new System.Drawing.Size(163, 25);
            this.btnBaocaotheotgian.TabIndex = 2;
            this.btnBaocaotheotgian.Text = "Báo cáo theo thời gian ";
            this.btnBaocaotheotgian.Click += new System.EventHandler(this.BtnBaocaotheotgian_Click);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.BorderSize = 1;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = null;
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Image = null;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(15, 55);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(223, 25);
            this.gunaAdvenceButton1.TabIndex = 3;
            this.gunaAdvenceButton1.Text = "Báo cáo theo thời gian và PTN";
            // 
            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.BorderSize = 1;
            this.gunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.CheckedImage = null;
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.Image = null;
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(244, 54);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(123, 26);
            this.gunaAdvenceButton2.TabIndex = 4;
            this.gunaAdvenceButton2.Text = "Báo cáo tất cả";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(23, 127);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1278, 502);
            this.crystalReportViewer1.TabIndex = 3;
            // 
            // ReportKiemKeTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 629);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.gbIntatca);
            this.Controls.Add(this.gbBaocaoTgian);
            this.Controls.Add(this.gbBaocaoPTN);
            this.Name = "ReportKiemKeTS";
            this.Text = "Báo cáo Kiểm kê";
            this.gbBaocaoPTN.ResumeLayout(false);
            this.gbBaocaoTgian.ResumeLayout(false);
            this.gbBaocaoTgian.PerformLayout();
            this.gbIntatca.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gbBaocaoPTN;
        private Guna.UI.WinForms.GunaGroupBox gbBaocaoTgian;
        private Guna.UI.WinForms.GunaGroupBox gbIntatca;
        private System.Windows.Forms.ComboBox cbbPTN;
        private Guna.UI.WinForms.GunaAdvenceButton btnBaocaotheoPTN;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePicker1;
        private Guna.UI.WinForms.GunaAdvenceButton btnBaocaotheotgian;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePicker2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument1;
    }
}