using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Application.Queries.PhotovoltaicSystem.GetByMaintenance
{
    public sealed record GetByMaintenanceQuery(bool IsHasMaintenance) : IQuery<IEnumerable<PhotovoltaicSystemInstall>>;
}
