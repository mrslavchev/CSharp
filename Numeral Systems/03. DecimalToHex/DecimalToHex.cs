using System;

class DecimalToHex
{
    static void Main(string[] args)
    {
        int dec = 1000;
        string hex = dec.ToString("X");
        Console.WriteLine(hex);
    }
}

