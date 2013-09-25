using System;
using System.Text;

public class Display
{
    // Fields
    private int size;
    private int numOfColors;

    // Properties
    public int Size
    {
        get { return this.size; }
        private set 
        {
            if (value > 0)
            {
                size = value;
            }
            else
            {
                throw new ArgumentException("Invalid size value!");
            }
        }
    }

    public int NumOfColors
    {
        get { return this.numOfColors; }
        private set 
        {
            if (value > 0)
            {
                numOfColors = value;
            }
            else
            {
                throw new ArgumentException("Invalid number of colours value!");
            }
        }
    }
    
    //Constructors
    public Display(int size, int numberOfColors)
    {
        this.Size = size;
        this.NumOfColors = numberOfColors;
    }

    public Display()
        : this(4, 12000)
    { }

    // Methods
    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        output.AppendFormat("Size: {0}-inches, Colors: {1}", this.size, this.numOfColors);

        return output.ToString();
    }
}

