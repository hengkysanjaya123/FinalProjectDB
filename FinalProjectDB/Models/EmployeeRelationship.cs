using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB
{
    class EmployeeRelationship
    {
        private DBConnection conn = new DBConnection();

        public int Id { get; set; }
        public string Relationship { get; set; }

        public EmployeeRelationship()
        {
        }

        public EmployeeRelationship(int id, string relationship)
        {
            this.Id = id;
            this.Relationship = relationship;
        }


        public List<EmployeeRelationship> RetrieveRelationships()
        {
            List<EmployeeRelationship> list = new List<EmployeeRelationship>();
            MySqlConnection connection = conn.OpenConnection();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM EmployeeRelationship";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int thisid = reader.GetInt32("ID");
                string relationship = reader.GetString("Relationship");
                list.Add(new EmployeeRelationship(Convert.ToInt32(thisid), relationship));
            }
            connection.Close();
            return list;
        }
    }
}
