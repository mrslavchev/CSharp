using System;
using System.Text;

public static class StringBuilderExtensions
{
    public static StringBuilder Substring(this StringBuilder builder, int startIndex, int length)
    {
        if (startIndex + length >= builder.Length)
        {
            throw new ArgumentException("Out of range");
        }

        StringBuilder result = new StringBuilder();
        for (int i = 0; i <= length; i++)
        {
            result.Append(builder[startIndex + i]);
        }

        return result;
    }
}