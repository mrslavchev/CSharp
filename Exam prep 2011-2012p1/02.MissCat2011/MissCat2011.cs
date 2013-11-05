using System;



class MissCat2011
{

    static void Main(string[] args)
    {
        int[] scores = new int[10];
        int[] contestants = new int[10];
        for (int i = 0; i < contestants.Length; i++)
        {
            contestants[i] = i + 1;
            scores[i] = 0;
        }

        int juryCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < juryCount; i++)
        {
            int position = int.Parse(Console.ReadLine());
            scores[position - 1]++;
        }

        Array.Sort(scores, contestants);
        if (scores[scores.Length - 1] == scores[scores.Length - 2])
        {
            if (contestants[contestants.Length - 1] < contestants[contestants.Length - 2])
            {
                Console.WriteLine(contestants[contestants.Length - 1]);
            }
            else
            {
                Console.WriteLine(contestants[contestants.Length - 2]);
            }
        }
        else
        {
            Console.WriteLine(contestants[contestants.Length - 1]);
        }

    }
}

