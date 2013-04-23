using System;

class ShortToBinary
{
    static void Main(string[] args)
    {
        short dec = -12;
        string binary = Convert.ToString((short)dec, 2).PadLeft(16, '0');
        Console.WriteLine(binary);
    }
}

