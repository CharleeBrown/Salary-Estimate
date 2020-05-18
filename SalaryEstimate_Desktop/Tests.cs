using System;

namespace SalaryEstimate_Desktop
{


    public class Tests{
        
        private const double hoursInPaycheck = 80;
        private const double checksInMonth = 2;
        private const double monthsInYear = 12;
        public void HourlyTests()
        {
        
            public double rate = 10.00; 
            public double expectedPay = 800.00;

            HourlyCalculation cals = new HourlyCalculation();

                    if(expectedPay = cals.checkCalc(rate))
                    {
                        Console.WriteLIne(@"Test Passed. {0} is equal to {1}", expectedPay, cals.checkCalc(rate));
                    }
                    else
                    {
                        Console.WriteLine(@"Test Not passed. {0}  and {1} are not equal", expectedPay, cals.checkCalc(rate));
                    };
        }
    }
}


        
    

