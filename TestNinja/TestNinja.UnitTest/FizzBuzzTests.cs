using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using  TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    class FizzBuzzTests
    {
        [Test]
        [TestCase(8)]
        [TestCase(16)]
        [TestCase(22)]
        public void GetOutput_NotDivisibleBy3Or5_ReturnNumber(int number)
        {
            var result = FizzBuzz.GetOutput(number);
            
            Assert.That(result, Is.EqualTo(number.ToString()));
        }

        [Test]
        [TestCase(5)]
        [TestCase(20)]
        [TestCase(25)]
        public void GetOutput_DivisibleBy5_ReturnBuzz(int number)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        

        [Test]
        [TestCase(18)]
        [TestCase(21)]
        [TestCase(27)]
        public void GetOutput_DivisibleBy3_ReturnFizz(int number)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        [TestCase(15)]
        [TestCase(30)]
        [TestCase(60)]
        public void GetOutput_DivisBy3And5_ReturnFizzBuzz(int number)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }
    }
}
