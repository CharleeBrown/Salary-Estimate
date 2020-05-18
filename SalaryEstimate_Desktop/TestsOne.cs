using System;

namespace SalaryEstimate_Desktop
{
    class TestsOne
    {
        private const double hoursInPaycheck = 80;
        private const double checksInMonth = 2;
        private const double monthsInYear = 12;


        public void HourlyTests()
        {
            double rate = 10.00;
            double expectedPay = 800.00;
            HourlyCalculation cals = new HourlyCalculation();

            if (cals.checkCalc(rate) == expectedPay)
            {
                Console.WriteLine("Correct");

            }
            else
            {
                Console.WriteLine("Incorrect");
            }

        }


    }






}
