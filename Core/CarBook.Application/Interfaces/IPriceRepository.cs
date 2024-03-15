using System;
using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces
{
	public interface IPriceRepository
	{
		Task<List<Pricing>> GetPricingWithCar();
		Task<List<Pricing>> GetPricingWithCarAndBrandByBrandId(Guid brandId);
	}
}

