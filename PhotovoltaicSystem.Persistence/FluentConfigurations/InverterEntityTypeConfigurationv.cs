using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhotovoltaicSystem.Domain.Entities;
using PhotovoltaicSystem.Persistence.FluentConfigurations.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Persistence.FluentConfigurations
{
    internal class InverterEntityTypeConfiguration : EntityTypeConfigurationBase<Inverter>
    {
        public override void Configure(EntityTypeBuilder<Inverter> builder)
        {
            base.Configure(builder);
            builder.ToTable("Inverter");
            builder.Property(x => x.Model);
            builder.Property(x => x.SerialNumber);
            builder.Property(x => x.MaximumPower);

        }
    }
}
