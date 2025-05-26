using FluentResults;
using Microsoft.EntityFrameworkCore;
using PhotovoltaicSystem.Contracts.Reposotories;
using PhotovoltaicSystem.Domain.Entities.Abstract;
using PhotovoltaicSystem.Domain.ValueObjects;
using PhotovoltaicSystem.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Persistence.Repositories
{
    public class HousingRepository : IHousingRepository
    {
        private readonly AppDbContext _context;

        public HousingRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Housing housing)
        {
            await _context.Housings.AddAsync(housing);
        }

        public void DeleteAsync(Address address, int houseNumber)
        {
            Housing? housing = _context.Housings.FirstOrDefault(
                x => x.HouseNumber == houseNumber && x.Address == address);

            if (housing is null)
                return;

            _context.Housings.Remove(housing);
        }

        public  Task<List<Housing>> GetByAddress(Address address)
        {
            List<Housing> housings = _context.Housings.Where(x => x.Address == address).ToList();

            return Task.FromResult(housings);
        }

        public Task<Housing?> GetBySpecificAddress(Address address, int houseNumber)
        {
            return Task.FromResult
                (_context.Housings.FirstOrDefault
                (x => x.HouseNumber == houseNumber && x.Address == address));
        }

        public Task UpdateAsync(Housing housing)
        {
            _context.Housings.Update(housing);
            return Task.CompletedTask;
        }
    }
}
