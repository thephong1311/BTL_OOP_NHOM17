namespace BTL_OOP_N17
{
    partial class ChartSoTienTrongPTN
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartMoneyinLab = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chartMoneyinLab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMoneyinLab
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMoneyinLab.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMoneyinLab.Legends.Add(legend1);
            this.chartMoneyinLab.Location = new System.Drawing.Point(42, 12);
            this.chartMoneyinLab.Name = "chartMoneyinLab";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "đồng";
            this.chartMoneyinLab.Series.Add(series1);
            this.chartMoneyinLab.Size = new System.Drawing.Size(344, 320);
            this.chartMoneyinLab.TabIndex = 0;
            this.chartMoneyinLab.Text = "chartMoneyinLab";
            title1.Name = "title1";
            title1.Text = "THỐNG KÊ SỐ TIỀN TRONG PHÒNG THÍ NGHIỆM";
            this.chartMoneyinLab.Titles.Add(title1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(419, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 205);
            this.dataGridView1.TabIndex = 1;
            // 
            // ChartSoTienTrongPTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chartMoneyinLab);
            this.Name = "ChartSoTienTrongPTN";
            this.Text = "ChartSoTienTrongPTN";
            this.Load += new System.EventHandler(this.ChartSoTienTrongPTN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMoneyinLab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMoneyinLab;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}