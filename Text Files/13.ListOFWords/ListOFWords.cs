using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;
/*Write a program that reads a list of words from a file words.txt and finds how many times each 
 * of the words is contained in another file test.txt. The result should be written in the file result.txt 
 * and the words should be sorted by the number of their occurrences in descending order. 
 * Handle all possible exceptions in your methods.
*/

class ListOFWords
{
    /// <summary>
    /// Reads the words from textfile and converting them to collection of strings.
    /// </summary>
    /// <returns>Array of strings</returns>
    static string[] ReadList() 
    {
        using (StreamReader reader = new StreamReader("../../../words.txt"))
        {
            string line;
            List<string> words = new List<string>();
            while ((line = reader.ReadLine()) != null)
            {
                words.Add(line);
            }

            return words.ToArray();
        }
    }

    /// <summary>
    /// Reads a text file
    /// </summary>
    /// <returns>Text as string</returns>
    static string ReadFile() 
    {
        using (StreamReader reader = new StreamReader("../../test.txt"))
        {
            string file = reader.ReadToEnd();
            return file;
        }
    }

    /// <summary>
    /// Counts the word occurances, and sorts them in an array.
    /// We sort the array, and the words using the Array.Sort()
    /// in a relation key-value(count, word).
    /// </summary>
    /// <param name="collection">List of words to ocunt</param>
    /// <param name="text">Text to scan for matches</param>
    /// <returns>Sorted key + value</returns>
    static string CountWords(string[] collection, string text) 
    {
        int[] occurances = new int[collection.Length];
        for (int i = 0; i < collection.Length; i++)
        {
            string pattern = collection[i];
            MatchCollection matches = Regex.Matches(text, pattern);
            occurances[i] = matches.Count;
        }

        Array.Sort(occurances, collection);
        StringBuilder output = new StringBuilder();

        for (int i = occurances.Length-1; i >= 0; i--)
        {
            output.AppendLine(occurances[i] + " " + collection[i]);
        }

        return output.ToString();
    }
    
    /// <summary>
    /// Writes the result to text file
    /// </summary>
    /// <param name="input">String to be written</param>
    static void WriteResult(string input) 
    {
        using (StreamWriter writer = new StreamWriter("../../result.txt"))
        {
            writer.Write(input);
        }
    }

    static void Main()
    {
        try
        {
            string[] words = ReadList();
            string inputText = ReadFile();
            string result = CountWords(words, inputText);
            WriteResult(result);
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