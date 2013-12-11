using System;

class EasterEgg
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int height = 2 * n;
        int widthEgg = (3 * n) - 1;
        int widthArea = (3 * n) + 1;
        int sizes = n - 1;
        int downCounter = 0;
        int upperRib = height / 2;
        int lowerRib = (height / 2) + 1;
        int left = ((widthArea / 2) - (sizes / 2) + 1);
        int right = ((widthArea / 2) + (sizes / 2) + 1);

        //Console.WriteLine(height);
        //Console.WriteLine(widthEgg);
        //Console.WriteLine(widthArea);
        //Console.WriteLine(sizes);
        //Console.WriteLine(upperRib);
        //Console.WriteLine(lowerRib);
        //Console.WriteLine(left);
        //Console.WriteLine(right);

        for (int rows = 1; rows <= height ; rows++)
        {
            for (int cols = 1; cols <= widthArea; cols++)
            {
                if ((cols >= left && cols <= right) && ((rows == 1) || rows == height))
                {
                    Console.Write("*");
                }
                else if ((cols == left) || cols == right)
                {
                    Console.Write("*");
                }
                else if ((rows == upperRib) )
                {
                    if ((cols & 1) == 0)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                else if ((rows == lowerRib))
                {
                    if (((cols & 1) == 1) && ((cols != 1) && (cols != widthArea)))
                    {
                        Console.Write("#");
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
            if (rows < (height / 2) - (n / 2) + 1)
            {
                left -= 2;
                right += 2;
            }
            else if (rows >= height - (n / 2))
            {
                left += 2;
                right -= 2;
            }
            
        }
    }
}

