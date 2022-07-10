using FontAwesome.Sharp;
using Program.forms;
using Program.forms.calendar.works;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Program
{
    public partial class menuUserForm : Form
    {
        private IconButton currBtn;
        private Panel leftBdr;
        private Form formActivate;

        public menuUserForm()
        {
            InitializeComponent();
            leftBdr = new Panel();
            leftBdr.Size = new Size(7, 40);
            panelMenu.Controls.Add(leftBdr);
            MessageBox.Show("Hello User!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            set();
        }

        private void set()
        {
            textBox1.Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an " +
                "unknown printer took a galley of type and scrambled it to make a type specimen book. It " +
                "has survived not only five centuries, but also the leap into electronic typesetting, remaining " +
                "essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets " +
                "containing Lorem Ipsum passages, and more recently with desktop publishing software like " +
                "Aldus PageMaker including versions of Lorem Ipsum.";
        }

        public struct DataUser
        {
            public static string plec;
            public static string wiek;
            public static string waga;
            public static string wzrost;
            public static string obwodbioder;
            public static string obwodklatki;
            public static string aktywnoscBM;
            public static string aktywnoscM;
            public static string aktywnoscS;
            public static string aktywnoscD;
            public static string aktywnoscBD;
        }

        public struct SummaryUser
        {
            public static string data1;
            public static string data2;
            public static string data3;
            public static string data4;
            public static string data5;
            public static string data6;
            public static string data7;
            public static string data8;
            public static string data9;
            public static string data10;
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
                labelCurrentTitle.Text = currBtn.Text;
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
            Openchildform(new calendarForm());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color4);
            Openchildform(new calendarWorksForm());
        }

        private void iconButtonMessage_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color5);
            Openchildform(new messForm());
        }

        private void iconButtonAdmin_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color6);
            if (formActivate != null)
                formActivate.Close();
            Reset();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color7);
            Openchildform(new settingsForm());
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
    }
}
