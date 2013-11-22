using System;

    class Program
    {
        static void Main()
        {
            char sign = 'C';
            bool printed = true;
            for (int i = 0; i < 5; i++)
            {
                while (printed)
                {
                    Console.WriteLine(i * sign);
                    i += 2;
                }
            }
        }
    }

