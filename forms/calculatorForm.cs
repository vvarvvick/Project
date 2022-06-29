using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Program.FormMain;

namespace Program.forms
{
    public partial class calculatorForm : Form
    {
        public calculatorForm()
        {
            InitializeComponent();
        }

        private void button_Bmr_Click(object sender, EventArgs e)
        {
            double waga = double.Parse(textBox_Waga.Text);
            double wzrost = double.Parse(textBox_Wzrost.Text);
            double wiek = double.Parse(textBox_Wiek.Text);

            if (radioButton_Male.Checked == true)
            {
                double wynik = ((9.99 * waga) + (6.25 * wzrost) + (4.92 * wiek)) + 5;
                textBox_Bmr.Text = wynik.ToString();
            }
            if (radioButton_Female.Checked == true)
            {
                double wynik = ((9.99 * waga) + (6.25 * wzrost) + (4.92 * wiek)) - 161;
                textBox_Bmr.Text = Math.Round(wynik,2).ToString();
            }

            DataUser.BMR = float.Parse(textBox_Bmr.Text);
        }

        private void button_Amr_Click(object sender, EventArgs e)
        {
            double bMala = 0;
            double mala = 0;
            double umiarkowana = 0;
            double duza = 0;
            double bDuza = 0;

            if(textBox_Bm.Text!="")
                bMala = double.Parse(textBox_Bm.Text);
            if (textBox_M.Text != "")
                mala = double.Parse(textBox_M.Text);
            if (textBox_U.Text != "")
                umiarkowana = double.Parse(textBox_U.Text);
            if (textBox_D.Text != "")
                duza = double.Parse(textBox_D.Text);
            if (textBox_Bd.Text != "")
                bDuza = double.Parse(textBox_Bd.Text);


            double wynik = (bMala * 1.4) + (mala * 2.5) + (umiarkowana * 4.23) + (duza * 8.2) + (bDuza * 12);
            textBox_Amr.Text = Math.Round(wynik,2).ToString();

            DataUser.data5 = textBox_Amr.Text;
        }

        private void button_Tmr_Click(object sender, EventArgs e)
        {
            double wynik = double.Parse(textBox_Amr.Text) + double.Parse(textBox_Bmr.Text);

            textBox_Tmr.Text = Math.Round(wynik,2).ToString();

            DataUser.data6 = textBox_Tmr.Text;
        }
    }
}
