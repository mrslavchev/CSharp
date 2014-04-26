using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public abstract class Suplement : ISupplement
    {
        private int powerEffect;
        private int healthEffect;
        private int aggerssionEffect;

        public void ReactTo(ISupplement otherSupplement)
        {
            throw new NotImplementedException();
        }

        public virtual int PowerEffect
        {
            get { return this.powerEffect; }
            private set
            {
                this.powerEffect = value;
            }
        }

        public virtual int HealthEffect
        {
            get { return this.healthEffect; }
            private set 
            {
                this.powerEffect = value;
            }
        }

        public virtual int AggressionEffect
        {
            get { return this.aggerssionEffect; }
            private set
            {
                this.aggerssionEffect = value;
            }
        }
    }
}
