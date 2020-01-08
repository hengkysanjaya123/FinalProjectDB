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
    public partial class EmployeeEntryEmailData : core
    {
        bool formReady = false;

        public EmployeeEntryEmailData()
        {
            InitializeComponent();
        }

        private void EmployeeEntryEmailData_Load(object sender, EventArgs e)
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

            var employeeEmail = new EmployeeEmail();
            formReady = true;
            LoadEmployeeData();
            LoadEmailData();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (formReady)
            {
                LoadEmployeeData();

                LoadEmailData();
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

                string emailAddress = textBox1.Text;

                var employee = (Employee)comboBox1.SelectedValue;

                EmployeeEmail ef = new EmployeeEmail(employee.NIK, emailAddress);
                ef.AddEmailAddress();

                LoadEmailData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadEmailData()
        {
            var ef = new EmployeeEmail();
            var employee = (Employee)comboBox1.SelectedValue;

            var q = ef.RetrieveEmailAddress(employee.NIK);
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

                LoadEmailData();
            }
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
        private void Label5_Click(object sender, EventArgs e)
        {

        }

}
}
