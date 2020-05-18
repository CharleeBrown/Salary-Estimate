using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryEstimate_Desktop;

namespace TestRuns
{
    class Program
    {
        static void Main(string[] args)
        {
            TestsOne tests = new TestsOne();
            tests.HourlyTests();
            tests.IncorrectTest();
          
        }
    }
}
