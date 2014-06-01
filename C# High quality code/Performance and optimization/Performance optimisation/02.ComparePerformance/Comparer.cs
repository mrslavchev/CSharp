using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

class Comparer
{
    static void Main()
    {
        /*To test incrementation we put the value throug a 1 000 000 interations loop. The loops are 
         repeated code, on purpose. There's no generic way to do it otherways.*/
        int testInt = 10;
        double testDouble = 10;
        float testFloat = 10f;
        decimal testDecimal = 10m;
        long testLong = 10l;

        #region Increment
        Console.WriteLine(new string('-', 20));
        Console.WriteLine("Test incrementation:");
        Console.WriteLine("Int:");
        Stopwatch timer = new Stopwatch();
        timer.Start();
        for (int i = 0; i < 1000000; i++)
        {
            testInt++;
        }
        timer.Stop();
        Console.WriteLine(timer.Elapsed);

        Console.WriteLine("Long:");
        timer.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            testLong++;
        }
        timer.Stop();
        Console.WriteLine(timer.Elapsed);

        Console.WriteLine("Float:");
        timer.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            testFloat++;
        }
        timer.Stop();
        Console.WriteLine(timer.Elapsed);

        Console.WriteLine("Double:");
        timer.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            testFloat++;
        }
        timer.Stop();
        Console.WriteLine(timer.Elapsed);

        Console.WriteLine("Decimal:");
        timer.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            testDecimal++;
        }
        timer.Stop();
        Console.WriteLine(timer.Elapsed);
        Console.WriteLine(new string('-', 20));
        #endregion

        // Reset values to prevent overflow.
        testInt = 10;
        testLong = 10L;
        testFloat = 10f;
        testDouble = 10;
        testDecimal = 10m;
        #region Addition
        Console.WriteLine("Test addition:");
        Console.WriteLine("Int");
        int resultInt = 0;
        timer.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            resultInt += testInt;
        }

        timer.Stop();
        Console.WriteLine(timer.Elapsed);

        Console.WriteLine("Long");
        long resultLong = 0L;
        timer.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            resultLong += testLong;
        }

        timer.Stop();
        Console.WriteLine(timer.Elapsed);

        Console.WriteLine("Float");
        float resultFloat = 0f;
        timer.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            resultFloat += testFloat;
        }

        timer.Stop();
        Console.WriteLine(timer.Elapsed);

        Console.WriteLine("Double");
        double resultDouble = 0d;
        timer.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            resultDouble += testDouble;
        }

        timer.Stop();
        Console.WriteLine(timer.Elapsed);

        Console.WriteLine("Decimal");
        decimal resultDecimal = 0m;
        timer.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            resultDecimal += testDecimal;
        }

        timer.Stop();
        Console.WriteLine(timer.Elapsed);
        #endregion

        #region Substraction
        Console.WriteLine(new string('-', 20));
        Console.WriteLine("Test substraction:");
        Console.WriteLine("Int");
        timer.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            resultInt -= testInt;
        }

        timer.Stop();
        Console.WriteLine(timer.Elapsed);

        Console.WriteLine("Long");
        timer.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            resultLong -= testLong;
        }

        timer.Stop();
        Console.WriteLine(timer.Elapsed);

        Console.WriteLine("Float");
        timer.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            resultFloat -= testFloat;
        }

        timer.Stop();
        Console.WriteLine(timer.Elapsed);

        Console.WriteLine("Double");
        timer.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            resultDouble -= testDouble;
        }

        timer.Stop();
        Console.WriteLine(timer.Elapsed);

        Console.WriteLine("Decimal");
        timer.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            resultDecimal -= testDecimal;
        }

        timer.Stop();
        Console.WriteLine(timer.Elapsed);
        #endregion

        #region Multiplication
        Console.WriteLine(new string('-', 20));
        Console.WriteLine("Test multiplication:");
        Console.WriteLine("Int");
        timer.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            resultInt *= testInt;
        }

        timer.Stop();
        Console.WriteLine(timer.Elapsed);

        Console.WriteLine("Long");
        timer.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            resultLong *= testLong;
        }

        timer.Stop();
        Console.WriteLine(timer.Elapsed);

        Console.WriteLine("Float");
        timer.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            resultFloat *= testFloat;
        }

        timer.Stop();
        Console.WriteLine(timer.Elapsed);

        Console.WriteLine("Double");
        timer.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            resultDouble *= testDouble;
        }

        timer.Stop();
        Console.WriteLine(timer.Elapsed);

        Console.WriteLine("Decimal");
        timer.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            resultDecimal *= testDecimal;
        }

        timer.Stop();
        Console.WriteLine(timer.Elapsed);
        #endregion

        #region Division
        Console.WriteLine(new string('-', 20));
        Console.WriteLine("Test division:");
        Console.WriteLine("Int");
        timer.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            resultInt /= testInt;
        }

        timer.Stop();
        Console.WriteLine(timer.Elapsed);

        Console.WriteLine("Long");
        timer.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            resultLong /= testLong;
        }

        timer.Stop();
        Console.WriteLine(timer.Elapsed);

        Console.WriteLine("Float");
        timer.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            resultFloat /= testFloat;
        }

        timer.Stop();
        Console.WriteLine(timer.Elapsed);

        Console.WriteLine("Double");
        timer.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            resultDouble /= testDouble;
        }

        timer.Stop();
        Console.WriteLine(timer.Elapsed);

        Console.WriteLine("Decimal");
        timer.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            resultDecimal /= testDecimal;
        }

        timer.Stop();
        Console.WriteLine(timer.Elapsed);
        #endregion
    }
}

