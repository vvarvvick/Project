using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Program.forms
{
    public partial class dataUserForm : Form
    {
        String connString = "server=sql11.freemysqlhosting.net;database=sql11498483;uid=sql11498483;pwd=vMMyxj1Q7l";

        public dataUserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonMen.Checked)
                menuUserForm.DataUser.plec = "Men";
            else
                menuUserForm.DataUser.plec = "Women";

            menuUserForm.DataUser.wiek = textBoxWiek.Text;
            menuUserForm.DataUser.waga = textBoxWaga.Text;
            menuUserForm.DataUser.wzrost = textBoxWzrost.Text;
            menuUserForm.DataUser.obwodbioder = textBoxObwBioder.Text;
            menuUserForm.DataUser.obwodklatki = textBoxObwKlatki.Text;
            menuUserForm.DataUser.aktywnoscBD = textBox_Bd.Text;
            menuUserForm.DataUser.aktywnoscD = textBox_D.Text;
            menuUserForm.DataUser.aktywnoscS = textBox_U.Text;
            menuUserForm.DataUser.aktywnoscM = textBox_M.Text;
            menuUserForm.DataUser.aktywnoscBM = textBox_Bm.Text;

            bmis();
            fatcnt();
            due();
            pointerWThR();
            borcs();
            bmr();
            amr();
            tmr();


            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String sql = "UPDATE users SET bmi=@bmi, bmiP=@bmiP, fat=@fat, due=@due, pointer=@pointer, borc=@borc, borc2=@borc2, bmr=@bmr, amr=@amr, tmr=@tmr WHERE login = @log";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@bmi", menuUserForm.SummaryUser.data1);
            cmd.Parameters.AddWithValue("@bmiP", menuUserForm.SummaryUser.data2);
            cmd.Parameters.AddWithValue("@fat", menuUserForm.SummaryUser.data3);
            cmd.Parameters.AddWithValue("@due", menuUserForm.SummaryUser.data4);
            cmd.Parameters.AddWithValue("@pointer", menuUserForm.SummaryUser.data5);
            cmd.Parameters.AddWithValue("@borc", menuUserForm.SummaryUser.data6);
            cmd.Parameters.AddWithValue("@borc2", menuUserForm.SummaryUser.data7);
            cmd.Parameters.AddWithValue("@bmr", menuUserForm.SummaryUser.data8);
            cmd.Parameters.AddWithValue("@amr", menuUserForm.SummaryUser.data9);
            cmd.Parameters.AddWithValue("@tmr", menuUserForm.SummaryUser.data10);
            cmd.Parameters.AddWithValue("@log", loginForm._login);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

            MessageBox.Show("Data Saved!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Usun_Click(object sender, EventArgs e)
        {
            menuUserForm.DataUser.plec= "";
            menuUserForm.DataUser.wiek = "";
            menuUserForm.DataUser.waga = "";
            menuUserForm.DataUser.wzrost = "";
            menuUserForm.DataUser.obwodbioder = "";
            menuUserForm.DataUser.obwodklatki = "";
            menuUserForm.DataUser.aktywnoscBD = "";
            menuUserForm.DataUser.aktywnoscD = "";
            menuUserForm.DataUser.aktywnoscS = "";
            menuUserForm.DataUser.aktywnoscM = "";
            menuUserForm.DataUser.aktywnoscBM = "";

            radioButtonMen.Checked = false;
            radioButtonWomen.Checked = false;
            textBoxWiek.Text = "";
            textBoxWaga.Text = "";
            textBoxWzrost.Text = "";
            textBoxObwBioder.Text = "";
            textBoxObwKlatki.Text = "";
            textBox_Bd.Text = "";
            textBox_D.Text = "";
            textBox_U.Text = "";
            textBox_M.Text = "";
            textBox_Bm.Text = "";
        }

        private void bmis()
        {
            if ((textBoxWaga.Text != "")&&(textBoxWzrost.Text != ""))
            {
                decimal waga = decimal.Parse(textBoxWaga.Text);
                decimal wzrost = decimal.Parse(textBoxWzrost.Text);

                decimal BMI = (waga / (wzrost * wzrost)) * 10000;
                BMI = Math.Round(BMI, 2);

                menuUserForm.SummaryUser.data1 = BMI.ToString();

                float BMIPrime = (float)(24.99 - (float)BMI);

                menuUserForm.SummaryUser.data2 = Math.Round(BMIPrime, 2).ToString();
            }
        }

        private void fatcnt()
        {
            if ((textBoxObwBioder.Text != "") && (textBoxWzrost.Text != ""))
            {
                double biodra = double.Parse(textBoxObwBioder.Text);
                double wzrost = double.Parse(textBoxWzrost.Text);

                double BAI = (biodra / (Math.Pow(wzrost / 100, 1.5))) - 18;

                menuUserForm.SummaryUser.data3 = Math.Round(BAI, 2).ToString();
            }
        }

        private void due()
        {
            if ((textBoxWzrost.Text != "")&&(radioButtonMen.Checked || radioButtonWomen.Checked))
            {
                double wzrost = double.Parse(textBoxWzrost.Text);

                if(radioButtonMen.Checked)
                {
                    double MC = wzrost - 100 - ((wzrost - 100) / 20);
                    menuUserForm.SummaryUser.data4 = MC.ToString();
                }
                if (radioButtonWomen.Checked)
                {
                    double MC = wzrost - 100 - ((wzrost - 100) / 10);
                    menuUserForm.SummaryUser.data4 = MC.ToString();
                }
            }
        }

        private void pointerWThR()
        {
            if ((textBoxWzrost.Text != "") && (textBoxObwBioder.Text != ""))
            {
                double wzrost = double.Parse(textBoxWzrost.Text);
                double biodra = double.Parse(textBoxObwBioder.Text);

                double WThR = (biodra / wzrost) * 100;

                menuUserForm.SummaryUser.data5 = Math.Round(WThR, 2).ToString();
            }
        }

        private void borcs()
        {
            if ((textBoxWzrost.Text != "") && (radioButtonMen.Checked || radioButtonWomen.Checked))
            {
                double wzrost = double.Parse(textBoxWzrost.Text);

                double Borc = wzrost - 100;

                menuUserForm.SummaryUser.data6 = Math.Round(Borc, 2).ToString();

                if (radioButtonMen.Checked)
                {
                    double IBorc = Borc * 0.9;
                    menuUserForm.SummaryUser.data7 = IBorc.ToString();
                }
                if (radioButtonWomen.Checked)
                {
                    double IBorc = Borc * 0.85;
                    menuUserForm.SummaryUser.data7 = IBorc.ToString();
                }
            }
        }

        private void bmr()
        {
            if ((textBoxWaga.Text != "") && (textBoxWzrost.Text != "") && (textBoxWiek.Text != ""))
            {
                double waga = double.Parse(textBoxWaga.Text);
                double wzrost = double.Parse(textBoxWzrost.Text);
                double wiek = double.Parse(textBoxWiek.Text);

                if (radioButtonMen.Checked)
                {
                    double wynik = ((9.99 * waga) + (6.25 * wzrost) + (4.92 * wiek)) + 5;

                    menuUserForm.SummaryUser.data8 = Math.Round(wynik,2).ToString();
                }
                if (radioButtonWomen.Checked)
                {
                    double wynik = ((9.99 * waga) + (6.25 * wzrost) + (4.92 * wiek)) - 161;

                    menuUserForm.SummaryUser.data8 = Math.Round(wynik,2).ToString();
                }
            }
        }

        private void amr()
        {
            if((textBox_Bd.Text!="")||(textBox_D.Text != "")||(textBox_U.Text != "")||(textBox_M.Text != "")||(textBox_Bm.Text != ""))
            {
                double bMala = 0;
                double mala = 0;
                double umiarkowana = 0;
                double duza = 0;
                double bDuza = 0;

                if (textBox_Bm.Text != "")
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

                menuUserForm.SummaryUser.data9 = Math.Round(wynik, 2).ToString();
            }
        }

        private void tmr()
        {
            if ((menuUserForm.SummaryUser.data9 != null) && (menuUserForm.SummaryUser.data8 != null))
            {
                double wynik = double.Parse(menuUserForm.SummaryUser.data8) + double.Parse(menuUserForm.SummaryUser.data9);

                menuUserForm.SummaryUser.data10 = Math.Round(wynik, 2).ToString();
            }
        }
    }
}
