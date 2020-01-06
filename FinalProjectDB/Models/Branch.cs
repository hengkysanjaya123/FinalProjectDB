using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB
{
    class Branch
    {
        private DBConnection conn = new DBConnection();
        public int Id { get; set; }
        public string BranchName { get; set; }

        public Branch()
        {
        }

        public Branch(string branchName)
        {
            this.BranchName = branchName;
        }

        public Branch(int id, string branchName)
        {
            this.Id = id;
            this.BranchName = branchName;
        }

        public void AddBranch()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand insertBranch = connection.CreateCommand();
                insertBranch.CommandText = "INSERT INTO branch(Name) VALUES (@branchname)";
                insertBranch.Parameters.AddWithValue("@branchname", BranchName);
                insertBranch.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:", ex.ToString());
            }

        }

        public List<Branch> RetrieveBranches()
        {
            try
            {
                List<Branch> branchList = new List<Branch>();
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand getBranches = connection.CreateCommand();
                getBranches.CommandText = "SELECT * FROM branch";
                MySqlDataReader branches = getBranches.ExecuteReader();
                while (branches.Read())
                {
                    int thisid = branches.GetInt32(0);
                    string thisname = branches.GetString(1);
                    branchList.Add(new Branch(Convert.ToInt32(thisid), thisname));
                }
                connection.Close();
                return branchList;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.Message);
                return null;
            }
        }

        public void UpdateBranch()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand insertDepartment = connection.CreateCommand();
                insertDepartment.CommandText = "UPDATE branch SET Name = @name WHERE ID = @id";
                insertDepartment.Parameters.AddWithValue("@name", BranchName);
                insertDepartment.Parameters.AddWithValue("@id", Id);
                insertDepartment.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully!");
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.Message);
            }

        }

        public void DeleteBranch(int id)
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "DELETE FROM branch WHERE ID = @id";
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
    }
}
