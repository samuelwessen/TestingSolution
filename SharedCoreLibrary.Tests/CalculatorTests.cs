using System;
using Xunit;

namespace SharedCoreLibrary.Tests
{
    public class CalculatorTests
    {
        private Calculator _calculator { get; set; }

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Theory]
        [InlineData(1, 3, 4)]
        [InlineData(2, 3, 5)]
        [InlineData(10, 15, 25)]
        [InlineData(1.1, 3.3, 4.4)]
        public void Add_ShouldCalculateTwoDoubleValues(double first, double second, double expected)
        {
            Assert.Equal(expected, _calculator.Add(first, second));
        }

        [Theory]
        [InlineData(3, 1, 2)]
        [InlineData(2, 1, 1)]
        [InlineData(15, 5, 10)]
        [InlineData(2.1, 1.1, 1.0)]
        public void Subtract_ShouldSubtractOneDoubleValueFromAnother(double first, double second, double expected)
        {
            Assert.Equal(expected, _calculator.Subtract(first, second));
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(10, 2, 20)]
        [InlineData(50, 3, 150)]
        [InlineData(2.2, 1.1, 2.42)]
        public void Multiply_ShouldMultiplyOneDoubleValueWithAnother(double first, double second, double expected)
        {         
            Assert.Equal(expected, _calculator.Multiply(first, second), 3);
        }

    }
}
