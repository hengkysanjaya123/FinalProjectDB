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
        public int Id { get; set; }
        public string PosName { get; set; }

        public Pos()
        {
        }

        public Pos(string posName)
        {
            this.PosName = posName;
        }

        public Pos(int id, string posName)
        {
            this.Id = id;
            this.PosName = posName;
        }

        public void AddPos()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand insertPos = connection.CreateCommand();
                insertPos.CommandText = "INSERT INTO pos(Name) VALUES (@posname)";
                insertPos.Parameters.AddWithValue("@posname", PosName);
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
        public void UpdatePos()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand insertDepartment = connection.CreateCommand();
                insertDepartment.CommandText = "UPDATE pos SET Name = @name WHERE ID = @id";
                insertDepartment.Parameters.AddWithValue("@name", PosName);
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

        public void DeletePos(int id)
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "DELETE FROM pos WHERE ID = @id";
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
