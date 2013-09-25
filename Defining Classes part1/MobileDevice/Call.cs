using System;
using System.Text;
/// <summary>
/// I realize I might have used a date time class for start date, 
/// but we don't have requirement to make start/end call methods and counter for the secs
/// therefore, using datetime is additional pain the ass. Will skip it for now. 
/// You can see the basic logic of the call class.
/// </summary>
public class Call
{
    // Fields
    private string startTime;
    private int dialedNumber;
    private int duration;
    public const decimal Price = 0.37m;

    // Properties
    public string StartTime 
    {
        get { return this.startTime; }
        set { this.startTime = value; }
    }

    public int DialedNumber
    { 
        get { return this.dialedNumber; }
        set { this.dialedNumber = value; }
    }
    public int Duration 
    {
        get { return this.duration; }
        set { this.duration = value; }
    }

    // Constructor
    public Call(string start, int dialedNumber, int duration)
    {
        this.startTime = start;
        this.dialedNumber = dialedNumber;
        this.duration = duration;
    }
    // Empty constructor
    public Call()
    { }

    // Methods
    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        output.AppendFormat("Date: {0} Dialed number: {1} Duration: {2} secs", this.StartTime, this.DialedNumber, this.Duration);
        return output.ToString();
    }
}

