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
    internal class PhotovoltaicSystemInstallRepository : IPhotovoltaicSystemInstallRepository
    {
        private AppDbContext _context;

        public PhotovoltaicSystemInstallRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(PhotovoltaicSystemInstall photovoltaicSystem)
        {
          await _context.AddAsync(photovoltaicSystem);
        }

        public void DeleteAsync(Guid id)
        {
            PhotovoltaicSystemInstall photovoltaicSystemInstall = _context.PhotovoltaicSystemInstalls.Where(x => x.Id == id).FirstOrDefault();
            _context.PhotovoltaicSystemInstalls.Remove(photovoltaicSystemInstall);
        }

        public Task<List<PhotovoltaicSystemInstall>> GetByBattery(bool isHasBattery)
        {
            List<PhotovoltaicSystemInstall> photovoltaicSystemInstalls = _context.PhotovoltaicSystemInstalls.Where(x => x.HasBattery == isHasBattery).ToList();
            return Task.FromResult(photovoltaicSystemInstalls);
        }

        public Task<List<PhotovoltaicSystemInstall>> GetByMaintenance(bool isHasMaintenance)
        {
            List<PhotovoltaicSystemInstall> photovoltaicSystemInstalls;

            if (isHasMaintenance) 
            {
                //Devolver los q tienen
                photovoltaicSystemInstalls = _context.PhotovoltaicSystemInstalls.
                    Where(x => x.Maintenances != null && x.Maintenances.Count > 0).ToList();
            }
            else
            {
                //Devolver los no q tienen
                photovoltaicSystemInstalls = _context.PhotovoltaicSystemInstalls.
                    Where(x => x.Maintenances == null || x.Maintenances.Count == 0).ToList();
            }

            return Task.FromResult(photovoltaicSystemInstalls);
        }

        public Task UpdateAsync(PhotovoltaicSystemInstall photovoltaicSystem)
        {
            _context.Update(photovoltaicSystem);
            return Task.CompletedTask;
        }
    }
}
