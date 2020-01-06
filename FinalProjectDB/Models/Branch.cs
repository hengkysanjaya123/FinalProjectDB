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
        private int id;
        private string branchName;

        public int Id { get => id; set => id = value; }
        public string BranchName { get => branchName; set => branchName = value; }

        public Branch()
        {
        }

        public Branch(string branchName)
        {
            this.branchName = branchName;
        }

        public Branch(int id, string branchName)
        {
            this.id = id;
            this.branchName = branchName;
        }

        public void AddBranch()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand insertBranch = connection.CreateCommand();
                insertBranch.CommandText = "INSERT INTO branch(Name) VALUES (@branchname)";
                insertBranch.Parameters.AddWithValue("@branchname", branchName);
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
    }
}
