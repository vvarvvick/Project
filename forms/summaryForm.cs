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
            setData();
        }

        private void setData()
        {
            label_Bmi.Text = DataUser.BMI.ToString();
            label_BmiPrime.Text = DataUser.data1;
            label_ZawTl.Text = DataUser.ZawTl.ToString();
            label_WagaNalez.Text = DataUser.NalWaga.ToString();
            label_Wthr.Text = DataUser.data2;
            label_Borc.Text = DataUser.data3;
            label_IBorc.Text = DataUser.data4;
            label_Bmr.Text = DataUser.BMR.ToString();
            label_Amr.Text = DataUser.data5;
            label_Ter.Text = DataUser.data6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK){
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                while (!sr.EndOfStream)
                {
                    listBox1.Items.Add(sr.ReadLine());
                }
                sr.Close();
            }
        }
    }
}




