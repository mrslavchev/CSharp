﻿using System;

public class Loop
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 100; i++)
        {
            if (i % 10 == 0)
            {
                if (array[i] == expectedValue)
                {
                    Console.WriteLine("Value Found");
                    break;
                }
            }

            Console.WriteLine(array[i]);
        }
    }
}

