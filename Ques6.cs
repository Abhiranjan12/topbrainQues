using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DivideFunctionTest
{
    // Calculator class
    public class Calculator
    {
        public int Divide(int x, int y)
        {
            if (y == 0)
                throw new DivideByZeroException("Cannot divide by zero");

            return x / y;
        }
    }

    // MSTest class
    [TestClass]
    public class CalculatorTests
    {
        private Calculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new Calculator();
        }

        // Test 1: Normal division
        [TestMethod]
        public void Divide_ValidNumbers_ReturnsQuotient()
        {
            int result = calculator.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        // Test 2: Division with negative number
        [TestMethod]
        public void Divide_NegativeNumbers_ReturnsQuotient()
        {
            int result = calculator.Divide(-10, 2);
            Assert.AreEqual(-5, result);
        }

        // Test 3: Division by zero
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ByZero_ThrowsException()
        {
            calculator.Divide(10, 0);
        }
    }
}