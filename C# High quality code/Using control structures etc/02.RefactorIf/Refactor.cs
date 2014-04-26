using System;

public class Refactor
{
    static void Main(string[] args)
    {
        // First example.
        Potato potato;
        if (potato != null)
        {
            if (!potato.IsRotten && potato.HasNotBeenPeeled)
            {
                Cook(potato);
            }
        }
        else
        {
            throw new NullReferenceException("Potato can not be null! Please initialize it!!!");
        }    

        // Second example.
        if (shouldVisitCell && (MIN_X <= x && x <= MAX_X) && (MIN_Y <= y && y <= MAX_Y))
        {
           VisitCell();
        }
    }
}
