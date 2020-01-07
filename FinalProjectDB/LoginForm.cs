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
    public partial class LoginForm : core
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            button2.BackColor = Color.PaleVioletRed;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Validation(container))
            {
                MessageBox.Show("All data must be filled");
            }

            var username = textBox1.Text;
            var password = textBox2.Text;

            var conn = new DBConnection();
            MySqlConnection connection = conn.OpenConnection();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select * from user where username = @username and password =@password";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            MySqlDataReader reader = cmd.ExecuteReader();
            var res = reader.Read();
            if (res == false)
            {
                MessageBox.Show("Please check your username and password");
                return;
            }

            var role = reader.GetString("role");
            currentRole = role;

            formLogin = this;

            new MainForm().Show();
            this.Hide();
            textBox1.Text = "";
            textBox2.Text = "";

            connection.Close();
        }
    }
}
