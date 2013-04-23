﻿using System;
using System.IO;

class ConcatTwoFiles
{
    static void WriteToFile(StreamWriter output, string file)
    {
        using (StreamReader input = new StreamReader(file))
            for (string line; (line = input.ReadLine()) != null; )
                output.WriteLine(line);
    }

    static void Main()
    {
        string[] files = { "../../LoremIpsum.txt", "../../LoremIpsumTwo.txt" };

        using (StreamWriter output = new StreamWriter("../../outputFile.txt"))//blank output file
            foreach (string file in files)
                WriteToFile(output, file);
    }
}