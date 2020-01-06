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
    public partial class PosForm : core
    {
        Pos pos = new Pos();

        public PosForm()
        {
            InitializeComponent();
        }

        private void PosForm_Load(object sender, EventArgs e)
        {
            LoadPos();
        }

        public void LoadPos()
        {
            Reset();

            var q = pos.RetrievePos();

            dataGridView1.DataSource = q;
            dataGridView1.CurrentCell = null;

            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please input Position Name");
                return;
            }

            var btnAction = btnInsert.Text;
            if (btnAction == "Insert")
            {
                pos.PosName = textBox1.Text;
                pos.AddPos();
            }
            else if (btnAction == "Update")
            {
                var currentSelectedId = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                pos.Id = int.Parse(currentSelectedId);
                pos.PosName = textBox1.Text;

                pos.UpdatePos();

            }

            LoadPos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select data in datagridview first");
                return;
            }

            var id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            pos.DeletePos(int.Parse(id));

            LoadPos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadPos();
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
                textBox1.Text = dataGridView1.CurrentRow.Cells["PosName"].Value.ToString();
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
