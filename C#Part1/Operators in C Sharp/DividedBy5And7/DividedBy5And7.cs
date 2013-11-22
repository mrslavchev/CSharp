using System;

/// <summary>
/// Write a boolean expression that checks for given integer if it 
/// can be divided (without remainder) by 7 and 5 in the same time.
/// </summary>
class DividedBy5And7
{
    /// <summary>
    /// Quite simple, the smallest number divisible by 5 and 7 at the same time is 5*7
    /// All number should be devided by 35 w/o remain to make the expression true.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("PLease write a number to be devided");
        int input = int.Parse(Console.ReadLine());
        bool isDivisible = (input % 35) == 0;
        Console.WriteLine("Is {0} divisible by 5 and 7 at the same time?\n{1}", input, isDivisible);
    }
}

