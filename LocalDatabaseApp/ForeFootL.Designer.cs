namespace LocalDatabaseApp
{
    partial class ForeFootL
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ForeFootLChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ForeFootLChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ForeFootLChart
            // 
            this.ForeFootLChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.AxisX.Title = "Time (ms)";
            chartArea5.AxisY.Title = "Pressure (N)";
            chartArea5.Name = "ChartArea1";
            this.ForeFootLChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.ForeFootLChart.Legends.Add(legend5);
            this.ForeFootLChart.Location = new System.Drawing.Point(12, 12);
            this.ForeFootLChart.Name = "ForeFootLChart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "ForeFootL";
            this.ForeFootLChart.Series.Add(series5);
            this.ForeFootLChart.Size = new System.Drawing.Size(873, 237);
            this.ForeFootLChart.TabIndex = 10;
            this.ForeFootLChart.Text = "ForeFootLChart";
            title5.Name = "ForeFootLeft";
            title5.Text = "Fore Foot Left";
            this.ForeFootLChart.Titles.Add(title5);
            // 
            // ForeFootL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 261);
            this.Controls.Add(this.ForeFootLChart);
            this.Name = "ForeFootL";
            this.Text = "ForeFootL";
            ((System.ComponentModel.ISupportInitialize)(this.ForeFootLChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ForeFootLChart;
    }
}