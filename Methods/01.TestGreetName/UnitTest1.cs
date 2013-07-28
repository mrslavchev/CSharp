using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestGreetName()
    {
        HelloName.GreetUser();
        Assert();
    }
}

