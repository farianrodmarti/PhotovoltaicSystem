using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhotovoltaicSystem.Domain.Entities;
using PhotovoltaicSystem.Domain.Entities.Abstract;
using PhotovoltaicSystem.Persistence.FluentConfigurations.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Persistence.FluentConfigurations
{
    internal class HouseEntityTypeConfiguration : IEntityTypeConfiguration<House>
    {
        public void Configure(EntityTypeBuilder<House> builder)
        {
            builder.ToTable("Houses");
            builder.HasBaseType<Housing>();
        }
    }
}
