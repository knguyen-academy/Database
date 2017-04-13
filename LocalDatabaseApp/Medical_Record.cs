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
using Finisar.SQLite;   //add SQLlite
namespace LocalDatabaseApp
{
    public partial class Medical_Record : Form
    {
        //Global
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        SQLiteDataReader sqlite_datareader;
       
        public Medical_Record(string fn, string ln)
        {
            
           
            InitializeComponent();

            //Constructor to pass value from PatientInfo to Meidcal form
            fname_text.Text = fn;
            lname_text.Text = ln;

            InitializeServer();
            InitializeVaribles();


        }

      
        private void InitializeVaribles()
        {
            //Select from current patitent   
            //sqlite_cmd.CommandText = "SELECT * FROM Patient_Info WHERE Fname = '" + this.fname_text.Text + "' AND Lname = '" + this.lname_text.Text + "'  ";


            //JOIN Patient and Medical Table Ref. by ID
            sqlite_cmd.CommandText = "SELECT * FROM Patient_Info JOIN Medical_Record ON Patient_Info.Id = Medical_Record.Id  WHERE Fname = '" + this.fname_text.Text + "' AND Lname = '" + this.lname_text.Text + "'  ";
            
            // Now the SQLiteCommand object can give us a DataReader-Object:
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            

            // The SQLiteDataReader allows us to run through the result lines:
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                // Print out the content of the text field:
                string phone = sqlite_datareader.GetString(5);     //0 = 1st_column
                string address = sqlite_datareader.GetString(6);   //0 = 1st_column
                string zipcode = sqlite_datareader.GetString(7);   //0 = 1st_column
                                                                   //// From Medical
                // Print out the content of the text field:
                string id_label = sqlite_datareader.GetString(0);
                string blood = sqlite_datareader.GetString(9);   //0 = 1st_column
                string weight = sqlite_datareader.GetString(10);   //0 = 1st_column
                string height = sqlite_datareader.GetString(11);   //0 = 1st_column
                string visit = sqlite_datareader.GetString(12);   //0 = 1st_column
                string subscription = sqlite_datareader.GetString(13);   //0 = 1st_column
              
                // Populate contents
                //Patient TAble
                this.phone_text.Text = phone;
                this.address_text.Text = address;
                this.zipcode_text.Text = zipcode;
                //Medical Table
                this.blood_text.Text = blood;
                this.weight_text.Text = weight;
                this.height_text.Text = height;
                this.visit_text.Text = visit;
                this.subcription_text.Text = subscription;
                this.id_label.Text = id_label;
                
            }

       
        }
        private void InitializeServer()
        {


            // create a new database connection:
            //*******Data Source =C:\....\databse.db
            //sqlite_conn = new SQLiteConnection("Data Source = database.db; Version = 3; New=True;Compress=True;");
            sqlite_conn = new SQLiteConnection("Data Source = database.db; Version = 3");

            // open the connection:
            sqlite_conn.Open();

            // create a new SQL command:
            sqlite_cmd = sqlite_conn.CreateCommand();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            string id = id_label.Text;
            string fname = fname_text.Text;
            string lname = lname_text.Text;
            string weight = weight_text.Text;

            string UpdateQuery = "UPDATE Patient_Info SET Fname = @fname, Lname = @lname WHERE Patient_Info.Id = @id ";
            //string UpdateQuery1= "UPDATE Medical_Recored SET Weight= @weightWHERE Medical_Record.Id = @id ";
            
            //string UpdateQuery = " UPDATE Patient_Info, Medical_Record SET Fname = @fname, Lname = @lname, Weight= @weight WHERE Patient_Info.Id =@id AND Medical_Record.Id= @id";
            try
            {
                SQLiteCommand sqlite_cmd = new SQLiteCommand(UpdateQuery, sqlite_conn);
                //sqlite_cmd.CommandText= "UPDATE Patient_Info SET Fname = @fname, Lname = @lname WHERE Patient_Info.Id = @id ";
                sqlite_cmd.Parameters.Add("@fname", fname).Value = fname;
                sqlite_cmd.Parameters.Add("@lname", lname).Value = lname;
                //sqlite_cmd.Parameters.Add("@weight", weight).Value = weight;
                sqlite_cmd.Parameters.Add("@id", id).Value = id;

                sqlite_cmd.ExecuteNonQuery();

                //sqlite_cmd.CommandText = "UPDATE Medical_Recored SET Weight = @weight WHERE Medical_Record.Id = @id ";
                //sqlite_cmd.Parameters.Add("@weight", weight).Value = weight;
                //sqlite_cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully updated ...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Insert ...");
                MessageBox.Show(ex.Message);
                sqlite_conn.Close();
            }
            /*OLD UPdate
            sqlite_conn.Open();
            string test= null;
            DataTable dt = dataGridView.DataSource as DataTable;

            for ( int i= 0; i < dt.Rows.Count; i++)
            {


                if (dt.Rows[i].RowState == DataRowState.Modified)
                {

                    //string test = dt.Rows[i].RowState.ToString();
                    test = dt.Rows[i][1].ToString();
                    //string UpdateQuery = "UPDATE PatientInfo SET patient_fname  = '" + test + " '";


                    MessageBox.Show(test);

                  string UpdateQuery = "UPDATE Patient_Info SET patient_fname  = '" + test + "' WHERE rowid = '" + i + "'  ";
                   // string UpdateQuery = "UPDATE PatientInfo SET patient_fname  = '" + test + "' WHERE rowid = 3  ";
                    SQLiteCommand sqlite_cmd = new SQLiteCommand(UpdateQuery, sqlite_conn);

                    sqlite_cmd.ExecuteNonQuery();

                }
            }





            sqlite_conn.Close();
            }


            /*
            string bloodtype = blood_text.Text;
            string weight = weight_text.Text;
            string height = height_text.Text;
            string visit = visit_text.Text;
            string subscription = subcription_text.Text;
            string Insertquery = "INSERT INTO Medical_Record (BloodType, Weight, Height, Visit, Subscription) VALUES (@bloodtype, @weight, @height, @visit, @subscription)";
            try
            {
                SQLiteCommand sqlite_cmd = new SQLiteCommand(Insertquery, sqlite_conn);
                sqlite_cmd.Parameters.Add("@bloodtype", bloodtype).Value = bloodtype;
                sqlite_cmd.Parameters.Add("@weight", weight).Value = weight;
                sqlite_cmd.Parameters.Add("@height", height).Value = height;
                sqlite_cmd.Parameters.Add("@visit", visit).Value = visit;
                sqlite_cmd.Parameters.Add("@subscription", subscription).Value = subscription;



                sqlite_cmd.ExecuteNonQuery();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Insert ...");
                MessageBox.Show(ex.Message);
                sqlite_conn.Close();
            }
            */
        }


        private void cancel_button_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Graph_button_Click(object sender, EventArgs e)
        {
            Graph_Form Graph_form = new Graph_Form();
            Graph_form.Show();
        }
    }
}
