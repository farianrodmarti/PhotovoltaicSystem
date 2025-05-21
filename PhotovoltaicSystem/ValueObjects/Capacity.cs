using PhotovoltaicSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Domain.ValueObjects
{
    public class Capacity : ValueObject
    {
        public int Value { get; set; }
        public string Unit { get; set; }

        public Capacity(int value, string unit ) 
        { 
            Value = value;
            Unit = unit;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
           return new object[] { Value, Unit };
        }
    }
}
