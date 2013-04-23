﻿using System;
using System.IO;

class Program
{
    static void Main()
    {
        int n = 0, same = 0;

        using (StreamReader input1 = new StreamReader("../../LoremIpsum.txt"))
        using (StreamReader input2 = new StreamReader("../../outputFile.txt"))
            for (string line1, line2; (line1 = input1.ReadLine()) != null && (line2 = input2.ReadLine()) != null; n++)
                if (line1 == line2) same++;

        Console.WriteLine("Same lines are: {0} and different are: {1}", same, n - same);
    }
}
