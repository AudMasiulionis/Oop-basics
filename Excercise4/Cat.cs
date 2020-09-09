using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise04
{
    class Cat : Animal
    {
        private int meowCount;

        public Cat(string name) : base(name, "Feline")
        {
        }

        public void Meaow()
        {
            Console.WriteLine("Meaow!");
            meowCount++;
        }
    }
}
