using PhotovoltaicSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Contracts.Reposotories
{
    public interface IPhotovoltaicSystemInstallRepository
    {
        /// <summary>
        /// Añade un sistema fotovoltaico
        /// </summary>
        /// <param name="photovoltaicSystem"></param>
        /// <returns></returns>
        Task AddAsync(PhotovoltaicSystemInstall photovoltaicSystem);

        /// <summary>
        /// Obtiene una lista de sistemas fotovoltaicos que tienen bateria
        /// </summary>
        /// <param name="isHasBattery"></param>
        /// <returns></returns>
        Task<List<PhotovoltaicSystemInstall>> GetByBattery (bool isHasBattery);

        /// <summary>
        /// Obtien una lista de sistemas fotovoltaicos que se le ha realizado mantenimiento.
        /// </summary>
        /// <param name="isHasMaintenance"></param>
        /// <returns></returns>
        Task<List<PhotovoltaicSystemInstall>> GetByMaintenance(bool isHasMaintenance);

        /// <summary>
        /// Actualiza un sistema fotovoltaico.
        /// </summary>
        /// <param name="photovoltaicSystem"></param>
        /// <returns></returns>
        Task UpdateAsync(PhotovoltaicSystemInstall photovoltaicSystem);

        /// <summary>
        /// Elimina un sistema fotovoltaico.
        /// </summary>
        /// <param name="photovoltaicSystem"></param>
        /// <returns></returns>
        void DeleteAsync(PhotovoltaicSystemInstall photovoltaicSystem);
    }
}
