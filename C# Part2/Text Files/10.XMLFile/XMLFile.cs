using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
/// <summary>
/// We are using regular expressions
/// to extract the text. And store it in a collection. 
/// We print the collection to the console. 
/// </summary>
class XMLFile
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("../../xmlTest.xml")) 
        {
            string input = reader.ReadToEnd();
            MatchCollection extracted = Regex.Matches(input, @"(?<=^|>)[^><]+?(?=<|$)");
            foreach (var item in extracted)
            {
                Console.WriteLine(item.ToString());   
            }
        }
    }
}