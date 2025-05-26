using PhotovoltaicSystem.Contracts.Reposotories;
using PhotovoltaicSystem.Domain.Entities;
using PhotovoltaicSystem.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Persistence.Repositories
{
    internal class InverterRepository : IInverterRepository
    {
        private AppDbContext _context;

        public InverterRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Inverter inverter)
        {
            await _context.AddAsync(inverter);
        }

        public void DeleteAsync(string serialNumber)
        {
            Inverter? inverter = _context.Inverters.FirstOrDefault(
                x => x.SerialNumber == serialNumber);
            if (inverter is null)
                return;
        }

        public Task<List<Inverter>> GetByMaximumPower(double maximumPower)
        {
            List<Inverter> inverters = _context.Inverters.Where(x => x.MaximumPower == maximumPower).ToList();
            return Task.FromResult(inverters);
        }

        public Task<List<Inverter>> GetByModel(string model)
        {
            List<Inverter> inverters = _context.Inverters.Where(x =>x.Model == model).ToList();
            return Task.FromResult(inverters);
        }

        public Task<Inverter?> GetBySpecificSerialNumber(string serialNumber)
        {
            Inverter? inverter = _context.Inverters.FirstOrDefault(
                x => x.SerialNumber == serialNumber);
            
                return Task.FromResult(inverter);
        }

        public Task UpdateAsync(Inverter inverter)
        {
           _context.Inverters.Update(inverter);
            return Task.CompletedTask;
        }
    }
}
