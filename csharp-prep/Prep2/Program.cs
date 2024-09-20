using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for grade percentage
            Console.Write("Enter your grade percentage: ");
            double percentage = Convert.ToDouble(Console.ReadLine());

            // Initialize letter grade variable
            string letter = "";
            string sign = "";  // Initialize sign variable

            // Determine letter grade
            if (percentage >= 90)
            {
                letter = "A";
            }
            else if (percentage >= 80)
            {
                letter = "B";
            }
            else if (percentage >= 70)
            {
                letter = "C";
            }
            else if (percentage >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            // Determine sign (+, -, or none)
            int lastDigit = (int)(percentage % 10);  // Get last digit
            if (letter != "A" && letter != "F")  // Exclude A and F
            {
                if (lastDigit >= 7)
                {
                    sign = "+";
                }
                else if (lastDigit < 3)
                {
                    sign = "-";
                }
            }
            else  // Handle A and F cases
            {
                if (letter == "A" && lastDigit < 3)
                {
                    letter = "A-";
                }
                // No F+ or F- grades
            }

            // Print letter grade with sign
            if (letter.Length > 1)  // Print A- (no sign)
            {
                Console.WriteLine($"Your letter grade is: {letter}");
            }
            else
            {
                Console.WriteLine($"Your letter grade is: {letter}{sign}");
            }

            // Determine if user passed the course
            if (percentage >= 70)
            {
                Console.WriteLine("Congratulations, you passed the course!");
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }
        }
    }
}