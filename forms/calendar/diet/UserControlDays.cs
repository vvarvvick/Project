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

namespace Program.forms
{
    public partial class UserControlDays : UserControl
    {
        String connString = "server=sql11.freemysqlhosting.net;database=sql11498483;uid=sql11498483;pwd=vMMyxj1Q7l";
        public static string static_day;

        public UserControlDays()
        {
            InitializeComponent();
        }

        public void days(int numday)
        {
            labelDays.Text = numday + "";
            displayEvent(numday);
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = labelDays.Text;

            eventCalendarForm eventForm = new eventCalendarForm(label_Event.Text, readValue(int.Parse(static_day)));
            eventForm.ShowDialog();

            displayEvent(int.Parse(static_day));
        }

        private void displayEvent(int day)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();
            string sql = "SELECT * FROM " + loginForm._login + "_calendar" + " WHERE date= ?";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", calendarForm.static_month + "/" + day + "/" + calendarForm.static_year);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                label_Event.Text = reader["event"].ToString();
                
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        private void label_Event_Click(object sender, EventArgs e)
        {
            UserControlDays_Click(sender,e);
        }

        private string readValue(int day)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            string _value ="";

            conn.Open();
            string sql = "SELECT value FROM " + loginForm._login + "_calendar" + " WHERE date= ?";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", calendarForm.static_month + "/" + day + "/" + calendarForm.static_year);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                _value =  reader["value"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();

            return _value;
        }

        private void UserControlDays_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 230, 230, 230);
            this.BorderStyle = BorderStyle.Fixed3D;
            label_Event.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
        }

        private void UserControlDays_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
            this.BorderStyle = BorderStyle.None;
            label_Event.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        }
    }
}
