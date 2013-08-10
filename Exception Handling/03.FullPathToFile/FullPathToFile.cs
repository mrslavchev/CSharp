using System;
using System.IO;
using System.Security;

class FullPathToFile
{
    static void Main()
    {
        try
        {
            //You can use the .cs file for this task, by right click on it and take full path from properties
        Console.WriteLine("Plaese enter the full path to the file you would like to read.");
        string filePath =Console.ReadLine();
        string input = System.IO.File.ReadAllText(@filePath);
        Console.WriteLine(input);
        }
        catch (ArgumentException)
        {
            Console.Error.WriteLine("Wrong input");
        }
        catch (PathTooLongException)
        {
            Console.Error.WriteLine("Path or filename exceeds allowed length");
        }
        catch (DirectoryNotFoundException)
        {
            Console.Error.WriteLine("Incomplete path");
        }
        catch (UnauthorizedAccessException)
        {
            Console.Error.WriteLine("Access denied");
        }
        catch (FileNotFoundException)
        {
            Console.Error.WriteLine("No such file");
        }
        catch (NotSupportedException)
        {
            Console.Error.WriteLine("Path is in an invalid format");
        }
        catch (SecurityException)
        {
            Console.Error.WriteLine("You have no permission to view this file");
        }
        
    }
}