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
    public partial class UserControlWorksBlankAdmin : UserControl
    {
        String connString = "server=localhost;database=db_calendar;uid=root;pwd=";
        public static string static_day21;

        public UserControlWorksBlankAdmin()
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

        private void UserControlWorksBlank_Click(object sender, EventArgs e)
        {
            static_day21 = labelDays.Text;
            eventCalendarWorksAdminForm eventForm = new eventCalendarWorksAdminForm(label3.Text, readValue(int.Parse(static_day21)), calendarWorksAdminForm.static_month2, int.Parse(static_day21), calendarWorksAdminForm.static_year2);
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
