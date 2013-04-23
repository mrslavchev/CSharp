﻿using System;

class NumberInFormats
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Decimal {0,15}", number);   

        Console.WriteLine("Hex {0,15:X}", number);

        Console.WriteLine("Percentage {0,15:P}", number); 

        Console.WriteLine("Scientific notation {0,15:E}", number);
    }
}