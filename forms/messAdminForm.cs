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
    public partial class messAdminForm : Form
    {
        String connString = "server=sql11.freemysqlhosting.net;database=sql11498483;uid=sql11498483;pwd=vMMyxj1Q7l";
        int _indexMes =0;
        int _index = 0;

        public messAdminForm()
        {
            InitializeComponent();
            indexMes();
            setLbl();
            download(_indexMes);
        }
        private void indexMes()
        {
            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();
            string sql = "SELECT COUNT(*) FROM "+menuAdminForm._log2+"_mess";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                _indexMes = int.Parse(reader["COUNT(*)"].ToString());
                _index = _indexMes;
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        private void download(int _id)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();
            string sql = "SELECT * FROM " + menuAdminForm._log2 + "_mess"+" WHERE id = ?";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("id", _id);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = reader["value"].ToString();
                textBox2.Text = reader["themat"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        private void setLbl()
        {
            label2.Text = "Masz " + _indexMes + " wiadomości";
            label3.Text = "Wiadomość numer: " + _indexMes;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _index--;

            if (_index == 0)
                _index = 1;

            download(_index);
            label3.Text = "Wiadomość numer: " + _index;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _index++;

            if (_index > _indexMes)
                _index = _indexMes;

            download(_index);
            label3.Text = "Wiadomość numer: " + _index;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();
            string sql = "INSERT INTO "+ menuAdminForm._log2 + "_mess" + " (themat, value) VALUES(@th,@va)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@th", textBox2.Text);
            cmd.Parameters.AddWithValue("@va", textBox1.Text);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
