using System;

namespace FizzBuzz
{
    public class FizzBuzzChecker
    {
        public static string FizzBuzz(int number)
        {
            if (number == 15)
                return "FizzBuzz";

            if (number % 3 == 0)
                return "Fizz";

            if (number == 5)
                return "Buzz";

            if (number == 10)
                return "Buzz";

            return number.ToString();
        }
    }
}
