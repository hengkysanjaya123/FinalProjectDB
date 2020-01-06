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

        public int Id { get; set; }
        public string BankName { get; set; }

        public Bank()
        {

        }
        public Bank(int id, string bankname)
        {
            this.Id = id;
            this.BankName = bankname;
        }
        public Bank(string bankName)
        {
            this.BankName = bankName;
        }


        public void AddBank()
        {
            try
            { 
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand insertBank = connection.CreateCommand();
                insertBank.CommandText = "INSERT INTO bank(Name) VALUES (@bankname)";
                insertBank.Parameters.AddWithValue("@bankname", BankName);
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
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand insertDepartment = connection.CreateCommand();
                insertDepartment.CommandText = "UPDATE bank SET Name = @name WHERE ID = @id";
                insertDepartment.Parameters.AddWithValue("@name", BankName);
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

        public void DeleteBank(int id)
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "DELETE FROM bank WHERE ID = @id";
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
