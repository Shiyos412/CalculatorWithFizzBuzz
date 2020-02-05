using System;
using Xunit;
using Calculations;

namespace CalculatorTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new long[] { -5, 23, 0, 1026 }, 1044)]
        [InlineData(new long[] { 0, 0, 0, 1 }, 1)]

        public void SumTests(long[] arr, long expected)
        {
            //Act
            long result = Calculator.Sum(arr);
            //Assert
            Assert.Equal(expected, result);
        }

        
    }
}
