using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.forms.personalForms
{
    public partial class bmiForm : Form
    {
        public bmiForm()
        {
            InitializeComponent();
            set();
        }

        private void set()
        {
            label2.Text = menuUserForm.SummaryUser.data1;
            label3.Text = menuUserForm.SummaryUser.data2;

            textBoxBmi.Text = "Body Mass Index to wskaźnik masy ciała. Wykorzystywany jest przede wszystkim do oceny " +
                "ryzyka pojawienia się groźnych chorób: miażdżycy, choroby niedokrwiennej serca, udaru mózgu, czy " +
                "nawet nowotworów. Większość tych chorób jest związana z otyłością i dlatego kalkulator BMI to tak " +
                "przydatne narzędzie.";

            textBoxBmiprmie.Text= "Pozwala obrazowo ukazać problem nadwagi i szybko wyliczyć ile kilogramów powinien " +
                "schudnąć, aby jego waga wróciła do normy. Np. BMI Prime wynoszące 1,2 oznacza 20% nadmiaru masy " +
                "ciała. Jeśli otrzymana liczba mieści się w przedziale 0,74 do 1 waga mieści się w normie.";
        }
    }
}
