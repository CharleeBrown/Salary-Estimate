namespace SalaryEstimate_Desktop
{
    public class YearCalculation
    {
        private const double monthsInYear = 12;
        private const double checksInMonth = 2;
        private const double hoursInCheck = 80;
        public double monthly(double annualSalary)
        {
            double monthlySalary;
            monthlySalary = annualSalary / monthsInYear;

            return monthlySalary;

        }


        public double paycheckAmount(double annualSalary)
        {
            double paycheckAmount = (annualSalary / monthsInYear) / checksInMonth;
            return paycheckAmount;
        }

        public double hourlyCalc(double annualSalary)
        {
            double hourlyRate = ((annualSalary / monthsInYear) / checksInMonth) / hoursInCheck;
            return hourlyRate;
        }
    }
}
