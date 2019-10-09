using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BL.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValid()
        {
            //-- Arrange
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "2000";
            decimal expected = 40M;



            //-- Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);


            //-- Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValidAndSame()
        {
            //-- Arrange
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "5000";
            decimal expected = 100M;

            //-- Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValidActualIsZero()
        {
            //-- Arrange
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "0";
            decimal expected = 0M;

            //-- Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOfGoalStepsTestGoalIsNull()
        {
            //-- Arrange
            var customer = new Customer();
            string goalsSteps = null;
            string actualSteps = "2000";

            //-- Act
            var actual = customer.CalculatePercentOfGoalSteps(goalsSteps, actualSteps);

            //-- Assert

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOfGoalStepsTestGoalIsNotNumeric()
        {
            //-- Arrange
            var customer = new Customer();
            string goalsSteps = "one";
            string actualSteps = "2000";

            //-- Act
            try
            {
                var actual = customer.CalculatePercentOfGoalSteps(goalsSteps, actualSteps);
            }
            catch (Exception ex)
            {

                Assert.AreEqual("Goal must be numeric", ex.Message);
                throw;
            }

            //-- Assert

        }

    }
}