﻿using calculator.TwoArguments;
using NUnit.Framework;

namespace calculator.Tests.TwoArguments
{
    [TestFixture]
    class MaxTwoArgumentsTest
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 4)]
        [TestCase(-7, -2, -2)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new MaxTwoArguments();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
