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
        string[] catMenu;
        int index;

        public sumForm()
        {
            InitializeComponent();
            set();

            index = 0;
            calorie = 0;
            catMenu = new string[4];

            setArray();
            Import(catMenu[index]);
        }

        private void setArray()
        {
            catMenu[0] = "Sniadanie";
            catMenu[1] = "Lekkie";
            catMenu[2] = "Przekaski";
            catMenu[3] = "Obiady";
        }

        private void Import(string path)
        {
            clear();
            textBox2.Text = path;

            System.IO.StreamReader sr = new System.IO.StreamReader("../../produkty/"+path+".txt");

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

        private void set()
        {
            label_Bmi.Text = menuUserForm.SummaryUser.data1;
            label_Ztluszcz.Text = menuUserForm.SummaryUser.data3;
            label_Waga.Text = menuUserForm.SummaryUser.data4;
            label_Bmr.Text = menuUserForm.SummaryUser.data8;

            textBox1.Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has " +
                "been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley " +
                "of type and scrambled it to make a type specimen book. It has survived not only five centuries, but ";
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            index++;

            if (index == 4)
                index = 0;

            Import(catMenu[index]);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            index--;

            if (index == -1)
                index = 3;

            Import(catMenu[index]);
        }

        private void clear()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            calorie = 0;
            label_Suma.Text = "";
        }
    }
}
