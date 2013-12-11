using System;

class UkFlag
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int mid = (n / 2) + 1;
        int leftLine = 1;
        int rightLine = n;
        int midLine = mid;
        for (int i = 1; i <= n; i++)
        {
            for (int k = 1; k <= n; k++)
            {
                if (k == leftLine && i < mid)
                {
                    Console.Write("\\");
                }
                else if (k == mid && i != mid)
                {
                    Console.Write("|");
                }
                else if (k == rightLine && i < mid)
                {
                    Console.Write("/");
                }
                else if (i == mid)
                {
                    if (k == mid)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                else if (k == leftLine && i > mid)
                {
                    Console.Write("/");
                } 
                else if (k == rightLine && i > mid)
                {
                    Console.Write("\\");
                }
                else
                {
                    Console.Write(".");
                }
            }
            if (i < mid)
            {
                leftLine++;
                rightLine--;
            }
            else if (i == mid)
            {
                leftLine--;
                rightLine++;
            }
            else if (i > mid)
            {
                leftLine--;
                rightLine++;
            }
            Console.WriteLine();
        }
    }
}

