using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using MySql.Data.MySqlClient;

namespace FinalProjectDB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void OpenForm(Form form)
        {
            form.MdiParent = this;
            form.TopLevel = false;
            form.Show();
        }

        private void bankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new BankForm());
        }

        private void branchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new BranchForm());
        }

        private void contractTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new ContractTypeForm());
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new DepartmentForm());
        }

        private void levelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new LevelForm());
        }
        private void posToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new PosForm());
        }
        private void transactionTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new TransactionTypeForm());
        }


        private void registerNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new RegisterNewEmployeeForm());
        }

        private void registerEmployeeFamilyDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new EmployeeEntryFamilyData());
        }

        private void registerEmployeePhoneDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new EmployeeEntryPhoneData());
        }
        private void registerEmployeeEmailDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new EmployeeEntryEmailData());
        }
        private void registerEmployeeAddressDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new EmployeeEntryAddressData());
        }
        private void registerEmployeeEducationDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new EmployeeEntryEducationData());
        }
        private void registerEmployeeJobHistoryDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new EmployeeEntryJobHistoryData());
        }


        private void employeeDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new EmployeeReportForm());
        }

        private void importDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void importPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "CSV Files|*.csv";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    StreamReader reader = new StreamReader(op.FileName);
                    string line = "";
                    reader.ReadLine(); // skip header

                    string query = "INSERT INTO pos (Name) VALUES ";
                    string values = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        values += "('" + line.ToString() + "'),";
                    }
                    values = values.Substring(0, values.Length - 1);

                    query = query + values;

                    DBConnection conn = new DBConnection();
                    MySqlConnection connection = conn.OpenConnection();
                    connection.Open();

                    Console.WriteLine(query);
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Data Imported Successfully!");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void transactionReportFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new TransactionFormReport());
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            core.formLogin.Show();
            this.Close();
        }

        private void contractTypeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "CSV Files|*.csv";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    StreamReader reader = new StreamReader(op.FileName);
                    string line = "";
                    reader.ReadLine(); // skip header

                    string query = "INSERT INTO contracttype (Name) VALUES ";
                    string values = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        values += "('" + line.ToString() + "'),";
                    }
                    values = values.Substring(0, values.Length - 1);

                    query = query + values;

                    DBConnection conn = new DBConnection();
                    MySqlConnection connection = conn.OpenConnection();
                    connection.Open();

                    Console.WriteLine(query);
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Data Imported Successfully!");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void branchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "CSV Files|*.csv";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    StreamReader reader = new StreamReader(op.FileName);
                    string line = "";
                    reader.ReadLine(); // skip header

                    string query = "INSERT INTO branch (Name) VALUES ";
                    string values = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        values += "('" + line.ToString() + "'),";
                    }
                    values = values.Substring(0, values.Length - 1);

                    query = query + values;

                    DBConnection conn = new DBConnection();
                    MySqlConnection connection = conn.OpenConnection();
                    connection.Open();

                    Console.WriteLine(query);
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Data Imported Successfully!");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bankToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "CSV Files|*.csv";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    StreamReader reader = new StreamReader(op.FileName);
                    string line = "";
                    reader.ReadLine(); // skip header

                    string query = "INSERT INTO bank (Name) VALUES ";
                    string values = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        values += "('" + line.ToString() + "'),";
                    }
                    values = values.Substring(0, values.Length - 1);

                    query = query + values;

                    DBConnection conn = new DBConnection();
                    MySqlConnection connection = conn.OpenConnection();
                    connection.Open();

                    Console.WriteLine(query);
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Data Imported Successfully!");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void levelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "CSV Files|*.csv";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    StreamReader reader = new StreamReader(op.FileName);
                    string line = "";
                    reader.ReadLine(); // skip header

                    string query = "INSERT INTO level (Name) VALUES ";
                    string values = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        values += "('" + line.ToString() + "'),";
                    }
                    values = values.Substring(0, values.Length - 1);

                    query = query + values;

                    DBConnection conn = new DBConnection();
                    MySqlConnection connection = conn.OpenConnection();
                    connection.Open();

                    Console.WriteLine(query);
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Data Imported Successfully!");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void transactionTypeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "CSV Files|*.csv";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    StreamReader reader = new StreamReader(op.FileName);
                    string line = "";
                    reader.ReadLine(); // skip header

                    string query = "INSERT INTO transactiontype (Name) VALUES ";
                    string values = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        values += "('" + line.ToString() + "'),";
                    }
                    values = values.Substring(0, values.Length - 1);

                    query = query + values;

                    DBConnection conn = new DBConnection();
                    MySqlConnection connection = conn.OpenConnection();
                    connection.Open();

                    Console.WriteLine(query);
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Data Imported Successfully!");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void departmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "CSV Files|*.csv";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    StreamReader reader = new StreamReader(op.FileName);
                    string line = "";
                    reader.ReadLine(); // skip header

                    string query = "INSERT INTO department (Name) VALUES ";
                    string values = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        values += "('" + line.ToString() + "'),";
                    }
                    values = values.Substring(0, values.Length - 1);

                    query = query + values;

                    DBConnection conn = new DBConnection();
                    MySqlConnection connection = conn.OpenConnection();
                    connection.Open();

                    Console.WriteLine(query);
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Data Imported Successfully!");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registerNewEmployeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenForm(new RegisterEmployeeForm());
        }

        private void registerNewEmployeeToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            OpenForm(new RegisterNewEmployeeForm());
        }

        private void editTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new EditTransactionForm());
        }
    }
}
