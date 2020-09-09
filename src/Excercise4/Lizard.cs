using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise04
{
    class Lizard : Animal
    {
        private int coughtFlyCount;

        public Lizard(string name) : base(name, "Reptile")
        {
        }

        public void CatchFly()
        {
            Console.WriteLine("Fly cought");
            coughtFlyCount++;
        }
    }
}
