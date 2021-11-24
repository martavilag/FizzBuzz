using System;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzSpecs
    {
        [Theory]
        [InlineData(1,"1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        [InlineData(7, "7")]
        [InlineData(8, "8")]
        [InlineData(11, "11")]
        [InlineData(13, "13")]
        [InlineData(14, "14")]
        public void ANumberReturnsTheSameNumberAsAString(int number, string expected)
        {
            //Arrange and Act
            string actual = FizzBuzzChecker.FizzBuzz(number);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(6, "Fizz")]
        [InlineData(9, "Fizz")]
        [InlineData(12, "Fizz")]
        public void ANumberMultipleOfThreeReturnsStringFizz(int number, string expected)
        {
            //Arrange and Act
            string actual = FizzBuzzChecker.FizzBuzz(number);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FiveReturnsBuzz()
        {
            //Arrange and Act
            string result = FizzBuzzChecker.FizzBuzz(5);

            //Assert
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void TenReturnsBuzz()
        {
            //Arrange and Act
            string result = FizzBuzzChecker.FizzBuzz(10);

            //Assert
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void FifteenReturnsFizzBuzz()
        {
            //Arrange and Act
            string result = FizzBuzzChecker.FizzBuzz(15);

            //Assert
            Assert.Equal("FizzBuzz", result);
        }

    }
}
