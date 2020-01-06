using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB
{
    class Pos
    {
        private DBConnection conn = new DBConnection();
        private int id;
        private string posName;

        public int Id { get => id; set => id = value; }
        public string PosName { get => posName; set => posName = value; }

        public Pos()
        {
        }

        public Pos(string posName)
        {
            this.posName = posName;
        }

        public Pos(int id, string posName)
        {
            this.id = id;
            this.posName = posName;
        }

        public void AddPos()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand insertPos = connection.CreateCommand();
                insertPos.CommandText = "INSERT INTO pos(Name) VALUES (@posname)";
                insertPos.Parameters.AddWithValue("@posname", posName);
                insertPos.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:", ex.ToString());
            }

        }

        public List<Pos> RetrievePos()
        {
            try
            {
                List<Pos> posList = new List<Pos>();
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand getPos = connection.CreateCommand();
                getPos.CommandText = "SELECT * FROM pos";
                MySqlDataReader poss = getPos.ExecuteReader();
                while (poss.Read())
                {
                    int thisid = poss.GetInt32(0);
                    string thisname = poss.GetString(1);
                    posList.Add(new Pos(Convert.ToInt32(thisid), thisname));
                }
                connection.Close();
                return posList;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.Message);
                return null;
            }
        }
    }
}
