using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB
{
    class Level
    {
        private DBConnection conn = new DBConnection();

        public int Id { get; set; }
        public string LevelName { get; set; }

        public Level()
        {
        }

        public Level(string levelName)
        {
            this.LevelName = levelName;
        }

        public Level(int id, string levelName)
        {
            this.Id = id;
            this.LevelName = levelName;
        }

        public void AddLevel()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand insertLevel = connection.CreateCommand();
                insertLevel.CommandText = "INSERT INTO level(Name) VALUES (@levelname)";
                insertLevel.Parameters.AddWithValue("@levelname", LevelName);
                insertLevel.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:", ex.ToString());
            }

        }

        public List<Level> RetrieveLevels()
        {
            try
            {
                List<Level> levelList = new List<Level>();
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand getLevels = connection.CreateCommand();
                getLevels.CommandText = "SELECT * FROM level";
                MySqlDataReader levels = getLevels.ExecuteReader();
                while (levels.Read())
                {
                    int thisid = levels.GetInt32(0);
                    string thisname = levels.GetString(1);
                    levelList.Add(new Level(Convert.ToInt32(thisid), thisname));
                }
                connection.Close();
                return levelList;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.Message);
                return null;
            }
        }

        public void UpdateLevel()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand insertDepartment = connection.CreateCommand();
                insertDepartment.CommandText = "UPDATE level SET Name = @name WHERE ID = @id";
                insertDepartment.Parameters.AddWithValue("@name", LevelName);
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

        public void DeleteLevel(int id)
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "DELETE FROM level WHERE ID = @id";
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
