using System;
using System.Threading;
using System.Globalization;

class IntDoubleOrString
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture =
        CultureInfo.InstalledUICulture;

        Console.WriteLine("Please enter one of the following: \n 1 for number\n 2 for floating-point number\n 3 for a word ");
        byte input = byte.Parse(Console.ReadLine());
        switch (input)
        {
            case 1: Console.WriteLine("Please enter a number: ");
                int num = int.Parse(Console.ReadLine());
                num += 1;
                Console.WriteLine("The new value is {0}",num);
                break;
            case 2: Console.WriteLine("Please enter a floating-point number: ");
                double fPoint = double.Parse(Console.ReadLine());
                fPoint += 1;
                Console.WriteLine("The new value is {0}", fPoint);
                break;
            case 3: Console.WriteLine("Please enter a word: ");
                string word = Console.ReadLine();
                word=word +"*";
                Console.WriteLine("The new value is {0}", word);
                break;
            default: Console.WriteLine("Wrong input !");
                break;
        }
    }
}

