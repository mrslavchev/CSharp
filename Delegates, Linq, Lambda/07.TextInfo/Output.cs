using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
//Using delegates write a class Timer that has can execute certain method at each t seconds

public class Timer
{
    static void Main()
    {
        Console.WriteLine("Pleasr enter the interval in seconds: ");
        int interval = Int32.Parse(Console.ReadLine());
        Stopwatch sw = new Stopwatch();
        sw.Start();
        Func<int, bool> sleep = (x) =>
        {
            if (x * 1000 == sw.ElapsedMilliseconds)
                return true;
            else
                return false;
        };
        while (true)
        {
            if (sleep(interval) == true)
            {
                Console.WriteLine("The method is executed!!");
                sw.Restart();
            }
        }
    }
}

