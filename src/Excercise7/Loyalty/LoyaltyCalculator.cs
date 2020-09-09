using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise07.Loyalty
{
    public class LoyaltyCalculator
    {
        private Customer[] customers;
        private PurchaseItem[] items;

        public LoyaltyCalculator()
        {
            this.customers = new Customer[]
            {
                new Customer("Klientas1"),
                new Customer("Klientas2"),
                new Customer("Klientas3"),
                new Customer("Klientas4"),
            };

            this.items = new PurchaseItem[]
            {
                new PurchaseItem("Item1", 100),
                new PurchaseItem("Item2", 200),
                new PurchaseItem("Item3", 120),
                new PurchaseItem("Item4", 400),
                new PurchaseItem("Item5", 150),
                new PurchaseItem("Item6", 300),
            };
        }

        public void PrintCustomers()
        {
            Array.Sort(customers);
            Array.Reverse(customers);
            foreach (var customer in this.customers)
            {
                customer.Print();
            }
        }

        public void PrintItems()
        {
            Array.Sort(items);
            Array.Reverse(items);
            foreach (var item in this.items)
            {
                item.Print();
            }
        }

        public void RegisterPurchase(string customerName, string itemName)
        {
            var customer = this.FindCustomerByName(customerName);
            var item = this.FindItemByName(itemName);
            customer.RegisterPurcase(item);
        }

        private Customer FindCustomerByName(string name)
        {
            foreach (var customer in this.customers)
            {
                if (customer.Name == name)
                {
                    return customer;
                }
            }

            return null;
        }

        private PurchaseItem FindItemByName(string name)
        {
            foreach (var item in this.items)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
