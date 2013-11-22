using System;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter count of numbers");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your choise:");
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (numbers > max)
                {
                    max = numbers;
                }
                if (numbers < min)
                {
                    min = numbers;
                }
            }
            Console.WriteLine("The smallest number is:{0} ", min);
            Console.WriteLine("The biggest number is:{0} ", max);
        }
    }
}
