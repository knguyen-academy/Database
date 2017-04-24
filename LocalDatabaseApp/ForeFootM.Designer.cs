namespace LocalDatabaseApp
{
    partial class ForeFootM
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
            this.ForeFootMChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ForeFootMChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ForeFootMChart
            // 
            this.ForeFootMChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Title = "Time (ms)";
            chartArea1.AxisY.Title = "Pressure (N)";
            chartArea1.Name = "ChartArea1";
            this.ForeFootMChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ForeFootMChart.Legends.Add(legend1);
            this.ForeFootMChart.Location = new System.Drawing.Point(14, 9);
            this.ForeFootMChart.Name = "ForeFootMChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "ForeFootM";
            this.ForeFootMChart.Series.Add(series1);
            this.ForeFootMChart.Size = new System.Drawing.Size(873, 237);
            this.ForeFootMChart.TabIndex = 11;
            this.ForeFootMChart.Text = "ForeFootMChart";
            title1.Name = "ForeFootMid";
            title1.Text = "Fore Foot Mid";
            this.ForeFootMChart.Titles.Add(title1);
            // 
            // ForeFootM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 254);
            this.Controls.Add(this.ForeFootMChart);
            this.Name = "ForeFootM";
            this.Text = "ForeFootM";
            ((System.ComponentModel.ISupportInitialize)(this.ForeFootMChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ForeFootMChart;
    }
}