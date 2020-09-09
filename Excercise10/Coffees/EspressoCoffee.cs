using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise10.Coffees
{
    public class EspressoCoffee : CoffeeBase
    {
        public const int RequiredMilk = 0;
        public const int RequiredWater = 100;
        public const int RequiredCoffeeBeans = 30;

        public override string ToString()
        {
            return $"Espresso kava. Ingridientai: Pienas {RequiredMilk}, Vanduo {RequiredWater}, Kavos pupelės {RequiredCoffeeBeans}";
        }
    }
}
