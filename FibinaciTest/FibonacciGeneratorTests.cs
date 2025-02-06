using NUnit.Framework;
using System;
using System.Collections.Generic;

public class FibonacciGeneratorTests
{
    [TestFixture]
    public class GenerateFibonacciSeriesTests
    {
        [Test]
        public void GenerateFibonacciSeries_ValidInput_ReturnsCorrectSeries()
        {
            // Arrange
            int n = 10;
            List<int> expectedSeries = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };

            // Act
            List<int> actualSeries = FibonacciGenerator.GenerateFibonacciSeries(n);

            // Assert
            Assert.That(actualSeries, Is.EqualTo(expectedSeries));
        }

        [Test]
        public void GenerateFibonacciSeries_ZeroInput_ReturnsEmptyList()
        {
            // Arrange
            int n = 0;
            List<int> expectedSeries = new List<int>();

            // Act
            List<int> actualSeries = FibonacciGenerator.GenerateFibonacciSeries(n);

            // Assert
            Assert.That(actualSeries, Is.EqualTo(expectedSeries));
        }

        [Test]
        public void GenerateFibonacciSeries_OneInput_ReturnsListWithZero()
        {
            // Arrange
            int n = 1;
            List<int> expectedSeries = new List<int> { 0 };

            // Act
            List<int> actualSeries = FibonacciGenerator.GenerateFibonacciSeries(n);

            // Assert
            Assert.That(actualSeries, Is.EqualTo(expectedSeries));
        }

        [Test]
        public void GenerateFibonacciSeries_TwoInput_ReturnsListWithZeroAndOne()
        {
            // Arrange
            int n = 2;
            List<int> expectedSeries = new List<int> { 0, 1 };

            // Act
            List<int> actualSeries = FibonacciGenerator.GenerateFibonacciSeries(n);

            // Assert
            Assert.That(actualSeries, Is.EqualTo(expectedSeries));
        }

        [Test]
        public void GenerateFibonacciSeries_NegativeInput_ThrowsArgumentException()
        {
            // Arrange
            int n = -1;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => FibonacciGenerator.GenerateFibonacciSeries(n));
        }

        [Test]
        public void GenerateFibonacciSeries_LargeInput_ReturnsCorrectSeries()
        {
            // Arrange
            int n = 15;
            List<int> expectedSeries = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 };

            // Act
            List<int> actualSeries = FibonacciGenerator.GenerateFibonacciSeries(n);

            // Assert
            Assert.That(actualSeries, Is.EqualTo(expectedSeries));
        }
    }
}