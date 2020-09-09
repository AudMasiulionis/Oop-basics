using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise06
{
    public abstract class Employee
    {
        protected Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public abstract void DoWork();
    }
}
