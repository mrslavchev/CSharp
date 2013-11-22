﻿using System;
/*Write a program that reads a number and prints it as a decimal number,
 * hexadecimal number, percentage and in scientific notation. 
 * Format the output aligned right in 15 symbols*/
class NumberInFormats
{
    static void Main()
    {
        Console.WriteLine("Please write a number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Decimal: {0:D}".PadRight(15), number);
        Console.WriteLine("Hex: {0:X}".PadRight(15), number);
        Console.WriteLine("Percent: {0:P}".PadRight(15), number);
        Console.WriteLine("Scientific: {0:E}".PadRight(15), number);
    }
}