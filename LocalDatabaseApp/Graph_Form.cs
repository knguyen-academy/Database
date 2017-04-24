using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace LocalDatabaseApp
{
    public partial class Graph_Form : Form
    {
        StreamReader ForeFootMid_file = new StreamReader("C:\\Users\\knguyen\\Desktop\\out0.txt");
        StreamReader ForeFootRight_file = new StreamReader("C:\\Users\\knguyen\\Desktop\\out1.txt");
        StreamReader ForeFootLeft_file = new StreamReader("C:\\Users\\knguyen\\Desktop\\out2.txt");
        StreamReader Heel_file = new StreamReader("C:\\Users\\knguyen\\Desktop\\out3.txt");
        StreamReader Thumb_file = new StreamReader("C:\\Users\\knguyen\\Desktop\\out4.txt");
        public Graph_Form()
        {
            InitializeComponent();
            InitializeGraph();  //Initialize Each Graph
            //AllGraphLoad(); // Load All Graphs
           
        }

        private void InitializeGraph()
        {
            GenerateGraph(ForeFootLeft_file, ForeFootLChart, "ForeFootL");
            GenerateGraph(ForeFootRight_file, ForeFootRChart, "ForeFootR");
            GenerateGraph(ForeFootMid_file, ForeFootMChart, "ForeFootM");
            GenerateGraph(Heel_file, HeelChart, "Heel");
            GenerateGraph(Thumb_file, ThumbChart, "Thumb");

            //Change colors
            ForeFootLChart.Series["ForeFootL"].Color = Color.Red;
            ForeFootRChart.Series["ForeFootR"].Color = Color.Red;
            ForeFootMChart.Series["ForeFootM"].Color = Color.Blue;
            //MidFootRChart.Series["MidFootR"].Color = Color.Blue;
            HeelChart.Series["Heel"].Color = Color.GreenYellow;
            //RearFootRChart.Series["RearFootR"].Color = Color.GreenYellow;
            ThumbChart.Series["Thumb"].Color = Color.Teal;

        }
        /*
        private void AllGraphLoad()
        {
            //Reopen Files 
            StreamReader ForeFootMid_file = new StreamReader("C:\\Users\\knguyen\\Desktop\\out0.txt");
            StreamReader ForeFootRight_file = new StreamReader("C:\\Users\\knguyen\\Desktop\\out1.txt");
            StreamReader ForeFootLeft_file = new StreamReader("C:\\Users\\knguyen\\Desktop\\out2.txt");
            StreamReader Heel_file = new StreamReader("C:\\Users\\knguyen\\Desktop\\out3.txt");
            StreamReader Thumb_file = new StreamReader("C:\\Users\\knguyen\\Desktop\\out4.txt");

            GenerateGraph(ForeFootLeft_file, AllGraphChart, "ForeFootL");
            GenerateGraph(ForeFootRight_file, AllGraphChart, "ForeFootR");
            GenerateGraph(MidFootLeft_file, AllGraphChart, "MidFootL");
            //GenerateGraph(MidFootRight_file, AllGraphChart, "MidFootR");
            GenerateGraph(RearFootLeft_file, AllGraphChart, "RearFootL");
            //GenerateGraph(RearFootRight_file, AllGraphChart, "RearFootR");
            GenerateGraph(Thumb_file, AllGraphChart, "Thumb");

            //Change Color
            ForeFootLChart.Series["ForeFootL"].Color = Color.Red;
            ForeFootRChart.Series["ForeFootR"].Color = Color.Red;
            ForeFootMChart.Series["MidFootL"].Color = Color.Blue;
            //MidFootRChart.Series["MidFootR"].Color = Color.Blue;
            RearFootLChart.Series["RearFootL"].Color = Color.GreenYellow;
            //RearFootRChart.Series["RearFootR"].Color = Color.GreenYellow;
            ThumbChart.Series["Thumb"].Color = Color.Teal;

            ForeFootLeft_file.Close();
            ForeFootRight_file.Close();
            RearFootLeft_file.Close();
            //RearFootRight_file.Close();
            MidFootLeft_file.Close();
            //MidFootRight_file.Close();
            Thumb_file.Close();
        }
        */
        private void GenerateGraph(StreamReader File_name, Chart ChartSerial, string chartName)
        {
            string line = "";
            Series filePoints = new Series();
            while ((line = File_name.ReadLine()) != null)
            {
                //find the ',' so that you know were to split the string
                int split = line.IndexOf(",");
                float X = float.Parse(line.Substring(0, split));
                float Y = float.Parse(line.Substring(split + 1, line.Length - (split + 1)));

                //add the points
                //filePoints.Points.AddXY(X, Y);
                ChartSerial.Series[chartName].Points.AddXY(X, Y);    // Create ForeFoot graph Graph by X,Y points

            }
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Acceleration_button_Click(object sender, EventArgs e)
        {
            Accel_Form Pressure_form= new Accel_Form();
            Pressure_form.Show();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
