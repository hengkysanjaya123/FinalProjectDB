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
    public partial class EmployeeEntryPhoneData : core
    {
        bool formReady = false;

        public EmployeeEntryPhoneData()
        {
            InitializeComponent();
        }

        private void EmployeeEntryPhoneData_Load(object sender, EventArgs e)
        {
            var employee = new Employee();
            var q = employee.RetrieveEmployees().Select(x => new
            {
                Display = x.nickname + " - " + x.NIK,
                Value = x
            }).ToList();
            comboBox1.DisplayMember = "Display";
            comboBox1.ValueMember = "Value";
            comboBox1.DataSource = q;

            comboBox3.Items.Add("Home");
            comboBox3.Items.Add("Mobile");
            comboBox3.Items.Add("Work");

            var employeePhone = new Models.EmployeePhone();
            formReady = true;
            LoadEmployeeData();
            LoadPhoneData();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (formReady)
            {
                LoadEmployeeData();

                LoadPhoneData();
            }
        }

        private void LoadEmployeeData()
        {
            var employee = (Employee)comboBox1.SelectedValue;
            var list = new List<Employee>() { employee };
            dataGridView1.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Validation(groupBox1))
            {
                MessageBox.Show("All data must be filled");
                return;
            }
            try
            {

                string phonenumber = textBox1.Text;
                string phoneType = comboBox3.SelectedItem.ToString();

                var employee = (Employee)comboBox1.SelectedValue;

                MessageBox.Show((Convert.ToString(employee.NIK) + phonenumber + phoneType));
                Models.EmployeePhone ef = new Models.EmployeePhone(employee.NIK, phonenumber, phoneType);
                ef.AddEmployeePhone();

                LoadPhoneData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadPhoneData()
        {
            var ef = new Models.EmployeePhone();
            var employee = (Employee)comboBox1.SelectedValue;

            var q = ef.RetrievePhoneNumbers(employee.NIK);
            dataGridView2.DataSource = q;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Please choose the data in the datagridview first");
                return;
            }

            var msg = MessageBox.Show("Are you sure to delete this data ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                var id = dataGridView2.CurrentRow.Cells["Id"].Value.ToString();
                var em = new Models.EmployeePhone();
                em.DeleteEmployeePhone(int.Parse(id));

                LoadPhoneData();
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
