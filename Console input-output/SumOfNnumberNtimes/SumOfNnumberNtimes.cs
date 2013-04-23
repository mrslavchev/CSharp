using System;

class ComplexNumberSum
{
    static void Main()
    {

        Console.Write("Enterthe count of the numbers you want to sum: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n;)
        {
            Console.Write("Enter number {0}: ",i);
            sum += double.Parse(Console.ReadLine());
            i++;
        }
        Console.WriteLine("The sum is: {0}", sum);

    }
}