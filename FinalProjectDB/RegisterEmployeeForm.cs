using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB
{
    public partial class RegisterEmployeeForm : core
    {
        public RegisterEmployeeForm()
        {
            InitializeComponent();
        }

        private void RegisterEmployeeForm_Load(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            var q = employee.RetrieveEmployees().Select(x => new
            {
                Display = x.fullName + " - " + x.NIK,
                Value = x
            }).ToList();
            comboBox1.DisplayMember = "Display";
            comboBox1.ValueMember = "Value";
            comboBox1.DataSource = q;

            ContractType ct = new ContractType();
            var q2 = ct.RetrieveContractTypes();
            comboBox2.DisplayMember = "ContractTypeName";
            comboBox2.DataSource = q2;

            Branch b = new Branch();
            var q3 = b.RetrieveBranches();
            comboBox3.DisplayMember = "BranchName";
            comboBox3.DataSource = q3;

            Department d = new Department();
            var q4 = d.RetrieveDepartments();
            comboBox4.DisplayMember = "DepartmentName";
            comboBox4.DataSource = q4;

            Pos p = new Pos();
            var q5 = p.RetrievePos();
            comboBox5.DisplayMember = "PosName";
            comboBox5.DataSource = q5;

            Level l = new Level();
            var q6 = l.RetrieveLevels();
            comboBox6.DisplayMember = "LevelName";
            comboBox6.DataSource = q6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var conn = new DBConnection();
                MySqlConnection connection = conn.OpenConnection();
                connection.Open();

                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO transaction(NIK, TransactionTypeID, NoSurat,EffectiveDate, " +
                                    "EndDate, ContractTypeID, BranchID, DepartmentID, PositionID, " +
                                    "LevelID, Reasons, Notes) VALUES " +
                                    "(@NIK, @TransactionTypeID, @NoSurat,@EffectiveDate, " +
                                    "@EndDate, @ContractTypeID, @BranchID, @DepartmentID, @PositionID, " +
                                    "@LevelID, @Reasons, @Notes)";

                var employee = comboBox1.SelectedValue as Employee;
                var ct = comboBox2.SelectedValue as ContractType;
                var branch = comboBox3.SelectedValue as Branch;
                var department = comboBox4.SelectedValue as Department;
                var pos = comboBox5.SelectedValue as Pos;
                var level = comboBox6.SelectedValue as Level;
                var enddate = dateTimePicker1.Value.Date;
                var noSurat = textBox1.Text;
                var reason = textBox2.Text;
                var notes = richTextBox1.Text;

                cmd.Parameters.AddWithValue("@NIK", employee.NIK);
                cmd.Parameters.AddWithValue("@TransactionTypeID", 2) ; // karyawan baru
                cmd.Parameters.AddWithValue("@NoSurat", noSurat);
                cmd.Parameters.AddWithValue("@EffectiveDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@EndDate", enddate);
                cmd.Parameters.AddWithValue("@ContractTypeID", ct.Id);
                cmd.Parameters.AddWithValue("@BranchID", branch.Id);
                cmd.Parameters.AddWithValue("@DepartmentID", department.Id);
                cmd.Parameters.AddWithValue("@PositionID", pos.Id);
                cmd.Parameters.AddWithValue("@LevelID", level.Id);
                cmd.Parameters.AddWithValue("@Reasons", reason);
                cmd.Parameters.AddWithValue("@Notes", notes);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:"+ ex.ToString());
            }
        }
    }
}
