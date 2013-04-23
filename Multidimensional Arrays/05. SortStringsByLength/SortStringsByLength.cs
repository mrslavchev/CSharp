using System;
using System.Linq;

class SortStringsByLength
{
    static void Main()
    {
        string[] unsortedStrings = { "g", "dijfhdifg", "dfmisfiwiwfiyfiyf", "a", "fdjfnshbfhsbhfb", "fnfsbkfhbsdhfbsjfbfvgfvsgv" };
        foreach (var item in unsortedStrings.OrderBy(uStrings => uStrings.Length))
        {
            Console.WriteLine(item);
        }
    }
}