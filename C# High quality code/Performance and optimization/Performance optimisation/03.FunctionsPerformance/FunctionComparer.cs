using System;
using System.Linq;
using System.Diagnostics;

class FunctionComparer
{
    static void Main(string[] args)
    {
        float testFloat = 20.5f;
        double testDouble = 20.5;
        decimal testDecimal = 20.5m;

        #region Power
        Console.WriteLine(new string('-', 20));
        Console.WriteLine("Testing sqare root.");
        Stopwatch timer = new Stopwatch();
        timer.Start();
        testFloat *= testFloat;
        timer.Stop();
        Console.WriteLine("Float {0}", timer.Elapsed);

        timer.Restart();
        testDouble *= testDouble;
        timer.Stop();
        Console.WriteLine("Double {0}", timer.Elapsed);

        timer.Restart();
        testDecimal *= testDecimal;
        timer.Stop();
        Console.WriteLine("Decimal {0}", timer.Elapsed);
        #endregion

        #region Logarithm
        Console.WriteLine(new string('-', 20));
        Console.WriteLine("Testing logarithm.");
        timer.Restart();
        timer.Start();
        Math.Log(testFloat, 2);
        timer.Stop();
        Console.WriteLine("Float {0}", timer.Elapsed);

        timer.Restart();
        Math.Log(testDouble, 2);
        timer.Stop();
        Console.WriteLine("Double {0}", timer.Elapsed);

        timer.Restart();
        Math.Log((double)testDecimal, 2); // I know type casting fucks up things here, but honestly, my math sux. Srry. 
        timer.Stop();
        Console.WriteLine("Decimal {0}", timer.Elapsed);
        #endregion

        #region Sinus
        Console.WriteLine(new string('-', 20));
        Console.WriteLine("Testing logarithm.");
        timer.Restart();
        timer.Start();
        Math.Sin(testFloat);
        timer.Stop();
        Console.WriteLine("Float {0}", timer.Elapsed);

        timer.Restart();
        Math.Sin(testDouble);
        timer.Stop();
        Console.WriteLine("Double {0}", timer.Elapsed);

        timer.Restart();
        Math.Sin((double)testDecimal); // I know type casting fucks up things here, but honestly, my math sux. Srry. 
        timer.Stop();
        Console.WriteLine("Decimal {0}", timer.Elapsed);
        #endregion
    }
}

