using FontAwesome.Sharp;
using Program.forms;
using Program.forms.calendar.works;
using System;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Program
{
    public partial class menuAdminForm : Form
    {
        String connString = "server=sql11.freemysqlhosting.net;database=sql11498483;uid=sql11498483;pwd=vMMyxj1Q7l";
        private IconButton currBtn;
        private Panel leftBdr;
        private Form formActivate;
        static public string _log2;
        int index;
        string[] users;
        int idx2=0;

        public menuAdminForm()
        {
            InitializeComponent();
            leftBdr = new Panel();
            leftBdr.Size = new Size(7, 40);
            panel1.BackColor = Color.FromArgb(220, 39, 41, 61);
            label2.BackColor = Color.FromArgb(0, 39, 41, 61);
            label1.BackColor = Color.FromArgb(0, 39, 41, 61);
            panelMenu.Controls.Add(leftBdr);
            MessageBox.Show("Hello Admin!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            set();
            setlogins();
        }

        private void set()
        {
            index = 0;
            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();
            string sql = "SELECT COUNT(login) FROM users;";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                index = int.Parse(reader["COUNT(login)"].ToString());
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();

            index = index - 1;
            label2.Text = "Ilość użytkowników twojego programu to: " + index;
        }

        private void setData()
        {
            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();
            string sql = "SELECT * FROM users WHERE login= @login";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@login", _log2);
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

        private void setlogins()
        {
            int idx = 0;
            users = new string[index];
            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();
            string sql = "SELECT login FROM users;";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["login"].ToString() != "admin")
                {
                    users[idx] = reader["login"].ToString();
                    idx++;
                }
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();

            if (idx > 0)
            {
                _log2 = users[0];
                label4.Text = _log2;
            }
        }

        private struct Colors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(172, 126, 241);
        }

        private void Activatebutton(object senderbtn, Color color)
        {
            if (senderbtn != null)
            {
                Diasblebutton();

                currBtn = (IconButton)senderbtn;
                currBtn.BackColor = Color.FromArgb(39, 41, 61);
                currBtn.ForeColor = color;
                currBtn.TextAlign = ContentAlignment.MiddleCenter;
                currBtn.IconColor = color;
                currBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBdr.BackColor = color;
                leftBdr.Location = new Point(0, currBtn.Location.Y);
                leftBdr.Visible = true;
                leftBdr.BringToFront();

                iconPictureBoxCurrentIcon.IconChar = currBtn.IconChar;
                iconPictureBoxCurrentIcon.IconColor = color;
                labelCurrentTitle.Text = currBtn.Text + " for " + _log2;
            }
        }

        private void Diasblebutton()
        {
            if (currBtn != null)
            {
                currBtn.BackColor = Color.Transparent;
                currBtn.ForeColor = Color.White;
                currBtn.TextAlign = ContentAlignment.MiddleLeft;
                currBtn.IconColor = Color.White;
                currBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Openchildform(Form childform)
        {
            if (formActivate != null)
                formActivate.Close();

            formActivate = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelCenter.Controls.Add(childform);
            childform.BringToFront();
            childform.Show();

            childform.BackColor = Color.FromArgb(39, 41, 61);
        }

        public void IconButtonLogin_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color1);
            Openchildform(new personalDataForm());
        }

        private void iconButtonBase_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color3);
            Openchildform(new sumForm());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color5);
            Openchildform(new calendarAdminForm());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color4);
            Openchildform(new calendarWorksAdminForm());
        }

        private void iconButtonMessage_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color5);
            Openchildform(new messAdminForm());
        }

        private void iconButtonAdmin_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color6);
            if (formActivate != null)
                formActivate.Close();
            Reset();
            set();
            setlogins();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color7);
            Openchildform(new setAdminForm());
        }

        private void iconButtonLogout_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color7);

            if (formActivate != null)
                formActivate.Close();
            Reset();

            DialogResult result = MessageBox.Show("Are you sure you want to Exit??", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
                this.Close();
        }

        public void Reset()
        {                   
            Diasblebutton();
            leftBdr.Visible = false;
            iconPictureBoxCurrentIcon.IconChar = IconChar.Home;
            iconPictureBoxCurrentIcon.IconColor = Color.White;
            labelCurrentTitle.Text = "Home";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idx2++;
            if (idx2 > (index-1))
                idx2 = (index-1);

            _log2 = users[idx2];
            label4.Text = _log2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idx2--;
            if (idx2 < 0)
                idx2 = 0;

            _log2 = users[idx2];
            label4.Text = _log2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setData();
            MessageBox.Show("Data Loaded!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
