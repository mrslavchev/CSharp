using System;

class BinaryToHex
{
    static void Main()
    {
        string bin = "1101";

        int rest = bin.Length % 4;
        bin = bin.PadLeft(rest, '0'); //pad the length out to by divideable by 4

        string output = "";

        for (int i = 0; i <= bin.Length - 4; i += 4)
        {
            output += string.Format("{0:X}", Convert.ToByte(bin.Substring(i, 4), 2));
        }
        Console.WriteLine(output);
    }
}

