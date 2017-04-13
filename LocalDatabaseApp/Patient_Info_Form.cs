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
//using System.Data.Sql;
//using System.Data.SqlClient;
namespace LocalDatabaseApp

{

    public partial class PatientInfo_Form : Form
    {

        //Global var
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        //SQLiteDataReader sqlite_datareader;
     

        public PatientInfo_Form()
        {
            InitializeComponent();
            InitializeServer();
       
        }

    
        private void InitializeServer()
        {


            // create a new database connection:
            //*******Data Source =C:\....\databse.db
            sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3");    //New=True;Compress=True;

            // open the connection:
            //sqlite_conn.Open();

            // create a new SQL command:
            sqlite_cmd = sqlite_conn.CreateCommand();
            //sqlite_conn.Open();
            //SQLiteCommand cmd = new SQLiteCommand("PRAGMA foreign_keys = ON", sqlite_conn);
            //cmd.ExecuteNonQuery();

        }
        private void display_button_Click(object sender, EventArgs e)
        {

            string TableQuery = "SELECT Fname, Lname, Phone, Zipcode  FROM Patient_Info";

            SQLiteDataAdapter sqlData = new SQLiteDataAdapter(TableQuery, sqlite_conn);
            DataSet dataSet = new DataSet();

            try
            {

                sqlData.Fill(dataSet);
                DataTable dataTable = dataSet.Tables[0];
                dataGridView.DataSource = dataTable;
               


            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            //sqlite_conn.Close();

        }//display_button

        private void insert_button_Click(object sender, EventArgs e)
        {
            Insert_Form InsertForm = new Insert_Form();
            InsertForm.Show();
        } //insert_function

        private void retrieve_button_Click(object sender, EventArgs e)
        {
            string fname = fname_text.Text;
            string lname = lname_text.Text;
            string id = patientId_text.Text;

            string SearchQuery = "SELECT Fname, Lname, Phone, Zipcode FROM Patient_Info WHERE Id = '" + id + "' OR  Fname = '" + fname+ "' OR Lname= '"+ lname +"' ";
            SQLiteDataAdapter sqlData = new SQLiteDataAdapter(SearchQuery, sqlite_conn);
            //SQLiteCommand sqlite_cmd = new SQLiteCommand(SearchQuery, sqlite_conn);
            
            DataSet dataSet = new DataSet();
            try
            {
                sqlData.Fill(dataSet);
                DataTable dataTable = dataSet.Tables[0];
                dataGridView.DataSource = dataTable;
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            sqlite_conn.Open();
  
            string fname = fname_text.Text;
            string lname = lname_text.Text;
            //string DeleteQuery = "DELETE FROM PatientInfo WHERE patient_fname = '" + fname + "' AND patient_lname= '" + lname + "' " ;
            string DeleteQuery = "DELETE FROM Patient_Info WHERE Fname LIKE '" + fname + "' AND Lname LIKE '" + lname + "'";

            

            SQLiteCommand sqlite_cmd = new SQLiteCommand(DeleteQuery, sqlite_conn);

           

            DialogResult result = MessageBox.Show("Are you sure to delete this item?","Delete",MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                sqlite_conn.Close();

            else
            {
                sqlite_cmd.ExecuteNonQuery();
                sqlite_conn.Close();
                fname_text.Text = "";
                lname_text.Text = "";

                         
            }
        }

        private void detail_button_Click(object sender, EventArgs e)
        {
            //check valid
            if (fname_text.Text == "" | lname_text.Text == "")
                MessageBox.Show("Please select a patient..");
            else
            {
                Medical_Record MeidcalForm = new Medical_Record(fname_text.Text, lname_text.Text);
                MeidcalForm.Show();
            }
            
        }

      

        public void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                fname_text.Text = row.Cells[0].Value.ToString();
                lname_text.Text = row.Cells[1].Value.ToString();

            }


        }

        private void DeleteAll_button_Click(object sender, EventArgs e)
        {
            sqlite_conn.Open();
            string DeleteAll_PatientsQuery = "DELETE FROM Patient_Info" ;
            string DeleteAll_MedicalQuerey = "DELETE FROM Medical_Record";
            SQLiteCommand sqlite_cmd = new SQLiteCommand(DeleteAll_PatientsQuery, sqlite_conn);
            SQLiteCommand sqlite_cmd2 = new SQLiteCommand(DeleteAll_MedicalQuerey, sqlite_conn);
            DialogResult result = MessageBox.Show("Are you sure to delete ALL items?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                sqlite_conn.Close();

            else
            {
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd2.ExecuteNonQuery();
                sqlite_conn.Close();
                fname_text.Text = "";
                lname_text.Text = "";


            }
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
