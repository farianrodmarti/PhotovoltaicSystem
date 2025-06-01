using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PhotovoltaicSystem.Domain.Entities;
using PhotovoltaicSystem.Persistence.FluentConfigurations.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Persistence.FluentConfigurations
{
    internal class PhotovoltaicSystemEntityTypeConfiguration : EntityTypeConfigurationBase<PhotovoltaicSystemInstall>
    {
        public override void Configure(EntityTypeBuilder<PhotovoltaicSystemInstall> builder)
        {
            base.Configure(builder);
            builder.ToTable("PhotovoltaicSystem");
            builder.HasOne(x => x.Inverter);
            builder.HasMany(x => x.SolarPanels);
            builder.OwnsMany(x => x.Maintenances);
            builder.Property(x => x.HasBattery);
        }
    }
}
