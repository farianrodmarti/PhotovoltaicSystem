using PhotovoltaicSystem.Domain.Entities.Abstract;
using PhotovoltaicSystem.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Contracts.Reposotories
{
    /// <summary>
    /// Modela el repositorio de una vivienda.
    /// </summary>
    public interface IHousingRepository
    {
        /// <summary>
        /// Añade una vivienda al repositorio
        /// </summary>
        /// <param name="housing">Vivienda</param>
        /// <returns></returns>
        Task AddAsync(Housing housing);

        /// <summary>
        /// Obtiene una vivienda por la dirección específica
        /// </summary>
        /// <param name="address"></param>
        /// <param name="houseNumber"></param>
        /// <returns></returns>
        Task<Housing?> GetBySpecificAddress(Address address, int houseNumber);

        /// <summary>
        /// Obtiene una lista de viviendas en una dirección
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        Task<List<Housing>> GetByAddress(Address address);

        /// <summary>
        /// Actualiza una vivienda
        /// </summary>
        /// <param name="housing"></param>
        /// <returns></returns>
        Task UpdateAsync(Housing housing);

        /// <summary>
        /// Elimina una vivienda por su dirección exacta
        /// </summary>
        /// <param name="address"></param>
        /// <param name="houseNumber"></param>
        /// <returns></returns>
        void DeleteAsync(Address address, int houseNumber);




    }
}
