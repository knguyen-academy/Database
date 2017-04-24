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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ForeFootMChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ForeFootMChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ForeFootMChart
            // 
            this.ForeFootMChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.AxisX.Title = "Time (ms)";
            chartArea3.AxisY.Title = "Pressure (N)";
            chartArea3.Name = "ChartArea1";
            this.ForeFootMChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ForeFootMChart.Legends.Add(legend3);
            this.ForeFootMChart.Location = new System.Drawing.Point(14, 9);
            this.ForeFootMChart.Name = "ForeFootMChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "ForeFootM";
            this.ForeFootMChart.Series.Add(series3);
            this.ForeFootMChart.Size = new System.Drawing.Size(873, 237);
            this.ForeFootMChart.TabIndex = 11;
            this.ForeFootMChart.Text = "ForeFootMChart";
            title3.Name = "ForeFootMid";
            title3.Text = "Fore Foot Mid";
            this.ForeFootMChart.Titles.Add(title3);
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