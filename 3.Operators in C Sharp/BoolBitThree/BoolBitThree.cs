using System;

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

