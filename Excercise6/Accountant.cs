using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise06
{
    public class Accountant : Employee
    {
        public Accountant(string name) : base(name)
        {
        }

        public override void DoWork()
        {
            Console.WriteLine("I deal with numbers all day");
        }
    }
}
