using System;

/// <summary>
/// We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators
/// that modifies n to hold the value v at the position p from the binary representation of n.
///	Example: n = 5 (00000101), p=3, v=1  13 (00001101)
///	n = 5 (00000101), p=2, v=0  1 (00000001)
/// </summary>
class HoldBitPosition
{
    static void Main()
    {
        Console.WriteLine("Please write a number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please write a bit position:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Please write 0 or 1");
        int v = int.Parse(Console.ReadLine());
        if (v == 1)
        {
            n = n | (1 << p);
            Console.WriteLine("And the new number is: {0}", n);
        }
        else if (v == 0)
        {
           n = n & (~(1<<p));
            
                Console.WriteLine("And the new number is: {0}", n);
            
        }
    }

}
