using System;
using System.Text.RegularExpressions;

class ParseURL
{
    static void Main()
    {
        string uri = "http://www.devbg.org/forum/index.php";

        var fragments = Regex.Match(uri, "(.*)://(.*?)(/.*)").Groups;

        Console.WriteLine(fragments[1]);
        Console.WriteLine(fragments[2]);
        Console.WriteLine(fragments[3]);
    }
}
