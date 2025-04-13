using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExam
{
    public class Perfume
    {
        private string brand;

        private double price;

        //set and get method
        public Perfume(string brand, double price)
        {
            this.Brand = brand;
            this.Price = price;
        }
        public double Price
        {
            set
            {
                if (value > 100)
                {
                    throw new ArgumentException("Invalid perfume price!");
                }
                this.price = value;
            }
            get
            {
                return this.price;
            }
        }
        public string Brand
        {
            set
            {
                this.brand = value;
            }
            get
            {
                return this.brand;
            }
        }

        public override string ToString()
        {
            return $"Perfume {this.brand} costs {this.price:f2}";
        }
    }
}
