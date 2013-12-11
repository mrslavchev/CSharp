using System;

class BoykosTower
{
    static void Main(string[] args)
    {
        int h = int.Parse(Console.ReadLine());
        int w = h * 2;
        int n = 2;
        int left = h;
        int right = h + 1;
        for (int rows = 1; rows <= h; rows++)
        {
            for (int cols = 1; cols <= w; cols++)
            {
                if (cols == left)
                {
                    Console.Write("/");
                }
                else if (cols == right)
                {
                    Console.Write("\\");
                }
                else if (rows == n)
                {
                    if (cols > left && cols < right)
                    {
                        Console.Write("-");
                        n = n * ((n - 1) / 2) + 1;
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
            left--;
            right++;
        }
    }
}

