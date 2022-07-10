using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Program.forms.calendar.works
{
    public partial class UserControlWorksBlank : UserControl
    {
        String connString = "server=sql11.freemysqlhosting.net;database=sql11498483;uid=sql11498483;pwd=vMMyxj1Q7l";
        public static string static_day21;

        public UserControlWorksBlank()
        {
            InitializeComponent();
        }

        public void days(int numday, string month, int year)
        {
            labelDays.Text = numday + "";
            label1.Text = month;
            label2.Text = year.ToString();

            displayEvent(numday);
            textBox1.Text = readValue(numday);
        }

        private void displayEvent(int day)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();
            string sql = "SELECT * FROM " + loginForm._login + "_works" + " WHERE date= ?";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", calendarWorksForm.static_month2 + "/" + day + "/" + calendarWorksForm.static_year2);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                label3.Text = reader["event"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        private void UserControlWorksBlank_Click(object sender, EventArgs e)
        {
            static_day21 = labelDays.Text;
            eventCalendarWorksForm eventForm = new eventCalendarWorksForm(label3.Text, readValue(int.Parse(static_day21)), calendarWorksForm.static_month2, int.Parse(static_day21), calendarWorksForm.static_year2);
            eventForm.ShowDialog();

            displayEvent(int.Parse(static_day21));
            textBox1.Text = readValue(int.Parse(static_day21));
        }

        private void UserControlWorksBlank_MouseHover(object sender, EventArgs e)
        {
            this.Size = new Size(210, 320);
            textBox1.Size = new Size(200, 200);
        }

        private void UserControlWorksBlank_MouseLeave(object sender, EventArgs e)
        {
            this.Size = new Size(185, 287);
            textBox1.Size = new Size(178, 165);
        }

        private string readValue(int day)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            string _value = "";

            conn.Open();
            string sql = "SELECT value FROM " + loginForm._login + "_works" + " WHERE date= ?";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", calendarWorksForm.static_month2 + "/" + day + "/" + calendarWorksForm.static_year2);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                _value = reader["value"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();

            return _value;
        }
    }
}
