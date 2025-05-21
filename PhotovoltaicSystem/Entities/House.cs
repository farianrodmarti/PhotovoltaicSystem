using PhotovoltaicSystem.Domain.Entities.Abstract;
using PhotovoltaicSystem.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Domain.Entities
{
    public sealed class House : Housing
    {
        public House(int houseNumber, Address address) : base( houseNumber, address) 
        {
        }
    }
}
