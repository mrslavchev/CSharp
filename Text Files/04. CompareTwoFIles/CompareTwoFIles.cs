﻿using System;
using System.IO;
/*Write a program that compares two text files line by line and prints the number of lines
 * that are the same and the number of lines that are different. Assume the files have equal number of lines.
*/
class CompareTwoFIles
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../FileOne.txt");
        StreamReader secondReader = new StreamReader("../../FileTwo.txt");
        using (reader)
        {
            using (secondReader)
            {
                string firstReaderLine;
                string secondReaderLine;
                int equalLines = 0;
                int differentLines = 0;
                while ((firstReaderLine = reader.ReadLine()) != null &&
                        ((secondReaderLine = secondReader.ReadLine()) != null))
                {
                    if (firstReaderLine == secondReaderLine)
                    {
                        equalLines++;
                    }
                    else
                    {
                        differentLines++;
                    }
                }
                
                Console.WriteLine("Equal lines are: {0}\nDifferent lines are: {1}", equalLines, differentLines);
            }
        }
    }
}
