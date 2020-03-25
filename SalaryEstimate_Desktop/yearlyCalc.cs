namespace SalaryEstimate_Desktop
{
    class yearlyCalc
    {
        public double monthly(double yearAmount)
        {
            double monthCheck;
            monthCheck = yearAmount / 12;

            return monthCheck;

        }


        public double paycheckAmount(double yearAmount)
        {
            double paycheckAmount = (yearAmount / 12) / 2;
            return paycheckAmount;
        }

        public double hourlyCalc(double yearAmount)
        {
            double hourly = ((yearAmount / 12) / 2) / 80;
            return hourly;
        }
    }
}
