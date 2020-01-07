using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB
{
    class Employee
    {
        private DBConnection conn = new DBConnection();
        public int NIK{ get; set; }
        public string fullName{ get; set; }
        public string nickname{ get; set; }
        public string KTP{ get; set; }
        public string jamsostek{ get; set; }
        public int bankID{ get; set; }
        public string BankName { get; set; }
        public string rekening{ get; set; }
        public string NPWP{ get; set; }
        public string statusPajak{ get; set; }
        public DateTime DOB{ get; set; }
        public string gender{ get; set; }
        public string religion{ get; set; }
        public string maritalStatus{ get; set; }


        public Employee()
        {

        }

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
            connection.Open();
            
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO employee(NIK, Fullname, Nickname, KTP, " +
                "Jamsostek, BankID, Rekening, NPWP, StatusPajak, DOB, Gender, Religion, MaritalStatus) " +
                "VALUES (@nik, @fullname, @nickname, @ktp, @jamsostek, @bankid, @rekening, @npwp, " +
                "@statuspajak, @dob, @gender, @religion, @maritalstatus)";

            cmd.Parameters.AddWithValue("@nik", NIK.ToString());
            cmd.Parameters.AddWithValue("@fullname", fullName);
            cmd.Parameters.AddWithValue("@nickname", nickname);
            cmd.Parameters.AddWithValue("@ktp", KTP);
            cmd.Parameters.AddWithValue("@jamsostek", jamsostek);
            cmd.Parameters.AddWithValue("@bankid", bankID.ToString());
            cmd.Parameters.AddWithValue("@rekening", rekening);
            cmd.Parameters.AddWithValue("@npwp", NPWP);
            cmd.Parameters.AddWithValue("@statuspajak", statusPajak);
            cmd.Parameters.AddWithValue("@dob", DOB);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@religion", religion);
            cmd.Parameters.AddWithValue("@maritalstatus", maritalStatus);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Created Successfully!");
            connection.Close();
        }

        public List<Employee> RetrieveEmployees()
        {
            List<Employee> list = new List<Employee>();
            MySqlConnection connection = conn.OpenConnection();
            connection.Open();
            MySqlCommand getBanks = connection.CreateCommand();
            getBanks.CommandText = "SELECT * FROM Employee e " +
                                    "JOIN Bank b ON e.BankID = b.ID";
            MySqlDataReader reader = getBanks.ExecuteReader();
            while (reader.Read())
            {
                int nik = (int)reader.GetInt64("NIK");
                var fullName = reader.GetString("Fullname");
                var nickName = reader.GetString("Nickname");
                var ktp = reader.GetString("KTP");
                var jamsostek = reader.GetString("Jamsostek");
                var bankName = reader.GetString("Name");
                var bankId = (int)reader.GetInt64("BankID");
                var rekening = reader.GetString("Rekening");
                var npwp = reader.GetString("NPWP");
                var statusPajak = reader.GetString("StatusPajak");
                var dob = reader.GetDateTime("DOB");
                var gender = reader.GetString("Gender");
                var religion = reader.GetString("Religion");
                var maritalStatus = reader.GetString("MaritalStatus");



                var employee = new Employee(nik, fullName, nickName, ktp, jamsostek, bankId, rekening, npwp, statusPajak, dob, gender, religion, maritalStatus);
                employee.BankName = bankName;
                list.Add(employee);
            }
            connection.Close();
            return list;
        }

        public void UpdateEmployee()
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "UPDATE employee SET Fullname = @fullname, Nickname = @nickname, " +
                    "KTP = @ktp, Jamsostek = @jamsostek, " +
                    "BankID = @bankid, Rekening = @rekening, " +
                    "NPWP = @npwp, StatusPajak = @statuspajak, " +
                    "DOB = @dob, Gender = @gender, " +
                    "Relgion = @religion, MaritalStatus = @maritalstatus" +
                    " WHERE NIK = @nik";
                comd.Parameters.AddWithValue("@fullname", fullName);
                comd.Parameters.AddWithValue("@nickname", nickname);
                comd.Parameters.AddWithValue("@ktp", KTP);
                comd.Parameters.AddWithValue("@jamsostek", jamsostek);
                comd.Parameters.AddWithValue("@bankid", bankID);
                comd.Parameters.AddWithValue("@rekening", rekening);
                comd.Parameters.AddWithValue("@npwp", NPWP);
                comd.Parameters.AddWithValue("@statuspajak", statusPajak);
                comd.Parameters.AddWithValue("@dob", DOB);
                comd.Parameters.AddWithValue("@gender", gender);
                comd.Parameters.AddWithValue("@religion", religion);
                comd.Parameters.AddWithValue("@maritalstatus", maritalStatus);
                comd.Parameters.AddWithValue("@NIK", NIK);
                comd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully!");
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:", ex.Message);
            }

        }

        public void DeleteEmployee(int delNIK)
        {
            try
            {
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();
                MySqlCommand comd = connection.CreateCommand();
                comd.CommandText = "DELETE FROM employee WHERE NIK = @nik";
                comd.Parameters.AddWithValue("@nik", delNIK);
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
