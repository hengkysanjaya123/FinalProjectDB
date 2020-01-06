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
        private int id;
        private string levelName;

        public int Id { get => id; set => id = value; }
        public string LevelName { get => levelName; set => levelName = value; }

        public Level()
        {
        }

        public Level(string levelName)
        {
            this.levelName = levelName;
        }

        public Level(int id, string levelName)
        {
            this.id = id;
            this.levelName = levelName;
        }

        public void AddLevel()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand insertLevel = connection.CreateCommand();
                insertLevel.CommandText = "INSERT INTO level(Name) VALUES (@levelname)";
                insertLevel.Parameters.AddWithValue("@levelname", levelName);
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
    }
}
