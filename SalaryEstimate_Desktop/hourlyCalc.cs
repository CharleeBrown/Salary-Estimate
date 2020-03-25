namespace SalaryEstimate_Desktop
{
    class hourlyCalc
    {
        Form1 form = new Form1();
        public double checkCalc(double hourAmount)
        {
            double grossCheck;
            grossCheck = hourAmount * 80;

            return grossCheck;

        }


        public double monthCalc(double hourAmount)
        {
            double monthlyAmount = (hourAmount * 80) * 2;
            return monthlyAmount;
        }

        public double yearCalc(double hourAmount)
        {
            double yearAmount = ((hourAmount * 80) * 2) * 12;
            return yearAmount;
        }
    }
}
