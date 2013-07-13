using System;

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

