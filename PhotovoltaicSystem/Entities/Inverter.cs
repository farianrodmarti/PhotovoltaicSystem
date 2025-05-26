using PhotovoltaicSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Domain.Entities
{
    public class Inverter : Entity
    {
        public string Model { get; init; }
        public string SerialNumber { get; init; }
        public double MaximumPower { get; init; }
        public Guid PhotovoltaicSystemId { get; init; }

        public Inverter(string model, string serialNumber, double maximumPower) : base(new Guid())
        {
            Model = model;
            SerialNumber = serialNumber;
            MaximumPower = maximumPower;
        }
    }

}
