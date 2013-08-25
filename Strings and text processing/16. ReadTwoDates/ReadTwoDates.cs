﻿using System;
using System.Globalization;
/*Write a program that reads two dates in the format: day.month.year and calculates the number of days between them*/
/// <summary>
/// Using the datetime class.
/// </summary>
class ReadTwoDates
{
    static void Main()
    {
        Console.WriteLine("PLease write a first date:");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("PLease write a second date:");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("There are {0} days between them.", (secondDate - firstDate).Days);
    }
}