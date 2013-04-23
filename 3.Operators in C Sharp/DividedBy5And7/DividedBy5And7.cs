using System;

    class DividedBy5And7
{
    static void Main()
    {
        int num = 35;
        bool res1 = (num % 5)==0;
        bool res2 = (num % 7)==0;
        bool result = (res1 & res2);
        Console.WriteLine(" Is the number {0} divisible by 5 and 7 at the same time witouth a reminder? {1} ",num,result);
    }
}

