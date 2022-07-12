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
    public partial class terForm : Form
    {
        public terForm()
        {
            InitializeComponent();
            set();
        }

        private void set()
        {
            label2.Text = menuUserForm.SummaryUser.data10;

            textBoxBmi.Text = "Total Energy Requirement to dzienne całkowite zapotrzebowanie na energię i określa " +
                "ilość energii w kaloriach jaką wydatkuje organizm w ciągu doby. TER jest sumą wyników dwóch " +
                "kalkulatorów AMR i BMR. Dzięki wynikowi TER poznajemy ilość kalorii codziennie zużywanej " +
                "przez nasz organizm, co pozwala nam utrzymać, obniżać lub podwyższyć masę ciała zmniejszając " +
                "lub zwiększając kaloryczność przyjmowanych posiłków.";
        }
    }
}
