using PhotovoltaicSystem.Contracts.Reposotories;
using PhotovoltaicSystem.Domain.Records;
using PhotovoltaicSystem.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Persistence.Repositories
{
    internal class MaintenanceRecordRepository : IMaintenanceRecordRepository
    {
        private AppDbContext _context;

        public MaintenanceRecordRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(MaintenanceRecord maintenance)
        {
            await _context.AddAsync(maintenance);
        }

        public Task<MaintenanceRecord?> GetByDateTime(DateTime date, Guid photovoltaicSystemId)
        {
           MaintenanceRecord? maintenanceRecords = _context.Maintenances.FirstOrDefault(x => x.DateTime == date && x.PhtovoltaicSystemId == photovoltaicSystemId);
            return Task.FromResult(maintenanceRecords);
        }

        public Task<List<MaintenanceRecord>> GetBYDateTime(DateTime dateInitial, DateTime dateFinal, Guid phtovoltaicSystemId)
        {
            List<MaintenanceRecord> maintenanceRecords = _context.Maintenances.Where(x => x.DateTime == dateInitial && x.DateTime == dateFinal && x.PhtovoltaicSystemId == phtovoltaicSystemId).ToList();
            return Task.FromResult(maintenanceRecords);
        }
    }
}
