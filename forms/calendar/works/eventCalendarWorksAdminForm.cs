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
    public partial class eventCalendarWorksAdminForm : Form
    {
        String connString = "server=sql11.freemysqlhosting.net;database=sql11498483;uid=sql11498483;pwd=vMMyxj1Q7l";

        public eventCalendarWorksAdminForm(string _event, string _value, int month, int day, int year)
        {
            InitializeComponent();
            textBox2.Text = _event;
            textBox3.Text = _value;
            textBox1.Text = month + "/" + day + "/" + year;
        }

        private void eventCalendarWorksAdminForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String sql = "INSERT INTO "+menuAdminForm._log2+"_works"+" (date,event,value)values(?,?,?)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", textBox1.Text);
            cmd.Parameters.AddWithValue("event", textBox2.Text);
            cmd.Parameters.AddWithValue("value", textBox3.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Saved!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmd.Dispose();
            conn.Close();
        }
    }
}
