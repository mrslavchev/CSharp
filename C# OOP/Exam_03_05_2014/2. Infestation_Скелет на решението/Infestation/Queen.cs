using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class Queen : Unit
    {
        const int queenHealth = 30;
        const int queenPower = 1;
        const int queenAggression = 1;

        public Queen(string id)
            : base(id, UnitClassification.Psionic, Queen.queenHealth, Queen.queenPower, Queen.queenAggression)
        { }
    }
}
