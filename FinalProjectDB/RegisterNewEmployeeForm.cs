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
    public partial class RegisterNewEmployeeForm : core
    {
        public RegisterNewEmployeeForm()
        {
            InitializeComponent();
        }

        private void RegisterNewEmployeeForm_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Male");
            comboBox2.Items.Add("Female");

            LoadComboboxBank();
            LoadEmployees();
        }

        public void LoadComboboxBank()
        {
            Bank b = new Bank();
            var q = b.RetrieveBanks();
            comboBox1.DisplayMember = "BankName";
            comboBox1.DataSource = q;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Validation(container))
            {
                MessageBox.Show("All data must be filled");
                return;
            }

            var nik = int.Parse(textBox1.Text);
            string fullName = textBox2.Text;
            string nickName = textBox3.Text;
            string ktp = textBox4.Text;
            string jamsostek = textBox5.Text;
            var selectedBank = comboBox1.SelectedValue as Bank;
            var rekening = textBox6.Text;
            string npwp = textBox7.Text;
            string statusPajak = textBox8.Text;
            DateTime dob = dateTimePicker1.Value;
            string gender = comboBox2.SelectedItem.ToString()[0].ToString();
            string religion = textBox9.Text;
            string maritalStatus = textBox10.Text;

            Employee employee = new Employee(nik, fullName, nickName, ktp, jamsostek, selectedBank.Id, rekening, npwp, statusPajak, dob, gender, religion, maritalStatus);
            employee.CreateEmployee();

            LoadEmployees();
        }

        public void LoadEmployees()
        {
            Employee e = new Employee();
            var q = e.RetrieveEmployees();
            dataGridView1.DataSource = q;
        }
    }
}
