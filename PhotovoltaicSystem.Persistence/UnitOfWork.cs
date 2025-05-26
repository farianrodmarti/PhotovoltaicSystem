using PhotovoltaicSystem.Contracts;
using PhotovoltaicSystem.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Persistence
{
    internal class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            if (!context.Database.CanConnect())
                context.Database.EnsureCreated();
        }

        public Task SaveChangesAsync(CancellationToken cancellationToken)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }
    }
}
