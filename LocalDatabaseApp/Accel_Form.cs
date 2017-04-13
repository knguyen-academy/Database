//Create by : Khoi Nguyen
//Diabetic Database App
//Reivised 04-13-2017

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalDatabaseApp
{
    public partial class Accel_Form : Form
    {
        public Accel_Form()
        {
            InitializeComponent();
            InitializePressureGrid();
        }

        public void InitializePressureGrid()
        {
            //System.IO.StreamReader file = new System.IO.StreamReader("C:\\test2.txt");
            System.IO.StreamReader file = new System.IO.StreamReader("D:\\test7.txt");

            DataTable dt = new DataTable();

            //USE THIS IF FILE CONTAINS COLUMN NAME AT FIRST LINE///
            //string[] columnnames = file.ReadLine().Split(',');
            //foreach (string c in columnnames)
            //{
            //dt.Columns.Add(c);
            //}
            ////////////////////////////////////////////////////////


            dt.Columns.Add("X");
            dt.Columns.Add("Y");
            dt.Columns.Add("Z");
            string newline;
            while ((newline = file.ReadLine()) != null)
            {
                DataRow dr = dt.NewRow();
                string[] values = newline.Split(',');
                for (int i = 0; i < values.Length; i++)
                {
                    dr[i] = values[i];
                }
                dt.Rows.Add(dr);
            }
            file.Close();
            dataGridView1.DataSource = dt;

        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
