using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhotovoltaicSystem.Domain.Entities.Abstract;
using PhotovoltaicSystem.Persistence.FluentConfigurations.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Persistence.FluentConfigurations
{
    internal class HousingEntityTypeConfiguration : EntityTypeConfigurationBase<Housing>
    {
        public override void Configure(EntityTypeBuilder<Housing> builder)
        {
            base.Configure(builder);
            builder.ToTable("Housing");
            builder.OwnsOne(x => x.Address);
            builder.OwnsOne(x => x.PhotovoltaicSystem);
            builder.Property(x => x.HouseNumber).IsRequired();
            builder.Property(x => x.Address).IsRequired();
        }
    }
}
