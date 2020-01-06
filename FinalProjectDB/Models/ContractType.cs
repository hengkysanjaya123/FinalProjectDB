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
        private int id;
        private string contractTypeName;

        public int Id { get => id; set => id = value; }
        public string ContractTypeName { get => contractTypeName; set => contractTypeName = value; }

        public ContractType()
        {
        }

        public ContractType(string contractTypeName)
        {
            this.contractTypeName = contractTypeName;
        }

        public ContractType(int id, string contractTypeName)
        {
            this.id = id;
            this.contractTypeName = contractTypeName;
        }

        public void AddContractType()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand insertContractType = connection.CreateCommand();
                insertContractType.CommandText = "INSERT INTO contracttype(Name) VALUES (@contracttypename)";
                insertContractType.Parameters.AddWithValue("@contracttypename", contractTypeName);
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
    }

}
