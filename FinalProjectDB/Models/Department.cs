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

        public int Id { get; set; }
        public string DepartmentName { get; set; }

        public Department()
        {
        }

        //public Department(string departmentName)
        //{
        //    this.departmentName = departmentName;
        //}

        public Department(int id, string departmentName)
        {
            this.Id = id;
            this.DepartmentName = departmentName;
        }

        public void AddDepartment()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand insertDepartment = connection.CreateCommand();
                insertDepartment.CommandText = "INSERT INTO department(Name) VALUES (@departmentname)";
                insertDepartment.Parameters.AddWithValue("@departmentname", DepartmentName);
                insertDepartment.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:", ex.ToString());
            }

        }


        public void UpdateDepartment()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand insertDepartment = connection.CreateCommand();
                insertDepartment.CommandText = "UPDATE department SET Name = @name WHERE ID = @id";
                insertDepartment.Parameters.AddWithValue("@name", DepartmentName);
                insertDepartment.Parameters.AddWithValue("@id", Id);
                insertDepartment.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully!");
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.ToString());
            }

        }

        public void DeleteDepartment(int id)
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "DELETE FROM Department WHERE ID = @id";
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
}
