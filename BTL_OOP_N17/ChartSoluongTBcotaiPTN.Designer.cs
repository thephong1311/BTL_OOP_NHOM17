namespace BTL_OOP_N17
{
    partial class ChartSoluongTBcotaiPTN
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chartSLTBtaiPTN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSLTBtaiPTN)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(480, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // chartSLTBtaiPTN
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSLTBtaiPTN.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSLTBtaiPTN.Legends.Add(legend1);
            this.chartSLTBtaiPTN.Location = new System.Drawing.Point(521, 26);
            this.chartSLTBtaiPTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartSLTBtaiPTN.Name = "chartSLTBtaiPTN";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSLTBtaiPTN.Series.Add(series1);
            this.chartSLTBtaiPTN.Size = new System.Drawing.Size(461, 351);
            this.chartSLTBtaiPTN.TabIndex = 1;
            this.chartSLTBtaiPTN.Text = "Chart thống kê số lượng thiết bị có tại PTN";
            // 
            // ChartSoluongTBcotaiPTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 497);
            this.Controls.Add(this.chartSLTBtaiPTN);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChartSoluongTBcotaiPTN";
            this.Text = "ChartGV";
            this.Load += new System.EventHandler(this.ChartSoluongTBcotaiPTN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSLTBtaiPTN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSLTBtaiPTN;
    }
}