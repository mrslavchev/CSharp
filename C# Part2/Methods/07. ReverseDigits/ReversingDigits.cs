using System;
using System.Text;
/*Write a method that reverses the digits of given decimal number. Example: 256  652
*/

class ReversingDigits
{
    /// <summary>
    /// Converts to string, uses strinbuilder to build the new string, than converts to decimal
    /// </summary>
    /// <param name="number">Takes decimal number as forst parameter</param>
    /// <returns>Decimal number</returns>
    static decimal Reverse(decimal number)
    {
        string input = number.ToString();
        StringBuilder strOutput = new StringBuilder();
        for (int i = input.Length-1; i >= 0; i--)
        {
            strOutput.Append(input[i]);
        }

        string output = strOutput.ToString();
        return Convert.ToDecimal(output);
    }
    
    static void Main()
    {
        decimal testDec = 1.3456m;
        Console.WriteLine(Reverse(testDec));
    }
}