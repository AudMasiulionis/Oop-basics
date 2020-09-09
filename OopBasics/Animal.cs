using System;
using System.Collections.Generic;
using System.Text;

namespace OopBasics
{
    class Animal
    {
        public Animal(string name, string family)
        {
            Name = name;
            Family = family;
        }

        public string Name { get; set; }
        public string Family { get; set; }

        public void Greet()
        {
            Console.WriteLine($"Labas aš {Name} iš {Family} giminės");
        }
    }
}
