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
    public partial class LevelForm : core
    {
        Level level = new Level();

        public LevelForm()
        {
            InitializeComponent();
        }

        private void LevelForm_Load(object sender, EventArgs e)
        {
            LoadLevels();
        }

        public void LoadLevels()
        {
            Reset();

            var q = level.RetrieveLevels();

            dataGridView1.DataSource = q;
            dataGridView1.CurrentCell = null;

            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please input Level Name");
                return;
            }

            var btnAction = btnInsert.Text;
            if (btnAction == "Insert")
            {
                level.LevelName = textBox1.Text;
                level.AddLevel();
            }
            else if (btnAction == "Update")
            {
                var currentSelectedId = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                level.Id = int.Parse(currentSelectedId);
                level.LevelName = textBox1.Text;

                level.UpdateLevel();

            }

            LoadLevels();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select data in datagridview first");
                return;
            }

            var id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            level.DeleteLevel(int.Parse(id));

            LoadLevels();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadLevels();
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
                textBox1.Text = dataGridView1.CurrentRow.Cells["LevelName"].Value.ToString();
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
