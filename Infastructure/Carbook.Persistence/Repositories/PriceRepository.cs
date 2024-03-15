using System;
using Carbook.Persistence.Context;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carbook.Persistence.Repositories
{
    public class PriceRepository : IPriceRepository
    {
        private readonly CarbookContext _carbookContext;

        public PriceRepository(CarbookContext carbookContext)
        {
            _carbookContext = carbookContext;
        }

        public async Task<List<Pricing>> GetPricingWithCar()
        {
            var values = await _carbookContext.Prices.Include(x => x.Car).ThenInclude(x=>x.Brand).ToListAsync();
            return values;
        }

        public async Task<Pricing> GetPricingWithCarAndBrandByCarId(Guid carId)
        {
            var value = await _carbookContext.Prices.Include(x => x.Car).ThenInclude(x => x.Brand).FirstOrDefaultAsync(x=>x.CarId == carId);
            return value;
        }
    }
}

