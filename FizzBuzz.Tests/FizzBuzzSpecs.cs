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
        public void ANumberReturnsTheSameNumberAsAString(int number, string expected)
        {
            //Arrange and Act
            string actual = FizzBuzzChecker.FizzBuzz(number);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ThreeReturnsFizz()
        {
            //Arrange and Act
            string result = FizzBuzzChecker.FizzBuzz(3);

            //Assert
            Assert.Equal("Fizz", result);
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
        public void SixReturnsFizz()
        {
            //Arrange and Act
            string result = FizzBuzzChecker.FizzBuzz(6);

            //Assert
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void NineReturnsFizz()
        {
            //Arrange and Act
            string result = FizzBuzzChecker.FizzBuzz(9);

            //Assert
            Assert.Equal("Fizz", result);
        }


    }
}
