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
    public partial class EmployeeEntryJobHistoryData : core
    {
        bool formReady = false;

        public EmployeeEntryJobHistoryData()
        {
            InitializeComponent();
        }

        private void EmployeeEntryJobHistoryData_Load(object sender, EventArgs e)
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

            var emp = new Models.EmployeeJobHistory();
            formReady = true;
            LoadEmployeeData();
            LoadHistoryData();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (formReady)
            {
                LoadEmployeeData();

                LoadHistoryData();
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

                string company = textBox1.Text;
                string pos = textBox2.Text;

                var employee = (Employee)comboBox1.SelectedValue;

                Models.EmployeeJobHistory ef = new Models.EmployeeJobHistory(employee.NIK, company, pos);
                ef.AddJobHistory();

                LoadHistoryData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadHistoryData()
        {
            var ef = new Models.EmployeeJobHistory();
            var employee = (Employee)comboBox1.SelectedValue;

            var q = ef.RetrieveJobHistory(employee.NIK);
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
                var em = new Models.EmployeeJobHistory();
                em.DeleteJobHistory(int.Parse(id));

                LoadHistoryData();
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

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
