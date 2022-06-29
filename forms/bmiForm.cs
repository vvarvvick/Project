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
    public partial class bmiForm : Form
    {
        public bmiForm()
        {
            InitializeComponent();
        }

        private void checkBox_BMI_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_BMI.Checked == true)
            {
                buttonOblicz.Enabled = true;
                textBoxWaga.Enabled = true;
                textBoxWzrost.Enabled = true;
            }
            else
            {
                buttonOblicz.Enabled = false;
                textBoxWaga.Enabled = false;
                textBoxWzrost.Enabled = false;
                textBoxWaga.Text = "";
                textBoxWzrost.Text = "";
            }
        }

        private void checkBox_BMIPrmie_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_BMIPrmie.Checked == true)
            {
                buttonOblicz.Enabled = true;
                textBoxWaga.Enabled = true;
                textBoxWzrost.Enabled = true;
            }
            else
            {
                buttonOblicz.Enabled = false;
                textBoxWaga.Enabled = false;
                textBoxWzrost.Enabled = false;
                textBoxWaga.Text = "";
                textBoxWzrost.Text = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                buttonOblicz.Enabled = true;
                textBoxBiodra.Enabled = true;
                textBoxWzrost.Enabled = true;
            }
            else
            {
                buttonOblicz.Enabled = false;
                textBoxBiodra.Enabled = false;
                textBoxWzrost.Enabled = false;
                textBoxBiodra.Text = "";
                textBoxWzrost.Text = "";
            }
        }

        private void checkBoxWagaNalezna_CheckedChanged(object sender, EventArgs e)
        { 
            if (checkBoxWagaNalezna.Checked == true)
            {
                checkBoxMale.Enabled = true;
                checkBoxFemale.Enabled = true;
                buttonOblicz.Enabled = true;
                textBoxWzrost.Enabled = true;
            }
            else
            {
                checkBoxMale.Enabled = false;
                checkBoxFemale.Enabled = false;
                buttonOblicz.Enabled = false;
                textBoxWzrost.Enabled = false;
                textBoxWzrost.Text = "";
            }
        }

        private void checkBoxWThR_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWThR.Checked == true)
            {
                buttonOblicz.Enabled = true;
                textBoxBiodra.Enabled = true;
                textBoxWzrost.Enabled = true;
            }
            else
            {
                buttonOblicz.Enabled = false;
                textBoxBiodra.Enabled = false;
                textBoxWzrost.Enabled = false;
                textBoxBiodra.Text = "";
                textBoxWzrost.Text = "";
            }
        }

        private void checkBoxBorc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBorc.Checked == true)
            {
                buttonOblicz.Enabled = true;
                textBoxWzrost.Enabled = true;
            }
            else
            {
                buttonOblicz.Enabled = false;
                textBoxWzrost.Enabled = false;
                textBoxWzrost.Text = "";
            }
        }

        private void checkBoxIBorca_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIBorca.Checked == true)
            {
                buttonOblicz.Enabled = true;
                textBoxWzrost.Enabled = true;
            }
            else
            {
                checkBoxMale.Enabled = false;
                checkBoxFemale.Enabled = false;
                buttonOblicz.Enabled = false;
                textBoxWzrost.Enabled = false;
                textBoxWzrost.Text = "";
            }
        }

        private void buttonOblicz_Click(object sender, EventArgs e)
        {
            if(checkBox_BMI.Checked == true)
            {
                decimal waga = decimal.Parse(textBoxWaga.Text);
                decimal wzrost = decimal.Parse(textBoxWzrost.Text);
                string wskazanie = "";

                decimal BMI = (waga / (wzrost * wzrost)) * 10000;
                BMI = Math.Round(BMI, 2);


                if ((float)BMI < 18.5)
                    wskazanie = "Niedowaga";
                if ((float)BMI > 18.5 && (float)BMI < 24.99)
                    wskazanie = "Waga normalna";
                if ((float)BMI > 30 && (float)BMI < 34.99)
                    wskazanie = "Otyłość 1 stopnia";
                if ((float)BMI > 35.0 && (float)BMI < 39.99)
                    wskazanie = "Otyłość 2 stopnia";
                if ((float)BMI > 40)
                    wskazanie = "Otyłość 3 stopnia";


                labelBMI.Text = BMI.ToString();
                labelWskazanie.Text = wskazanie;
            }

            if (checkBox_BMIPrmie.Checked == true)
            {
                decimal waga = decimal.Parse(textBoxWaga.Text);
                decimal wzrost = decimal.Parse(textBoxWzrost.Text);

                decimal BMI = (waga / (wzrost * wzrost)) * 10000;
                BMI = Math.Round(BMI, 2);
                float BMIPrmie = (float)(24.99 - (float)BMI);


                label_BMIPrmie.Text = Math.Round(BMIPrmie, 2).ToString();
            }

            if (checkBox3.Checked == true)
            {
                double biodra = double.Parse(textBoxBiodra.Text);
                double wzrost = double.Parse(textBoxWzrost.Text);


                double BAI = (biodra / (Math.Pow(wzrost / 100, 1.5))) - 18;

                labelZawTlu.Text = Math.Round(BAI, 1).ToString();
            }

            if (checkBoxWagaNalezna.Checked == true)
            {
                double wzrost = double.Parse(textBoxWzrost.Text);

                if (checkBoxMale.Checked)
                {
                    double MC = wzrost - 100 - ((wzrost - 100) / 20);
                    labelWagaNalezna.Text = MC.ToString();
                }
                if (checkBoxFemale.Checked)
                {
                    double MC = wzrost - 100 - ((wzrost - 100) / 10);
                    labelWagaNalezna.Text = MC.ToString();
                }
            }

            if (checkBoxWThR.Checked == true)
            {
                double wzrost = double.Parse(textBoxWzrost.Text);
                double biodra = double.Parse(textBoxBiodra.Text);

                double WThR = (biodra / wzrost) * 100;

                labelWThR.Text = Math.Round(WThR,2).ToString();
            }

            if (checkBoxBorc.Checked == true)
            {
                double wzrost = double.Parse(textBoxWzrost.Text);

                double Borc = wzrost - 100;

                labelBorc.Text = Borc.ToString();
            }

            if (checkBoxIBorca.Checked == true)
            {
                double wzrost = double.Parse(textBoxWzrost.Text);
                double Borc = wzrost - 100;


                if (checkBoxMale.Checked)
                {
                    double IBorc = Borc * 0.9;
                    labelIBorca.Text = IBorc.ToString();
                }
                if (checkBoxFemale.Checked)
                {
                    double IBorc = Borc * 0.85;
                    labelIBorca.Text = IBorc.ToString();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(labelBMI.Text!="")
                DataUser.BMI = float.Parse(labelBMI.Text);
            if(labelZawTlu.Text!="")
                DataUser.ZawTl = float.Parse(labelZawTlu.Text);
            if(labelZawTlu.Text!="")
                DataUser.NalWaga = float.Parse(labelZawTlu.Text);
            if (labelZawTlu.Text != "")
                DataUser.data1 = label_BMIPrmie.Text;
            if (labelZawTlu.Text != "")
                DataUser.data2 = labelWThR.Text;
            if (labelZawTlu.Text != "")
                DataUser.data3 = labelBorc.Text;
            if (labelZawTlu.Text != "")
                DataUser.data4 = labelBorc.Text;
        }
    }
}
