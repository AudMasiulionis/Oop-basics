using System;

namespace Exercise07.Loyalty
{
    internal class PurchaseItem : IComparable<PurchaseItem>, IPrintable
    {
        public PurchaseItem(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }

        public int CompareTo(PurchaseItem other)
        {
            if (other.Price > this.Price)
            {
                return -1;
            }
            else if (other.Price < this.Price)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"Pirkinys:[{this.Name}], kaina[{this.Price}]";
        }
    }
}
