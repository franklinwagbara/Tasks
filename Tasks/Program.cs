using System;
using System.Collections.Generic;

public class FibonacciGenerator
{
    public static List<int> GenerateFibonacciSeries(int n)
    {
        // Input validation: Check for non-negative input
        if (n < 0)
        {
            throw new ArgumentException("The number of Fibonacci numbers to generate must be non-negative.");
        }

        List<int> fibonacciSeries = new List<int>();

        if (n == 0)
        {
            return fibonacciSeries; // Return an empty list if n is 0
        }

        fibonacciSeries.Add(0); // First Fibonacci number

        if (n == 1)
        {
            return fibonacciSeries;
        }

        fibonacciSeries.Add(1); // Second Fibonacci number

        if (n == 2)
        {
            return fibonacciSeries;
        }

        // Generate the remaining Fibonacci numbers iteratively
        for (int i = 2; i < n; i++)
        {
            int nextFibonacci = fibonacciSeries[i - 1] + fibonacciSeries[i - 2];
            fibonacciSeries.Add(nextFibonacci);
        }

        return fibonacciSeries;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter the number of Fibonacci numbers to generate: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int n))
        {
            try
            {
                List<int> fibonacciSeries = GenerateFibonacciSeries(n);

                Console.WriteLine("Fibonacci Series:");
                foreach (int fibonacciNumber in fibonacciSeries)
                {
                    Console.WriteLine(fibonacciNumber);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}