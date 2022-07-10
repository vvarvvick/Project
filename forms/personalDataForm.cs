using FontAwesome.Sharp;
using Program.forms.personalForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.forms
{
    public partial class personalDataForm : Form
    {
        private IconButton currBtn;
        private Panel leftBdr;
        private Form formActivate;

        public personalDataForm()
        {
            InitializeComponent();
            leftBdr = new Panel();
            leftBdr.Size = new Size(7, 40);
            panelLeft.Controls.Add(leftBdr);
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
            panelMain.Controls.Add(childform);
            childform.BringToFront();
            childform.Show();

            childform.BackColor = Color.FromArgb(39, 41, 61);
        }

        private void iconButtonClient_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color7);
            Openchildform(new dataUserForm());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color6);
            Openchildform(new bmiForm());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color5);
            Openchildform(new duoweightForm());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color4);
            //Openchildform(new bmiFormDel());
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color3);
            Openchildform(new fatcontentForm());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color2);
            Openchildform(new poniterForm());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color1);
            Openchildform(new bodyweightForm());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color7);
            Openchildform(new bmrForm());
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color6);
            Openchildform(new terForm());
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color5);
            Openchildform(new summaryForm());
        }
    }
}
