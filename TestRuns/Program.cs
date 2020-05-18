namespace TestRuns
{
    class Program
    {
        static void Main(string[] args)
        {
            HourlyCalcTest tests = new HourlyCalcTest();
            tests.CorrectHourlyTest();
            tests.IncorrectHourlyTest();

        }
    }
}
