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
    public partial class Login_Form : Form
    {

        // We use these three SQLite objects:
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        SQLiteDataReader sqlite_datareader;
        public Login_Form()
        {
            InitializeComponent();
            //Form.Keydown += form_KeyDown;

        }

        
        // Create SQLite Connection
        private void connect_button_Click(object sender, EventArgs e)
        {


            // create a new database connection:
            //sqlite_conn = new SQLiteConnection("Data Source=passwordDB.db;Version=3;New=True;Compress=True;");    //Will overite the old one
            sqlite_conn = new SQLiteConnection("Data Source=database_password.db;Version=3");
            // open the connection:
            sqlite_conn.Open();

            // create a new SQL command:
            sqlite_cmd = sqlite_conn.CreateCommand();


            ///************** CREATE AND DROP SECTION ****************//////////
            //sqlite_cmd.CommandText = "DROP TABLE PatientInfo;";

            // Let the SQLiteCommand object know our SQL-Query:
            //********CREATE TABLE TABLE_NAME (1st_Attribute/Column datatype key_type(if applicable), 2nd_column data_type);
           // sqlite_cmd.CommandText = "CREATE TABLE PatientInfo (patient_Id varchar(50), patient_fname varchar(50), patient_lname varchar(50), patient_sex varchar(50), patient_birthday varchar(50), patient_phone varchar(50), patient_weight varchar(50), patient_height varchar(50), patient_visit varchar(50), patient_Password varchar(50));";
            //sqlite_cmd.ExecuteNonQuery();
            //sqlite_cmd.CommandText = "INSERT INTO PatientInfo (rowid, patient_Id, patient_fname, patient_lname, patient_sex, patient_birthday, patient_phone, patient_weight, patient_height, patient_visit, patient_Password) VALUES (1,'Admin', 'Admin', 'Admin', 'M', '09/08/1957', '916-380-8952','130','5-2','20/9/2016','123456');";
            //sqlite_cmd.ExecuteNonQuery();

            ///************** CREATE AND DROP SECTION ****************//////////


            // Now lets execute the SQL ;D
            //sqlite_cmd.ExecuteNonQuery();

            // Lets insert something into our new table:
            //sqlite_cmd.CommandText = "INSERT INTO PatientInfo (patient_Id, patient_Password) VALUES (3, '1');";    

            // And execute this again ;D
            //sqlite_cmd.ExecuteNonQuery();

            // ...and inserting another line:
            //sqlite_cmd.CommandText = "INSERT INTO PatientInfo (patient_Id, patient_Password) VALUES (2, '2');";   //2

            // And execute this again ;D
            //sqlite_cmd.ExecuteNonQuery();



            //String Query = "SELECT* FROM PatientInfo where patient_Id='" + this.username_text.Text + "'and patient_Password='" + this.password_text.Text + "' ";
            sqlite_cmd.CommandText = "SELECT* FROM PasswordTable where User= '" + this.username_text.Text + "' and Password='" + this.password_text.Text + "' ";
            
            sqlite_cmd.ExecuteNonQuery();
           
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            
            int count = 0;
            while (sqlite_datareader.Read())
            {
                count++;
            }
            if (count==1) {
                //MessageBox.Show("Username and password is correct");
                //Open Patient_Info
                sqlite_conn.Close();
                this.Hide(); //hide login_form

                PatientInfo_Form PatientInfo = new PatientInfo_Form();
                PatientInfo.Show();
                
            }

            if (count > 1)
            {
                MessageBox.Show("Duplicate Username and password is correct. Try again");
        
            }

            if (count < 1)
            {
                MessageBox.Show("Username and password is NOT correct");
                
            }
            sqlite_conn.Close();
        }//connect button

        private static void close()
        {
            throw new NotImplementedException();
        }

        //Enter key == connect button
        private void form_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Enter))
            {
                connect_button.PerformClick();
               
            }
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }//login form
}//local dataApp


////// Basic syntax of SQLlite

/*
private void connect_button_Click(object sender, EventArgs e)
{
    // [snip] - As C# is purely object-oriented the following lines must be put into a class:

    // We use these three SQLite objects:
    SQLiteConnection sqlite_conn;
    SQLiteCommand sqlite_cmd;
    SQLiteDataReader sqlite_datareader;

    // create a new database connection:
    //*******Data Source =C:\....\databse.db
    sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");    

    // open the connection:
    sqlite_conn.Open();

    // create a new SQL command:
    sqlite_cmd = sqlite_conn.CreateCommand();

    // Let the SQLiteCommand object know our SQL-Query:
    //********CREATE TABLE TABLE_NAME (1st_Attribute/Column datatype key_type(if applicable), 2nd_column data_type);
    sqlite_cmd.CommandText = "CREATE TABLE PatiensInfo (patient_Id integer primary key, patient_Age varchar(100));";

    // Now lets execute the SQL ;D
    sqlite_cmd.ExecuteNonQuery();

    // Lets insert something into our new table:
    //***********INSERT INTO TABLE_NAME (1st_column, 2nd_column) VALUES (value of 1st_column, value of 2nd_column); 
    sqlite_cmd.CommandText = "INSERT INTO PatiensInfo (patient_Id, patient_Age) VALUES (111, '20');";    

    // And execute this again ;D
    sqlite_cmd.ExecuteNonQuery();

    // ...and inserting another line:
    sqlite_cmd.CommandText = "INSERT INTO PatiensInfo (patient_Id, patient_Age) VALUES (321, '30');";   //2

    // And execute this again ;D
    sqlite_cmd.ExecuteNonQuery();

    // But how do we read something out of our table ?
    // First lets build a SQL-Query again:
    sqlite_cmd.CommandText = "SELECT * FROM PatiensInfo";

    // Now the SQLiteCommand object can give us a DataReader-Object:
    sqlite_datareader = sqlite_cmd.ExecuteReader();

    // The SQLiteDataReader allows us to run through the result lines:
    while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
    {
        // Print out the content of the text field:
        //System.Console.WriteLine(sqlite_datareader["text"]);
        string Myreader = sqlite_datareader.GetString(0);   //0 = 1st_column
        MessageBox.Show(Myreader);
    }
}
*/
