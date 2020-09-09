using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise10
{
    public class CoffeeMachineException : Exception
    {
        public CoffeeMachineException(string message) : base(message)
        {
        }
    }
}
