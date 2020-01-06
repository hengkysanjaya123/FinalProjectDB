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
    public partial class TransactionTypeForm : core
    {
        TransactionType transactionType = new TransactionType();

        public TransactionTypeForm()
        {
            InitializeComponent();
        }

        private void TransactionTypeForm_Load(object sender, EventArgs e)
        {
            LoadTransactionTypes();
        }

        public void LoadTransactionTypes()
        {
            Reset();

            var q = transactionType.RetrieveTransactionTypes();

            dataGridView1.DataSource = q;
            dataGridView1.CurrentCell = null;

            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please input Transaction Type Name");
                return;
            }

            var btnAction = btnInsert.Text;
            if (btnAction == "Insert")
            {
                transactionType.TransactionTypeName = textBox1.Text;
                transactionType.AddTransactionType();
            }
            else if (btnAction == "Update")
            {
                var currentSelectedId = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                transactionType.Id = int.Parse(currentSelectedId);
                transactionType.TransactionTypeName = textBox1.Text;

                transactionType.UpdateTransactionType();

            }

            LoadTransactionTypes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select data in datagridview first");
                return;
            }

            var id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            transactionType.DeleteTransactionType(int.Parse(id));

            LoadTransactionTypes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadTransactionTypes();
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
                textBox1.Text = dataGridView1.CurrentRow.Cells["TransactionTypeName"].Value.ToString();
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
