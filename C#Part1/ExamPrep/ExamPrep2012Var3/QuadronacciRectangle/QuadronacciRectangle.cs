using System;
using System.Collections.Generic;
using System.Numerics;


class QuadronacciRectangle
{
    static void Main(string[] args)
    {
        List<BigInteger> numbs = new List<BigInteger>();
        numbs.Add(long.Parse(Console.ReadLine()));
        numbs.Add(long.Parse(Console.ReadLine()));
        numbs.Add(long.Parse(Console.ReadLine()));
        numbs.Add(long.Parse(Console.ReadLine()));
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());
        int end = (col * row);
        for (int i = 3; i < end - 1; i++)
        {
            numbs.Add(numbs[i] + numbs[i - 1] + numbs[i - 2] + numbs[i - 3]);
        }

        int counter = 0;
        for (int i = 0; i < row; i++)
        {
            for (int k = 0; k < col; k++)
            {
                if (k != col - 1)
                {
                    Console.Write("{0} ", numbs[counter]);
                    counter++;
                }
                else
                {
                    Console.Write(numbs[counter]);
                    counter++;
                }
            }
            Console.WriteLine();
        }
    }
}

