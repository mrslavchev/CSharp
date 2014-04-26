using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    class ConvertibleChair : Chair, IConvertibleChair
    {
        private bool isConverted;

        public ConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height, numberOfLegs)
        { }

        public bool IsConverted
        {
            get { return this.isConverted; }
            private set
            {
                this.isConverted = value;
            }
        }

        public override decimal Height
        {
            get
            {
                if (isConverted)
                {
                    return 0.10M;
                }
                else
                {
                    return base.Height;
                }
            }
            protected set
            {
                base.Height = value;
            }
        }

        public void Convert()
        {
            if (isConverted)
            {
                IsConverted = false;
            }
            else
            {
                IsConverted = true;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", State: {0}", this.IsConverted ? "Converted" : "Normal");
        }
    }
}
