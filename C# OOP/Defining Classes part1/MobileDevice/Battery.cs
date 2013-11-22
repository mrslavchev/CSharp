using System;
using System.Text;

public class Battery
{
    // Fields
    private string model;
    private double hoursIdle;
    private double hoursTalk;
    private BatteryType type;

    // Properties
    public string Model
    {
        get { return this.model; }
        private set 
        {
            if (value.Length > 0)
            {
                model = value;
            }
            else
            {
                throw new ArgumentException("Invalid model input!");
            }
        }
    }

    public double HoursIdle 
    {
        get { return this.hoursIdle; }
        private set 
        {
            if (value > 0)
            {
                hoursIdle = value;
            }
            else
            {
                throw new ArgumentException("Incorrect hoursIdle value!");
            }
        }
    }

    public double HoursTalk
    {
        get { return this.hoursTalk; }
        private set
        {
            if (value > 0)
            {
                hoursTalk = value;
            }
            else
            {
                throw new ArgumentException("Incorrect hoursTalk value!");
            }
        }
    }

    public BatteryType Type
    {
        get { return this.type; }
    }

    //Constructors
    public Battery(string model, double hoursIdle, double hoursTalk, BatteryType type)
    {
        this.Model = model;
        this.HoursIdle = hoursIdle;
        this.HoursTalk = hoursTalk;
        this.type = type;
    }

    public Battery()
        : this("Chinese", 15.5, 11.2, BatteryType.LiIon)
    { }

    // Methods
    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        output.AppendFormat("Battery: Brand: {0}, Type: {1}, Hours idle: {2}, Hour talk: {3} ", this.Model, this.Type, this.HoursIdle, this.HoursTalk);
        return output.ToString();
    }
    
}

