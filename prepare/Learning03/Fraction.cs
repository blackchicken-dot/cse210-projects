using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        if (bottom == 0)
        {
            throw new ArgumentException("bottom cannot be zero.");
        }
        _top = top;
        _bottom = bottom;
    }

    // Public Properties
    public int top 
    { 
        get { return top; } 
        set { top = value; } 
    }

    public int bottom 
    { 
        get { return bottom; } 
        set 
        { 
            if (value == 0)
            {
                throw new ArgumentException("bottom cannot be zero.");
            }
            bottom = value; 
        } 
    }

    // Method to return fractional representation
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to return decimal representation
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }

    // Override ToString method
    public override string ToString()
    {
        return GetFractionString();
    }
}