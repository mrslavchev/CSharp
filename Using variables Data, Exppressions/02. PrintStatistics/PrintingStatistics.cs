using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class PrintingStatistics
{
    public void PrintStatistics(double[] inputArray, int counter)
    {
        double maxMember = double.MinValue; 
        double tmp = 0; // no idea what's is this doing, and no idea how to name it o.O
        for (int i = 0; i < counter; i++)
        {
            if (inputArray[i] > maxMember)
            {
                maxMember = inputArray[i];
            }
        }
        PrintMaximumNumber(maxMember);
        tmp = 0;
        maxMember = 0;
        for (int i = 0; i < counter; i++)
        {
            if (inputArray[i] < maxMember)
            {
                maxMember = inputArray[i];
            }
        }
        PrintMinimumNumber(maxMember);

        tmp = 0;
        for (int i = 0; i < counter; i++)
        {
            tmp += inputArray[i];
        }
        PrintAvarageNumber(tmp / counter);
    }

    public void PrintMinimumNumber(double input)
    {
        //TO DO...
    }

    public void PrintMaximumNumber(double input)
    {
        //TO DO ..
    }

    public void PrintAvarageNumber(double input)
    {
        //TO DO ..
    }
}

