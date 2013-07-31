using System;
using System.Collections.Generic;
using System.Linq;


public static class IDictionaryExtensions
{
    /// <summary>
    /// Extesion methhod for searching by value in dictionary
    /// </summary>
    /// <typeparam name="TKey">Key in key-value pair</typeparam>
    /// <typeparam name="TValue">Value in key-value pair</typeparam>
    /// <param name="dictionary">Applied to a dictionary collection</param>
    /// <param name="value">Takes values as single parameter</param>
    /// <returns>Key</returns>
    public static TKey FindKeyByValue<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TValue value)
    {
        if (dictionary == null)
            throw new ArgumentNullException("dictionary");

        foreach (KeyValuePair<TKey, TValue> pair in dictionary)
            if (value.Equals(pair.Value)) return pair.Key;

        throw new Exception("the value is not found in the dictionary");
    }
}

