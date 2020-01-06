using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB
{
    class TransactionType
    {
        private DBConnection conn = new DBConnection();

        public int Id { get; set; }
        public string TransactionTypeName { get; set; }

        public TransactionType()
        {
        }

        public TransactionType(string transactionName)
        {
            this.TransactionTypeName = transactionName;
        }

        public TransactionType(int id, string transactionName)
        {
            this.Id = id;
            this.TransactionTypeName = transactionName;
        }

        public void AddTransactionType()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand insertTransactionType = connection.CreateCommand();
                insertTransactionType.CommandText = "INSERT INTO transactiontype(Name) VALUES (@transactionname)";
                insertTransactionType.Parameters.AddWithValue("@transactionname", TransactionTypeName);
                insertTransactionType.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully!");
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.Message);
            }
        }

        public List<TransactionType> RetrieveTransactionTypes()
        {
            try
            {
                List<TransactionType> transactionTypeList = new List<TransactionType>();
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand getTransactionTypes = connection.CreateCommand();
                getTransactionTypes.CommandText = "SELECT * FROM transactiontype";
                MySqlDataReader transactionTypes = getTransactionTypes.ExecuteReader();
                while (transactionTypes.Read())
                {
                    int thisid = transactionTypes.GetInt32(0);
                    string thisname = transactionTypes.GetString(1);
                    transactionTypeList.Add(new TransactionType(Convert.ToInt32(thisid), thisname));
                }
                connection.Close();
                return transactionTypeList;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.Message);
                return null;
            }
        }
        public void UpdateTransactionType()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand insertDepartment = connection.CreateCommand();
                insertDepartment.CommandText = "UPDATE transactiontype SET Name = @name WHERE ID = @id";
                insertDepartment.Parameters.AddWithValue("@name", TransactionTypeName);
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

        public void DeleteTransactionType(int id)
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "DELETE FROM transactiontype WHERE ID = @id";
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
