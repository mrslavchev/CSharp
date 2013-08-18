﻿using System;
using System.IO;
/*Write a program that reads a text file and inserts line numbers in front of each of its lines. 
 * The result should be written to another text file.
*/
class LineNumbers
{
    static void Main()
    {
        StreamWriter writer = new StreamWriter("../../Output.txt");
        StreamReader reader = new StreamReader("../../Example.txt");
        using (writer)
        {
            using (reader)
            {
                string line = reader.ReadLine();
                int lineCount = 1;
                while (line != null)
                {
                    writer.WriteLine("{0} {1}", lineCount, line);
                    lineCount++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}