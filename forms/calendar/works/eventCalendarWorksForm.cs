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
    public partial class eventCalendarWorksForm : Form
    {
        String connString = "server=localhost;database=db_calendar;uid=root;pwd=";

        public eventCalendarWorksForm(string _event, string _value, int month, int day, int year)
        {
            InitializeComponent();
            textBox2.Text = _event;
            textBox3.Text = _value;
            textBox1.Text = month + "/" + day + "/" + year;
        }

        private void eventCalendarWorksForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String sql = "INSERT INTO "+loginForm._login+"_works"+"(date,event,value)values(?,?,?)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", textBox1.Text);
            cmd.Parameters.AddWithValue("event", textBox2.Text);
            cmd.Parameters.AddWithValue("value", textBox3.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            cmd.Dispose();
            conn.Close();
        }
    }
}
