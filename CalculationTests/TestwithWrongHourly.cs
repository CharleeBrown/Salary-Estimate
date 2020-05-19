using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalaryEstimate_Desktop;

namespace CalculationTests
{
    [TestClass]
    public class TestwithWrongHourly
    {
        [TestMethod]
        public void CorrectHourlyRate()
        {
            // The gross calculation method checks the total amount for two weeks worth of work. 
            // The hours would be correct, but the rate would be wrong. 
            // So i set an incorrect rate and a correct rate and run both against each other. 

            
            double incorrectRate = 2.00;

            double expected = 160.00;

            HourlyCalculation hourCalc = new HourlyCalculation();

           double actual =  hourCalc.checkCalc(incorrectRate);
                
            Assert.AreEqual(expected, actual, "The rate is correct");
        }

        [TestMethod]
        public void IncorrectHourlyRate()
        {

            // The gross calculation method checks the total amount for two weeks worth of work. 
            // The hours would be correct, but the rate would be wrong. 
            // So i set an incorrect rate and a correct rate and run both against each other. 


            double incorrectRate = 2.00;

            double expected = 1600.00;

            HourlyCalculation hourCalc = new HourlyCalculation();

            double actual = hourCalc.checkCalc(incorrectRate);
            Assert.AreNotEqual(expected, actual, 1.0, "The rate is incorrect");
        }
     
        
    }

    [TestClass]
    public class TestYearly
    {
        // Constant variables from the main class. 
        private const double monthsInYear = 12;
        private const double checksInMonth = 2;
        private const double hoursInCheck = 80;


        YearCalculation yearly = new YearCalculation();

        [TestMethod]
        public void CorrectYearlyTest()
        {
            int Salary = 30000;

            int expected = 2500;
            double actual = yearly.monthly(Salary);
            Assert.AreEqual(expected, actual,  "Incorrect Salary"); 

        }

        [TestMethod]
        public void IncorrectYearlyTest()
        {
            // This test should come up as incorrect. 

            int Salary = 30000;

            int expected= 2600;
            double actual = yearly.monthly(Salary);

            Assert.AreNotEqual(expected, actual, "Wrong Salary Amount");


           
        }
    }
}
