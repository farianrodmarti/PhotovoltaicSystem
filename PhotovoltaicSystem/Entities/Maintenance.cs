using PhotovoltaicSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Domain.Entities
{
    public class Maintenance : Entity
    {
        public DateTime DateTime { get; set; }
        public string Description { get; set; }

        protected Maintenance() { }

        public Maintenance(DateTime dateTime, string description) : base(new Guid())
        {
            DateTime = dateTime;
            Description = description;
        }
    }
}
