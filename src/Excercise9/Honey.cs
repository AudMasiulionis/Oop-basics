using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise09
{
    public class Honey
    {
        public string HoneyType { get; set; }
        public bool IsFresh { get; set; }

        public override string ToString()
        {
            return $"Honey:{nameof(HoneyType)} - {HoneyType} \n {nameof(IsFresh)} - {IsFresh}";
        }
    }
}
