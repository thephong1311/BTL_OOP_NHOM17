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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartTKMuaTS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chartTKMuaTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTKMuaTS
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTKMuaTS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTKMuaTS.Legends.Add(legend1);
            this.chartTKMuaTS.Location = new System.Drawing.Point(16, 15);
            this.chartTKMuaTS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartTKMuaTS.Name = "chartTKMuaTS";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Số yêu cầu mua";
            this.chartTKMuaTS.Series.Add(series1);
            this.chartTKMuaTS.Size = new System.Drawing.Size(536, 369);
            this.chartTKMuaTS.TabIndex = 2;
            this.chartTKMuaTS.Text = "chartTKMuaTS";
            title1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "THỐNG KÊ MUA YÊU CẦU MUA THEO THỜI GIAN ";
            this.chartTKMuaTS.Titles.Add(title1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(583, 116);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(320, 185);
            this.dataGridView1.TabIndex = 3;
            // 
            // ChartMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 469);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chartTKMuaTS);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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