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
    public partial class DepartmentForm : core
    {
        Department department = new Department();

        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            LoadDepartments();
        }

        public void LoadDepartments()
        {
            Reset();

            var q = department.RetrieveDepartments();

            dataGridView1.DataSource = q;
            dataGridView1.CurrentCell = null;

            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please input Department Name");
                return;
            }

            var btnAction = btnInsert.Text;
            if (btnAction == "Insert")
            {
                department.DepartmentName = textBox1.Text;
                department.AddDepartment();
            }
            else if (btnAction == "Update")
            {
                var currentSelectedId = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                department.Id = int.Parse(currentSelectedId);
                department.DepartmentName = textBox1.Text;

                department.UpdateDepartment();
                
            }

            LoadDepartments();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select data in datagridview first");
                return;
            }

            var id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            department.DeleteDepartment(int.Parse(id));

            LoadDepartments();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadDepartments();
        }

        private void Reset()
        {
            btnInsert.Text = "Insert";
            btnDelete.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells["DepartmentName"].Value.ToString();
                btnInsert.Text = "Update";
                btnDelete.Enabled = true;
            }
            catch  (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
