
//Write a program to convert decimal numbers to their binary representation.

using System;
using System.Text;
using System.Collections.Generic;

class DecimalToBin
{
    static string ConvertToBinary(int decValue) 
    {
        List<int> tempBinary = new List<int>();
        StringBuilder output = new StringBuilder();
        while (decValue != 0)
        {
            tempBinary.Add(decValue % 2);
            decValue = decValue / 2;
        }

        tempBinary.Reverse();
        foreach (var item in tempBinary)
        {
            output.Append(item);
        }

        return output.ToString();
    }

    static void Main()
    {
        Console.WriteLine(ConvertToBinary(321));
    }
}

