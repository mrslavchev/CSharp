using System;

/// <summary>
/// Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.
/// </summary>
class BitNumberValue
{
    static void Main()
    {
        int i = 1234;
        int b = 10;
        int mask = 1 << b;
        int nAndMask = i & mask;
        int bit = nAndMask >> b;
        Console.WriteLine("The value of bit {0} in the number {1} is {2}",b,i,bit );
    }
}

