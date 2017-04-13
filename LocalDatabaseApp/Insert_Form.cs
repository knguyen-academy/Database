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
    public partial class Insert_Form : Form
    {
        //Global
        
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        //SQLiteDataReader sqlite_datareader;
        //int patient_id;
        public Insert_Form()
        {
            InitializeComponent();
            InitializeServer();
        }


        private void InitializeServer()
        {
            panel1.Visible = false;

            // create a new database connection:
            //*******Data Source =C:\....\databse.db
            //sqlite_conn = new SQLiteConnection("Data Source = database.db; Version = 3; New=True;Compress=True;");
            sqlite_conn = new SQLiteConnection("Data Source = database.db; Version = 3");
        
            // open the connection:
            sqlite_conn.Open();

            // create a new SQL command:
            sqlite_cmd = sqlite_conn.CreateCommand();
        }



        private void done_button_Click(object sender, EventArgs e)
        {

           
            string fname = fname_text.Text;
            string lname = lname_text.Text;
            string patientId="";

            ///Create a unique Patient ID
            Random rnd = new Random();
            int id = rnd.Next(1000);
            
            string sex = "";
            string birthdate = birthday_text.Text;
            string phone = phone_text.Text;
            string address = address_text.Text;
            string zipcode = zipcode_text.Text;
       


            //////Check Input validity
            if (fname == "" || lname == "" || birthdate == "" || phone =="" || address =="" || zipcode == "" || (M_button.Checked == false && F_button.Checked ==false))
            {
                MessageBox.Show("Please insert all the information...");
                return;
            }
            else
            {
                if(M_button.Checked)
                    sex = "M";
                if (F_button.Checked)
                    sex = "F";
                patientId = fname_text.Text.Substring(0, 1) + lname_text.Text.Substring(0, 1) + id.ToString();
                
            }

            // Insert  Patients INTO PatientInfo Table
            // Insert  
            //('" + varialbe + "')";
            // string Insertquery = "INSERT INTO PatientInfo (patient_fname, patient_lname, patient_sex, patient_birthday, patient_phone, patient_weight, patient_height, patient_visit, patient_Id, patient_Password) VALUES ('" + fname + "' , '" + lname + "' , '" + sex  + "', '" + birthday + "', '" + phone + "', '" + weight + "', '" + height + "', '" + visit + "', '" + patientId + "', '" + password + "' ); ";
            string Insertquery = "INSERT INTO Patient_Info (Fname, Lname, Sex, Birthdate, Phone, Address, Zipcode, Id) VALUES (@fname, @lname, @sex, @birthdate, @phone,@address, @zipcode, @patientId)";
            try
            {
                SQLiteCommand sqlite_cmd = new SQLiteCommand(Insertquery, sqlite_conn);
                sqlite_cmd.Parameters.Add("@fname", fname).Value = fname;
                sqlite_cmd.Parameters.Add("@lname", lname).Value = lname;
                sqlite_cmd.Parameters.Add("@sex", sex).Value = sex;
                sqlite_cmd.Parameters.Add("@birthdate", birthdate).Value = birthdate;
                sqlite_cmd.Parameters.Add("@phone", phone).Value = phone;
                sqlite_cmd.Parameters.Add("@address", address).Value = address;
                sqlite_cmd.Parameters.Add("@zipcode", zipcode).Value = zipcode;
                //sqlite_cmd.Parameters.Add("@visit", visit).Value = visit;
                sqlite_cmd.Parameters.Add("@patientId", patientId).Value = patientId;

                //if (fname == null || lname == null)
                    


                sqlite_cmd.ExecuteNonQuery();
                panel1.Visible = true;
                //this.Hide();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Unable to Insert Patient");
                MessageBox.Show(ex.Message);
                //sqlite_conn.Close();
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //NEXT BUTTON
        private void done_button_Click_1(object sender, EventArgs e)
        {
            string weight = weight_text.Text;
            string height = height_text.Text;
            string blood = blood_text.Text;
            string visit = visit_text.Text;
            string subscription = subscription_text.Text;

            //sqlite_cmd.CommandText = "INSERT INTO Medical_Record (Id) VALUES ((SELECT Id FROM Patient_Info LIMIT 1))";
            //sqlite_cmd.ExecuteNonQuery();

            //string UpdateQuery = "UPDATE Medical_Record SET Medical_Record.Id = Patient_Info.Id FROM Medical_Record, Patient_Info" ;
            //SQLiteCommand sqlite_cmd = new SQLiteCommand(UpdateQuery, sqlite_conn);

            /*
            string FK_ID; // This is where we store the foreign key


            sqlite_cmd.CommandText = "SELECT * FROM Patient_Info";
            //sqlite_cmd.ExecuteNonQuery();

            sqlite_datareader = sqlite_cmd.ExecuteReader();

            while (sqlite_datareader.Read())
            {
                FK_ID = sqlite_datareader.GetString(0);
            }
           */

            //sqlite_cmd.CommandText = "UPDATE Medical_Record SET Id = (SELECT Id FROM Patient_Info)";
            //WHERE EXISTS (SELECT * FROM Patient_Info)";
            // sqlite_cmd.ExecuteNonQuery();


            string Insertquery = "INSERT INTO Medical_Record (Id, Weight, Height, BloodType, Visit, Subscription) VALUES ((SELECT Id FROM Patient_Info ORDER BY ROWID DESC),@weight, @height, @blood, @visit, @subscription)";
           
                try
                {
                //sqlite_cmd.CommandText = "INSERT INTO Medical_Record (Weight, Height, BloodType, Visit, Subscription) VALUES(@weight, @height, @blood, @visit, @subscription)";

                SQLiteCommand sqlite_cmd = new SQLiteCommand(Insertquery, sqlite_conn);
                //sqlite_cmd.Parameters.Add("@FK_ID", FK_ID).Value = FK_ID;
                sqlite_cmd.Parameters.Add("@weight", weight).Value = weight;
                    sqlite_cmd.Parameters.Add("@height", height).Value = height;
                    sqlite_cmd.Parameters.Add("@blood", blood).Value = blood;
                    sqlite_cmd.Parameters.Add("@visit", visit).Value = visit;
                    sqlite_cmd.Parameters.Add("@subscription", subscription).Value = subscription;

                    sqlite_cmd.ExecuteNonQuery();
                    this.Hide();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Unable to Insert Patient");
                    MessageBox.Show(ex.Message);
                    sqlite_conn.Close();
                }
            
        }
    }
}
