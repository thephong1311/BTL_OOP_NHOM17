namespace BTL_OOP_N17
{
    partial class ChartTKMuon
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartTKMuonTS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTKMuonTS)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTKMuonTS
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTKMuonTS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTKMuonTS.Legends.Add(legend1);
            this.chartTKMuonTS.Location = new System.Drawing.Point(1, -1);
            this.chartTKMuonTS.Name = "chartTKMuonTS";
            this.chartTKMuonTS.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.chartTKMuonTS.Size = new System.Drawing.Size(883, 560);
            this.chartTKMuonTS.TabIndex = 0;
            this.chartTKMuonTS.Text = "chartTKMuonTS";
            title1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.IndianRed;
            title1.Name = "title1";
            title1.Text = "THỐNG KÊ MƯỢN TÀI SẢN TẠI CÁC PHÒNG THÍ NGHIỆM";
            this.chartTKMuonTS.Titles.Add(title1);
            // 
            // ChartTKMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 556);
            this.Controls.Add(this.chartTKMuonTS);
            this.Name = "ChartTKMuon";
            this.Text = "ChartTKMuon";
            this.Load += new System.EventHandler(this.ChartTKMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTKMuonTS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTKMuonTS;
    }
}