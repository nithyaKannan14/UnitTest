using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;

namespace FizzBuzzer.Tests
{
    public class FizzBuzzerTests
    {
        FizzBuzz.FizzBuzzer fizzBuzzer;

        public FizzBuzzerTests()
        {
            fizzBuzzer = new FizzBuzz.FizzBuzzer();

        }

        [Test]
        public void ValidateWordFizz()
        {
            int inputValue = 3;
            string returnWord = fizzBuzzer.Generate(inputValue);
            Assert.AreEqual(returnWord, "Fizz");
        }

        [Test]
        public void ValidateWordBuzz()
        {
            int inputValue = 5;
            string returnWord = fizzBuzzer.Generate(inputValue);
            Assert.AreEqual(returnWord, "Buzz");
        }

        [Test]
        public void ValidateWordFizzBuzz()
        {
            int inputValue = 15;
            string returnWord = fizzBuzzer.Generate(inputValue);
            Assert.AreEqual(returnWord, "FizzBuzz");
        }

        [Test]
        public void ValidateInputValueNotDivisible()
        {
            int inputValue = 3;
            string returnWord = fizzBuzzer.Generate(inputValue);
            if (!returnWord.Equals(inputValue.ToString()))
            {
                Assert.Fail("inputValue not equals to return value");
            }         

        }
    }
}

