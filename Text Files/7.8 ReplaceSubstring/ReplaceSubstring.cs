using System;
using System.IO;
using System.Text.RegularExpressions;


namespace _7._8_ReplaceSubstring
{
    class ReplaceSubstring
    {
        static void Main(string[] args)
        {
            using (StreamReader input = new StreamReader("../../inputFile.txt"))
            using (StreamWriter output = new StreamWriter("../../outputFile.txt"))
                for (string line; (line = input.ReadLine()) != null; )
                    //  output.WriteLine(line.Replace("start", "finish"));             // Exercise 7
                    output.WriteLine(Regex.Replace(line, @"\bstart\b", "finish")); // Exercise 8 
        }
    }
}
