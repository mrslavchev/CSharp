using System;
using System.IO;
using System.Text;
/*Write a program that reads a text file and prints on the console its odd lines.
*/
class OddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../../Example.txt");
        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                lineNumber++;
                if (lineNumber % 2 != 0)
                {
                    Console.WriteLine("{0} {1}", lineNumber, line);
                }

                line = reader.ReadLine();
            }
        }
    }
}