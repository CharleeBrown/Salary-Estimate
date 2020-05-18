using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryEstimate_Desktop;

namespace TestRuns.Tests
{
    class YearCalcTests
    {
        // Constant variables from the main class. 
        private const double monthsInYear = 12;
        private const double checksInMonth = 2;
        private const double hoursInCheck = 80;


        YearCalculation yearly = new YearCalculation();


        public void CorrectYearlyTest()
        {


         const Int32 Salary = 30000;

        const Int32 expectedMonthly = 2500;
        Console.WriteLine(" Annual Salary Method Tests");
            // This test should come up as correct. 
           
            if (yearly.monthly(Salary) == expectedMonthly)
            {
                Console.WriteLine(@"Correct, the expected number was {0}, and the calculated number was {1}", expectedMonthly, yearly.monthly(Salary));

            }
            else
            {
                Console.WriteLine(@"Incorrect the expected number was {0}, and the calculated number was {1}", expectedMonthly, yearly.monthly(Salary));
            }

           
        }

        public void IncorrectYearlyTest()
        {
            // This test should come up as incorrect. 

            const Int32 Salary = 30000;

            const Int32 expectedMonthly = 2600;


            if (yearly.monthly(Salary) == expectedMonthly)
            {
                Console.WriteLine("Correct the expected number was {0}, and the calculated number was {1}", expectedMonthly, yearly.monthly(Salary));

            }
            else
            {
                Console.WriteLine("Incorrect the expected number was {0}, and the calculated number was {1}", expectedMonthly, yearly.monthly(Salary));
            }

            Console.ReadLine();
        }
    }
}
