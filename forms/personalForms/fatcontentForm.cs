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
    public partial class fatcontentForm : Form
    {
        public fatcontentForm()
        {
            InitializeComponent();
            set();
        }

        private void set()
        {
            label2.Text = menuUserForm.SummaryUser.data3;

            textBoxBmi.Text = " Kalkulator zawartości tkanki tłuszczowej w organizmie pokazuje procentowy " +
                "poziom tkanki tłuszczowej dla ludzi dorosłych.";
        }
    }
}
