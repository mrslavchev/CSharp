using System;
using System.Text;
using System.Collections.Generic;


public class GSM
{
    private string model;
    private string manifacturer;
    private int? price;
    private string owner;
    public Display Display = new Display("15 x 10", null);
    public Batery Batery = new Batery(batteryType.LiIon, null, null);  //fields end here

    private static GSM iPhone4S = new GSM("iPhone", "Apple", 500);  //static field

    public GSM(string model, string manifacturer)
        : this(model, manifacturer, null, null, null, null)  //constructor reuse
    {
    }

    public GSM(string model, string manifacturer, int price)
        : this(model, manifacturer, price, null, null, null)
    {
    }

    public GSM(string model, string manifacturer, int price, string owner)
        : this(model, manifacturer, price, owner, null, null)
    {
    }

    public GSM(string model, string manifacturer, int? price, string owner, Batery batery, Display display)  //constructor
    {
        this.model = model;
        this.manifacturer = manifacturer;
        this.price = price;
        this.owner = owner;
        this.Batery = batery;
        this.Display = display;
    }

    public string Model  //properties
    {
        get { return this.model; }
        set
        {
            if (value.Length > 0)
            {
                this.model = value;
            }

            else
            {
                throw new ArgumentException();
            }
        }
    }

    public string Manifacturer
    {
        get { return this.manifacturer; }
        set
        {
            if (value.Length > 0)
            {
                this.manifacturer = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public int? Price
    {
        get { return this.price; }
        set
        {
            if (value == null || value > 0)
            {
                this.price = value;
            }

            else
            {
                throw new ArgumentException();
            }
        }
    }

    public string Owner
    {
        get { return this.owner; }
        set
        {
            if (value == null || value.Length > 0)
            {
                this.owner = value;
            }

            else
            {
                throw new ArgumentException();
            }
        }
    }

    public static GSM IPhone4S
    {
        get { return iPhone4S; }  
    }

    private List<Call> callHistory = new List<Call>();

    // methods
    public void AddCall(string number, DateTime now, int duration)
    {
        Call myCall = new Call(number, now, duration);
        callHistory.Add(myCall);
    }

    public void RemovecCall(int duration)
    {
        for (int i = 0; i < callHistory.Count; i++)
        {
            if (callHistory[i].Duration == duration)
            {
                callHistory.RemoveAt(i);
                break;
            }
        }
    }

    public void ClearHistory()
    {
        callHistory.Clear();
    }

    public double CalculatePrice(double pricePerMin)
    {
        double fullTime = 0;
        for (int i = 0; i < callHistory.Count; i++)
        {
            fullTime = fullTime + callHistory[i].Duration;
        }
        double price = pricePerMin * (Math.Ceiling(fullTime / 60));
        return price;
    }

    public void DisplayHistory()
    {
        StringBuilder callHist = new StringBuilder();
        callHist.AppendLine("Call History:");
        foreach (var call in callHistory)
        {
            callHist.AppendFormat("Number {0}, Date: {1}, Duration: {2} \n", call.Number, call.DateAndTime, call.Duration);
        }

        Console.WriteLine(callHist.ToString());
    }

    public override string ToString()
    {
        StringBuilder endText = new StringBuilder();
        endText.AppendLine("GSM");
        endText.AppendLine(this.model);
        endText.AppendLine(this.manifacturer);
        endText.AppendLine(this.owner);
        endText.AppendLine(this.Batery.ToString());
        endText.AppendLine(this.Display.ToString());
        string result = endText.ToString();
        return result;
    }
}  



