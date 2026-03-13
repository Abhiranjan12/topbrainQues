using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataDrivenTest
{
    public class PrimeChecker
    {
        public bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }

    [TestClass]
    public class PrimeCheckerTests
    {
        [DataTestMethod]
        [DataRow(2, true)]
        [DataRow(3, true)]
        [DataRow(4, false)]
        [DataRow(5, true)]
        [DataRow(9, false)]
        [DataRow(11, true)]
        [DataRow(1, false)]
        [DataRow(0, false)]
        public void IsPrime_TestMultipleData(int number, bool expected)
        {
            PrimeChecker checker = new PrimeChecker();

            bool result = checker.IsPrime(number);

            Assert.AreEqual(expected, result);
        }
    }
}