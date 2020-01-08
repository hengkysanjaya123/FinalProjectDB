using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB
{
    class DBConnection
    {
        private string server = "localhost";
        private string database = "fp_db_nrhr";
        private string uid = "root";
        private string password = "";

        public MySqlConnection OpenConnection()
        {
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";ConvertZeroDateTime=True ";
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                return connection;
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message);
                return null;
            }


        }
    }
}