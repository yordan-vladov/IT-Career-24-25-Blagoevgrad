using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegularExam
{
    public class Perfumery
    {
        private string name;
        private List<Perfume> perfumes;

        public Perfumery(string name)
        {
            this.Name = name;
            this.perfumes = new List<Perfume>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 6)
                {
                    throw new ArgumentException("Invalid perfumery name!");
                }
                this.name = value;
            }
        }

        public void AddPerfume(Perfume perfume)
        {
            this.perfumes.Add(perfume);
        }

        public bool SellPerfume(Perfume perfume)
        {
            foreach (var shopPerfume in this.perfumes)
            {
                if (shopPerfume.Brand == perfume.Brand
                && shopPerfume.Price == perfume.Price)
                {
                    perfumes.Remove(shopPerfume);
                    return true;
                }

            }

            return false;
        }

        public double CalculateTotalPrice()
        {
            return perfumes.Sum(perfume => perfume.Price);
        }

        public Perfume GetPerfumeWithHighestPrice()
        {
            var maxPrice = perfumes.Max(perfume => perfume.Price);
            return perfumes.Where(perfume => perfume.Price == maxPrice).FirstOrDefault();
        }

        public Perfume GetPerfumeWithLowestPrice()
        {
            var minPrice = perfumes.Min(perfume => perfume.Price);
            return perfumes.Where(perfume => perfume.Price == minPrice).FirstOrDefault();
        }

        public void RenamePerfumery(string newName)
        {
            this.Name = newName;
        }

        public void SellAllPerfumes()
        {
            this.perfumes.Clear();
        }

        public override string ToString()
        {
            if (perfumes.Count == 0)
            {
                return $"Perfumery {this.name} has no available perfumes.";
            }

            List<string> resultStr = new List<string>();
            resultStr.Add($"Perfumery {this.name} has {this.perfumes.Count} perfume/s:");

            foreach (var perfume in perfumes)
            {
                resultStr.Add(perfume.ToString());
            }

            return string.Join('\n', resultStr);
        }
    }
}
