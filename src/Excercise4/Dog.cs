using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise04
{
    class Dog : Animal
    {
        private int barkCount;

        public Dog(string name) : base(name, "Canine")
        {
        }

        public void Bark()
        {
            Console.WriteLine("Woof");
            barkCount++;
        }
    }
}
