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

        [Fact]
        public void ThreeReturnsFizz()
        {
            //Arrange and Act
            string result = FizzBuzzChecker.FizzBuzz(3);

            //Assert
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void FourReturnsFour()
        {
            //Arrange and Act
            string result = FizzBuzzChecker.FizzBuzz(4);

            //Assert
            Assert.Equal("4", result);
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

    }
}
