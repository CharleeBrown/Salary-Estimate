using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryEstimate_Desktop;
namespace TestRuns
{
    class TestsOne
    {
        private const double hoursInPaycheck = 80;
        private const double checksInMonth = 2;
        private const double monthsInYear = 12;
        HourlyCalculation cals = new HourlyCalculation();

        public void HourlyTests()
        {
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

        public void IncorrectTest()
        {
            double rate = 20.00;
            double expectedPay = 800.00;

            // Should come up as incorrect. 
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
