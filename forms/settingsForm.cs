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
    public partial class settingsForm : Form
    {
        String connString = "server=localhost;database=db_calendar;uid=root;pwd=";

        public settingsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuUserForm.SummaryUser.data1 = "";
            menuUserForm.SummaryUser.data2 = "";
            menuUserForm.SummaryUser.data3 = "";
            menuUserForm.SummaryUser.data4 = "";
            menuUserForm.SummaryUser.data5 = "";
            menuUserForm.SummaryUser.data6 = "";
            menuUserForm.SummaryUser.data7 = "";
            menuUserForm.SummaryUser.data8 = "";
            menuUserForm.SummaryUser.data9 = "";
            menuUserForm.SummaryUser.data10 = "";


            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();
            String sql = "UPDATE users SET bmi=@bmi, bmiP=@bmiP, fat=@fat, due=@due, pointer=@pointer, borc=@borc, borc2=@borc2, bmr=@bmr, amr=@amr, tmr=@tmr WHERE login = @log";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@bmi", "");
            cmd.Parameters.AddWithValue("@bmiP", "");
            cmd.Parameters.AddWithValue("@fat", "");
            cmd.Parameters.AddWithValue("@due", "");
            cmd.Parameters.AddWithValue("@pointer", "");
            cmd.Parameters.AddWithValue("@borc", "");
            cmd.Parameters.AddWithValue("@borc2", "");
            cmd.Parameters.AddWithValue("@bmr", "");
            cmd.Parameters.AddWithValue("@amr", "");
            cmd.Parameters.AddWithValue("@tmr", "");
            cmd.Parameters.AddWithValue("@log", loginForm._login);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

            MessageBox.Show("Data Deleted!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
