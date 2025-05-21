using PhotovoltaicSystem.Domain.Common;
using PhotovoltaicSystem.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Domain.Entities
{
    public class SolarPanel : Entity
    {
        public string SerialNumber { get; init; }
        public string Model { get; init; }
        public Capacity Capacity { get; init; }
        public Guid PhtovoltaicSystemId { get; init; }

        protected SolarPanel() { }

        public SolarPanel( string serialNumber, string model, Capacity capacity ) : base(new Guid())
        {
            SerialNumber = serialNumber;
            Model = model;
            Capacity = capacity;
        }
    }
}
