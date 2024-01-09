namespace BTL_OOP_N17
{
    partial class ChartMua
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartTKMuaTS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chartTKMuaTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTKMuaTS
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTKMuaTS.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTKMuaTS.Legends.Add(legend2);
            this.chartTKMuaTS.Location = new System.Drawing.Point(12, 12);
            this.chartTKMuaTS.Name = "chartTKMuaTS";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Số yêu cầu mua";
            this.chartTKMuaTS.Series.Add(series2);
            this.chartTKMuaTS.Size = new System.Drawing.Size(402, 300);
            this.chartTKMuaTS.TabIndex = 2;
            this.chartTKMuaTS.Text = "chartTKMuaTS";
            title2.Name = "Title1";
            title2.Text = "THỐNG KÊ MUA";
            this.chartTKMuaTS.Titles.Add(title2);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(437, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // ChartMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 381);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chartTKMuaTS);
            this.Name = "ChartMua";
            this.Text = "ChartMua";
            this.Load += new System.EventHandler(this.ChartMua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTKMuaTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTKMuaTS;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}