using System;
using Exercise10.Coffees;

namespace Exercise10
{
    public class CoffeeMachine
    {
        private const int UsageCleanCount = 10;
        private Products products;

        public CoffeeMachine()
        {
            this.products = new Products();
        }

        public int TimesUsed { get; private set; }
        public int TotalCoffeesMade { get; private set; }

        public CoffeeBase MakeCoffee(string type)
        {
            if (TimesUsed == UsageCleanCount)
            {
                throw new CoffeeMachineException("Laikas plauti aparatą");
            }

            switch (type)
            {
                case "black":
                    this.products.RemoveProducts(BlackCoffee.RequiredMilk, BlackCoffee.RequiredCoffeeBeans, BlackCoffee.RequiredWater);
                    TotalCoffeesMade++;
                    TimesUsed++;
                    return new BlackCoffee();
                case "latte":
                    this.products.RemoveProducts(LatteCoffee.RequiredMilk, LatteCoffee.RequiredCoffeeBeans, LatteCoffee.RequiredWater);
                    TotalCoffeesMade++;
                    TimesUsed++;
                    return new LatteCoffee();
                case "espresso":
                    this.products.RemoveProducts(EspressoCoffee.RequiredMilk, EspressoCoffee.RequiredCoffeeBeans, EspressoCoffee.RequiredWater);
                    TotalCoffeesMade++;
                    TimesUsed++;
                    return new EspressoCoffee();
                default:
                    throw new CoffeeMachineException("Klaidingas pasirinkimas");
            }
        }

        public void Refill(int milkAmmount, int cofeeBeanAmmount, int waterAmmount)
        {
            this.products.AddProducts(milkAmmount, cofeeBeanAmmount, waterAmmount);
        }

        public void Clean()
        {
            if (TimesUsed == 0)
            {
                throw new CoffeeMachineException("Kavos aparato valyti nereikia");
            }

            TimesUsed = 0;
        }

        public void ShowStatus()
        {
            Console.WriteLine(products);
            Console.WriteLine($"Pagaminta kavų: {TotalCoffeesMade}");
            Console.WriteLine($"Iki plovimo liko:{UsageCleanCount - TimesUsed}");
        }
    }
}
