using System;

class Program
{
    static void Main(string[] args)
    {
        // Test constructors and representations
        Fraction fraction1 = new Fraction(1);
        Fraction fraction2 = new Fraction(5, 1);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);

        // Display fractions
        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()} = {fraction1.GetDecimalValue()}");
        Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()} = {fraction2.GetDecimalValue()}");
        Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()} = {fraction3.GetDecimalValue()}");
        Console.WriteLine($"Fraction 4: {fraction4.GetFractionString()} = {fraction4.GetDecimalValue()}");

        // Test default constructor
        Fraction fraction5 = new Fraction();
        Console.WriteLine($"Fraction 5 (default): {fraction5.GetFractionString()} = {fraction5.GetDecimalValue()}");
    }
}