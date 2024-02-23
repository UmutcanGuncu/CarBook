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

        public async Task<List<Car>> GetCarsListWithBrand()
        {
            var values = await _context.Cars.Include(x => x.Brand).Include(x=>x.Pricing).ToListAsync();
            return values;
        }

        public async Task<List<Car>> GetFiveCarList()
        {
            var values = await _context.Cars.Include(x => x.Brand).Take(5).ToListAsync();
            return values;
        }

    }
}

