using System;
// Implementing the required standard via Adaptee
public class Adapter : Adaptee, ITarget
{
    public string Request(int i)
    {
        return "Rough estimate is " + (int)Math.Round(SpecificRequest(i, 3));
    }
}