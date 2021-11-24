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
        [InlineData(16, "16")]
        [InlineData(17, "17")]
        [InlineData(19, "19")]
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
        [InlineData(18, "Fizz")]
        public void ANumberMultipleOfThreeReturnsStringFizz(int number, string expected)
        {
            //Arrange and Act
            string actual = FizzBuzzChecker.FizzBuzz(number);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        [InlineData(20, "Buzz")]
        public void ANumberMultipleOfFiveReturnsStringBuzz(int number, string expected)
        {
            //Arrange and Act
            string actual = FizzBuzzChecker.FizzBuzz(number);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(15, "FizzBuzz")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(45, "FizzBuzz")]
        public void ANumberMultipleOfThreeAndFiveReturnsStringFizzBuzz(int number, string expected)
        {
            //Arrange and Act
            string actual = FizzBuzzChecker.FizzBuzz(number);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
