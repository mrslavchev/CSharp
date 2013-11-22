using System;
using System.Text.RegularExpressions;
/*Write a program that replaces in a HTML document given as
 * string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]*/
class HTMLDoc
{
    /// <summary>
    /// We split the regex in groups first group is the url and second is 
    /// the content of the tag. While replacing we use $1 and $2 which is a back reference
    /// to the group matched by the regex, so we replace them with forst and second group.
    /// </summary>
    static void Main()
    {
        string html = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        string pattern = @"<a\shref=(.*?)(.*?)</a>";
        Console.WriteLine(Regex.Replace(html, pattern, "[URL=$1]$2[/URL]"));
    }
}