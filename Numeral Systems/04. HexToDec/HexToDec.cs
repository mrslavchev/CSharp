using System;

class HexToDec
{
    static void Main()
    {
        string hexValue = "3E8";
        int decValue = Convert.ToInt32(hexValue,16);
        Console.WriteLine(decValue);
    }
}

