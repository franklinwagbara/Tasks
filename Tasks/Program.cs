using System;
using System.Collections.Generic;

public class FibonacciGenerator
{
    /// <summary>
    /// Generates a Fibonacci sequence up to a specified number of terms.
    /// </summary>
    /// <param name="n">The number of Fibonacci terms to generate.</param>
    /// <returns>A list containing the Fibonacci sequence, or null if the input is invalid.</returns>
    public static List<int> GenerateFibonacci(int n)
    {
        // Input validation: Check for non-positive input
        if (n <= 0)
        {
            return null; // Or throw an exception, depending on desired behavior
        }

        List<int> fibonacciSeries = new List<int>();

        // Base cases for the first two Fibonacci numbers
        if (n >= 1)
        {
            fibonacciSeries.Add(0);
        }
        if (n >= 2)
        {
            fibonacciSeries.Add(1);
        }

        // Generate the remaining Fibonacci numbers
        for (int i = 2; i < n; i++)
        {
            int nextFibonacci = fibonacciSeries[i - 1] + fibonacciSeries[i - 2];
            fibonacciSeries.Add(nextFibonacci);
        }

        return fibonacciSeries;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter the number of Fibonacci terms to generate: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int n))
        {
            List<int> fibonacciSeries = GenerateFibonacci(n);

            if (fibonacciSeries != null)
            {
                Console.WriteLine("Fibonacci Series:");
                foreach (int fibonacciNumber in fibonacciSeries)
                {
                    Console.WriteLine(fibonacciNumber);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}