using System;
/*Write a program to convert hexadecimal numbers to their decimal representation.
*/
/// <summary>
/// Using the ocnvert class
/// </summary>
class HexToDec
{
    static void Main()
    {
        string hexValue = "3E8";
        int decValue = Convert.ToInt32(hexValue,16);
        Console.WriteLine(decValue);
    }
}

