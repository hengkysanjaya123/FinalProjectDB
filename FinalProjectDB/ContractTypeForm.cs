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
    public partial class ContractTypeForm : core
    {
        ContractType contracttype = new ContractType();

        public ContractTypeForm()
        {
            InitializeComponent();
        }

        private void ContractTypeForm_Load(object sender, EventArgs e)
        {
            LoadContractTypes();
        }

        public void LoadContractTypes()
        {
            Reset();

            var q = contracttype.RetrieveContractTypes();

            dataGridView1.DataSource = q;
            dataGridView1.CurrentCell = null;

            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please input Contract Type Name");
                return;
            }

            var btnAction = btnInsert.Text;
            if (btnAction == "Insert")
            {
                contracttype.ContractTypeName = textBox1.Text;
                contracttype.AddContractType();
            }
            else if (btnAction == "Update")
            {
                var currentSelectedId = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                contracttype.Id = int.Parse(currentSelectedId);
                contracttype.ContractTypeName = textBox1.Text;

                contracttype.UpdateContractType();

            }

            LoadContractTypes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select data in datagridview first");
                return;
            }

            var id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            contracttype.DeleteContractType(int.Parse(id));

            LoadContractTypes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadContractTypes();
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
                textBox1.Text = dataGridView1.CurrentRow.Cells["ContractTypeName"].Value.ToString();
                btnInsert.Text = "Update";
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
