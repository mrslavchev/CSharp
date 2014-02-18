using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class InvalidRangeException<T> : Exception
{
    private const string Message = "Value out of range!";

    public T Start { get; set; }
    public T End { get; set; }

    public InvalidRangeException(T start, T end, Exception innerException = null)
        : base(Message, innerException)
    {
        this.Start = start;
        this.End = end;
    }
}

