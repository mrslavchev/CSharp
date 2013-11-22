using System;
/*Write a program to convert binary numbers to their decimal representation.
*/
class BinaryToDec
{
    static void Main()
    {
        string binary = "1011";
        int decRepresent = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[binary.Length - i -1] == '0')
            {
                continue;
            }
            else
            {
                decRepresent += (int)Math.Pow(2, i);
            }
        }

        Console.WriteLine(decRepresent);
    }
}

