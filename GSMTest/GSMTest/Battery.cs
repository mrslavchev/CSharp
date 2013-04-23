using System;
using System.Text;
using System.Collections.Generic;

public enum batteryType
{
    LiIon, NiMh, NiCd
}

public class Batery
{
    private batteryType model;
    private byte? hoursIdle;
    private byte? hoursTalk;

    public Batery(batteryType model)
        : this(model, null, null)
    {
    }

    public Batery(batteryType model, byte? hoursIdle)
        : this(model, hoursIdle, null)
    {
    }

    public Batery(batteryType model, byte? hoursIdle, byte? hoursTalk)
    {
        this.model = model;
        this.hoursIdle = hoursIdle;
        this.hoursTalk = hoursTalk;
    }

    private batteryType Model
    {
        get { return this.model; }
        set { this.model = value; }

    }
    public byte? HoursIdle
    {
        get { return this.hoursIdle; }
        set
        {
            if ((value >= 0) || (value <= 255))
            {
                this.hoursIdle = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public byte? HoursTalk
    {
        get { return this.hoursTalk; }
        set
        {
            if ((value >= 0) || (value <= 255))
            {
                this.hoursTalk = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public override string ToString()
    {
        StringBuilder batteryOutput = new StringBuilder();
        batteryOutput.AppendLine("Battery:");
        batteryOutput.AppendLine(this.model.ToString());
        batteryOutput.AppendLine(this.hoursIdle.ToString());
        batteryOutput.AppendLine(this.hoursTalk.ToString());
        return batteryOutput.ToString();
    }

}
