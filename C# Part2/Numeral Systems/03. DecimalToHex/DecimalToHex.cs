using System;
/*Write a program to convert decimal numbers to their hexadecimal representation.
*/
/// <summary>
/// Using the the format function of string
/// </summary>
class DecimalToHex
{
    static void Main(string[] args)
    {
        int dec = 1000;
        string hex = dec.ToString("X");
        Console.WriteLine(hex);
    }
}

