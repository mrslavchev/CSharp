using System;

class BinaryToDec
{
    static void Main()
    {
        string binary = "101011";
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

