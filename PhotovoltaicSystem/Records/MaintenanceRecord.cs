using PhotovoltaicSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Domain.Records
{
    public sealed record MaintenanceRecord
    {
        public DateTime DateTime { get;}
        public string Description { get; }
        public Guid PhtovoltaicSystemId { get; init; }

        protected MaintenanceRecord() { }

        public MaintenanceRecord(DateTime dateTime, string description, Guid phtovoltaicSystemId)
        {
            DateTime = dateTime;
            Description = description;
            PhtovoltaicSystemId = phtovoltaicSystemId;
        }
    }
}
