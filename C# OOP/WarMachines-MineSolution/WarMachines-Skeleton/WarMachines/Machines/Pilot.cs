using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarMachines.Interfaces;


namespace WarMachines.Machines
{
     public class Pilot : IPilot
    {
         private string name;

         private List<IMachine> machines;

         public Pilot(string name)
         {
             this.Name = name;
             this.Machines = new List<IMachine>();
         }

         public string Name
        {
            get { return this.name; }
            private set 
            {
                if (value == null)
                {
                    throw new ArgumentException("Name can not be set to null.");
                }

                this.name = value;
            }
        }

         public List<IMachine> Machines
         {
             get { return this.machines; }
             private set 
             {
                 if (value == null)
                 {
                     throw new ArgumentException("Machines can not be set to null.");
                 }

                 this.machines = value;
             }
         }
         
         public void AddMachine(IMachine machine)
        {
            this.machines.Add(machine);
        }
         
         public string Report()
        {
            var output = new StringBuilder();
            output.AppendLine(string.Format("{0} - {1} {2}",
                this.Name,
                this.Machines.Count != 0 ? this.Machines.Count.ToString() : "no",
                this.Machines.Count != 1 ? "machines" : "machine"));

            var sorted = this.Machines.OrderBy(x => x.HealthPoints).ThenBy(x => x.Name);
            foreach (var item in sorted)
            {
                output.AppendLine(item.ToString());
            }

            return output.ToString().Trim();
        }
    }
}
