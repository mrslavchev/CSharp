using System;

class TelerikLogo
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int cols = (x * 3) - 2;
        int rows1 = x;
        int rows2 = x - 1;
        int center = (cols /2) + 1;
        int rightEdge  = center + (x - 1);
        int rightMiddle = center + (x - 1);
        int leftEdge = center - (x - 1);
        int leftMiddle = center - (x - 1);
        for (int i = 1; i <= rows1; i++)
        {
            for (int k = 1; k <= cols; k++)
            {
                if (k == leftEdge || k == leftMiddle)
                {
                    Console.Write("*");
                }
                else if (k == rightEdge || k == rightMiddle)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }

            Console.WriteLine();
            if (i == x)
            {
                continue;
            }
            rightEdge++;
            leftEdge--;
            leftMiddle++;
            rightMiddle--;
        }

        for (int i = 1; i <= rows2; i++)
        {
            leftMiddle--;
            rightMiddle++;
            for (int k = 1; k <= cols; k++)
            {
                if (k == leftMiddle || k == rightMiddle)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }

            Console.WriteLine();
        }

        for (int i = 1; i <= rows2; i++)
        {
            leftMiddle++;
            rightMiddle--;
            for (int k = 1; k <= cols; k++)
            {
                if (k == leftMiddle || k == rightMiddle)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
      
            Console.WriteLine();
        }
    }
}

