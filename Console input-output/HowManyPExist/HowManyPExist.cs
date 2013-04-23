using System;

class HowManyPExist
{
    static void Main()
    {
        Console.WriteLine("Please write down a number:");
        uint num = uint.Parse(Console.ReadLine());
        Console.WriteLine("Please write down another number:");
        uint num2 = uint.Parse(Console.ReadLine());
        uint p = 0;
        uint exch = num2;
        uint divider = 5;
        if (num>num2)
        {
            num2 = num;
            num = exch;
        }
        else if (num==num2)
        {
            Console.WriteLine("Wrong input!");
            return;
        }

        Console.WriteLine("The numbers bitween {0} and {1} are:", num, num2);

        while  (num <= num2) 
        {
            uint res = num % divider;
            if (res == 0)
            {
                
                p++;
                Console.Write("{0}, ",num);

            }
            num++;
        }
        Console.WriteLine("\nAnd their count is: "+p);

    }
}


