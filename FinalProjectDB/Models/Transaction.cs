using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB.Models
{
    class Transaction
    {
        DBConnection conn = new DBConnection();
        public int Id { get; set; }
        public int NIK { get; set; }
        public int TransactionTypeID { get; set; }
        public string NoSurat { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ContractTypeID { get; set; }
        public int BranchID { get; set; }
        public int DepartmentID { get; set; }
        public int PositionID { get; set; }
        public int LevelID { get; set; }
        public string Reason { get; set; }
        public string Notes { get; set; }

        public Transaction()
        {
        }

        public Transaction(string noSurat, DateTime effectiveDate, DateTime endDate, string reason, string notes)
        {
            NoSurat = noSurat;
            EffectiveDate = effectiveDate;
            EndDate = endDate;
            Reason = reason;
            Notes = notes;
        }

        public Transaction(int nIK, int transactionTypeID, string noSurat, DateTime effectiveDate, DateTime endDate, int contractTypeID, int branchID, int departmentID, int positionID, int levelID, string reason, string notes)
        {
            NIK = nIK;
            TransactionTypeID = transactionTypeID;
            NoSurat = noSurat;
            EffectiveDate = effectiveDate;
            EndDate = endDate;
            ContractTypeID = contractTypeID;
            BranchID = branchID;
            DepartmentID = departmentID;
            PositionID = positionID;
            LevelID = levelID;
            Reason = reason;
            Notes = notes;
        }

        public Transaction(int id, int nIK, int transactionTypeID, string noSurat, DateTime effectiveDate, DateTime endDate, int contractTypeID, int branchID, int departmentID, int positionID, int levelID, string reason, string notes)
        {
            Id = id;
            NIK = nIK;
            TransactionTypeID = transactionTypeID;
            NoSurat = noSurat;
            EffectiveDate = effectiveDate;
            EndDate = endDate;
            ContractTypeID = contractTypeID;
            BranchID = branchID;
            DepartmentID = departmentID;
            PositionID = positionID;
            LevelID = levelID;
            Reason = reason;
            Notes = notes;
        }

        public void AddTransaction()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "INSERT INTO Transaction(NIK, TransactionTypeID, NoSurat, EffectiveDate, EndDate, " +
                    "ContractTypeID, BranchID, DepartmentID, PositionID, LevelID, Reasons, Notes) VALUES " +
                    "(@nik, @transactiontypeid, @nosurat, @effectivedate, @enddate, @contracttypeid, @branchid, " +
                    "@departmentid, @positionid, @levelid, @reasons, @notes)";
                comd.Parameters.AddWithValue("@nik", NIK);
                comd.Parameters.AddWithValue("@transactiontypeid", NIK);
                comd.Parameters.AddWithValue("@nosurat", NoSurat);
                comd.Parameters.AddWithValue("@effectivedate", EffectiveDate);
                comd.Parameters.AddWithValue("@enddate", EndDate);
                comd.Parameters.AddWithValue("@contracttypeid", ContractTypeID);
                comd.Parameters.AddWithValue("@branchid", BranchID);
                comd.Parameters.AddWithValue("@departmentid", DepartmentID);
                comd.Parameters.AddWithValue("@positionid", PositionID);
                comd.Parameters.AddWithValue("@levelid", LevelID);
                comd.Parameters.AddWithValue("@reasons", Reason);
                comd.Parameters.AddWithValue("@notes", Notes);
                comd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully!");
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.ToString());
            }
        }
        public List<Transaction> RetrieveTransaction()
        {
            try
            {
                List<Transaction> transactionList = new List<Transaction>();
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "SELECT * FROM Transaction";
                MySqlDataReader transactions = comd.ExecuteReader();
                while (transactions.Read())
                {
                    int thisid = transactions.GetInt32(0);
                    int thisNIK = transactions.GetInt32(1);
                    int thisTransactionTypeId = transactions.GetInt32(2);
                    string thisNoSurat = transactions.GetString(3);
                    DateTime thisEffectiveDate = transactions.GetDateTime(4);
                    DateTime thisEndDate = transactions.GetDateTime(5);
                    int thisContractTypeID = transactions.GetInt32(6);
                    int thisBranchID = transactions.GetInt32(7);
                    int thisDepartmentID = transactions.GetInt32(8);
                    int thisPositionID = transactions.GetInt32(9);
                    int thisLevelID = transactions.GetInt32(10);
                    string thisreasons = transactions.GetString(11);
                    string thisnotess = transactions.GetString(12);
                    transactionList.Add(new Transaction(Convert.ToInt32(thisid), thisNIK, thisTransactionTypeId, thisNoSurat,
                        thisEffectiveDate, thisEndDate, thisContractTypeID, thisBranchID, thisDepartmentID, thisPositionID, thisLevelID
                        , thisreasons, thisnotess));
                }
                connection.Close();
                return transactionList;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.Message);
                return null;
            }
        }
        public void UpdateTransaction()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "UPDATE Transaction SET NoSurat = @nosurat," +
                    " EffecttiveDate = @effectivedate" +
                    " EndDate = @enddate" +
                    " Reasons = @reason" +
                    " Notes = @notes" +
                    " WHERE NIK = @nik";
                comd.Parameters.AddWithValue("@nosurat", NoSurat);
                comd.Parameters.AddWithValue("@effectivedate", EffectiveDate);
                comd.Parameters.AddWithValue("@enddate", EndDate);
                comd.Parameters.AddWithValue("@reason", Reason);
                comd.Parameters.AddWithValue("@notes", Notes);
                comd.Parameters.AddWithValue("@nik", NIK);
                comd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully!");
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.ToString());
            }
        }
        public void DeleteTransaction(int id)
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "DELETE FROM Transaction WHERE ID = @id";
                comd.Parameters.AddWithValue("@id", id);
                comd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully!");
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.ToString());
            }

        }
    }
}
