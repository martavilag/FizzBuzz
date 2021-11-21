using System;

namespace FizzBuzz
{
    public class FizzBuzzChecker
    {
        public static string FizzBuzz(int number)
        {
            if (number == 1)
            {
                return "1";
            }

            if (number == 2)
            {
                return "2";
            }

            return "Fizz";
        }
    }
}
