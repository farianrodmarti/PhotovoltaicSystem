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
            builder.HasOne(x => x.PhotovoltaicSystem);
            builder.OwnsOne(x => x.Address, addressBuilder =>
            {
                addressBuilder.Property(a => a.Street).IsRequired();
                addressBuilder.Property(a => a.City).IsRequired();
                addressBuilder.Property(a => a.Country).IsRequired();
                addressBuilder.Property(a => a.PostalCode).IsRequired();
            });
            builder.Property(x => x.HouseNumber).IsRequired();
        }
    }
}
