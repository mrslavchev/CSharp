
//Write a program to convert decimal numbers to their binary representation.

using System;


class DecimalToBin
{
    static void Main(string[] args)
    {
        int number = 63;
        string binary = Convert.ToString(number, 2);
        long result = Convert.ToInt64(binary);
        Console.WriteLine(result);
    }
}

