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
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ForeFootLChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MidFootLChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ForeFootRChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Exit_button = new System.Windows.Forms.Button();
            this.AllGraphChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RearFootLChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ThumbChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Acceleration_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ForeFootLChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MidFootLChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForeFootRChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllGraphChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RearFootLChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ForeFootLChart
            // 
            this.ForeFootLChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea1.AxisX.Title = "Time";
            chartArea1.AxisY.Title = "Pressure";
            chartArea1.Name = "ChartArea1";
            this.ForeFootLChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ForeFootLChart.Legends.Add(legend1);
            this.ForeFootLChart.Location = new System.Drawing.Point(12, 171);
            this.ForeFootLChart.Name = "ForeFootLChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "ForeFootL";
            series1.YValuesPerPoint = 2;
            this.ForeFootLChart.Series.Add(series1);
            this.ForeFootLChart.Size = new System.Drawing.Size(1372, 153);
            this.ForeFootLChart.TabIndex = 0;
            this.ForeFootLChart.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Fore Foot - Left";
            this.ForeFootLChart.Titles.Add(title1);
            // 
            // MidFootLChart
            // 
            this.MidFootLChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea2.AxisX.Title = "Time";
            chartArea2.AxisY.Title = "Pressure";
            chartArea2.Name = "ChartArea1";
            this.MidFootLChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.MidFootLChart.Legends.Add(legend2);
            this.MidFootLChart.Location = new System.Drawing.Point(12, 330);
            this.MidFootLChart.Name = "MidFootLChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "MidFootL";
            this.MidFootLChart.Series.Add(series2);
            this.MidFootLChart.Size = new System.Drawing.Size(693, 153);
            this.MidFootLChart.TabIndex = 1;
            this.MidFootLChart.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "Mid Foot - Left";
            this.MidFootLChart.Titles.Add(title2);
            // 
            // ForeFootRChart
            // 
            this.ForeFootRChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea3.AxisX.Title = "Time";
            chartArea3.AxisY.Title = "Pressure";
            chartArea3.Name = "ChartArea1";
            this.ForeFootRChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ForeFootRChart.Legends.Add(legend3);
            this.ForeFootRChart.Location = new System.Drawing.Point(711, 330);
            this.ForeFootRChart.Name = "ForeFootRChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "ForeFootR";
            this.ForeFootRChart.Series.Add(series3);
            this.ForeFootRChart.Size = new System.Drawing.Size(673, 153);
            this.ForeFootRChart.TabIndex = 3;
            this.ForeFootRChart.Text = "chart4";
            title3.Name = "Title1";
            title3.Text = "Fore Foot - Right";
            this.ForeFootRChart.Titles.Add(title3);
            // 
            // Exit_button
            // 
            this.Exit_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit_button.Location = new System.Drawing.Point(24, 785);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(75, 23);
            this.Exit_button.TabIndex = 5;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // AllGraphChart
            // 
            this.AllGraphChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea4.AxisX.Title = "Time";
            chartArea4.AxisY.Title = "Pressure";
            chartArea4.Name = "ChartArea1";
            this.AllGraphChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.AllGraphChart.Legends.Add(legend4);
            this.AllGraphChart.Location = new System.Drawing.Point(119, 677);
            this.AllGraphChart.Name = "AllGraphChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "ForeFootL";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "ForeFootR";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "MidFootL";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "MidFootR";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "RearFootL";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Legend = "Legend1";
            series9.Name = "RearFootR";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "Thumb";
            this.AllGraphChart.Series.Add(series4);
            this.AllGraphChart.Series.Add(series5);
            this.AllGraphChart.Series.Add(series6);
            this.AllGraphChart.Series.Add(series7);
            this.AllGraphChart.Series.Add(series8);
            this.AllGraphChart.Series.Add(series9);
            this.AllGraphChart.Series.Add(series10);
            this.AllGraphChart.Size = new System.Drawing.Size(1265, 176);
            this.AllGraphChart.TabIndex = 2;
            this.AllGraphChart.Text = "chart3";
            title4.Name = "Title1";
            title4.Text = "All pressure graph";
            this.AllGraphChart.Titles.Add(title4);
            // 
            // RearFootLChart
            // 
            this.RearFootLChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea5.Name = "ChartArea1";
            this.RearFootLChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.RearFootLChart.Legends.Add(legend5);
            this.RearFootLChart.Location = new System.Drawing.Point(12, 489);
            this.RearFootLChart.Name = "RearFootLChart";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Legend = "Legend1";
            series11.Name = "RearFootL";
            this.RearFootLChart.Series.Add(series11);
            this.RearFootLChart.Size = new System.Drawing.Size(1372, 153);
            this.RearFootLChart.TabIndex = 7;
            this.RearFootLChart.Text = "chart1";
            title5.Name = "Title1";
            title5.Text = "Rear Foot - Left";
            this.RearFootLChart.Titles.Add(title5);
            // 
            // ThumbChart
            // 
            this.ThumbChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea6.Name = "ChartArea1";
            this.ThumbChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.ThumbChart.Legends.Add(legend6);
            this.ThumbChart.Location = new System.Drawing.Point(12, 12);
            this.ThumbChart.Name = "ThumbChart";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Legend = "Legend1";
            series12.Name = "Thumb";
            this.ThumbChart.Series.Add(series12);
            this.ThumbChart.Size = new System.Drawing.Size(1372, 153);
            this.ThumbChart.TabIndex = 8;
            this.ThumbChart.Text = "chart2";
            title6.Name = "Thumb";
            title6.Text = "Thumb ";
            this.ThumbChart.Titles.Add(title6);
            // 
            // Acceleration_button
            // 
            this.Acceleration_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Acceleration_button.Location = new System.Drawing.Point(24, 700);
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
            this.back_button.Location = new System.Drawing.Point(24, 740);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 11;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Graph_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 865);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.Acceleration_button);
            this.Controls.Add(this.ThumbChart);
            this.Controls.Add(this.RearFootLChart);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.ForeFootRChart);
            this.Controls.Add(this.AllGraphChart);
            this.Controls.Add(this.MidFootLChart);
            this.Controls.Add(this.ForeFootLChart);
            this.Name = "Graph_Form";
            this.Text = "Graph_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ForeFootLChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MidFootLChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForeFootRChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllGraphChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RearFootLChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ForeFootLChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart MidFootLChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ForeFootRChart;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.DataVisualization.Charting.Chart AllGraphChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart RearFootLChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ThumbChart;
        private System.Windows.Forms.Button Acceleration_button;
        private System.Windows.Forms.Button back_button;
    }
}