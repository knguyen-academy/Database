namespace LocalDatabaseApp
{
    partial class ForeFootR
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
            this.ForeFootRChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ForeFootRChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ForeFootRChart
            // 
            this.ForeFootRChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Title = "Time (ms)";
            chartArea1.AxisY.Title = "Pressure (N)";
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.ForeFootRChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ForeFootRChart.Legends.Add(legend1);
            this.ForeFootRChart.Location = new System.Drawing.Point(13, 12);
            this.ForeFootRChart.Name = "ForeFootRChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "ForeFootR";
            this.ForeFootRChart.Series.Add(series1);
            this.ForeFootRChart.Size = new System.Drawing.Size(873, 237);
            this.ForeFootRChart.TabIndex = 11;
            this.ForeFootRChart.Text = "ForeFootRChart";
            title1.Name = "ForeFootRight";
            title1.Text = "Fore Foot Right";
            this.ForeFootRChart.Titles.Add(title1);
            // 
            // ForeFootR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 261);
            this.Controls.Add(this.ForeFootRChart);
            this.Name = "ForeFootR";
            this.Text = "ForeFootR";
            ((System.ComponentModel.ISupportInitialize)(this.ForeFootRChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ForeFootRChart;
    }
}