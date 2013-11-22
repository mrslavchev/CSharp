using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
/*Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags*/
class ExtractText
{
    /// <summary>
    /// We use streamreader to read from the file, we extract the content with regex and addd it to stringbuilder, trimming 
    /// the empty space indents.
    /// </summary>
    static void Main()
    {
        StringBuilder extract = new StringBuilder();
        using (StreamReader reader = new StreamReader("../../LinkedIn.html"))
        {
            MatchCollection matches = Regex.Matches(reader.ReadToEnd(), "(?<=^|>)[^><]+?(?=<|$)");
            foreach (var item in matches)
            {
                extract.Append(item.ToString().TrimStart() +"\n");
            }

            Console.WriteLine(extract);
        }
    }
}