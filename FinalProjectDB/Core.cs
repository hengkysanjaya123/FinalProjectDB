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
    public partial class core : Form
    {
        public core()
        {
            InitializeComponent();
        }

        private void Core_Load(object sender, EventArgs e)
        {
            //container.BackColor = Color.White;
            container.ForeColor = Color.Black;

            SetStyle(container);
        }

        public void SetStyle(Control ctrl)
        {
            foreach(Control a in ctrl.Controls)
            {
                if(a is Button btn)
                {
                    var text = btn.Text.ToLower();
                    if(text.Contains("delete") || text.Contains("cancel"))
                    {
                        btn.BackColor = ColorTranslator.FromHtml("#e74c3c");
                    }
                    else
                        btn.BackColor = ColorTranslator.FromHtml("#1abc9c");

                    btn.ForeColor = ColorTranslator.FromHtml("#ecf0f1");
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                }

                if (a.HasChildren)
                {
                    SetStyle(a);
                }
            }
        }

        private void container_ControlAdded(object sender, ControlEventArgs e)
        {
            SetStyle(container);
        }

        private void Core_ControlAdded(object sender, ControlEventArgs e)
        {
            SetStyle(container);

        }
    }
}
