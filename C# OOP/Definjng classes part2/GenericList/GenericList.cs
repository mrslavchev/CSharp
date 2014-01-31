using System;
using System.Collections.Generic;
using System.Linq;

public class GenericList<T> 
{
    // Default capacity of the internal array.
    private const int DefaultCapacity = 5;

    private T[] elements;

    private int count = 0;

    // Fields.
    public int Count
    {
        get { return count; }
    }

    // Indexer.
    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException(string.Format(
                    "Index {0}, is out of range for collection count {1}", index, this.Count));
            }
            else
            {
                T result = elements[index];
                return result;
            }
        }
        set
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException(string.Format(
                    "Index {0}, is out of range for collection count {1}", index, this.Count));
            }
            else
            {
                this.elements[index] = value;
            }
        }
    }

    // Constructors.
    public GenericList(int capacity)
    {
        this.elements = new T[capacity];
    }

    public GenericList()
        : this(DefaultCapacity)
    {
    }

    // Basic methods implementation.
    /// <summary>
    /// Adds value of type T to a list.
    /// </summary>
    /// <param name="value"> Get value of type T as single parameter</param>
    public void Add(T value)
    {
        if ((count) >= this.elements.Length)
        {
            AutoGrow();         
        }
        elements[count] = value;
        count++;
        
    }

    /// <summary>
    /// Inserts value of type T to a specific index
    /// </summary>
    /// <param name="index">Takes int index as first paramter.</param>
    /// <param name="value">Takes value of type T as second paramenter.</param>
    public void InsertAt(int index, T value)
    {
        T[] array = new T[this.elements.Length + 1];
        Array.Copy(this.elements, 0, array, 0, index);
        array[index] = value;
        Array.Copy(this.elements, index, array, index + 1, this.elements.Length - index - 1);
        this.elements = array;
        count++;
    }

    /// <summary>
    /// Removes value of type T from a specific index
    /// </summary>
    /// <param name="index">Takes int index as first paramter.</param>
    public void RemoveAt(int index)
    {
        T[] array = new T[this.elements.Length - 1];
        Array.Copy(this.elements, 0, array, 0, index);
        Array.Copy(this.elements, index + 1, array, index, elements.Length - 1 - index);
        this.elements = array;
        count--;
    }

    /// <summary>
    /// Returns the index of a specified element of type T.
    /// </summary>
    /// <param name="value">Takes a value of an element of type T.</param>
    /// <returns>Int index of the element contained, or -1 if the element is not present in the sequence.</returns>
    public int IndexOf(T value)
    {
        int index = Array.BinarySearch(this.elements, value);
        return index;
    }

    /// <summary>
    /// Clears the current instance of the class.
    /// </summary>
    public void Clear()
    {
        this.elements = new T[DefaultCapacity];
        this.count = 0;
    }

    /// <summary>
    /// Resizes the array when count reaches it's length.
    /// </summary>
    private void AutoGrow()
    {
        Array.Resize(ref elements, count * 2);
    }

    /// <summary>
    /// Returns the  smallest element in a collection.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="collection">Takes a generic collection as single parameter.</param>
    /// <returns>Smallest element of type T.</returns>
    public static T Min<T>(GenericList<T> collection)
       where T : IComparable<T>, new()
    {
        if (collection.Count == 1)
        {
            return collection[0];
        }
        else if (collection.Count == 0)
        {
            throw new ArgumentException("Empty sequence.");
        }

        T item = new T();
        /* Using linear approach here, but I didn't came up with
         * anything more effective.*/
        for (int i = 0; i < collection.Count; i++)
        {
            if (item.CompareTo(collection[i]) > 0)
            {
                item = collection[i];
            }
        }

        return item;
    }

    /// <summary>
    /// Returns the  largest element in a collection.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="collection">Takes a generic collection as single parameter.</param>
    /// <returns>Largest element of type T.</returns>
    public static T Max<T>(GenericList<T> collection)
       where T : IComparable<T>, new()
    {
        if (collection.Count == 1)
        {
            return collection[0];
        }
        else if (collection.Count == 0)
        {
            throw new ArgumentException("Empty sequence.");
        }

        T item = new T();
        for (int i = 0; i < collection.Count; i++)
        {
            if (item.CompareTo(collection[i]) < 0)
            {
                item = collection[i];
            }
        }

        return item;
    }

    public override string ToString()
    {
        string output = String.Format("Type: {0}, \nCount: {1}", base.ToString(), Count);
        return output;
    }
}