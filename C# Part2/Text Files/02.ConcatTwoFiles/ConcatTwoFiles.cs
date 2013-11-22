﻿using System;
using System.IO;
using System.Text;

class ConcatTwoFiles
{
    /// <summary>
    /// Method which reads all content from a file
    /// </summary>
    /// <param name="filePath">Takes relative path to the file as single parameter</param>
    /// <returns>File content as a string</returns>
    static string StreamRead(string filePath) 
    {
        StreamReader reader = new StreamReader(filePath);
        using (reader)
        {
            string output = reader.ReadToEnd();
            return output;
        }
    }

    /// <summary>
    /// We have both file paths stored in an array of strings.
    /// Using writer we use the read method for each of the files, 
    /// and write it to Output.txt
    /// </summary>
    static void Main()
    {
        string[] filePaths = { "../../../Example.txt" , "../../../Example2.txt"};
        StreamWriter writer = new StreamWriter("../../../Output.txt");
        using (writer)
        {
            foreach (var path in filePaths)
            {
                writer.WriteLine(StreamRead(path));
            }
        }
    }
}