using PhotovoltaicSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Domain.Entities
{
    public class PhotovoltaicSystem : Entity
    {

        public bool HasBattery { get; set; }
        public Inverter Inverter { get; set; }
        public List<SolarPanel> SolarPanels { get; set; } = new();
        public List<Maintenance> Maintenances { get; set; } = new();

        protected PhotovoltaicSystem() { }

        public PhotovoltaicSystem(bool hasBattery, Inverter inverter, List<SolarPanel> solarPanels) : base(new Guid())
        {
            HasBattery = hasBattery;
            Inverter = inverter;
            SolarPanels = solarPanels;
        }

    }
}
