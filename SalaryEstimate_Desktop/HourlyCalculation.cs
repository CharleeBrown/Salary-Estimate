namespace SalaryEstimate_Desktop
{
    public class HourlyCalculation
    {
        // Variables for pay hours, check amounts and months. 
        private const double hoursInPaycheck = 80;
        private const double checksInMonth = 2;
        private const double monthsInYear = 12;

        // Method to get the gross amount in a check. 
        public double checkCalc(double ratePerHour)
        {
            double grossCheck = ratePerHour * hoursInPaycheck;

            return grossCheck;
        }

        // Method to get the gross amount in a month. Which is two checks. 
        public double monthlyCalculation(double ratePerHour)
        {
            double monthlyAmount = (ratePerHour * hoursInPaycheck) * checksInMonth;
            return monthlyAmount;
        }

        // Method to get the pay amount in a year. Which is 12 times the montly amount. 
        public double yearlyCalculation(double raterPerHour)
        {
            double yearAmount = ((raterPerHour * hoursInPaycheck) * checksInMonth) * monthsInYear;
            return yearAmount;
        }
    }
}