using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.forms
{
    public partial class poniterForm : Form
    {
        public poniterForm()
        {
            InitializeComponent();
            set();
        }

        private void set()
        {
            label2.Text = menuUserForm.SummaryUser.data5;

            textBoxBmi.Text = "Waist to Height Ratio – W sytuacji, gdy wskaźnik będzie na poziomie 49 lub wyższy " +
                "występuje zwiększone ryzyko zachorowań na choroby układu krążenia, cukrzycę itp, na które narażone " +
                "są też bardziej osoby o typie budowy jabłka aniżeli gruszki. Mówi się, że WHtR to dokładniejszy " +
                "wskaźnik, niż BMI. Jest to wskaźnik oceniający stan odżywienia, zaraz obok BMI oraz WHR. Pomiar ten" +
                " bierze pod uwagę okolice brzucha(liczony obwód talii), czyli miejsce, w którym gromadzi się najwięcej" +
                " tkanki tłuszczowej.";
        }
    }
}
