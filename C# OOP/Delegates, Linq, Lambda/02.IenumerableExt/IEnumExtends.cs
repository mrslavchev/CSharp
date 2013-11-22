using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class IEnumExtends
{
    public static T Sum<T>(this IEnumerable<T> input) where T : IComparable
    {
        dynamic sum = 0;
        foreach (var item in input)
        {
            sum += item;
        }

        return sum;
    }

    public static T Product<T>(this IEnumerable<T> input) where T : IComparable
    {
        dynamic product = 1;

        foreach (var item in input)
        {
            product *= item;
        }

        return product;
    }

    public static T Min<T>(this IEnumerable<T> input) where T : IComparable
    {
        dynamic min = int.MaxValue; //typical for comparissons we use min value to compare to

        foreach (var item in input)
        {
            if (item < min)
            {
                min = item;
            }
        }

        return min;
    }

    public static T Max<T>(this IEnumerable<T> input) where T : IComparable
    {
        dynamic max = int.MinValue; 
        // we use the same logic as the above but reversed 
        foreach (var item in input)
        {
            if (item > max)
            {
                max = item;
            }
        }

        return max;
    }

    public static decimal Avarage<T>(this IEnumerable<T> input) where T : IComparable
    {
        dynamic sum = 0;
        decimal counter = 0;

        foreach (var item in input)
        {
            sum += item;
            counter++;
        }

        return sum / counter;
    }
}

