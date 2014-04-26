using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.Furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException("Invalid company name.");
                }
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get { return this.registrationNumber; }
            private set
            {
                // Kids don't do this !!
                long n = 0L;
                if (value.Length != 10 || !(long.TryParse(value, out n)))
                {
                    throw new ArgumentException("Registration number must contain only numbers and have length 10 symbols.");
                }

                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get { return this.furnitures; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Value can not be set to null.");
                }

                this.furnitures = value;
            }
        }

        public void Add(IFurniture furniture)
        {
            this.Furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            var selection = this.Furnitures.Where(f => f == furniture).FirstOrDefault();
            this.Furnitures.Remove(selection);
        }

        public IFurniture Find(string model)
        {
            var selection = this.Furnitures.Where(f => f.Model == model).FirstOrDefault();
            return selection;
        }

        public string Catalog()
        {
            StringBuilder catalog = new StringBuilder();
            catalog.AppendFormat("{0} - {1} - {2} {3}\n",
                                    this.Name,
                                    this.RegistrationNumber,
                                    this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                                    this.Furnitures.Count != 1 ? "furnitures" : "furniture"
                                    );
            var ordered = this.Furnitures.OrderBy(f => f.Price).ThenBy(f => f.Model);
            //catalog.AppendLine(string.Join(", ", this.Furnitures.OrderBy(f => f.Price).ThenBy(f => f.Model)));
            foreach (var item in ordered)
            {
                catalog.AppendLine(item.ToString());
            }

            return catalog.ToString().Trim();
        }
    }
}
