using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhotovoltaicSystem.Domain.Common;
using PhotovoltaicSystem.Domain.Entities;
using PhotovoltaicSystem.Persistence.FluentConfigurations.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Persistence.FluentConfigurations
{
    internal class SolarPanelEntityTypeConfiguration : EntityTypeConfigurationBase<SolarPanel>
    {
        public override void Configure(EntityTypeBuilder<SolarPanel> builder)
        {
            base.Configure(builder);
            builder.ToTable("SolarPanel");
            builder.Property(x => x.SerialNumber);
            builder.Property(x => x.Model);
            builder.OwnsOne(x => x.Capacity);
        }
    }
}
