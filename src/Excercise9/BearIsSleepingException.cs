using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise09
{
    public class BearIsSleepingException : Exception
    {
        public BearIsSleepingException(int roarDecibals) : base()
        {
            RoarDecibals = roarDecibals;
        }

        public BearIsSleepingException(int roarDecibals, string message) : base(message)
        {
            RoarDecibals = roarDecibals;
        }

        public BearIsSleepingException(int roarDecibals, string message, Exception innerException) : base(message, innerException)
        {
            RoarDecibals = roarDecibals;
        }

        public int RoarDecibals { get; }

        public override string Message
        {
            get
            {
                return $"Bear is roaring at {RoarDecibals} decibals. It is very angry. {base.Message}";
            }
        }
    }
}
