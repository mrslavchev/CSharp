using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public abstract class Furniture : IFurniture
    {
        private string model;
        private string material;
        private decimal price;
        private decimal height;

        public Furniture(string model, string material, decimal price, decimal height)
        {
            this.Model = model;
            this.Material = material;
            this.Price = price;
            this.Height = height;
        }

        public string Model
        {
            get { return this.model; }
            protected set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentException("Model can not be null, empty or less than 3 symbols.");
                }

                this.model = value;
            }
        }

        public string Material
        {
            get { return this.material; }
            protected set { this.material = value; }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0.00M)
                {
                    throw new ArgumentException("Price can not be less than or equal to zero.");
                }

                this.price = value;
            }
        }

        public virtual decimal Height
        {
            get { return this.height; }
            protected set
            {
                if (value <= 0.00M)
                {
                    throw new ArgumentException("Height can not be less than or equal to zero.");
                }

                this.height = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4},", this.GetType().Name,
                this.Model, this.Material, this.Price, this.Height).ToString();
        }
    }
}
