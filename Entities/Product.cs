using System;
using System.Globalization;
using System.Runtime.Remoting;

namespace RestringindoGeneric.Entities
{
    internal class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        
        public override string ToString()
        {
            return Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("Comparing error: argument is not a Product!");
            }
            
            // Casting
            Product other = (Product)obj;
            return Price.CompareTo(other.Price);
        }
    }
}
