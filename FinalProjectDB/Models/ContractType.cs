using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB
{
    class ContractType
    {
        private DBConnection conn = new DBConnection();
        public int Id { get; set; }
        public string ContractTypeName { get; set; }

        public ContractType()
        {
        }

        public ContractType(string contractTypeName)
        {
            this.ContractTypeName = contractTypeName;
        }

        public ContractType(int id, string contractTypeName)
        {
            this.Id = id;
            this.ContractTypeName = contractTypeName;
        }

        public void AddContractType()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand insertContractType = connection.CreateCommand();
                insertContractType.CommandText = "INSERT INTO contracttype(Name) VALUES (@contracttypename)";
                insertContractType.Parameters.AddWithValue("@contracttypename", ContractTypeName);
                insertContractType.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:", ex.ToString());
            }

        }

        public List<ContractType> RetrieveContractTypes()
        {
            try
            {
                List<ContractType> contractTypeList = new List<ContractType>();
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand getContractTypes = connection.CreateCommand();
                getContractTypes.CommandText = "SELECT * FROM contracttype";
                MySqlDataReader contractTypes = getContractTypes.ExecuteReader();
                while (contractTypes.Read())
                {
                    int thisid = contractTypes.GetInt32(0);
                    string thisname = contractTypes.GetString(1);
                    contractTypeList.Add(new ContractType(Convert.ToInt32(thisid), thisname));
                }
                connection.Close();
                return contractTypeList;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.Message);
                return null;
            }
        }
        public void UpdateContractType()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand insertDepartment = connection.CreateCommand();
                insertDepartment.CommandText = "UPDATE contracttype SET Name = @name WHERE ID = @id";
                insertDepartment.Parameters.AddWithValue("@name", ContractTypeName);
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

        public void DeleteContractType(int id)
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "DELETE FROM contracttype WHERE ID = @id";
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
