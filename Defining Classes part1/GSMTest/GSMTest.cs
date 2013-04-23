using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GSMTest
{


    static void Main()
    {
            GSM[] phones = new GSM[2];
            Batery testingBattery = new Batery(batteryType.LiIon, 15, 7);
            Display testingDisplay = new Display("45 x 45", "red");
            GSM peshoPhone = new GSM("Nokia", "Bitaka", 45, "Pesho", testingBattery, testingDisplay);
            GSM goshoPhone = new GSM("Samsung", "Maze", 50, "Gosho", testingBattery, testingDisplay);
            phones[0] = peshoPhone;
            phones[1] = goshoPhone;

            for (int i = 0; i < phones.Length; i++)
            {
                Console.WriteLine(phones[i]);
            }
    }
}

