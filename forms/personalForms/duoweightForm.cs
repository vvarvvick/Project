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
    public partial class duoweightForm : Form
    {
        public duoweightForm()
        {
            InitializeComponent();
            set();
        }

        private void set()
        {
            label2.Text = menuUserForm.SummaryUser.data4;

            textBoxBmi.Text = "Należna masa ciała (nmc) to inaczej idealna lub pożądana masa ciała, taka, która chroni " +
                "zarówno przed niedożywieniem, jak i nadwagą i otyłością. Jest to optymalna masa ciała, która " +
                "pozwala na zachowanie zdrowia i prawidłowe funkcjonowanie. Aby oszacować czy występuje nadwaga, " +
                "otyłość lub wychudzenie należy porównać aktualną masę ciała do wyliczonej należnej. Jeśli masz " +
                "prawidłową masę ciała, to istnieje zaledwie niewielkie ryzyko wystąpienia chorób cywilizacyjnych, " +
                "takich jak choroby serca, cukrzyca typu 2 czy niektóre nowotwory.";
        }
    }
}
