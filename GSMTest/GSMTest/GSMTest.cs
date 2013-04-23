using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMTest
{
    class GSMTest
    {
        static void Main(string[] args)
        {
            GSM[] phones = new GSM[2];
            Batery testingBattery = new Batery(batteryType.LiIon, 15, 7);
            Display testingDisplay = new Display("45 x 45", "256");
            GSM peshoPhone = new GSM("Asha", "Nokia", 45, "Pesho", testingBattery, testingDisplay);
            GSM goshoPhone = new GSM("D40", "Samsung", 50, "Gosho", testingBattery, testingDisplay);
            
            phones[0] = peshoPhone;
            phones[1] = goshoPhone;

            for (int i = 0; i < phones.Length; i++)
            {
                Console.WriteLine(phones[i]);
            }
            Console.WriteLine(GSM.IPhone4S.Model);
            Console.WriteLine(GSM.IPhone4S.Manifacturer);
            Console.WriteLine(GSM.IPhone4S.Price);

            GSM testCalls = new GSM("Samsung", "Samsung", 10, "Pesho", testingBattery, testingDisplay);
            testCalls.AddCall("08888888", DateTime.Now, 231);
            testCalls.AddCall("07777777", DateTime.Now, 221);
            testCalls.AddCall("06666666", DateTime.Now, 118);

            testCalls.DisplayHistory();
            testCalls.RemovecCall(1);

            testCalls.DisplayHistory();
            Console.WriteLine(testCalls.CalculatePrice(0.37));
            testCalls.ClearHistory();
            testCalls.DisplayHistory();


        }
    }
}
