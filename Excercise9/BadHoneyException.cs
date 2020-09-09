﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise09
{
    public class BadHoneyException : Exception
    {
        public BadHoneyException(Honey honey) : base()
        {
            Honey = honey;
        }

        public BadHoneyException(Honey honey, string message) : base(message)
        {
            Honey = honey;
        }

        public BadHoneyException(Honey honey, string message, Exception innerException) : base(message, innerException)
        {
            Honey = honey;
        }

        public Honey Honey { get; }

        public override string Message
        {
            get
            {
                return $"Bear doesn't like { Honey.ToString() }";
            }
        }
    }
}
