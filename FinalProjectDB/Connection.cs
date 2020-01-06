using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FinalProjectDB
{
    public class Connection
    {
        MySqlConnection con;

        public bool Connect()
        {
            try
            {
                string connection = "server=localhost;database=fp_db_nrhr;uid=root;pwd=";
                con = new MySqlConnection(connection);
                con.Open();
                return true;
            }
            catch
            {
                Console.WriteLine("Connection Failed to open");
                return false;
            }
        }

    }
}
