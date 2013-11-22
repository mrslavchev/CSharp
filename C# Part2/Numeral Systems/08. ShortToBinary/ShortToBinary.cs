using System;
/*Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
*/
class ShortToBinary
{
    /// <summary>
    /// Using the convert class again
    /// </summary>
    static void Main()
    {
        short dec = -12;
        string binary = Convert.ToString((short)dec, 2).PadLeft(16, '0');
        Console.WriteLine(binary);
    }
}

