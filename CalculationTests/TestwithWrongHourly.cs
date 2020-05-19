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
}
