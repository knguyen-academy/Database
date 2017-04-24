namespace LocalDatabaseApp
{
    partial class Heel
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
            this.HeelChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.HeelChart)).BeginInit();
            this.SuspendLayout();
            // 
            // HeelChart
            // 
            this.HeelChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Title = "Time (ms)";
            chartArea1.AxisY.Title = "Pressure (N)";
            chartArea1.Name = "ChartArea1";
            this.HeelChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.HeelChart.Legends.Add(legend1);
            this.HeelChart.Location = new System.Drawing.Point(12, 12);
            this.HeelChart.Name = "HeelChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Heel";
            this.HeelChart.Series.Add(series1);
            this.HeelChart.Size = new System.Drawing.Size(873, 237);
            this.HeelChart.TabIndex = 11;
            this.HeelChart.Text = "HeelChart";
            title1.Name = "Heel";
            title1.Text = "Heel";
            this.HeelChart.Titles.Add(title1);
            // 
            // Heel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 261);
            this.Controls.Add(this.HeelChart);
            this.Name = "Heel";
            this.Text = "Heel";
            ((System.ComponentModel.ISupportInitialize)(this.HeelChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart HeelChart;
    }
}