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
        public int Id { get; set; }
        public int NIK { get; set; }
        public string emailAddress { get; set; }

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
            this.Id = id;
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
                MessageBox.Show("Error:", ex.ToString());
            }
        }
        public List<EmployeeEmail> RetrieveEmailAddress(int retNIK)
        {
            try
            {
                List<EmployeeEmail> emailAddressList = new List<EmployeeEmail>();
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand getEmail = connection.CreateCommand();
                getEmail.CommandText = "SELECT * FROM employee_email WHERE NIK = @nik";
                getEmail.Parameters.AddWithValue("@nik", retNIK);
                MySqlDataReader emailAddresses = getEmail.ExecuteReader();
                while (emailAddresses.Read())
                {
                    int thisid = emailAddresses.GetInt32(0);
                    int thisNIK = emailAddresses.GetInt32(1);
                    string thisEmailAddress = emailAddresses.GetString(2);
                    emailAddressList.Add(new EmployeeEmail(Convert.ToInt32(thisid), thisNIK, thisEmailAddress));
                }
                connection.Close();
                return emailAddressList;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.ToString());
                return null;
            }
        }
        public void UpdateEmployeeEmail()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "UPDATE employee_email SET emailaddress = @emailaddress WHERE NIK = @nik";
                comd.Parameters.AddWithValue("@emailaddress", emailAddress);
                comd.Parameters.AddWithValue("@nik", NIK);
                comd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully!");
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.ToString());
            }
        }
        public void DeleteEmployeeEmail(int id)
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "DELETE FROM employee_email WHERE ID = @id";
                comd.Parameters.AddWithValue("@id", id);
                comd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully!");
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.ToString());
            }

        }
    }
}