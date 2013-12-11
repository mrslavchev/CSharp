using System;



class ApplesAndOranges
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        long num = 0;
        long sumEven = 0;
        long sumOdd = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if ((input[i] == '-') || (input[i] == '.'))
            {
                continue;
            }
            else
            {
                num = long.Parse(input[i].ToString());
                if ((num & 1) == 1)
                {
                    sumOdd += num;
                }
                else
                {
                    sumEven += num;
                }
            }
        }

        if (sumEven > sumOdd)
        {
            Console.WriteLine("apples {0}", sumEven);
        }
        else if (sumEven == sumOdd)
        {
            Console.WriteLine("both {0}", sumEven);
        }
        else
        {
            Console.WriteLine("oranges {0}", sumOdd);
        }
    }
}

