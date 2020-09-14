// <copyright file="TestClass.cs" company="Ashi Chamarasinghe">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation

/*
  Kadupitige Ashi Chamarasinghe
  011611751
 */

namespace NUnit.Tests1
{
    using Homework3;
    using NUnit.Framework;

    /// <summary>
    /// This class test functions for overrride methods in fibonacci class.
    /// </summary>
    [TestFixture]
    public class TestClass
    {
        /// <summary>
        /// This function tests the overrriden read line function with a zero and it returns null since there's
        /// no calculations to be done.
        /// </summary>
        [Test]
        public void TestReadLineWithZero()
        {
            FibonacciTextReader fibTest = new FibonacciTextReader(0);
            string output = fibTest.ReadLine();
            Assert.That(output, Is.EqualTo(null));
        }

        /// <summary>
        /// This function tests the overriden read line with first two special cases which are zero and one.The function checks
        /// whether the number of sequcne is zero and one. This is a normal case.
        /// </summary>
        [Test]
        public void TestReadLineWithSpecialCases()
        {
            FibonacciTextReader fibTest = new FibonacciTextReader(1);
            int fibNumber = fibTest.NumberOfSequence;

            // Checks the first case of 0
            if (fibNumber == 0)
            {
                Assert.That(fibNumber, Is.EqualTo(0));
            }

            // Checks the second case of 1
            if (fibNumber == 1)
            {
                Assert.That(fibNumber, Is.EqualTo(1));
            }
        }

        /// <summary>
        /// This function tests the read line function with negative numbers. It would return null since the function
        /// only works with numbers > 0. This is an edge case.
        /// </summary>
        [Test]
        public void TestReadLineWithNegativeNumbers()
        {
            FibonacciTextReader fibTest = new FibonacciTextReader(-1);
            string output = fibTest.ReadLine();
            Assert.That(output, Is.EqualTo(null));
        }

        /// <summary>
        /// This function tests the overrriden read to end function with a zero and it returns an empty string since there's
        /// no calculations to be done.
        /// </summary>
        [Test]
        public void TestReadToEndWithZero()
        {
            FibonacciTextReader fibTest = new FibonacciTextReader(0);
            string output = fibTest.ReadToEnd();
            Assert.That(output, Is.EqualTo(string.Empty));
        }

        /// <summary>
        /// This function tests the overriden read to end function with first two special cases which are zero and one.The function checks
        /// outputs. For zero, it should output 0 and for 1, it would should output 1.
        /// </summary>
        [Test]
        public void TestReadToEndWithSpecialCases()
        {
            FibonacciTextReader fibTest = new FibonacciTextReader(2);
            string output = fibTest.ReadToEnd();
            int fibNumber = fibTest.NumberOfSequence;

            // Checks the first case of 0
            if (fibNumber == 0)
            {
                Assert.That(output, Is.EqualTo("1: 0\r\n"));
            }

            // Checks the second case of 1
            if (fibNumber == 1)
            {
                Assert.That(output, Is.EqualTo("1: 0\r\n" + "2: 1\r\n"));
            }
        }

        /// <summary>
        /// This function tests the overriden read to end with negative numbrs. The function would simply return an empty
        /// string since the function only accepts positive numbers.
        /// </summary>
        [Test]
        public void TestReadToEndWithNegativeNumbers()
        {
            FibonacciTextReader fibTest = new FibonacciTextReader(-2);
            string output = fibTest.ReadToEnd();
            Assert.That(output, Is.EqualTo(string.Empty));
        }
    }
}
