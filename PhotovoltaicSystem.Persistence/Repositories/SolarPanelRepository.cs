using PhotovoltaicSystem.Contracts.Reposotories;
using PhotovoltaicSystem.Domain.Entities;
using PhotovoltaicSystem.Domain.ValueObjects;
using PhotovoltaicSystem.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Persistence.Repositories
{
    internal class SolarPanelRepository : ISolarPanelRepository
    {
        private AppDbContext _context;

        public SolarPanelRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(SolarPanel solarPanel)
        {
            await _context.SolarPanels.AddAsync(solarPanel);
        }

        public void DeleteAsync(string serialNumber)
        {
            SolarPanel? solarPanel = _context.SolarPanels.FirstOrDefault(x => x.SerialNumber == serialNumber);
            if (solarPanel is null)
                return;
            _context.SolarPanels.Remove(solarPanel);
        }

        public Task<List<SolarPanel>> GetByCapacity(Capacity capacity)
        {
            List<SolarPanel> solarPanels = _context.SolarPanels.Where(x => x.Capacity == capacity).ToList();
            return Task.FromResult(solarPanels);
        }

        public Task<List<SolarPanel>> GetByModel(string model)
        {
            List<SolarPanel> solarPanels = _context.SolarPanels.Where(x =>x.Model == model).ToList();
            return Task.FromResult(solarPanels);
        }

        public Task<SolarPanel?> GetBySerialNumber(string serialNumber)
        {
            SolarPanel? solarPanel = _context.SolarPanels.FirstOrDefault(
                x => x.SerialNumber == serialNumber);
            return Task.FromResult(solarPanel);
        }

        public Task UpdateAsync(SolarPanel solarPanel)
        {
           _context.SolarPanels.Update(solarPanel);
            return Task.CompletedTask;
        }
    }
}
