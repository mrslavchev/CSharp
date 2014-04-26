using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class Marine : Unit
    {
        public Marine(string id)
            : base(id, UnitClassification.Biological, Human.HumanHealth, Human.HumanPower, Human.HumanAggression)
        { }

        public override void AddSupplement(ISupplement newSupplement)
        {
            base.AddSupplement(newSupplement);
        }
    }
}
