using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise09
{
    public class Bear
    {
        public string Type { get; set; }
        public bool IsSleeping { get; set; }


        public void GiveHoney(Honey honey)
        {
            if (honey.HoneyType == "Buckwheat" ||
                honey.HoneyType == "Mustard" ||
                !honey.IsFresh)
            {
                throw new BadHoneyException(honey);
            }

            if (IsSleeping)
            {
                throw new BearIsSleepingException(100);
            }

            Console.WriteLine($"The {Type} bear is enjoying the honey.");
        }
    }
}
