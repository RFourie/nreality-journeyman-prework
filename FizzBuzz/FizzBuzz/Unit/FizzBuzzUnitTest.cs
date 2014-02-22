using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FizzBuzz.Unit
{
    [TestFixture]
    class FizzBuzzUnitTest
    {
        [Test]
        public void PrintFizzSouldTheNumberBeDividableByThreeTest()
        {
            var fz = new Classes.FizzBuzz();

            var text = fz.ReturnValueForLetters(3);

            Assert.AreEqual("Fizz",text);
        }

        [Test]
        public void PrintBuzzSouldTheNumberBeDividableByFiveTest()
        {
            var fz = new Classes.FizzBuzz();

            var text = fz.ReturnValueForLetters(5);

            Assert.AreEqual("Buzz",text);
        }

        [Test]
        private void PrintFizzBuzzShouldTheNumberBeDeividableByThreeAndFive()
        {
            var fz = new Classes.FizzBuzz();

            var text = fz.ReturnValueForLetters(15);

            Assert.AreEqual("FizzBuzz",text);
        }

        [Test]
        public void PrintNumberIfTheNumberIsNotDividableByThreeOrFive()
        {
            var fz = new Classes.FizzBuzz();

            var text = fz.ReturnValueForLetters(1);

            Assert.AreEqual("1",text);
        }

    }
}
