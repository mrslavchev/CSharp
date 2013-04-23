using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Call
{
    private string number;
    private DateTime dateAndTime;
    private int duration;
        
    public Call(string number, DateTime dateAndTime, int duration)
    {
        this.number = number;
        this.dateAndTime = dateAndTime;
        this.duration = duration;
    }

    public string Number
    {
        get { return this.number; }
        set { this.number = value; }
    }

    public DateTime DateAndTime
    {
        get { return this.dateAndTime; }
        set { this.dateAndTime = value; }
    }

    public int Duration
    {
        get { return this.duration; }
        set { this.duration = value; }
    }
}


