using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB.Models
{
    class EmployeeEducation
    {
        DBConnection conn = new DBConnection();
        public int Id { get; set; }
        public int NIK { get; set; }
        public string EducationLevel { get; set; }
        public string Institution { get; set; }
        public string Major { get; set; }
        public DateTime GraduationYear { get; set; }
        public float Score { get; set; }

        public EmployeeEducation()
        {
        }

        public EmployeeEducation(int nIK, string educationLevel, string institution, string major, DateTime graduationYear, float score)
        {
            NIK = nIK;
            EducationLevel = educationLevel;
            Institution = institution;
            Major = major;
            GraduationYear = graduationYear;
            Score = score;
        }

        public EmployeeEducation(int id, int nIK, string educationLevel, string institution, string major, DateTime graduationYear, float score)
        {
            Id = id;
            NIK = nIK;
            EducationLevel = educationLevel;
            Institution = institution;
            Major = major;
            GraduationYear = graduationYear;
            Score = score;
        }

        public void AddEmployeeEducation()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "INSERT INTO employeeeducation(NIK, EducationLevel, Institution, Major, " +
                    "GraduationYear, Score) VALUES " +
                    "(@nik, @educationlevel, @institution, @major, @graduationyear, @score)";
                comd.Parameters.AddWithValue("@nik", NIK);
                comd.Parameters.AddWithValue("@educationlevel", EducationLevel);
                comd.Parameters.AddWithValue("@institution", Institution);
                comd.Parameters.AddWithValue("@major", Major);
                comd.Parameters.AddWithValue("@graduationyear", GraduationYear);
                comd.Parameters.AddWithValue("@score", Score);
                comd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully!");
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.ToString());
            }
        }
        public List<EmployeeEducation> RetrieveEmployeeEducation(int retNIK)
        {
            try
            {
                List<EmployeeEducation> employeeEducationList = new List<EmployeeEducation>();
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand getEducation = connection.CreateCommand();
                getEducation.CommandText = "SELECT * FROM employeeeducation WHERE NIK = @nik";
                getEducation.Parameters.AddWithValue("@nik", retNIK);
                MySqlDataReader educations = getEducation.ExecuteReader();
                while (educations.Read())
                {
                    int thisid = educations.GetInt32(0);
                    int thisNIK = educations.GetInt32(1);
                    string thisEducationLevel = educations.GetString(2);
                    string thisInstitution = educations.GetString(3);
                    string thisMajor = educations.GetString(4);
                    DateTime thisGraduationYear = educations.GetDateTime(5);
                    float thisScore = educations.GetFloat(6);
                    employeeEducationList.Add(new EmployeeEducation(Convert.ToInt32(thisid), thisNIK, thisEducationLevel
                        , thisInstitution, thisMajor, thisGraduationYear, thisScore));
                }
                connection.Close();
                return employeeEducationList;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.ToString());
                return null;
            }
        }
        public void UpdateEmployeeEducation()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "UPDATE employeeeducation SET EducationLevel = @educationlevel, Institution = @institution" +
                    ", Najor = @major, GraduationYear = @graduationyear, Score = @score" +
                    " WHERE NIK = @nik";
                comd.Parameters.AddWithValue("@educationlevel", EducationLevel);
                comd.Parameters.AddWithValue("@institution", Institution);
                comd.Parameters.AddWithValue("@major", Major);
                comd.Parameters.AddWithValue("@graduationyear", GraduationYear);
                comd.Parameters.AddWithValue("@score", Score);
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
        public void DeleteEmployeeEducation(int id)
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "DELETE FROM employeeeducation WHERE ID = @id";
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
