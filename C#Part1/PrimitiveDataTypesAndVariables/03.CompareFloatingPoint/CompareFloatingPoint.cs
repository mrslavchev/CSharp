using System;

/// <summary>
/// Write a program that safely compares floating-point numbers with precision of 0.000001. 
/// Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true
/// </summary>

class CompareFloatingPoint
{
    static void Main()
    {
        // using math.round - a method for rounding decimal numbers up to specific point, the second parameter is 
        // the number of digits after the floating point
        Console.WriteLine("Please write the first number for comparison:");
        decimal num1 = Math.Round(decimal.Parse(Console.ReadLine()), 6);
        Console.WriteLine("Please write the second number for comparison:");
        decimal num2 = Math.Round(decimal.Parse(Console.ReadLine()), 6);
        bool areEqual = num1 == num2;
        Console.WriteLine("Are {0} and {1} equal with a precision up to 0.000001?\n{2}", num1, num2, areEqual);
    }
}

        
       
    


