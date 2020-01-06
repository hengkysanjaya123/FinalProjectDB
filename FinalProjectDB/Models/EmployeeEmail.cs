using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB
{
    class EmployeeEmail
    {
        private DBConnection conn = new DBConnection();
        private int id;
        private int NIK;
        private string emailAddress;

        public EmployeeEmail()
        {
        }

        public EmployeeEmail(int nIK, string emailAddress)
        {
            NIK = nIK;
            this.emailAddress = emailAddress;
        }

        public EmployeeEmail(int id, int nIK, string emailAddress)
        {
            this.id = id;
            NIK = nIK;
            this.emailAddress = emailAddress;
        }

        public void AddEmailAddress()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand insertEmailAddress = connection.CreateCommand();
                insertEmailAddress.CommandText = "INSERT INTO employee_email(NIK, EmailAddress) VALUES " +
                    "(@nik, @emailaddress)";
                insertEmailAddress.Parameters.AddWithValue("@nik", NIK);
                insertEmailAddress.Parameters.AddWithValue("@emailaddress", emailAddress);
                insertEmailAddress.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully!");
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.Message);
            }
        }
        public List<EmployeeEmail> RetrieveEmailAddress()
        {
            try
            {
                List<EmployeeEmail> emailAddressList = new List<EmployeeEmail>();
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand getEmail = connection.CreateCommand();
                getEmail.CommandText = "SELECT * FROM employee_email";
                MySqlDataReader emailAddresses = getEmail.ExecuteReader();
                while (emailAddresses.Read())
                {
                    int thisid = emailAddresses.GetInt32(0);
                    int thisNIK = emailAddresses.GetInt32(1);
                    string thisname = emailAddresses.GetString(2);
                    emailAddressList.Add(new EmployeeEmail(Convert.ToInt32(thisid), thisNIK, thisname));
                }
                connection.Close();
                return emailAddressList;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.Message);
                return null;
            }
        }
    }
}
