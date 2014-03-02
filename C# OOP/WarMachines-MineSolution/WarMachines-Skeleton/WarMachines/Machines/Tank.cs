using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Tank : Machine, ITank
    {
        private bool defenceMode;

        public Tank(string name, double attack, double defense)
            : base(name, 100, attack, defense)
        {
            this.defenceMode = true;
            this.DefensePoints += 30;
            this.AttackPoints -= 40;
        }

        public bool DefenseMode
        {
            get { return this.defenceMode; }
            private set { this.defenceMode = value; }
        }

        public void ToggleDefenseMode()
        {
            if (DefenseMode)
            {
                this.defenceMode = true;
                this.DefensePoints += 30;
                this.AttackPoints -= 40;
            }
            else
            {
                this.defenceMode = false;
                this.DefensePoints -= 30;
                this.AttackPoints += 40;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" *Defense: {0}", DefenseMode ? "ON" : "OFF");
        }
    }
}
