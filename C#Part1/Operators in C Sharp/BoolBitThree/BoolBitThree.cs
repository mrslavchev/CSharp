using System;

/// <summary>
/// Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
/// </summary>
class BoolBitThree
{
    static void Main()
    {
        int n = 16;
        int p = 4;
        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;
        bool result = (bit == 1);
        if (result)
        {
            Console.WriteLine("The third bit of the number {0} is 1",n);
        }
        else
        {
            Console.WriteLine("The third bit of the number {0} is 0",n);

        }

    }
}

