using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB
{
    class EmployeeFamily
    {
        private DBConnection conn = new DBConnection();

        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public int RelationshipId { get; set; }
        public int NIK { get; set; }

        public EmployeeFamily()
        {
        }

        public EmployeeFamily(int id, string name, string gender, DateTime dOB, int relationshipId, int nIK)
        {
            Id = id;
            Name = name;
            Gender = gender;
            DOB = dOB;
            RelationshipId = relationshipId;
            NIK = nIK;
        }


        public void AddEmployeeFamily()
        {
            try
            {
                using (MySqlConnection connection = conn.OpenConnection())
                {
                    connection.Open();
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "INSERT INTO employeefamily(NAME, Gender, DOB, EmployeeRelationshipID, NIK) " +
                        "VALUES (@name,@gender,@dob,@employeerelationshipid,@nik)";
                    cmd.Parameters.AddWithValue("@name", Name);
                    cmd.Parameters.AddWithValue("@gender", Gender);
                    cmd.Parameters.AddWithValue("@dob", DOB);
                    cmd.Parameters.AddWithValue("@employeerelationshipid", RelationshipId);
                    cmd.Parameters.AddWithValue("@nik", NIK);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfully!");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.ToString());
            }

        }

        public void DeleteEmployeeFamily(int id)
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "DELETE FROM employeefamily WHERE ID = @id";
                comd.Parameters.AddWithValue("@id", id);
                comd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully!");
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.Message);
            }

        }


        public List<EmployeeFamily> RetrieveEmployeeFamily(int nik)
        {
            try
            {
                List<EmployeeFamily> list = new List<EmployeeFamily>();
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM employeefamily WHERE NIK = " + nik;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var id = reader.GetInt32("ID");
                    var name = reader.GetString("NAME");
                    var gender = reader.GetString("Gender");
                    var dob = reader.GetDateTime("DOB");
                    var employeeRelationshipId = reader.GetInt32("EmployeeRelationshipID");
                    var cur_nik = (int)reader.GetInt32("NIK");

                    list.Add(new EmployeeFamily(id, name, gender, dob, employeeRelationshipId, cur_nik));
                }
                connection.Close();
                return list;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.Message);
                return null;
            }
        }
    }
}
