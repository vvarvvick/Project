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

            textBoxBmi.Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an " +
                "unknown printer took a galley of type and scrambled it to make a type specimen book. It " +
                "has survived not only five centuries, but also the leap into electronic typesetting, remaining " +
                "essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets " +
                "containing Lorem Ipsum passages, and more recently with desktop publishing software like " +
                "Aldus PageMaker including versions of Lorem Ipsum.";

            textBoxBmiprmie.Text= "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an " +
                "unknown printer took a galley of type and scrambled it to make a type specimen book. It " +
                "has survived not only five centuries, but also the leap into electronic typesetting, remaining " +
                "essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets " +
                "containing Lorem Ipsum passages, and more recently with desktop publishing software like " +
                "Aldus PageMaker including versions of Lorem Ipsum.";
        }
    }
}
