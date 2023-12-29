namespace BTL_OOP_N17
{
    partial class LapDSThietBi
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
            this.reportDocument1 = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            this.ReportThietBi = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reportDocument1
            // 
            this.reportDocument1.InitReport += new System.EventHandler(this.reportDocument1_InitReport);
            // 
            // ReportThietBi
            // 
            this.ReportThietBi.ActiveViewIndex = -1;
            this.ReportThietBi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportThietBi.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportThietBi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportThietBi.Location = new System.Drawing.Point(0, 0);
            this.ReportThietBi.Name = "ReportThietBi";
            this.ReportThietBi.Size = new System.Drawing.Size(800, 450);
            this.ReportThietBi.TabIndex = 0;
            // 
            // LapDSThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReportThietBi);
            this.Name = "LapDSThietBi";
            this.Text = "Báo cáo theo dõi tài sản ";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportThietBi;
    }
}