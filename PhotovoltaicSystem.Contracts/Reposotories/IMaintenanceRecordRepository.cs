using PhotovoltaicSystem.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Contracts.Reposotories
{
    public interface IMaintenanceRecordRepository
    {
        /// <summary>
        /// Añade un mantenimiento.
        /// </summary>
        /// <param name="maintenance"></param>
        /// <returns></returns>
        Task AddAsync(MaintenanceRecord maintenance);

        /// <summary>
        /// Obtiene un mantenimiento especifico por la fecha y el sistema fotovoltaico asociado.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        Task<MaintenanceRecord> GetByDateTime(DateTime date, Guid photovoltaicSystemId);

        /// <summary>
        /// Obtiene una lista de mantenimientos por un rango de fecha y el sistema fotovoltaico asociado.
        /// </summary>
        /// <param name="dateInitial"></param>
        /// <param name="dateFinal"></param>
        /// <returns></returns>
        Task<List<MaintenanceRecord>> GetBYDateTime(DateTime dateInitial, DateTime dateFinal, Guid phtovoltaicSystemId);
    }
}
