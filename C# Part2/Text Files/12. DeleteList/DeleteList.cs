using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;
using System.Collections.Generic;
/*Write a program that removes from a text file all words listed in given another text file. 
 * Handle all possible exceptions in your methods.
*/
class DeleteList
{
    /// <summary>
    /// Reads file as a list of strings
    /// </summary>
    /// <returns>List of the words to be removed</returns>
    static List<string> ReadFileAsList() 
    {
        List<string> words = new List<string>();
        string line;
        using (StreamReader reader = new StreamReader("../../ListToRemove.txt"))
        {
            while ((line = reader.ReadLine()) != null)
            {
                words.Add(line);
            }

            return words;
        }
    }

    /// <summary>
    /// Reads a file as a string
    /// </summary>
    /// <returns>String with file content</returns>
    static string ReadFileAsSrting() 
    {
        using (StreamReader reader = new StreamReader("../../File.txt"))
        {
            string file = reader.ReadToEnd();
            return file;
        }
    }

    /// <summary>
    /// Repmoves given list of strings from a string
    /// </summary>
    /// <param name="words">Takes list of strings as first parameter</param>
    /// <param name="text">Takes string as second parameter</param>
    /// <returns>String</returns>
    static string RemoveList(List<string> words, string text) 
    {
        foreach (var word in words)
        {
            text = Regex.Replace(text, word, String.Empty);
        }

        return text;
    }

    /// <summary>
    /// Writes result back to file
    /// </summary>
    /// <param name="input">Takes string as single parameter</param>
    static void WriteToFile(string input ) 
    {
        using (StreamWriter writer = new StreamWriter("../../File.txt"))
        {
            writer.Write(input);
        }
    }

    static void Main()
    {
        try
        {
            List<string> forbiiddenWords = ReadFileAsList();
            string file = ReadFileAsSrting();
            string output = RemoveList(forbiiddenWords, file);
            WriteToFile(output);
        }
        catch (System.IO.FileNotFoundException)
        {
            Console.Error.WriteLine("Cannot Find filepath");
        }
        catch (System.OutOfMemoryException)
        {
            Console.Error.WriteLine("Out of memory");
        }
        catch (System.FormatException)
        {
            Console.Error.WriteLine("Incorrect string format");
        }
        catch (DirectoryNotFoundException)
        {
            Console.Error.WriteLine("Directory not found");
        }
        catch (UnauthorizedAccessException)
        {
            Console.Error.WriteLine("No aceess to read/write to that file");
        }
        catch (ArgumentException)
        {
            Console.Error.WriteLine("Empty path");
        }
    }
}