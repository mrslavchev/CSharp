using System;

using System;
using System.Text; // Encoding.UTF8 е от тук

class CopyrightTriangle
{
    static void Main()
    {
        char copyRight = '\u00A9';
        Console.OutputEncoding = Encoding.Unicode;
        System.Console.WriteLine(@"
        {0}
      {0} {0} {0}
    {0} {0} {0} {0} {0}", copyRight);

    }
}
