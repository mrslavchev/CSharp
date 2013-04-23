using System;
using System.Text;
using System.Collections.Generic;


public  class GSM
{
    private string model;
    private string manifacturer;
    private int? price;
    private string owner;
    public Display Display = new Display("15 x 10", null);
    public Batery Batery = new Batery(batteryType.LiIon, null, null);

    private static GSM iPhone4S = new GSM("iPhone", "Apple", 500);

    public GSM(string model, string manifacturer)
        : this(model, manifacturer, null, null, null, null)
    { 
    }

    public GSM(string model, string manifacturer, int price)
        : this(model, manifacturer, price, null, null, null)
    {
    }

    public GSM(string model, string manifacturer, int price, string owner) : this(model, manifacturer, price, owner, null, null)
    { 
    }

    public GSM(string model, string manifacturer, int? price, string owner, Batery batery, Display display)
    {
        this.model = model;
        this.manifacturer = manifacturer;
        this.price = price;
        this.Batery = batery;
        this.Display = display;
    }

    public string Model
    {
        get {return this.model; }
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
        get {return this.manifacturer; }
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
        get {return this.price; }
        set 
        {
            if (value==null || value > 0)
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
        get {return this.owner; }
        set 
        {
            if (value==null||value.Length>0)
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
        get {return iPhone4S;}
    }
}

