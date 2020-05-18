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
            HourlyCalculation calc = new HourlyCalculation();

            if (!string.IsNullOrEmpty(hourRate.Text))
            {
                // Setting the currency formatting. 
                var payRate = hourRate.Text.Replace("$", "");
                decimal result;

                // If the string parses successfuly. 
                if (decimal.TryParse(payRate, out result))
                {
                    // Set the output to the mainAmount variable. 
                    double mainAmount = Convert.ToDouble(result);
                    string completeGross;
                    string completeMonth;
                    string completeYear;

                    // Set the text boxes to the calculated amounts. 
                    completeGross = calc.checkCalc(mainAmount).ToString("C", CultureInfo.CurrentCulture);
                    grossAmount.Text = completeGross;

                    completeMonth = calc.monthlyCalculation(mainAmount).ToString("C", CultureInfo.CurrentCulture);
                    monthAmount.Text = completeMonth;

                    completeYear = calc.yearlyCalculation(mainAmount).ToString("C", CultureInfo.CurrentCulture);
                    yearAmount.Text = completeYear;
                }

            }
            else
            {
                hourRate.Focus();
            }
        }
        private void hourRate_TextChanged(object sender, EventArgs e)
        {
            // clear all the formatting from the text. 
            string value = hourRate.Text.Replace(",", "").Replace("$", "").Replace(".", "").TrimStart('0');
            decimal ul;

            //parse the text for an integer.
            if (decimal.TryParse(value, out ul))
            {
                //Divide the number by 100 to get a decimal
                ul /= 100;

                //Unsub the event so we don't enter a loop
                hourRate.TextChanged -= hourRate_TextChanged;

                //Format the text as currency
                hourRate.Text = string.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:C2}", ul);

                // Subscribe to event
                hourRate.TextChanged += hourRate_TextChanged;

                // Select end of the string. 
                hourRate.Select(hourRate.Text.Length, 0);
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void yearButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mainYearAmount.Text))
            {
                YearCalculation mainCalc = new YearCalculation();

                double yearAmount = Convert.ToDouble(mainYearAmount.Text.Replace("$", ""));
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

        private void mainYearAmount_TextChanged(object sender, EventArgs e)
        {
            string value = mainYearAmount.Text.Replace(",", "").Replace("$", "").Replace(".", "").TrimStart('0');
            Int32 ul;
            if (Int32.TryParse(value, out ul))
            {

                //Unsub the event so we don't enter a loop
                mainYearAmount.TextChanged -= mainYearAmount_TextChanged;

                //Format the text as currency
                mainYearAmount.Text = string.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:C0}", ul);

                // Subscribe to event
                mainYearAmount.TextChanged += mainYearAmount_TextChanged;

                // Select end of the string. 
                mainYearAmount.Select(mainYearAmount.Text.Length, 0);
            }
        }
    }

}