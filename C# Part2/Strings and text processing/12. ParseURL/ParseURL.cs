using System;
using System.Text.RegularExpressions;
/*Write a program that parses an URL address given in the format:
and extracts from it the [protocol], [server] and [resource] elements. 
 * For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted*/
class ParseURL
{
    /// <summary>
    /// We are using a group collection for the mathes and we write it to the console. 
    /// Basically first brackets represent the protocol, second the server etc.
    /// </summary>
    static void Main()
    {
        string url = "http://www.devbg.org/forum/index.php";
        GroupCollection blocks = Regex.Match(url, "(.*)://(.*?)(/.*)").Groups;
        Console.WriteLine("[protocol]= " + blocks[1]);
        Console.WriteLine("[server]= " + blocks[2]);
        Console.WriteLine("[resource]= " + blocks[3]);
    }
}
