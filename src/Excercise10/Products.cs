using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise10
{
    public class Products
    {
        public int MilkAmmount { get; private set; }
        public int CoffeeBeanAmmount { get; private set; }
        public int WaterAmmount { get; private set; }

        public void AddProducts(int milkAmmount, int cofeeBeanAmmount, int waterAmmount)
        {
            ValidateAmmounts(milkAmmount, cofeeBeanAmmount, waterAmmount);
            MilkAmmount += milkAmmount;
            CoffeeBeanAmmount += cofeeBeanAmmount;
            WaterAmmount += waterAmmount;
        }

        public void RemoveProducts(int milkAmmount, int cofeeBeanAmmount, int waterAmmount)
        {
            ValidateAmmounts(milkAmmount, cofeeBeanAmmount, waterAmmount);
            if (!EnoughProducts(milkAmmount, cofeeBeanAmmount, waterAmmount))
            {
                throw new CoffeeMachineException("Neužtenka produktų");
            }

            MilkAmmount -= milkAmmount;
            CoffeeBeanAmmount -= cofeeBeanAmmount;
            WaterAmmount -= waterAmmount;
        }

        public override string ToString()
        {
            return $"Produktai: Pienas:{MilkAmmount}, Kava:{CoffeeBeanAmmount}, Vanduo:{WaterAmmount}";
        }

        private bool EnoughProducts(int milkAmmount, int cofeeBeanAmmount, int waterAmmount)
        {
            return MilkAmmount >= milkAmmount && CoffeeBeanAmmount >= cofeeBeanAmmount && WaterAmmount >= waterAmmount;
        }

        private void ValidateAmmounts(int milkAmmount, int cofeeAmmount, int waterAmmount)
        {
            if (milkAmmount < 0 || cofeeAmmount < 0 || waterAmmount < 0)
            {
                throw new CoffeeMachineException("Netinkamas produktų kiekis");
            }
        }
    }
}
