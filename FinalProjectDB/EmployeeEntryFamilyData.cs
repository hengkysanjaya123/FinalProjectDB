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
    public partial class EmployeeEntryFamilyData : core
    {
        bool formReady = false;

        public EmployeeEntryFamilyData()
        {
            InitializeComponent();
        }

        private void EmployeeEntryFamilyData_Load(object sender, EventArgs e)
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

            comboBox2.Items.Add("Male");
            comboBox2.Items.Add("Female");

            var employeeRelationship = new EmployeeRelationship();
            var q2 = employeeRelationship.RetrieveRelationships();
            comboBox3.DisplayMember = "Relationship";
            comboBox3.DataSource = q2;

            formReady = true;
            LoadEmployeeData();
            LoadFamilyData();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (formReady)
            {
                LoadEmployeeData();

                LoadFamilyData();
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

                string name = textBox1.Text;
                string gender = comboBox2.SelectedItem.ToString()[0].ToString();
                var dob = dateTimePicker1.Value;
                var relationship = comboBox3.SelectedValue as EmployeeRelationship;

                var employee = (Employee)comboBox1.SelectedValue;


                EmployeeFamily ef = new EmployeeFamily(0, name, gender, dob, relationship.Id, employee.NIK);
                ef.AddEmployeeFamily();

                LoadFamilyData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadFamilyData()
        {
            var ef = new EmployeeFamily();
            var employee = (Employee)comboBox1.SelectedValue;

            var q = ef.RetrieveEmployeeFamily(employee.NIK);
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
                var em = new EmployeeFamily();
                em.DeleteEmployeeFamily(int.Parse(id));

                LoadFamilyData();
            }
        }
    }
}
