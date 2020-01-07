using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB.Models
{
    class EmployeeJobHistory
    {
        DBConnection conn = new DBConnection();
        public int Id { get; set; }
        public int NIK { get; set; }
        public string Company { get; set; }
        public string Pos { get; set; }

        public EmployeeJobHistory()
        {
        }

        public EmployeeJobHistory(int nIK, string company, string pos)
        {
            NIK = nIK;
            Company = company;
            Pos = pos;
        }

        public EmployeeJobHistory(int id, int nIK, string company, string pos)
        {
            Id = id;
            NIK = nIK;
            Company = company;
            Pos = pos;
        }

        public void AddJobHistory()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "INSERT INTO employeejobhistory(NIK, Company, Pos) VALUES " +
                    "(@nik, @company, @pos)";
                comd.Parameters.AddWithValue("@nik", NIK);
                comd.Parameters.AddWithValue("@company", Company);
                comd.Parameters.AddWithValue("@pos", Pos);
                comd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully!");
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.ToString());
            }
        }
        public List<EmployeeJobHistory> RetrieveJobHistory(int retNIK)
        {
            try
            {
                List<EmployeeJobHistory> jobHistoryList = new List<EmployeeJobHistory>();
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "SELECT * FROM employeejobhistory WHERE NIK = @nik";
                comd.Parameters.AddWithValue("@nik", retNIK);
                MySqlDataReader jobhistories = comd.ExecuteReader();
                while (jobhistories.Read())
                {
                    int thisid = jobhistories.GetInt32(0);
                    int thisNIK = jobhistories.GetInt32(1);
                    string thisCompany = jobhistories.GetString(2);
                    string thisPos = jobhistories.GetString(3);
                    jobHistoryList.Add(new EmployeeJobHistory(Convert.ToInt32(thisid), Convert.ToInt32(thisNIK), thisCompany, thisPos));
                }
                connection.Close();
                return jobHistoryList;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.ToString());
                return null;
            }
        }
        public void UpdateJobHistory()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "UPDATE employeejobhistory SET Company = @company, Pos = @pos WHERE NIK = @nik";
                comd.Parameters.AddWithValue("@company", Company);
                comd.Parameters.AddWithValue("@pos", Pos);
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
        public void DeleteJobHistory(int id)
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "DELETE FROM employeejobhistory WHERE ID = @id";
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
