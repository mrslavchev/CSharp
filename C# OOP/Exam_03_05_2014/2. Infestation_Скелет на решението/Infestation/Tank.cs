using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class Tank : Unit
    {
        const int tankPower = 25;
        const int TankAggression = 20;
        const int TankHealth = 25;

        public Tank(string id)
            :base(id, UnitClassification.Mechanical, Tank.TankHealth, Tank.tankPower, TankAggression)
        {
        }
    }
}
