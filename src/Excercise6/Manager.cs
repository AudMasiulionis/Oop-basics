using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise06
{
    public class Manager : Employee
    {
        public Manager(string name) : base(name)
        {
        }

        public override void DoWork()
        {
            Console.WriteLine("I do managment stuff");
        }
    }
}
