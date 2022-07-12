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
    public partial class bmrForm : Form
    {
        public bmrForm()
        {
            InitializeComponent();
            set();
        }

        private void set()
        {
            label2.Text = menuUserForm.SummaryUser.data8;
            label3.Text = menuUserForm.SummaryUser.data9;

            textBoxBmi.Text = "Wskaźnik podstawowej przemiany materii (Basal Metabolic Rate, BMR) jest minimalnym " +
                "dziennym zapotrzebowaniem energetycznym koniecznym do podtrzymania podstawowych procesów życiowych " +
                "ciała w spoczynku. ";

            textBoxBmiprmie.Text = "Służy do szacowania wydatków energetycznych związanych z wysiłkiem fizycznym. " +
                "Przy pomocy kalkulatora kalorii AMR możemy więc określić, jak dużo kalorii spalamy podczas " +
                "uprawiania sportu, wykonywania obowiązków domowych, spacerowania czy wykonując trening siłowy.";
        }
    }
}
