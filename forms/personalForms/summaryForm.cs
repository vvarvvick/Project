using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Program.FormMain;

namespace Program.forms
{
    public partial class summaryForm : Form
    {
        public summaryForm()
        {
            InitializeComponent();
            set();
            setData();
        }

        private void setData()
        {
            label_Bmi.Text = menuUserForm.SummaryUser.data1;
            label_BmiPrime.Text = menuUserForm.SummaryUser.data2;
            label_ZawTl.Text = menuUserForm.SummaryUser.data3;
            label_WagaNalez.Text = menuUserForm.SummaryUser.data4;
            label_Wthr.Text = menuUserForm.SummaryUser.data5;
            label_Borc.Text = menuUserForm.SummaryUser.data6;
            label_IBorc.Text = menuUserForm.SummaryUser.data7;
            label_Bmr.Text = menuUserForm.SummaryUser.data8;
            label_Amr.Text = menuUserForm.SummaryUser.data9;
            label_Ter.Text = menuUserForm.SummaryUser.data10;
        }

        private void set()
        {
            textBox1.Text = "Dane zaznaczone na czerwone są powyżej normy..." +
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, " +
                "when an unknown printer took a galley of type and scrambled it to make a type " +
                "specimen book. It has survived not only five centuries, but also the leap into " +
                "electronic typesetting, remaining essentially unchanged. It was popularised in " +
                "the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                "and more recently with desktop publishing software like Aldus PageMaker " +
                "including versions of Lorem Ipsum.";
        }
    }
}




