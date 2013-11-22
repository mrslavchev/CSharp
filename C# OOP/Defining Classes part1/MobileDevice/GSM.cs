using System;
using System.Text;
using System.Collections.Generic;

public class GSM
{
    private string model;
    private string manufacturer;
    private int? price;
    private string owner;
    private Display gsmDisplay = new Display();
    private Battery gsmBattery = new Battery();
    private static GSM iphone4S = new GSM("4S", "Apple");

    // Properties
    public string Model
    {
        get { return this.model; }
        private set 
        {
            if (!String.IsNullOrEmpty(value))
            {
                model = value;
            }
            else
            {
                throw new ArgumentException("Model is null or empty string!");
            }
        }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }
        private set 
        {
            if (!String.IsNullOrEmpty(value))
            {
                manufacturer = value;
            }
            else
            {
                throw new ArgumentException("Invalid manufacturer parameter");
            }
        }
    }

    public int? Price
    {
        get { return this.price; }
        private set 
        {
            if (value == null || value > 0)
            {
                price = value;
            }
            else
            {
                throw new ArgumentException("Invalid price");
            }
        }
    }

    public string Owner
    {
        get { return this.owner; }
        private set 
        {
            if (value == null || value.Length > 0)
            {
                owner = value;
            }
            else
            {
                throw new ArgumentException("Invalid owner input");
            }
        }
    }

    public Display GsmDisplay
    {
        get { return this.gsmDisplay; }
    }

    public static GSM IPhone4S
    {
        get { return iphone4S; }
    }

    public List<Call> CallHistory { get; set; }

    public GSM(string model, string manufacturer, int? price, string owner)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Price = price;
        this.Owner = owner;
        this.CallHistory = new List<Call>();
        
    }

    public GSM(string model, string manufacturer) 
        : this(model, manufacturer, null, null)
    { }
    
    // Methods
    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        output.AppendLine("Model: " + this.model);
        output.AppendLine("Manufacturer: " + this.manufacturer);
        output.AppendLine("Price: " + this.price);
        output.AppendLine("Owner: " + this.owner);
        output.AppendLine("Display: " + this.gsmDisplay);
        output.AppendLine("Battery: " + this.gsmBattery);

        return output.ToString();
    }

    /// <summary>
    /// Adds record to call history
    /// </summary>
    /// <param name="startTime">The start time of the call</param>
    /// <param name="phoneNumber">The number of the dialed phone</param>
    /// <param name="duration">Duration of the call in seconds</param>
    public void AddCall(string startTime, int phoneNumber, int duration)
    {
        this.CallHistory.Add(new Call(startTime, phoneNumber, duration));
    }

    /// <summary>
    /// Removes record from the call history
    /// </summary>
    /// <param name="callToRemove">Call to be removed</param>
    public void RemoveCall(Call callToRemove)
    {
        this.CallHistory.Remove(callToRemove);
    }

    /// <summary>
    /// Clears call history records.
    /// </summary>
    public void ClearCallHistory()
    {
        this.CallHistory.Clear();
    }

    /// <summary>
    /// Sums the price of all calls in the call history.
    /// </summary>
    /// <returns>Decimal total.</returns>
    public decimal CalculatePrice()
    {
        decimal sum = 0;
        for (int i = 0; i < this.CallHistory.Count; i++)
        {
            sum += ((CallHistory[i].Duration / 60) * Call.Price);
        }
        return sum;
    }

    /// <summary>
    /// Finds the call with longest duration in call history
    /// </summary>
    /// <returns>Longest call</returns>
    public Call FindLongestCall()
    {
        Call output = new Call();
        for (int i = 0; i < this.CallHistory.Count; i++)
        {
            if (output.Duration < CallHistory[i].Duration)
            {
                output = CallHistory[i];
            }
        }

        return output;
    }
}

