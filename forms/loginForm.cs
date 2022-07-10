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
    public partial class loginForm : Form
    {
        String connString = "server=sql11.freemysqlhosting.net;database=sql11498483;uid=sql11498483;pwd=vMMyxj1Q7l";
        public static string _login;
        public static string _base;

        public loginForm()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(130, 88, 44, 55);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMain mainPage = (FormMain)this.Owner;
            string pass="";
            int access = 0;

            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();
            string sql = "SELECT password, access FROM users WHERE login= ?";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("login", textBox1.Text);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                pass = reader["password"].ToString();
                access = int.Parse(reader["access"].ToString());
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();

            if (pass == textBox2.Text)
            {
                if (access == 1)
                {
                    _login = textBox1.Text;
                    setData(_login);
                    mainPage.Openchildform(new menuUserForm());
                    this.Close();
                }
                if (access == 2)
                {
                    mainPage.Openchildform(new menuAdminForm());
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Bad Login or Pass!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMain mainPage = (FormMain)this.Owner;
            mainPage.Close();
        }

        private void setData(string _log)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();
            string sql = "SELECT * FROM users WHERE login= @login";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@login", _log);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                menuUserForm.SummaryUser.data1 = reader["bmi"].ToString();
                menuUserForm.SummaryUser.data2 = reader["bmiP"].ToString();
                menuUserForm.SummaryUser.data3 = reader["fat"].ToString();
                menuUserForm.SummaryUser.data4 = reader["due"].ToString();
                menuUserForm.SummaryUser.data5 = reader["pointer"].ToString();
                menuUserForm.SummaryUser.data6 = reader["borc"].ToString();
                menuUserForm.SummaryUser.data7 = reader["borc2"].ToString();
                menuUserForm.SummaryUser.data8 = reader["bmr"].ToString();
                menuUserForm.SummaryUser.data9 = reader["amr"].ToString();
                menuUserForm.SummaryUser.data10 = reader["tmr"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }
    }
}
