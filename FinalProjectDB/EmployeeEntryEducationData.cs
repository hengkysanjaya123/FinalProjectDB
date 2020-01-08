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
    public partial class EmployeeEntryEducationData : core
    {
        bool formReady = false;

        public EmployeeEntryEducationData()
        {
            InitializeComponent();
        }

        private void EmployeeEntryEducationData_Load(object sender, EventArgs e)
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

            comboBox2.Items.Add("High School");
            comboBox2.Items.Add("Bachelor Degree");
            comboBox2.Items.Add("Masters Degree");
            comboBox2.Items.Add("PHD");

            formReady = true;
            LoadEmployeeData();
            LoadEducationData();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (formReady)
            {
                LoadEmployeeData();

                LoadEducationData();
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
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy";
                string institution = textBox2.Text;
                string educationlevel = comboBox2.SelectedItem.ToString();
                var major = textBox5.Text;
                var gradyear = dateTimePicker1.Value;
                var score = textBox7.Text;

                var employee = (Employee)comboBox1.SelectedValue;


                Models.EmployeeEducation ef = new Models.EmployeeEducation(employee.NIK, educationlevel, institution, major, Convert.ToDateTime(gradyear), Convert.ToInt32(score));
                ef.AddEmployeeEducation();

                LoadEducationData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadEducationData()
        {
            var ef = new Models.EmployeeEducation();
            var employee = (Employee)comboBox1.SelectedValue;

            var q = ef.RetrieveEmployeeEducation(employee.NIK);
            dataGridView2.DataSource = q;
            dataGridView2.Columns["GraduationYear"].DefaultCellStyle.Format = "yyyy";
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
                var em = new Models.EmployeeEducation();
                em.DeleteEmployeeEducation(int.Parse(id));

                LoadEducationData();
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
