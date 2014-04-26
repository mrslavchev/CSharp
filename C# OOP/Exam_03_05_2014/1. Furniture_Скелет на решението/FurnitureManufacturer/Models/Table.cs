using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    class Table : Furniture, ITable
    {
        private decimal area;

        public Table(string model, string materialType, decimal price, decimal height, decimal length, decimal width)
            : base(model, materialType, price, height)
        {
            this.Length = length;
            this.Width = width;
            this.Area = this.Length * this.Width;
        }

        public decimal Length
        {
            get;
            private set;
        }

        public decimal Width
        {
            get;
            private set;
        }

        public decimal Area
        {
            get { return this.area; }
            private set 
            {
                this.area = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" Length: {0}, Width: {1}, Area: {2}", this.Length, this.Width, this.Area);
        }
    }
}
