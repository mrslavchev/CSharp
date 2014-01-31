using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class Extensions
{
    public static T Sum<T>(this IEnumerable<T> collection) where T : IComparable
    {
        dynamic sum = 0;
        foreach (var item in collection)
        {
            sum += item;
        }

        return sum;
    }

    public static T Product<T>(this IEnumerable<T> collection) where T : IComparable
    {
        dynamic sum = 1;
        foreach (var item in collection)
        {
            sum *= item;
        }

        return sum;
    }

    public static T Avarage<T>(this IEnumerable<T> collection) where T : IComparable
    {
        dynamic sum = 0;
        foreach (var item in collection)
        {
            sum += item;
        }

        dynamic count = collection.Count();
        return sum / count;
    }

    public static T Min<T>(this IEnumerable<T> collection) where T : IComparable
    {
        dynamic min = long.MaxValue;
        foreach (var item in collection)
        {
            if (item < min)
            {
                min = item;   
            }
        }

        return min;
    }

    public static T Max<T>(this IEnumerable<T> collection) where T : IComparable
    {
        // Above logic reversed.
        dynamic max = long.MinValue;
        foreach (var item in collection)
        {
            if (item > max)
            {
                max = item;
            }
        }

        return max;
    }


}

