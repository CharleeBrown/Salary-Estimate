namespace TestRuns
{
    class Program
    {
        static void Main(string[] args)
        {
            Tests.HourlyCalcTest tests = new Tests.HourlyCalcTest();
            
            Tests.YearCalcTests yearTest = new Tests.YearCalcTests();
            tests.CorrectHourlyTest();
            tests.IncorrectHourlyTest();

            yearTest.CorrectYearlyTest();
            yearTest.IncorrectYearlyTest();
            

        }
    }
}
