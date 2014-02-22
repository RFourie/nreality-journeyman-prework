using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            var fz = new Classes.FizzBuzz();

            for (int i = 1; i <= 100; i++)
            {
                var value = fz.ReturnValueForLetters(i);

                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
