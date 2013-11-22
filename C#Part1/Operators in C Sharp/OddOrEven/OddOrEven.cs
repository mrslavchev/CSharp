using System;

/// <summary>
/// Write an expression that checks if given integer is odd or even.
/// </summary>
class OddOrEven
{
    static void Main()
    {
        int a = -5;
        int b = (a & 1); // clever bitwise way check if a number is odd. 
        if (b == 1)      // good to know, all od numbers have the right most bit == 1
        {
            Console.WriteLine("This number is odd");
        }   
        else
            Console.WriteLine("This number is even");
    }
}

