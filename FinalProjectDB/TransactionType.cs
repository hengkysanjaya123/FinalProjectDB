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
        private int id;
        private string transactionTypeName;

        public int Id { get => id; set => id = value; }
        public string TransactionName { get => transactionTypeName; set => transactionTypeName = value; }

        public TransactionType()
        {
        }

        public TransactionType(string transactionName)
        {
            this.transactionTypeName = transactionName;
        }

        public TransactionType(int id, string transactionName)
        {
            this.id = id;
            this.transactionTypeName = transactionName;
        }

        public void AddTransactionType()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand insertTransactionType = connection.CreateCommand();
                insertTransactionType.CommandText = "INSERT INTO transactiontype(Name) VALUES (@transactionname)";
                insertTransactionType.Parameters.AddWithValue("@transactionname", transactionTypeName);
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
    }
}
