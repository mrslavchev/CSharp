public class PrintingStatistics
{
    public void PrintStatistics(double[] inputArray, int rangeIndex)
    {
        double maxValue = double.MinValue;
        double minValue = double.MaxValue;
        double valuesSum = 0;
        for (int i = 0; i < rangeIndex; i++)
        {
            if (inputArray[i] > maxValue)
            {
                maxValue = inputArray[i];
            }
            else if (inputArray[i] < minValue)
            {
                minValue = inputArray[i];
            }

            valuesSum += inputArray[i];
        }

        this.PrintNumber(maxValue);
        this.PrintNumber(minValue);
        double avarageValue = valuesSum / rangeIndex;
        this.PrintNumber(avarageValue);
    }

    /* I strongly doubt it printing max, min or avarage differs in any manner, 
     that's why we only leave one method.*/
    public void PrintNumber(double input)
    {
        //TO DO...
    }
}