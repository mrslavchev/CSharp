using System;
using System.Text;

/// <summary>
/// Letters that are not displayed properly are controls or special characters like \n, \t and so on
/// </summary>
class PrintTheASCIITable
{
    static void Main(string[] args)
    {
        // setting the output encoding to ascii
        Console.OutputEncoding = Encoding.ASCII;
        for (int i = 0; i < 128; i++)
        {
            Console.Write("{0},  ", (char)i); // printing numbers cated to chars
        }
        Console.WriteLine();
    }
}

