using System;
using System.IO;
using System.Collections.Generic;
/*Write a program that deletes from given text file all odd lines. The result should be in the same file.
*/
class DeleteAllOdd
{
    /// <summary>
    /// Reads contents from file storing it's lins in
    /// list of strings
    /// </summary>
    /// <returns>List of strings </returns>
    static List<string> ReadFile() 
    {
        using (StreamReader reader = new StreamReader("../../File.txt"))
        {
            string line;
            List<string> output = new List<string>();
            while ((line = reader.ReadLine()) != null)
            {
                output.Add(line);
            }

            return output;
        }
    }
    
    /// <summary>
    /// Writes all even lines of given list to files
    /// </summary>
    /// <param name="input">Takes list of strings as single parameter</param>
    static void WriteEvenLinesToFile(List<string> input ) 
    {
        using (StreamWriter writer = new StreamWriter("../../File.txt"))
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (i % 2 == 1)
                {
                    writer.WriteLine(input[i]);
                }
                else
                {
                    continue;
                }
            }
        }
    }

    static void Main() 
    {
        List<string> lines = ReadFile();
        WriteEvenLinesToFile(lines);
    }
}