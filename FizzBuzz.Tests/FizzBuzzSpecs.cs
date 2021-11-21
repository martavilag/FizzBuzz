using System;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzSpecs
    {
        [Fact]
        public void OneReturnsString()
        {
            //Arrange and Act
            string result = FizzBuzzChecker.FizzBuzz(1);

            //Assert
            Assert.Equal("1", result);
        }
    }
}
