using System;

class ForestRoad
{
    static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine());
        int length = (width * 2) - 1;
        for (int i = 0; i < length ; i++)
        {
            for (int k = 0; k < width; k++)
            {
                if (k == i)
                {
                    Console.Write("*");
                }
                else if (k == (length - i -1))
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

