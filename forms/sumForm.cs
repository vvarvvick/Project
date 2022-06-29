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
    public partial class sumForm : Form
    {
        int calorie;

        public sumForm()
        {
            InitializeComponent();

            label_Bmi.Text = DataUser.BMI.ToString();
            label_Ztluszcz.Text = DataUser.ZawTl.ToString();
            label_Waga.Text = DataUser.NalWaga.ToString();
            label_Bmr.Text = DataUser.BMR.ToString();
            calorie = 0;

            Import();
        }

        private void Import()
        {
            System.IO.StreamReader sr = new System.IO.StreamReader("../../produkty/listProduct.txt");

            while (!sr.EndOfStream){
                listBox1.Items.Add(sr.ReadLine());
            }
            sr.Close();
        }

        private void button_Dodaj_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.Text);

            string digit = new String(listBox1.Text.Where(Char.IsDigit).ToArray());
            calorie += int.Parse(digit);
            label_Suma.Text = calorie.ToString();
        }

        private void button_Usun_Click(object sender, EventArgs e)
        {
            string digit = new String(listBox2.Text.Where(Char.IsDigit).ToArray());
            calorie -= int.Parse(digit);
            label_Suma.Text = calorie.ToString();

            listBox2.Items.Remove(listBox2.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_Dodaj.Enabled = true;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_Usun.Enabled = true;
        }

        private void button_Zapisz_Click(object sender, EventArgs e)
        {
            string UserAnswer = Microsoft.VisualBasic.Interaction.InputBox("Podaj nazwę diety ", "Zapis diety", "dietaName");

            using (StreamWriter writetext = new StreamWriter("../../diety/"+ UserAnswer + ".txt"))
            {
                foreach (var item in listBox2.Items)
                {
                    writetext.WriteLine(item.ToString());
                }
                writetext.WriteLine("Suma kalorii = "+label_Suma.Text);
            }
        }
    }
}
