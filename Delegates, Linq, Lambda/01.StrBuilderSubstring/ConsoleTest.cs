/*Implement an extension method Substring(int index, int length) for the 
class StringBuilder that returns new StringBuilder 
and has the same functionality as Substring in the class String.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        StringBuilder check = new StringBuilder();
        check.AppendLine("Lorem Ipsum dolor molor drun dryn drun brym");
        Console.WriteLine(check.Substring(7, 4).ToString());
        Console.WriteLine(check.Substring(8,15).ToString());
    }
}

