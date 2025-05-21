using PhotovoltaicSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Contracts.Reposotories
{
    public interface IInverterRepository
    {
        /// <summary>
        /// Añade un inversor
        /// </summary>
        /// <param name="inverter"></param>
        /// <returns></returns>
        Task AddAsync(Inverter inverter);

        /// <summary>
        /// Actualiza un inversor
        /// </summary>
        /// <param name="inverter"></param>
        /// <returns></returns>
        Task UpdateAsync(Inverter inverter);

        /// <summary>
        /// Obtiene un inversor especifico por el numero de serie
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <returns></returns>
        Task<Inverter> GetBySpecificSerialNumber(string serialNumber);

        /// <summary>
        /// Obtiene una lista de inversores por su modelo
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<List<Inverter>> GetByModel(string model);

        /// <summary>
        /// Obtiene una lista de inversores por su potencia maxima
        /// </summary>
        /// <param name="maximumPower"></param>
        /// <returns></returns>
        Task<List<Inverter>> GetByMaximumPower(string maximumPower);

        /// <summary>
        /// Elimina un inversor por su numero de serie
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <returns></returns>
        Task DeleteAsync(string serialNumber);
    }
}
