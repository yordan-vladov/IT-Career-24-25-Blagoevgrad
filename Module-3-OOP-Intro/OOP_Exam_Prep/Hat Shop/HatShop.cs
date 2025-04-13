using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegularExam
{
    public class HatShop
    {
        private string name;
        private List<Hat> hats;

        public HatShop(string name)
        {
            this.Name = name;
            this.hats = new List<Hat>();
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
                    throw new ArgumentException("Invalid hat shop name!");
                }
                this.name = value;
            }
        }

        public void AddHat(Hat hat)
        {
            this.hats.Add(hat);
        }

        public bool SellHat(Hat hat)
        {
            foreach (var shopHat in hats)
            {
                if (shopHat.Type == hat.Type && shopHat.Color == hat.Color
                && shopHat.Price == hat.Price)
                {
                    hats.Remove(shopHat);
                    return true;
                }
            }

            return false;
        }

        public double CalculateTotalPrice()
        {
            return hats.Sum(hat => hat.Price);
        }

        public Hat GetHatWithHighestPrice()
        {
            var maxPrice = hats.Max(hat => hat.Price);
            return hats.Where(hat => hat.Price == maxPrice).FirstOrDefault();
        }

        public Hat GetHatWithLowestPrice()
        {
            var minPrice = hats.Min(hat => hat.Price);
            return hats.Where(hat => hat.Price == minPrice).FirstOrDefault();
        }

        public void RenameHatShop(string newName)
        {
            this.Name = newName;
        }

        public void SellAllHats()
        {
            this.hats.Clear();
        }

        public override string ToString()
        {
            if (hats.Count == 0)
            {
                return $"Hat Shop {name} has no available hats.";
            }

            List<string> resutltStr = new List<string>();

            resutltStr.Add($"Hat Shop {name} has {hats.Count} hat/s:");

            foreach (var hat in hats)
            {
                resutltStr.Add(hat.ToString());
            }

            return string.Join('\n', resutltStr);
        }
    }

}
