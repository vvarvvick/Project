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
    public partial class eventCalendarForm : Form
    {
        String connString = "server=localhost;database=db_calendar;uid=root;pwd=";

        public eventCalendarForm(string _event, string _value)
        {
            InitializeComponent();
            textBox2.Text = _event;
            textBox3.Text = _value;
        }

        private void eventCalendarForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = calendarForm.static_month+"/"+UserControlDays.static_day + "/" + calendarForm.static_year;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String sql = "INSERT INTO " + loginForm._login + "_calendar" + " (date,event,value)values(?,?,?)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", textBox1.Text);
            cmd.Parameters.AddWithValue("event", textBox2.Text);
            cmd.Parameters.AddWithValue("value", textBox3.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            cmd.Dispose();
            conn.Close();

            this.Close();
        }
    }
}
