using PhotovoltaicSystem.Domain.Common;
using PhotovoltaicSystem.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Domain.Entities
{
    public class PhotovoltaicSystemInstall : Entity
    {

        public bool HasBattery { get; set; }
        public Inverter Inverter { get; set; }
        public List<SolarPanel> SolarPanels { get; set; } = new();
        public List<MaintenanceRecord> Maintenances { get; set; } = new();
        public Guid HousingId { get; set; }

        protected PhotovoltaicSystemInstall() { }

        public PhotovoltaicSystemInstall(bool hasBattery, Inverter inverter, List<SolarPanel> solarPanels) : base(new Guid())
        {
            HasBattery = hasBattery;
            Inverter = inverter;
            SolarPanels = solarPanels;
        }

    }
}
