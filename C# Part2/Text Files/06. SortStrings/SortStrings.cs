﻿﻿using System;
using System.IO;
using System.Collections.Generic;
/*Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file*/
class SortStrings
{
    /// <summary>
    /// Reads list of strings from a file
    /// </summary>
    /// <returns>List of string</returns>
    static List<string> ReadList() 
    {
        using (StreamReader reader = new StreamReader("../../input.txt"))
        {
            List<string> extract = new List<string>();
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                extract.Add(line);
            }

            return extract;
        }
    }

    /// <summary>
    /// Writes elements from a list to a text file
    /// </summary>
    /// <param name="output">Takes list as first parameter</param>
    static void WriteList(List<string> output) 
    {
        using (StreamWriter writer = new StreamWriter("../../output.txt"))
        {
            foreach (var item in output)
        {
            writer.WriteLine(item);
        }
        }
    }

    /// <summary>
    /// We use the sort method of generics, nothing fancy
    /// </summary>
    static void Main()
    {
        List<string> input = ReadList();
        input.Sort();
        WriteList(input);
    }
}