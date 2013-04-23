using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;

class DeleteList
{
    static void Main()
    {
        try
        {
            string regex = @"\b(" + String.Join("|", File.ReadAllLines("../../IpsumLorem.txt")) + @")\b";

            using (StreamReader input = new StreamReader("../../LoremIpsum.txt"))
            using (StreamWriter output = new StreamWriter("../../outputFile.txt"))
                for (string line; (line = input.ReadLine()) != null; )
                    output.WriteLine(Regex.Replace(line, regex, String.Empty));
        }

        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (SecurityException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}