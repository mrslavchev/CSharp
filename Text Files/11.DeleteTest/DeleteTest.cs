using System;
using System.IO;
using System.Text.RegularExpressions;
/*Write a program that deletes from a text file all words that start with the prefix "test". 
 * Words contain only the symbols 0...9, a...z, A…Z, _.
*/
class DeleteTest
{
    /// <summary>
    /// We cant read and write at the same time, 
    /// so we store the content in one file, replace 
    /// the words prefixed with test with nothing and 
    /// write back to the same file
    /// </summary>
    static void Main()
    {
        string file;
        using (StreamReader reader = new StreamReader("../../File.txt"))
        {
            file = reader.ReadToEnd();
        }

        string output = Regex.Replace(file, @"test\B\w+", String.Empty);
        using (StreamWriter writer = new StreamWriter("../../File.txt"))
        {
            writer.Write(output);
        }
    }
}