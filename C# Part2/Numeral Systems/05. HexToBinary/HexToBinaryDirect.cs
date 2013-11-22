using System;
using System.Linq;
/*Write a program to convert hexadecimal numbers to binary numbers (directly).
*/

namespace _05.HexToBinary
{
    class HexToBinaryDirect
    {
        static string HexToBinary(string hexValue)
        {
            string binaryValue = "";
            binaryValue = Convert.ToString(Convert.ToInt32(hexValue, 16), 2);
            return binaryValue;
        }

        static void Main()
        {
            Console.WriteLine(HexToBinary("A5E"));
        }
    }
}
