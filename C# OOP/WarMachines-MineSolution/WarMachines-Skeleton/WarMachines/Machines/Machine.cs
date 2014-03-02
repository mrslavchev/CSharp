using System;
using System.Collections.Generic;
using System.Linq;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
     public abstract class Machine : IMachine
    {
         private string name;
         private IPilot pilot;
         private double healthPoints;
         private double attackPoints;
         private double defensePoints;
         private IList<string> targets;

         public Machine(string name, double healthPoints, double attack, double defense)
         {
             this.Name = name;
             this.pilot = null;
             this.HealthPoints = healthPoints;
             this.attackPoints = attack;
             this.defensePoints = defense;
             this.Targets = new List<string>();
         }

         public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Name can not be null.");
                }

                this.name = value;
            }
        }

         public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Pilot can not be set to null.");
                }

                this.pilot = value;
            }
        }

         public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                this.healthPoints = value;
            }
        }

         public double AttackPoints
        {
            get { return this.attackPoints; }
            protected set { this.attackPoints = value; }
        }

         public double DefensePoints
        {
            get { return this.defensePoints; }
            protected set { this.defensePoints = value; }
        }

         public IList<string> Targets
        {
            get { return this.targets; }
            protected set 
            {
                if (value == null)
                {
                    throw new ArgumentException("Target can not be set to null.");
                }

                this.targets = value;
            }
        }

         public void Attack(string target)
        {
            targets.Add(target);
        }

         public override string ToString()
         {
             return string.Format("- {0}\n *Type: {1}\n *Health: {2}\n *Attack: {3}\n *Defense: {4}\n *Targets: {5}\n",
                 this.Name, this.GetType().Name, this.HealthPoints, this.AttackPoints, this.DefensePoints, 
                 this.targets.Count == 0 ? "None" : string.Join(", ", this.targets));
         }
    }
}
