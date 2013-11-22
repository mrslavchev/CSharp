using System;
using System.Text;
using System.Collections.Generic;

public class Display
{
    private string size;
    private string color;

    public Display(string size)
        : this(size, null)
    {
    }

    public Display(string size, string color)
    {
        this.size = size;
        this.color = color;
    }

    public string Size
    {
        get { return this.size; }
        set
        {
            if (value.Length >= 0)
            {
                this.size = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }

    }

    public string Color
    {
        get { return this.color; }
        set
        {
            if (value.Length >= 0)
            {
                this.color = value;
            }

            else
            {
                throw new ArgumentException();
            }
        }
    }

    public override string ToString()
    {
        StringBuilder displayOutput = new StringBuilder();
        displayOutput.AppendLine("Display");
        displayOutput.AppendLine(this.color);
        displayOutput.AppendLine(this.size);
        return displayOutput.ToString();
    }


}

