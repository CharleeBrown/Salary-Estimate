using SalaryEstimate_Desktop;
using System;


namespace TestRuns.Tests
{
    class HourlyCalcTest
    {
        // Constant variables from the main class. 
        private const double hoursInPaycheck = 80;
        private const double checksInMonth = 2;
        private const double monthsInYear = 12;
        HourlyCalculation cals = new HourlyCalculation();


        public void CorrectHourlyTest()
        {
            // This test should come up as correct. 
            double rate = 10.00;
            double expectedPay = 800.00;


            if (cals.checkCalc(rate) == expectedPay)
            {
                Console.WriteLine(@"Correct, the expected number was {0}, and the calculated number was {1}", expectedPay, cals.checkCalc(rate));

            }
            else
            {
                Console.WriteLine(@"Incorrect the expected number was {0}, and the calculated number was {1}", expectedPay, cals.checkCalc(rate));
            }

            Console.ReadLine();
        }

        public void IncorrectHourlyTest()
        {
            // This test should come up as incorrect. 
            double rate = 20.00;
            double expectedPay = 800.00;


            if (cals.checkCalc(rate) == expectedPay)
            {
                Console.WriteLine("Correct the expected number was {0}, and the calculated number was {1}", expectedPay, cals.checkCalc(rate));

            }
            else
            {
                Console.WriteLine("Incorrect the expected number was {0}, and the calculated number was {1}", expectedPay, cals.checkCalc(rate));
            }

            Console.ReadLine();
        }
    }
}
