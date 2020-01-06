using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDB
{
    class Employee
    {
        private DBConnection conn;
        private int NIK;
        private string fullName;
        private string nickname;
        private string KTP;
        private string jamsostek;
        private int bankID;
        private string rekening;
        private string NPWP;
        private string statusPajak;
        private DateTime DOB;
        private string gender;
        private string religion;
        private string maritalStatus;

        public Employee(int nIK, string fullName, string nickname, string kTP, string jamsostek, int bankID, string rekening, string nPWP, string statusPajak, DateTime dOB, string gender, string religion, string maritalStatus)
        {
            this.NIK = nIK;
            this.fullName = fullName;
            this.nickname = nickname;
            this.KTP = kTP;
            this.jamsostek = jamsostek;
            this.bankID = bankID;
            this.rekening = rekening;
            this.NPWP = nPWP;
            this.statusPajak = statusPajak;
            this.DOB = dOB;
            this.gender = gender;
            this.religion = religion;
            this.maritalStatus = maritalStatus;
        }

        public void CreateEmployee()
        {
            MySqlConnection connection = conn.OpenConnection();
            MySqlCommand insertEmployee = connection.CreateCommand();
            insertEmployee.CommandText = "INSERT INTO employee(NIK, Fullname, Nickname, KTP, " +
                "Jamsostek, BankID, Rekening, NPWP, StatusPajak, DOB, Gender, Religion, MaritalStatus) " +
                "VALUES (@nik, @fullname, @nickname, @ktp, @jamsostek, @bankid, @rekening, @npwp, " +
                "@statuspajak, @dob, @gender, @religion, @maritalstatus)";

            insertEmployee.Parameters.AddWithValue("@nik", NIK.ToString());
            insertEmployee.Parameters.AddWithValue("@fullname", fullName);
            insertEmployee.Parameters.AddWithValue("@nickname", nickname);
            insertEmployee.Parameters.AddWithValue("@ktp", KTP);
            insertEmployee.Parameters.AddWithValue("@jamsostek", jamsostek);
            insertEmployee.Parameters.AddWithValue("@bankid", bankID.ToString());






        }

        public void RetrieveEmployees()
        {

        }

        public void UpdateEmployee()
        {

        }

        public void DeleteEmployee()
        {

        }

    
    }
}
