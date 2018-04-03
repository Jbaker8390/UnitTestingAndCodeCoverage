﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.UnitTest
{
    [TestFixture]
    class MathTest
    {
        private Fundamentals.Math _math;
        //Setup
        //TearDown - often used in integration test, need to clean up after each test

        [SetUp]
        public void SetUp()
        {
            _math = new Fundamentals.Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));

        }

        [Test]
        [TestCase(2 ,1 ,2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }


        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

 
            //This
            Assert.That(result, Is.EquivalentTo(new [] {1, 3, 5}));
            //additional options below
            //Assert.That(result, Is.Ordered);
            //Assert.That(result, Is.Unique);
        }

    }
}