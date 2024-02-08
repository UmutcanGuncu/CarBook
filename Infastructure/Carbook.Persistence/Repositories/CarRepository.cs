using System;
using Carbook.Persistence.Context;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carbook.Persistence.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarbookContext _context;

        public CarRepository(CarbookContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Car entity)
        {
            _context.Set<Car>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Car entity)
        {
            _context.Set<Car>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Car>> GetAllAsync()
        {
            return await _context.Set<Car>().ToListAsync();
        }

        public async Task<Car> GetByIdAsync(Guid id)
        {
            return await _context.Set<Car>().FindAsync(id);
        }

        public async Task<List<Car>> GetCarsListWithBrand()
        {
            var values = await _context.Cars.Include(x => x.Brand).ToListAsync();
            return values;
        }

        public async Task UpdateAsync(Car entity)
        {
            _context.Set<Car>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}

