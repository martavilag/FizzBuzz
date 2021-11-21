using System;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzSpecs
    {
        [Fact]
        public void OneReturnsOne()
        {
            //Arrange and Act
            string result = FizzBuzzChecker.FizzBuzz(1);

            //Assert
            Assert.Equal("1", result);
        }

        [Fact]
        public void TwoReturnsTwo()
        {
            //Arrange and Act
            string result = FizzBuzzChecker.FizzBuzz(2);

            //Assert
            Assert.Equal("2", result);
        }
    }
}
