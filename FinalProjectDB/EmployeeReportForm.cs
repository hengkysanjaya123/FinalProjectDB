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
using System.Windows.Forms.DataVisualization.Charting;

namespace FinalProjectDB
{
    public partial class EmployeeReportForm : core
    {
        public EmployeeReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            LoadGenderChart();
            LoadMaritalStatus();
            LoadAges();
        }

        public void LoadGenderChart()
        {
            chart1.Titles.Clear();

            chart1.Titles.Add("");
            chart1.Titles[0].Text = "Gender Percentage";
            chart1.Titles[0].Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);

            chart1.Series.Clear();

            Series s = chart1.Series.Add("");
            s.XValueMember = "Gender";
            s.YValueMembers = "Total";
            s.ChartType = SeriesChartType.Pie;
            s.IsValueShownAsLabel = true;

            DBConnection conn = new DBConnection();
            MySqlConnection connection = conn.OpenConnection();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Gender, count(*) 'total' FROM Employee group by Gender";
            MySqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Gender");
            dt.Columns.Add("Total");
            while (reader.Read())
            {
                var gender = reader.GetString("Gender").ToString();
                dt.Rows.Add(gender == "M" ? "Male" : gender == "L" ? "Male" : "Female", reader.GetInt16("total"));
            }
            connection.Close();

            chart1.DataSource = dt;
        }

        public void LoadMaritalStatus()
        {
            chart2.Titles.Clear();

            chart2.Titles.Add("");
            chart2.Titles[0].Text = "Marital Status";
            chart2.Titles[0].Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);


            chart2.Series.Clear();

            Series s = chart2.Series.Add("Marital Status");
            s.XValueMember = "Marital Status";
            s.YValueMembers = "Total";
            s.ChartType = SeriesChartType.Column;
            s.IsValueShownAsLabel = true;

            DBConnection conn = new DBConnection();
            MySqlConnection connection = conn.OpenConnection();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT MaritalStatus, count(*) 'total' FROM Employee group by MaritalStatus";
            MySqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Marital Status");
            dt.Columns.Add("Total");
            while (reader.Read())
            {
                var maritalStatus = reader.GetString("MaritalStatus");
                dt.Rows.Add(maritalStatus, reader.GetInt16("total"));
            }
            connection.Close();

            chart2.DataSource = dt;
        }

        public void LoadAges()
        {
            chart3.Titles.Clear();

            chart3.Titles.Add("");
            chart3.Titles[0].Text = "Age";
            chart3.Titles[0].Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);



            chart3.Series.Clear();

            Series s = chart3.Series.Add("");
            s.XValueMember = "Age Category";
            s.YValueMembers = "Total";
            s.ChartType = SeriesChartType.Column;
            s.IsValueShownAsLabel = true;

            DBConnection conn = new DBConnection();
            MySqlConnection connection = conn.OpenConnection();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select if(year(now())-year(DOB) < 20, 'Under 20', " +
                                        "if(year(now()) - year(DOB) <= 30, '20 - 30', " +
                                        "if(year(now()) - year(DOB) <= 40, '31 - 40','Above 40'))) as category, " +
                                        "count(*) 'total' " +
                            "from Employee group by category";
            MySqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Age Category");
            dt.Columns.Add("Total");
            while (reader.Read())
            {
                var category = reader.GetString("category");
                dt.Rows.Add(category, reader.GetInt16("total"));
            }
            connection.Close();

            chart3.DataSource = dt;
        }

        private void container_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
