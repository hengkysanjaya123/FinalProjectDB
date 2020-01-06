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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void OpenForm(Form form)
        {
            form.MdiParent = this;
            form.TopLevel = false;
            form.Show();
        }

        private void bankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new BankForm());
        }

        private void branchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new BranchForm());
        }

        private void contractTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new ContractTypeForm());
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new DepartmentForm());
        }



        private void registerNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new RegisterNewEmployeeForm());
        }

        private void registerEmployeeFamilyDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new EmployeeEntryFamilyData());
        }
    }
}
