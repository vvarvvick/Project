using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.forms.calendar.works
{
    public partial class calendarWorksForm : Form
    {
        int month, year, day;
        public static int static_month2, static_year2, static_day_now;

        public calendarWorksForm()
        {
            InitializeComponent();
        }

        private void calendarWorksForm_Load(object sender, EventArgs e)
        {
            displayDay();
        }

        private void displayDay()
        {
            int indexDay = 0;
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            day = now.Day;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            labelData.Text = day + " " + monthname + " " + year;

            static_month2 = month;
            static_year2 = year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            UserControlWorksBlank ucblank = new UserControlWorksBlank();
            ucblank.days(day, monthname, year);
            daycontainer.Controls.Add(ucblank);

            day = day + 1;
            indexDay = day + 3;
            if (indexDay > days)
                indexDay = days;

            for (int i = day; i <= indexDay; i++)
            {
                UserControlWorksDays ucdays = new UserControlWorksDays();
                ucdays.days(i, monthname, year);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
