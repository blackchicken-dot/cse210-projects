using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberListProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize list
            List<double> numbers = new List<double>();

            // Input numbers
            while (true)
            {
                Console.Write("Enter number (0 to finish): ");
                double number = Convert.ToDouble(Console.ReadLine());
                if (number == 0)
                {
                    break;
                }
                numbers.Add(number);
            }

            // Compute sum
            double sum = numbers.Sum();

            // Compute average
            double average = numbers.Average();

            // Find maximum
            double max = numbers.Max();

            // Find smallest positive number
            double smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty(double.MaxValue).Min();

            // Sort list
            var sortedNumbers = numbers.OrderBy(n => n).ToList();

            // Display results
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            Console.WriteLine("The sorted list is:");
            foreach (var number in sortedNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}