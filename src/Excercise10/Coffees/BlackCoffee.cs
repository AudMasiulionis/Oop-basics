using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise10.Coffees
{
    public class BlackCoffee : CoffeeBase
    {
        public const int RequiredMilk = 0;
        public const int RequiredWater = 200;
        public const int RequiredCoffeeBeans = 30;

        public override string ToString()
        {
            return $"Juoda kava. Ingridientai: Pienas {RequiredMilk}, Vanduo {RequiredWater}, Kavos pupelės {RequiredCoffeeBeans}";
        }
    }
}
