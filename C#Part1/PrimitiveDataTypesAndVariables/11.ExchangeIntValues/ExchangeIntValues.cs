using System;

/// <summary>
/// Declare  two integer variables and assign them with 5 and 10 and after that exchange their values
/// </summary>
class ExchangeIntValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("a = {0}; b = {1}", a, b);
        int c = b;
        b = a;
        a = c;
        Console.WriteLine("a = {0}; b = {1}", a, b);         
    }
}

