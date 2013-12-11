using System;

class AmericanPie
{
    static void Main(string[] args)
    {
        long nomA = int.Parse(Console.ReadLine());
        long denomA = int.Parse(Console.ReadLine());
        long nomB = int.Parse(Console.ReadLine());
        long denomB = int.Parse(Console.ReadLine());

        long sumNom = ((nomA * denomB) + (nomB * denomA)); 
        long sumDenom = denomA * denomB;
        long pies = sumNom / sumDenom;
        decimal frac = 0m;
        if (pies > 0)
        {
            Console.WriteLine(pies);
            Console.WriteLine("{0}/{1}", sumNom, sumDenom);
        }
        else
        {
            frac = sumNom / (decimal)sumDenom;
            Console.WriteLine("{0:0.00000000000000000000}", Math.Round(frac, 20));
            Console.WriteLine("{0}/{1}", sumNom, sumDenom);
        }
    }
}

