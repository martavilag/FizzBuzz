using System;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzSpecs
    {
        [Fact]
        public void OneReturnsString()
        {
            string result = FizzBuzzChecker.FizzBuzz();

            Assert.Equal("1", result);
        }
    }
}
