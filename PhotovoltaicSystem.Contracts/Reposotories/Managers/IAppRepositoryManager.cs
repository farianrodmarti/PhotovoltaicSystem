using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Contracts.Reposotories.Managers
{
    public interface IAppRepositoryManager
    {
        IHousingRepository Housing { get; }
        IInverterRepository Invert { get; }
        IMaintenanceRecordRepository MaintenanceRecord { get; }
        IPhotovoltaicSystemInstallRepository PhotovoltaicSystemInstall { get; }
        ISolarPanelRepository SolarPanel { get; }
        IUnitOfWork UnitOfWork { get; }
    }
}
