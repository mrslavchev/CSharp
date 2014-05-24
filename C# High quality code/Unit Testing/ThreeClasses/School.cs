using System;
using System.Collections.Generic;
using System.Linq;

public class School
{
    private List<int> uniqueIds;

    public School()
    {
        this.UniqueIds = new List<int>();
    }

    public List<int> UniqueIds
    {
        get { return this.uniqueIds; }
        private set
        {
            if (value == null)
            {
                throw new ArgumentException("List of ids can not be null.");
            }

            this.uniqueIds = value;
        }
    }
}