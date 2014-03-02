using System;
using System.Linq;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Fighter : Machine, IFighter
    {
        private bool stealthMode;

        public Fighter(string name, double attack, double defense, bool isInStealth)
            : base(name, 200, attack,  defense)
        {
            this.StealthMode = isInStealth;
        }

        public bool StealthMode
        {
            get { return this.stealthMode; }
            private set 
            {
                this.stealthMode = value;
            }
        }

        public void ToggleStealthMode()
        {
            if (this.stealthMode)
            {
                stealthMode = false;
            }
            else
            {
                stealthMode = true;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" *Stealth: {0}", StealthMode ? "ON" : "OFF");
        }
    }
}
