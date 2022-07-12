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
    public partial class bodyweightForm : Form
    {
        public bodyweightForm()
        {
            InitializeComponent();
            set();
        }

        private void set()
        {
            label2.Text = menuUserForm.SummaryUser.data6;
            label3.Text = menuUserForm.SummaryUser.data7;

            textBoxBmi.Text = "Należna masa ciała - jest to prawidłowa, pożądana masa ciała, która pozwala na odpowiednie " +
                "funkcjonowania człowieka oraz zachowanie zdrowia. Wzory na należna masę ciała nie są dla każdego. " +
                "Najlepiej sprawdza się u osób z przeciętną budowie ciała. Wynik będzie niewiarygodny w przypadku " +
                "sportowców czy kobiet w ciąży. Każdy wskaźnik masy ciała należy traktować orientacyjnie oraz " +
                "bardzo indywidualnie.";

            textBoxBmiprmie.Text = "Wagę idealną uzyskuje się poprzez odjęcie od wagi należnej: 10% jej wartości dla " +
                "mężczyzn (mnożymy przez 0,9) oraz 15% dla kobiet (mnożymy przez 0,85). Z tego wynika prosty wniosek, " +
                "że waga prawie idealna to przedział między wagą idealną, a należną. Natomiast w drugą stronę sprawa " +
                "wygląda następująco: pomiędzy wagą należną, a nadwagą mamy wagę akceptowalną. Nadwaga zaczyna " +
                "się w momencie kiedy masa ciała przewyższa o 10% wagę należną, z kolei otyłość wtedy gdy waga " +
                "należna zostanie przekroczona o 20% .";
        }
    }
}
