using System;

class ApplyBonusPoints
{
    static void Main()
    {
        Console.WriteLine("PLease enter a digit from 1 to 9");
        string digit = Console.ReadLine();
        int num;
        if (int.TryParse(digit, out num))
        {
            switch (num)
            {
                case 1:
                case 2:
                case 3:
                    num *= 10;
                    Console.WriteLine("And you gain {0} bonus points", num); break;
                case 4:
                case 5:
                case 6:
                    num *= 100;
                    Console.WriteLine("And you gain {0} bonus points", num); break;
                case 7:
                case 8:
                case 9:
                    num *= 1000;
                    Console.WriteLine("And you gain {0} bonus points", num); break;
                default: Console.WriteLine("Error!!! Please enter a valid number from 1 to 9.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Error!!! Please enter a valid number from 1 to 9.");
        }
    }
}


