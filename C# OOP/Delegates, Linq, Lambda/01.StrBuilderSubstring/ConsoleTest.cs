/*Implement an extension method Substring(int index, int length) for the 
class StringBuilder that returns new StringBuilder 
and has the same functionality as Substring in the class String.*/

using System;
using System.Text;

class ConsoleTest
{
    static void Main()
    {
        StringBuilder test = new StringBuilder();
        test.AppendLine("neprotivokonstitucionstvuvatelstvuvajte");
        Console.WriteLine(test.Substring(20, 20).ToString());
    }
}

