using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB
{
    class Bank
    {
        DBConnection conn = new DBConnection();
        private string bankName;
        private int id;

        public string BankName { get => bankName; set => bankName = value; }
        public int Id { get => id; set => id = value; }

        public Bank()
        {

        }
        public Bank(int id, string bankname)
        {
            this.id = id;
            this.bankName = bankname;
        }
        public Bank(string bankName)
        {
            this.bankName = bankName;
        }


        public void AddBank()
        {
            try
            { 
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand insertBank = connection.CreateCommand();
                insertBank.CommandText = "INSERT INTO bank(Name) VALUES (@bankname)";
                insertBank.Parameters.AddWithValue("@bankname", bankName);
                insertBank.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:", ex.ToString());
            }

        }
        public List<Bank> RetrieveBanks()
        {
            try
            {
                List<Bank> bankList = new List<Bank>();
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand getBanks = connection.CreateCommand();
                getBanks.CommandText = "SELECT * FROM Bank";
                MySqlDataReader banks = getBanks.ExecuteReader();
                while (banks.Read())
                {
                    int thisid = banks.GetInt32(0);
                    string thisname = banks.GetString(1);
                    bankList.Add(new Bank(Convert.ToInt32(thisid), thisname));
                }   
                connection.Close();
                return bankList;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.Message);
                return null;
            }
        }

        public void UpdateBank()
        {

        }

        public void RemoveBank()
        {

        }

    }
}
