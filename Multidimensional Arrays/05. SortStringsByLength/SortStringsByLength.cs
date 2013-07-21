using System;
using System.Linq;
/// <summary>
/// We are reordering the array by using lambda expression
/// </summary>
class SortStringsByLength
{
    static void Main()
    {
        string[] demo = { "a", "aaaa", "aaaaaaaaaaaaaaaaa", "a", "aaaaaa", "sdfsdffsf" };
        SortByLength(demo);
    }

    private static void SortByLength(string[] array)
    {
        string[] unsortedStrings = array;
        foreach (var item in unsortedStrings.OrderBy(uStrings => uStrings.Length))
        {
            Console.WriteLine(item);
        }
    }
}