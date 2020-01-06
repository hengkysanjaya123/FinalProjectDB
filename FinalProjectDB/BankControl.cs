using MySql.Data.MySqlClient;
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
    public partial class BankControl : Form
    {
        public BankControl()
        {
            InitializeComponent();
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                banksList.Rows.Clear();
                Bank newBank = new Bank();
                List<Bank> bankList = newBank.RetrieveBanks();
                foreach (Bank bank in bankList)
                {
                    string id = Convert.ToString(bank.Id);
                    string bankName = bank.BankName;
                    string[] row = new string[] { id, bankName };
                    banksList.Rows.Add(row);

                }
            }
        }

        private void addNewBank_Click(object sender, EventArgs e)
        {
            Bank newBank = new Bank(newBankText.Text);
            newBank.AddBank();

        }

        private void BankControl_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BanksList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}