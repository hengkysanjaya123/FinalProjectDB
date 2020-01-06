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

        private void employeeDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new ReportForm());
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


                    MessageBox.Show("Data Inserted Successfully!");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
