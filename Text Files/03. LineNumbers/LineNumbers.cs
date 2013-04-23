﻿using System;
using System.IO;

class Program
{
    static void Main()
    {
        int n = 1;

        using (StreamReader input = new StreamReader("../../LoremIpsum.txt"))
        using (StreamWriter output = new StreamWriter("../../outputFile.txt"))
            for (string line; (line = input.ReadLine()) != null; n++)
                output.WriteLine("{0}.{1}", n, line);
    }
}