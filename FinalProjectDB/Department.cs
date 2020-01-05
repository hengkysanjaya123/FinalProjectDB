using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB
{
    class Department
    {
        private DBConnection conn = new DBConnection();
        private int id;
        private string departmentName;

        public int Id { get => id; set => id = value; }
        public string DepartmentName { get => departmentName; set => departmentName = value; }

        public Department()
        {
        }

        public Department(string departmentName)
        {
            this.departmentName = departmentName;
        }

        public Department(int id, string departmentName)
        {
            this.id = id;
            this.departmentName = departmentName;
        }

        public void AddDepartment()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand insertDepartment = connection.CreateCommand();
                insertDepartment.CommandText = "INSERT INTO department(Name) VALUES (@departmentname)";
                insertDepartment.Parameters.AddWithValue("@departmentname", departmentName);
                insertDepartment.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:", ex.ToString());
            }

        }

        public List<Department> RetrieveDepartments()
        {
            try
            {
                List<Department> departmentList = new List<Department>();
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand getDepartments = connection.CreateCommand();
                getDepartments.CommandText = "SELECT * FROM department";
                MySqlDataReader departments = getDepartments.ExecuteReader();
                while (departments.Read())
                {
                    int thisid = departments.GetInt32(0);
                    string thisname = departments.GetString(1);
                    departmentList.Add(new Department(Convert.ToInt32(thisid), thisname));
                }
                connection.Close();
                return departmentList;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.Message);
                return null;
            }
        }
}
