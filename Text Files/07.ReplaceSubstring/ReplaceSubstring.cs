using System;
using System.IO;

/*Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. 
 * Ensure it will work with large files (e.g. 100 MB).
*/

class ReplaceSubstring
{
    /// <summary>
    /// Using the replace method of the string class
    /// </summary>
    static void Main()
    {
        using (StreamReader reader = new StreamReader("../../input.txt"))
        {
            string line = reader.ReadToEnd();
            string output = line.Replace("start", "finish");
            using (StreamWriter writer = new StreamWriter("../../output.txt"))
            {
                writer.Write(output);
            }
        }
    }
}

