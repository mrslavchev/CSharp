using System;

class Poker
{
    static void Main(string[] args)
    {
        string[] cards = new string[5];
        cards[0] = Console.ReadLine();
        cards[1] = Console.ReadLine();
        cards[2] = Console.ReadLine();
        cards[3] = Console.ReadLine();
        cards[4] = Console.ReadLine();
        Array.Sort(cards);
        foreach (var item in cards)
        {
            Console.WriteLine(item);
        }
    }
}

