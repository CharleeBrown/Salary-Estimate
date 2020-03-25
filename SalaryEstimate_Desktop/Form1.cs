using System;
using System.Globalization;
using System.Windows.Forms;

namespace SalaryEstimate_Desktop
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hourlyCalc calc = new hourlyCalc();

            if (!string.IsNullOrEmpty(hourRate.Text))
            {

                double mainAmount = Convert.ToDouble(hourRate.Text);

                string completeGross;
                string completeMonth;
                string completeYear;

                completeGross = calc.checkCalc(mainAmount).ToString("C", CultureInfo.CurrentCulture);
                grossAmount.Text = completeGross;

                completeMonth = calc.monthCalc(mainAmount).ToString("C", CultureInfo.CurrentCulture);
                monthAmount.Text = completeMonth;

                completeYear = calc.yearCalc(mainAmount).ToString("C", CultureInfo.CurrentCulture);
                yearAmount.Text = completeYear;


            }
            else
            {

                hourRate.Focus();

            }

        }

        private void hourRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void yearButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mainYearAmount.Text))
            {
                yearlyCalc mainCalc = new yearlyCalc();

                double yearAmount = Convert.ToDouble(mainYearAmount.Text);

                string totalMonth;
                string totalCheck;
                string totalHour;

                totalMonth = mainCalc.monthly(yearAmount).ToString("C", CultureInfo.CurrentCulture);
                mainMonthAmount.Text = totalMonth;

                totalCheck = mainCalc.paycheckAmount(yearAmount).ToString("C", CultureInfo.CurrentCulture);
                perCheckAmount.Text = totalCheck;

                totalHour = mainCalc.hourlyCalc(yearAmount).ToString("C", CultureInfo.CurrentCulture);
                mainHourRate.Text = totalHour;


            }
            else
            {

                mainYearAmount.Focus();

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }



}
