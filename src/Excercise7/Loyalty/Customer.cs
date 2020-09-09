using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise07.Loyalty
{
    class Customer
    {
        public Customer(string name)
        {
            this.Name = name;
        }

        public string Name { get; }
        public double LoyaltyPoints { get; private set; }

        public void RegisterPurcase(PurchaseItem item)
        {
            var points = this.CalculatePoints(item);
            this.LoyaltyPoints += points;
            Console.WriteLine($"Nupirkta prekė: {item}. Už prekė gaunami taškai: {points}. Iš viso turima taškų: {this.LoyaltyPoints}");
        }

        public int CompareTo(Customer other)
        {
            if (other.LoyaltyPoints > this.LoyaltyPoints)
            {
                return -1;
            }
            else if (other.LoyaltyPoints < this.LoyaltyPoints)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private double CalculatePoints(PurchaseItem item)
        {
            if (this.LoyaltyPoints > 100)
            {
                return item.Price * 1.10;
            }
            if (this.LoyaltyPoints > 500)
            {
                return item.Price * 1.20;
            }

            return item.Price;
        }

        public override string ToString()
        {
            return $"Kliento vardas:[{Name}]. Lojalumo taškai[{LoyaltyPoints}]";
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
