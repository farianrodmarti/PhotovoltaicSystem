using PhotovoltaicSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Contracts.Reposotories
{
    public interface ISolarPanelRepository
    {
        /// <summary>
        /// Añade un sistema fotovoltaico.
        /// </summary>
        /// <param name="solarPanel"></param>
        /// <returns></returns>
        Task AddAsync(SolarPanel solarPanel);

        /// <summary>
        /// Obtiene un sistema fotovoltaico con un numero de serie
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <returns></returns>
        Task<SolarPanel> GetBySerialNumber(string serialNumber);

        /// <summary>
        /// Obtiene una lista de sistemas fotovoltaicos con un mismo modelo
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<List<SolarPanel>> GetByModel(string model);

        /// <summary>
        /// Obtiene una lista de sistemas fotovoltaicos con una misma capacidad
        /// </summary>
        /// <param name="capacity"></param>
        /// <returns></returns>
        Task<List<SolarPanel>> GetByCapacity(string capacity);

        /// <summary>
        /// Actualiza un sistema fotovoltaico
        /// </summary>
        /// <param name="solarPanel"></param>
        /// <returns></returns>
        Task UpdateAsync(SolarPanel solarPanel);

        /// <summary>
        /// Elimina un sistema fotovoltaico
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <returns></returns>
        Task DeleteAsync(string serialNumber);

    }
}
