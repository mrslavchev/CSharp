using System;

class BoolBitEqualsOne
{
    static void Main()
    {
        int v = 43;
        int p = 2;
        int mask = 1 << p;
        int nAndMask = v & mask;
        int bit = nAndMask >> p;
        bool final = (bit == 1);
        Console.WriteLine("Is the {0} bit's value of the number {1} equal to 1? {2}",p,v,final );
    }
}

