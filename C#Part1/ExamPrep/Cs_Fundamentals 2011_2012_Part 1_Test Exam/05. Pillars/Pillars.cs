using System;

class Pillars
{
    static void Main(string[] args)
    {
        int n0 = int.Parse(Console.ReadLine());
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int n4 = int.Parse(Console.ReadLine());
        int n5 = int.Parse(Console.ReadLine());
        int n6 = int.Parse(Console.ReadLine());
        int n7 = int.Parse(Console.ReadLine());

        int bestCount = int.MinValue;
        int bestIndex = int.MinValue;
        for (int index = 0; index <= 7 ; index++)
        {
            int leftCount = 0;
            for (int leftIndex = index + 1; leftIndex <= 7; leftIndex++)
            {
                leftCount += (n0 >> leftIndex) & 1;
                leftCount += (n1 >> leftIndex) & 1;
                leftCount += (n2 >> leftIndex) & 1;
                leftCount += (n3 >> leftIndex) & 1;
                leftCount += (n4 >> leftIndex) & 1;
                leftCount += (n5 >> leftIndex) & 1;
                leftCount += (n6 >> leftIndex) & 1;
                leftCount += (n7 >> leftIndex) & 1;
            }

            int rightCount = 0;
            for (int rightIndex = 0; rightIndex <= index - 1; rightIndex++)
            {
                rightCount += (n0 >> rightIndex) & 1;
                rightCount += (n1 >> rightIndex) & 1;
                rightCount += (n2 >> rightIndex) & 1;
                rightCount += (n3 >> rightIndex) & 1;
                rightCount += (n4 >> rightIndex) & 1;
                rightCount += (n5 >> rightIndex) & 1;
                rightCount += (n6 >> rightIndex) & 1;
                rightCount += (n7 >> rightIndex) & 1;
            }

            if (leftCount == rightCount)
            {
                bestCount = leftCount;
                bestIndex = index;
            }
        }

        if (bestCount != int.MinValue)
        {
            Console.WriteLine(bestIndex);
            Console.WriteLine(bestCount);
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

