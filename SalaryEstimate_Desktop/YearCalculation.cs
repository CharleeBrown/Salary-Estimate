namespace SalaryEstimate_Desktop
{
    public class YearCalculation
    {
        // Variables to hold number of checks in a month. Months in Year, hours in check. 
        private const double monthsInYear = 12;
        private const double checksInMonth = 2;
        private const double hoursInCheck = 80;
        // Method to calculate the gross amount in a month. 
        public double monthly(double annualSalary)
        {
            double monthlySalary = annualSalary / monthsInYear;

            return monthlySalary;
        }

        // Method to calculate the amount in a paycheck. 
        // The yearly salary divided by the months in a year. Divided by checks in a month. 
        public double paycheckAmount(double annualSalary)
        {
            double paycheckAmount = (annualSalary / monthsInYear) / checksInMonth;
            return paycheckAmount;
        }
        // Method to calculate the hourly rate. 
        // The yearly salary divided by the months in a year. Divided by checks in a month. 
        // Divided by hours in a check. This is assuming 40 hours. 
        public double hourlyCalc(double annualSalary)
        {
            double hourlyRate = ((annualSalary / monthsInYear) / checksInMonth) / hoursInCheck;
            return hourlyRate;
        }
    }
}