using PhotovoltaicSystem.Domain.Entities.Abstract;
using PhotovoltaicSystem.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Domain.Entities
{
    public sealed class Building : Housing
    {
        public int NumberOfApartment { get; init; }

        protected Building() :base() { }

        public Building(int houseNumber, Address address, int numberOfApartment) : base (houseNumber, address)
        {
            NumberOfApartment = numberOfApartment;
        }
    }
}
