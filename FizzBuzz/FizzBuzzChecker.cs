using System;

namespace FizzBuzz
{
    public class FizzBuzzChecker
    {
        public static string FizzBuzz(int number)
        {
            if (number % 3 == 0)
                return "Fizz";

            if (number == 5)
                return "Buzz";

            return number.ToString();
        }
    }
}
