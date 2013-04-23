using System;

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
