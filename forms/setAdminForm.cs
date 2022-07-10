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
    public partial class setAdminForm : Form
    {
        String connString = "server=sql11.freemysqlhosting.net;database=sql11498483;uid=sql11498483;pwd=vMMyxj1Q7l";

        public setAdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {

                MySqlConnection conn = new MySqlConnection(connString);

                conn.Open();
                string sql = "SELECT login FROM users;";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["login"].ToString() == textBox1.Text)
                    {
                        MessageBox.Show("Login is used!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                reader.Dispose();
                cmd.Dispose();
                conn.Close();

                createUser();
                createCalendar();
                createWorks();
                createMess();

                MessageBox.Show("User Created!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void createUser()
        {
            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();
            string sql = "INSERT INTO users(login, password, access) VALUES (@login,@pass,@access)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@login", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);
            cmd.Parameters.AddWithValue("@access", "1");
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        private void createCalendar()
        {
            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();
            string sql = "CREATE TABLE "+textBox1.Text+"_calendar"+" (id int PRIMARY KEY AUTO_INCREMENT, event varchar(255),date varchar(255),value text)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        private void createWorks()
        {
            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();
            string sql = "CREATE TABLE " + textBox1.Text + "_works" + " (id int PRIMARY KEY AUTO_INCREMENT, event varchar(255),date varchar(255),value text)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        private void createMess()
        {
            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();
            string sql = "CREATE TABLE " + textBox1.Text + "_mess" + " (id int PRIMARY KEY AUTO_INCREMENT, themat varchar(255), value text)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
    }
}
