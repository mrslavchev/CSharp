using System;
using System.IO;
using System.Text.RegularExpressions;

class DeleteTest
{
    static void Main()
    {
        using (StreamReader input = new StreamReader("../../inputFile.txt"))
        using (StreamWriter output = new StreamWriter("../../outputFile.txt"))
            for (string line; (line = input.ReadLine()) != null; )
                output.WriteLine(Regex.Replace(line, @"\btest\w*\b", String.Empty));
    }
}