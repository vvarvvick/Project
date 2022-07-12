using FontAwesome.Sharp;
using Program.forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Program
{
    public partial class FormMain : Form
    {
        private Form formActivate;

        public FormMain()
        {
            InitializeComponent();
            Openchildform(new loginForm());
            label1.BackColor = Color.FromArgb(0, 88, 44, 55);
            label2.BackColor = Color.FromArgb(0, 88, 44, 55);
            label3.BackColor = Color.FromArgb(0, 88, 44, 55);
            label4.BackColor = Color.FromArgb(0, 88, 44, 55);
            label5.BackColor = Color.FromArgb(0, 88, 44, 55);
            panel1.BackColor = Color.FromArgb(140, 88, 44, 55);
            panel2.BackColor = Color.FromArgb(140, 88, 44, 55);
        }

        public void Openchildform(Form childform)
        {
            if (formActivate != null)
                formActivate.Close();

            formActivate = childform;
            childform.Owner = this;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelCenter.Controls.Add(childform);
            childform.BringToFront();
            childform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Openchildform(new loginForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
