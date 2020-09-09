using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise06
{
    public class Programmer : Employee
    {
        public Programmer(string name) : base(name)
        {
        }

        public override void DoWork()
        {
            Console.WriteLine("I am coding");
        }
    }
}
