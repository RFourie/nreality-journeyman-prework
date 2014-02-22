using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using NUnit.Framework.Constraints;

namespace FizzBuzz.Classes
{
    class FizzBuzz
    {
        public string ReturnValueForLetters(int number)
        {
            if (number%3 == 0 && number%5 == 0)
            {
                return "FizzBuzz";
            }
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            if (number % 5 == 0)
            {
                return "Buzz";
            }
            return number.ToString(CultureInfo.InvariantCulture);
        }
    }
}
