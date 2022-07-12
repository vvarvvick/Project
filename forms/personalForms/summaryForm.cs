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
            textBox1.Text = "Na podstawie podanych danych w zakładce Parameters zostały obliczone wszystkie wskaźniki " +
                "określające stan fizyczny użytkownika. Dane oznaczone na czerwono przedstawiają wyniki wymagające " +
                "uwagi, gdyż są to wyniki powyżej normy ";
        }

        private void chParam()
        {
            int param = int.Parse(menuUserForm.SummaryUser.data1);
            string res = "";

            if (param < 18)
            {
                label_Bmi.ForeColor = Color.Red;
                label_WagaNalez.ForeColor = Color.Red;
            }
            if (param>25)
            {
                label_Bmi.ForeColor = Color.Red;
                label_WagaNalez.ForeColor = Color.Red;
            }


        }
    }
}




