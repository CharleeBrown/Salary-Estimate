namespace SalaryEstimate_Desktop
{
    public class HourlyCalculation
    {
        private const double hoursInPaycheck = 80;
        private const double checksInMonth = 2;
        private const double monthsInYear = 12;
        public double checkCalc(double ratePerHour)
        {
            double grossCheck;
            grossCheck = ratePerHour * hoursInPaycheck;

            return grossCheck;

        }


        public double monthlyCalculation(double ratePerHour)
        {
            double monthlyAmount = (ratePerHour * hoursInPaycheck) * checksInMonth;
            return monthlyAmount;
        }

        public double yearlyCalculation(double raterPerHour)
        {
            double yearAmount = ((raterPerHour * hoursInPaycheck) * checksInMonth) * monthsInYear;
            return yearAmount;
        }
    }
}
