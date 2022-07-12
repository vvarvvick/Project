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

        private void button2_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();
            string sql = "SELECT login FROM users;";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["login"].ToString() == textBox4.Text)
                {
                    checkUser();
                    return;
                }
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();

            MessageBox.Show("User Not Found!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void delCalendar()
        {
            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();
            string sql = "DROP TABLE "+textBox4.Text+"_calendar";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        private void delMess()
        {
            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();
            string sql = "DROP TABLE " + textBox4.Text + "_mess";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        private void delWorks()
        {
            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();
            string sql = "DROP TABLE " + textBox4.Text + "_works";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        private void checkUser()
        {
            DialogResult res = MessageBox.Show("Confirm Delete User!!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (res == DialogResult.Yes)
            {
                MySqlConnection conn = new MySqlConnection(connString);

                conn.Open();
                string sql = "DELETE FROM users WHERE login = @log";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@log", textBox4.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();

                delCalendar();
                delMess();
                delWorks();

                textBox4.Text = "";
                MessageBox.Show("Data Deleted!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
