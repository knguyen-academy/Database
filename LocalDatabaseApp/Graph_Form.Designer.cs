namespace LocalDatabaseApp
{
    partial class Graph_Form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ForeFootLChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ForeFootMChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Exit_button = new System.Windows.Forms.Button();
            this.ThumbChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Acceleration_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.ForeFootRChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HeelChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ForeFootLChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForeFootMChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForeFootRChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeelChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ForeFootLChart
            // 
            this.ForeFootLChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea1.AxisX.Title = "Time (ms)";
            chartArea1.AxisY.Title = "Pressure (N)";
            chartArea1.Name = "ChartArea1";
            this.ForeFootLChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ForeFootLChart.Legends.Add(legend1);
            this.ForeFootLChart.Location = new System.Drawing.Point(9, 160);
            this.ForeFootLChart.Name = "ForeFootLChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "ForeFootL";
            series1.YValuesPerPoint = 2;
            this.ForeFootLChart.Series.Add(series1);
            this.ForeFootLChart.Size = new System.Drawing.Size(1387, 143);
            this.ForeFootLChart.TabIndex = 0;
            this.ForeFootLChart.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Fore Foot - Left";
            this.ForeFootLChart.Titles.Add(title1);
            // 
            // ForeFootMChart
            // 
            this.ForeFootMChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea2.AxisX.Title = "Time (ms)";
            chartArea2.AxisY.Title = "Pressure (N)";
            chartArea2.Name = "ChartArea1";
            this.ForeFootMChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ForeFootMChart.Legends.Add(legend2);
            this.ForeFootMChart.Location = new System.Drawing.Point(9, 319);
            this.ForeFootMChart.Name = "ForeFootMChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "ForeFootM";
            this.ForeFootMChart.Series.Add(series2);
            this.ForeFootMChart.Size = new System.Drawing.Size(1387, 142);
            this.ForeFootMChart.TabIndex = 1;
            this.ForeFootMChart.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "Fore Foot - Mid";
            this.ForeFootMChart.Titles.Add(title2);
            // 
            // Exit_button
            // 
            this.Exit_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit_button.Location = new System.Drawing.Point(171, 796);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(75, 23);
            this.Exit_button.TabIndex = 5;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // ThumbChart
            // 
            this.ThumbChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea3.AxisX.Title = "Time (ms)";
            chartArea3.AxisY.Title = "Pressure (N)";
            chartArea3.Name = "ChartArea1";
            this.ThumbChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ThumbChart.Legends.Add(legend3);
            this.ThumbChart.Location = new System.Drawing.Point(9, 5);
            this.ThumbChart.Name = "ThumbChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Thumb";
            this.ThumbChart.Series.Add(series3);
            this.ThumbChart.Size = new System.Drawing.Size(1387, 143);
            this.ThumbChart.TabIndex = 8;
            this.ThumbChart.Text = "chart2";
            title3.Name = "Thumb";
            title3.Text = "Thumb ";
            this.ThumbChart.Titles.Add(title3);
            // 
            // Acceleration_button
            // 
            this.Acceleration_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Acceleration_button.Location = new System.Drawing.Point(9, 796);
            this.Acceleration_button.Name = "Acceleration_button";
            this.Acceleration_button.Size = new System.Drawing.Size(75, 23);
            this.Acceleration_button.TabIndex = 10;
            this.Acceleration_button.Text = "Acceleration";
            this.Acceleration_button.UseVisualStyleBackColor = true;
            this.Acceleration_button.Click += new System.EventHandler(this.Acceleration_button_Click);
            // 
            // back_button
            // 
            this.back_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back_button.Location = new System.Drawing.Point(90, 796);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 11;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // ForeFootRChart
            // 
            this.ForeFootRChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea4.AxisX.Title = "Time (ms)";
            chartArea4.AxisY.Title = "Pressure (N)";
            chartArea4.Name = "ChartArea1";
            this.ForeFootRChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.ForeFootRChart.Legends.Add(legend4);
            this.ForeFootRChart.Location = new System.Drawing.Point(9, 478);
            this.ForeFootRChart.Name = "ForeFootRChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "ForeFootR";
            this.ForeFootRChart.Series.Add(series4);
            this.ForeFootRChart.Size = new System.Drawing.Size(1387, 153);
            this.ForeFootRChart.TabIndex = 1;
            this.ForeFootRChart.Text = "chart2";
            title4.Name = "Title1";
            title4.Text = "Fore Foot - Right";
            this.ForeFootRChart.Titles.Add(title4);
            // 
            // HeelChart
            // 
            this.HeelChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea5.AxisX.Title = "Time (ms)";
            chartArea5.AxisY.Title = "Pressure (N)";
            chartArea5.Name = "ChartArea1";
            this.HeelChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.HeelChart.Legends.Add(legend5);
            this.HeelChart.Location = new System.Drawing.Point(9, 647);
            this.HeelChart.Name = "HeelChart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Heel";
            this.HeelChart.Series.Add(series5);
            this.HeelChart.Size = new System.Drawing.Size(1387, 143);
            this.HeelChart.TabIndex = 1;
            this.HeelChart.Text = "chart2";
            title5.Name = "Title1";
            title5.Text = "Heel";
            this.HeelChart.Titles.Add(title5);
            // 
            // Graph_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 865);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.Acceleration_button);
            this.Controls.Add(this.ThumbChart);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.HeelChart);
            this.Controls.Add(this.ForeFootRChart);
            this.Controls.Add(this.ForeFootMChart);
            this.Controls.Add(this.ForeFootLChart);
            this.Name = "Graph_Form";
            this.Text = "Graph_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ForeFootLChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForeFootMChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForeFootRChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeelChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ForeFootLChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ForeFootMChart;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.DataVisualization.Charting.Chart ThumbChart;
        private System.Windows.Forms.Button Acceleration_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.DataVisualization.Charting.Chart ForeFootRChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart HeelChart;
    }
}