using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise10.Coffees
{
    public class LatteCoffee : CoffeeBase
    {
        public const int RequiredMilk = 50;
        public const int RequiredWater = 200;
        public const int RequiredCoffeeBeans = 30;

        public override string ToString()
        {
            return $"Latte kava. Ingridientai: Pienas {RequiredMilk}, Vanduo {RequiredWater}, Kavos pupelės {RequiredCoffeeBeans}";
        }
    }
}
