using System;
/*Write a program to convert binary numbers to hexadecimal numbers (directly).
*/
class BinaryToHex
{
    /// <summary>
    /// Using padleft to split the string into substring by 4 digits
    /// Basically the alorithm goes like this: split the binary number into substrings by 4s, convert to decimal using the position
    /// right to left as a power of 2, and than pick the corresponding letter/digit form the hex num system. Example:
    /// 1011101011001110 = 1011 1010 1100 1110 = 8+2+1 + 8+2 + 8+4 + 8+4+2 = 11 + 10 + 12 + 14
    /// And the coresponding letters are BACE
    /// </summary>
    static void Main()
    {
        string bin = "1011101011001110";
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

