using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class Parasite : Unit
    {
        const int parasiteHealth = 1;
        const int parasitePower = 1;
        const int parasiteAggression = 1;

        public Parasite(string id)
            : base(id, UnitClassification.Biological, Parasite.parasiteHealth, Parasite.parasitePower, Parasite.parasiteAggression)
        { }
    }
}
