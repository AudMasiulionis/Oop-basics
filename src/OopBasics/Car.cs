using System;

namespace OopBasics
{
    public class Car
    {
        public int MaxFuelAmount { get; }

        public Car(string name)
        {
            this.MaxFuelAmount = 50;
            this.Name = name;
        }

        public int Millage { get; private set; }
        public int FuelAmount { get; private set; }
        public string Name { get; }

        public void Drive()
        {
            if (this.FuelAmount < 10)
            {
                Console.WriteLine("Neužtenka kuro važiuoti");
                return;
            }

            this.Millage += 10;
        }

        public void Refuel(int amount)
        {
            if (this.FuelAmount + amount > MaxFuelAmount)
            {
                Console.WriteLine("Per didelis kuro kiekis");
                return;
            }

            this.FuelAmount += amount;
        }
    }
}
