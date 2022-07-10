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
    public partial class UserControlWorksDaysAdmin : UserControl
    {
        String connString = "server=localhost;database=db_calendar;uid=root;pwd=";
        public static string static_day2;

        public UserControlWorksDaysAdmin()
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

        private void UserControlWorksDays_Click(object sender, EventArgs e)
        {
            static_day2 = labelDays.Text;
            eventCalendarWorksAdminForm eventForm = new eventCalendarWorksAdminForm(label3.Text, readValue(int.Parse(static_day2)), calendarWorksAdminForm.static_month2, int.Parse(static_day2), calendarWorksAdminForm.static_year2);
            eventForm.ShowDialog();

            displayEvent(int.Parse(static_day2));
            textBox1.Text = readValue(int.Parse(static_day2));
        }

        private void displayEvent(int day)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();
            string sql = "SELECT * FROM " + menuAdminForm._log2 + "_works" + " WHERE date= ?";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", calendarWorksAdminForm.static_month2 + "/" + day + "/" + calendarWorksAdminForm.static_year2);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                label3.Text = reader["event"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        private void label_Event_Click_1(object sender, EventArgs e)
        {
            UserControlWorksDays_Click(sender, e);
        }

        private void UserControlWorksDays_MouseHover(object sender, EventArgs e)
        {
            this.Size = new Size(180, 280);
            textBox1.Size = new Size(165, 180);
        }

        private void UserControlWorksDays_MouseLeave(object sender, EventArgs e)
        {
            this.Size = new Size(153, 260);
            textBox1.Size = new Size(133, 150);
        }

        private string readValue(int day)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            string _value = "";

            conn.Open();
            string sql = "SELECT value FROM " + menuAdminForm._log2 + "_works" + " WHERE date= ?";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", calendarWorksAdminForm.static_month2 + "/" + day + "/" + calendarWorksAdminForm.static_year2);
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
