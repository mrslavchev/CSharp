using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    class AdjustableChair : Chair, IAdjustableChair
    {
        public AdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            :base(model, materialType, price, height, numberOfLegs)
        { }

        public void SetHeight(decimal height)
        {
            if (height > 0.00m)
            {
                this.Height = height;
            }
        }
    }
}
