using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
/*Modify the solution of the previous problem to replace only whole words (not substrings).
*/

/// <summary>
/// using regular expressions
/// </summary>
class ReplaceWord
{
    static void Main()
    {
        
        using (StreamReader reader = new StreamReader("../../input.txt"))
        {
            string line = reader.ReadToEnd();
            string output = Regex.Replace(line, @"\bstart\b", "finish");
            using (StreamWriter writer = new StreamWriter("../../output.txt"))
            {
                writer.WriteLine(output);
            }
        }
    }
}

