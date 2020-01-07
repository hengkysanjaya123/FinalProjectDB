using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB.Models
{
    class EmployeeAddress
    {
        DBConnection conn = new DBConnection();
        public int Id { get; set; }
        public string addressDetail { get; set; }
        public int NIK { get; set; }
        public string addressType { get; set; }

        public EmployeeAddress()
        {
        }

        public EmployeeAddress(string addressDetail, int nIK, string addressType)
        {
            this.addressDetail = addressDetail;
            NIK = nIK;
            this.addressType = addressType;
        }

        public EmployeeAddress(int id, string addressDetail, int nIK, string addressType)
        {
            Id = id;
            this.addressDetail = addressDetail;
            NIK = nIK;
            this.addressType = addressType;
        }

        public void AddEmployeeAddress()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "INSERT INTO employeeaddress(AddressDetail, EmployeeNIK, type) VALUES " +
                    "(@addressdetail, @nik, @addresstype)";
                comd.Parameters.AddWithValue("@addressdetail", addressDetail);
                comd.Parameters.AddWithValue("@nik", NIK);
                comd.Parameters.AddWithValue("@addresstype", addressType);
                comd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully!");
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.ToString());
            }
        }
        public List<EmployeeAddress> RetrieveEmployeeAddress(int retNIK)
        {
            try
            {
                List<EmployeeAddress> employeeAddressList = new List<EmployeeAddress>();
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "SELECT * FROM employeeaddress WHERE EmployeeNIK = @nik";
                comd.Parameters.AddWithValue("@nik", retNIK);
                MySqlDataReader employeeAddresses = comd.ExecuteReader();
                while (employeeAddresses.Read())
                {
                    int thisid = employeeAddresses.GetInt32(0);
                    string thisaddressdetail = employeeAddresses.GetString(1);
                    int thisNIK = employeeAddresses.GetInt32(2);
                    string thisaddresstype = employeeAddresses.GetString(3);
                    employeeAddressList.Add(new EmployeeAddress(Convert.ToInt32(thisid), thisaddressdetail, thisNIK, thisaddresstype));
                }
                connection.Close();
                return employeeAddressList;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.Message);
                return null;
            }
        }
        public void UpdateEmployeeAddress()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "UPDATE employeeaddress SET AddressDetail = @addressdetail," +
                    " type = @addresstype" +
                    " WHERE EmployeeNIK = @nik";
                comd.Parameters.AddWithValue("@addressdetail", addressDetail);
                comd.Parameters.AddWithValue("@addresstype", addressType);
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
        public void DeleteEmployeeAddress(int id)
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "DELETE FROM employeeaddress WHERE ID = @id";
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
