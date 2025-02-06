using NUnit.Framework;
using System.Collections.Generic;

public class FibonacciGeneratorTests
{
    [TestFixture]
    public class GenerateFibonacciTests
    {
        [Test]
        public void GenerateFibonacci_ValidInput_ReturnsCorrectSequence()
        {
            List<int> expected = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            List<int> actual = FibonacciGenerator.GenerateFibonacci(10);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GenerateFibonacci_SingleTerm_ReturnsZero()
        {
            List<int> expected = new List<int> { 0 };
            List<int> actual = FibonacciGenerator.GenerateFibonacci(1);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GenerateFibonacci_TwoTerms_ReturnsZeroAndOne()
        {
            List<int> expected = new List<int> { 0, 1 };
            List<int> actual = FibonacciGenerator.GenerateFibonacci(2);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GenerateFibonacci_ZeroTerms_ReturnsNull()
        {
            List<int> actual = FibonacciGenerator.GenerateFibonacci(0);
            Assert.That(actual, Is.Null);
        }

        [Test]
        public void GenerateFibonacci_NegativeInput_ReturnsNull()
        {
            List<int> actual = FibonacciGenerator.GenerateFibonacci(-5);
            Assert.That(actual, Is.Null);
        }

        [Test]
        public void GenerateFibonacci_LargeInput_ReturnsCorrectSequence()
        {
            List<int> actual = FibonacciGenerator.GenerateFibonacci(5);
            List<int> expected = new List<int> { 0, 1, 1, 2, 3 };
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}