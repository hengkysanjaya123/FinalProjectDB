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
    public partial class BranchForm : core
    {
        Branch branch = new Branch();

        public BranchForm()
        {
            InitializeComponent();
        }

        private void BranchForm_Load(object sender, EventArgs e)
        {
            LoadBranches();
        }

        public void LoadBranches()
        {
            Reset();

            var q = branch.RetrieveBranches();

            dataGridView1.DataSource = q;
            dataGridView1.CurrentCell = null;

            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please input Branch Name");
                return;
            }

            var btnAction = btnInsert.Text;
            if (btnAction == "Insert")
            {
                branch.BranchName = textBox1.Text;
                branch.AddBranch();
            }
            else if (btnAction == "Update")
            {
                var currentSelectedId = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                branch.Id = int.Parse(currentSelectedId);
                branch.BranchName = textBox1.Text;

                branch.UpdateBranch();

            }

            LoadBranches();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select data in datagridview first");
                return;
            }

            var id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            branch.DeleteBranch(int.Parse(id));

            LoadBranches();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadBranches();
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
                textBox1.Text = dataGridView1.CurrentRow.Cells["BranchName"].Value.ToString();
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
